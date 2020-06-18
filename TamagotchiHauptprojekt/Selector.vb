Public MustInherit Class Selector
    Inherits System.Windows.Forms.Form

    Private selectorEnabled As Boolean = True

    Private selected As Integer
    Private ReadOnly elements As Object()
    Private selector As Rectangle
    Private toSelect As Object
    Private ReadOnly percent As Double

    Private oldSelectorRegion As Region
    Private newSelectorRegion As Region


    Public Sub New(ByVal elements As Object())
        Me.New(elements, 2)
    End Sub
    Public Sub New(ByVal elements As Object(), ByVal percent As Double)
        Me.elements = elements
        Me.percent = percent
        Dim size As Integer = elements.Length
        If size Mod 2 Then
            selected = Int(Fix(size / 2))
        Else
            selected = 0
        End If
        CreateSelector()
    End Sub

    Public Sub New(ByVal elements As Object(), ByVal percent As Double, ByVal selected As Integer)
        Me.elements = elements
        Me.percent = percent
        Me.selected = selected
        CreateSelector()
    End Sub

    Private Sub CreateSelector()
        'For Each element In elements
        '    Console.WriteLine(element)
        'Next
        toSelect = elements(selected)

        Dim left As Integer = toSelect.Left - toSelect.Width * percent / 100
        Dim top As Integer = toSelect.Top - toSelect.Height * percent / 100 - 1
        'Console.WriteLine("Selector " & left & " " & top)
        'Console.WriteLine("toSelect " & toSelect.Left & " " & toSelect.Top)
        'Console.WriteLine("toSelect " & toSelect.Width & " " & toSelect.Height)
        Dim width As Integer = toSelect.Width + toSelect.Width * percent * 2 / 100
        Dim height As Integer = toSelect.Height + toSelect.Height * percent * 2 / 100 + 2

        'Dim selector As ColorBox = New ColorBox() With {
        '    .Left = left,
        '    .Top = top,
        '    .Width = width,
        '    .Height = height,
        '    .Color = Color.Orange
        '}
        Dim selector As Rectangle = New Rectangle(left, top, width, height)
        Me.selector = selector



    End Sub

    Private Sub Selector_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 37 Then
            SetSelected(-1)
        ElseIf e.KeyCode = 39 Then
            SetSelected(1)
        ElseIf e.KeyCode = 38 Or e.KeyCode = 40 Then
            Selecting()
            Return
        End If

        Dim newSelector = elements(selected)
        If newSelector Is toSelect Then
            Return
        End If

        oldSelectorRegion = New Region(New Rectangle(selector.X, selector.Y, selector.Width, selector.Height))
        oldSelectorRegion.Exclude(New Rectangle(toSelect.Left, toSelect.Top, toSelect.Width - 1, toSelect.Height))

        'Zuweisung der neuen Daten
        toSelect = newSelector

        'Berechnung des neuen Selectors mithilfe der neuen Daten
        selector.X = toSelect.Left - toSelect.Width * percent / 100
        selector.Y = toSelect.Top - toSelect.Height * percent / 100 - 1
        selector.Width = toSelect.Width + toSelect.Width * percent * 2 / 100
        selector.Height = toSelect.Height + toSelect.Height * percent * 2 / 100 + 2

        newSelectorRegion = New Region(New Rectangle(selector.X, selector.Y, selector.Width, selector.Height))
        newSelectorRegion.Exclude(New Rectangle(toSelect.Left, toSelect.Top, toSelect.Width - 1, toSelect.Height))

        Invalidate(oldSelectorRegion)
        Invalidate(newSelectorRegion)
    End Sub

    Public MustOverride Sub Selecting()

    Private Sub SetSelected(modifier As Integer)
        Dim nextSel As Integer = selected
        nextSel += modifier
        If nextSel >= 0 And nextSel <= elements.Length - 1 Then
            selected = nextSel
        End If
    End Sub

    Public Function GetSelected() As Integer
        Return selected
    End Function

    Private Sub Selector_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If IsSelectorEnabled() Then
            'If Not e.ClipRectangle = New RectangleF(0, 0, 809, 456) Then
            'selector.DrawPicture(e.Graphics)
            e.Graphics.FillRegion(New SolidBrush(Color.Orange), newSelectorRegion)
            'End If

            For Each element In elements
                If TypeOf element Is PictureBoxTransparent Then
                    element.DrawPicture(e.Graphics)
                ElseIf TypeOf element Is Label Then
                    Controls.Add(element)
                End If
            Next
        Else
            'For Each element In elements
            '    If TypeOf element Is Label Then
            '        Console.WriteLine(element)
            '        Controls.Remove(element)
            '    End If
            'Next
        End If
    End Sub

    Public Sub SetSelectorEnabled(ByVal selectorEnabled As Boolean)
        Me.selectorEnabled = selectorEnabled

        If selectorEnabled = False Then
            For Each element In elements
                If TypeOf element Is Label Then
                    Controls.Remove(element)
                End If
            Next
        End If
        Invalidate()
    End Sub

    Public Function IsSelectorEnabled() As Boolean
        Return selectorEnabled
    End Function

    Private Sub Selector_Load(sender As Object, e As EventArgs) Handles Me.Load
        newSelectorRegion = New Region(New Rectangle(selector.X, selector.Y, selector.Width, selector.Height))
        newSelectorRegion.Exclude(New Rectangle(toSelect.Left, toSelect.Top, toSelect.Width - 1, toSelect.Height))
        Invalidate(newSelectorRegion)
    End Sub
End Class
