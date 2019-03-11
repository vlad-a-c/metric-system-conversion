Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub num_meters_TextChanged(sender As Object, e As EventArgs) Handles num_meters.TextChanged
        If IsNumeric(num_meters.Text) Then
            feet_selection.Visible = True
            inches_selection.Visible = True
            yards_selection.Visible = True
        Else
            feet_selection.Visible = False
            yards_selection.Visible = False
            inches_selection.Visible = False
        End If
    End Sub
    Private Sub show_results_Click(sender As Object, e As EventArgs) Handles show_results.Click
        If Not IsNumeric(num_meters.Text) Then
            MsgBox("you need to input a number", MsgBoxStyle.Critical, "error")
            Me.Close()
        Else
            Dim value = Val(num_meters.Text)
            Dim text
            If feet_selection.Checked = True Then
                value = value * 3.28
                text = "feet"
            ElseIf yards_selection.Checked = True Then
                value = value * 1.09
                text = "yards"
            ElseIf inches_selection.Checked = True Then
                value = value * 39.37
                text = "inches"
            Else
                value = 0
                text = ""
            End If

            result.Text = value.ToString() + " " + text
            If feet_selection.Checked = False And yards_selection.Checked = False And inches_selection.Checked = False Then
                result.Visible = False
            Else
                result.Visible = True
            End If

        End If
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        feet_selection.Checked = False
        yards_selection.Checked = False
        inches_selection.Checked = False
        result.Text = ""
        result.Visible = False
        num_meters.Text = ""
    End Sub

    Private Sub button_exit_Click(sender As Object, e As EventArgs) Handles button_exit.Click
        Me.Close()
    End Sub
End Class
