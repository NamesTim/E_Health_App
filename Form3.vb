Public Class viewPatients
    Private Sub viewPatients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Patient' table. You can move, or remove it, as needed.
        Me.PatientTableAdapter.Fill(Me.Database1DataSet.Patient)

    End Sub

    Private Sub FillBy1PatientsToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBy1PatientsToolStripButton.Click
        Try
            Me.PatientTableAdapter.FillBy1Patients(Me.Database1DataSet1.Patient)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class