Public Class AddDoctor
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub AddDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Patient' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter.Fill(Me.Database1DataSet.Patient)

    End Sub
End Class