Public Class Form1
    Dim a As String

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Left Then
            car.Width = 75
            car.Height = 40
            car.Image = My.Resources.car
            a = "left"
            car1_Tick(car, e)
        ElseIf e.KeyCode = Keys.Right Then
            car.Width = 75
            car.Height = 40
            car.Image = My.Resources.car
            a = "right"
            car1_Tick(car, e)
        ElseIf e.KeyCode = Keys.Up Then
            car.Width = 35
            car.Height = 82
            car.Image = My.Resources.car
            a = "top"
            car1_Tick(car, e)
        ElseIf e.KeyCode = Keys.Down Then
            car.Width = 35
            car.Height = 82
            car.Image = My.Resources.car
            a = "down"
            car1_Tick(car, e)
        ElseIf e.KeyCode = Keys.PageUp Then

            a = "stop"
            car1_Tick(car, e)



        End If
    End Sub
    Private Sub car1_Tick(sender As Object, e As EventArgs) Handles car1.Tick

        If (a = "left") Then
            car.Left -= 1
            If (car.Bounds.IntersectsWith(x1.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x2.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x3.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x4.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x5.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x6.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x7.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x8.Bounds)) Then
                end1()
            End If

            If (car.Bounds.IntersectsWith(x9.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x10.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x11.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x12.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x13.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x14.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x15.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x16.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x17.Bounds)) Then
                end1()
            End If

        ElseIf (a = "right") Then
            car.Left += 1
            If (car.Bounds.IntersectsWith(x1.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x2.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x3.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x4.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x5.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x6.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x7.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x8.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x9.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x10.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x11.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x12.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x13.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x14.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x15.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x16.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x17.Bounds)) Then
                end1()
            End If
        ElseIf (a = "top") Then
            car.Top -= 1

            If (car.Bounds.IntersectsWith(x1.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x2.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x3.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x4.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x5.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x6.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x7.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x8.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x9.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x10.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x11.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x12.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x13.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x14.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x15.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x16.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x17.Bounds)) Then
                end1()
            End If
        ElseIf (a = "down") Then
            car.Top += 1
            If (car.Bounds.IntersectsWith(x1.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x2.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x3.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x4.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x5.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x6.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x7.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x8.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x9.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x10.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x11.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x12.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x13.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x14.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x15.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x16.Bounds)) Then
                end1()
            End If
            If (car.Bounds.IntersectsWith(x17.Bounds)) Then
                end1()
            End If
        ElseIf (a = "stop") Then
            Me.car1.Stop()
            Me.car1.Start()

        End If



    End Sub
    Private Sub end1()


        Button2.Visible = True
        Label2.Visible = True

        car1.Stop()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Controls.Clear()

        InitializeComponent()

        Form1_Load(e, e)

        a = "stop"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub x3_Click(sender As Object, e As EventArgs) Handles x3.Click

    End Sub

    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click

    End Sub

    Private Sub car_Click(sender As Object, e As EventArgs) Handles car.Click

    End Sub
End Class

