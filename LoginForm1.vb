
Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click


        If txtUserId.Text = "" Or txtPassword.Text = "" Then
            MsgBox("you entered a blank !")
        ElseIf txtUserId.Text = "001" And txtPassword.Text = "admin" Then
            MDIParent1.Show()
        Else
            MsgBox("invalid details", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        End If
        'Using db As New Database1DataSet
        'Dim checkuser = From p In db.users Where p.user_id = txtUserId.Text And p.password = txtPassword.Text Select p
        'If checkuser.Count = 0 Then
        'MsgBox("invalid details", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        'Else
        'MDIParent1.Show()
        'Me.Close()
        'End If
        'End Using

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
