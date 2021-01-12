<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewPatients
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Database1DataSet1 = New E_Health_App.Database1DataSet()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PatientIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DemographicDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New E_Health_App.Database1DataSet()
        Me.PatientTableAdapter = New E_Health_App.Database1DataSetTableAdapters.PatientTableAdapter()
        Me.FillBy1PatientsToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillBy1PatientsToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy1PatientsToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientIdDataGridViewTextBoxColumn, Me.FnameDataGridViewTextBoxColumn, Me.LnameDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.GenderDataGridViewCheckBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.RegistrationDateDataGridViewTextBoxColumn, Me.DemographicDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PatientBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(617, 131)
        Me.DataGridView1.TabIndex = 0
        '
        'PatientIdDataGridViewTextBoxColumn
        '
        Me.PatientIdDataGridViewTextBoxColumn.DataPropertyName = "Patient_Id"
        Me.PatientIdDataGridViewTextBoxColumn.HeaderText = "Patient_Id"
        Me.PatientIdDataGridViewTextBoxColumn.Name = "PatientIdDataGridViewTextBoxColumn"
        '
        'FnameDataGridViewTextBoxColumn
        '
        Me.FnameDataGridViewTextBoxColumn.DataPropertyName = "F_name"
        Me.FnameDataGridViewTextBoxColumn.HeaderText = "F_name"
        Me.FnameDataGridViewTextBoxColumn.Name = "FnameDataGridViewTextBoxColumn"
        '
        'LnameDataGridViewTextBoxColumn
        '
        Me.LnameDataGridViewTextBoxColumn.DataPropertyName = "L_name"
        Me.LnameDataGridViewTextBoxColumn.HeaderText = "L_name"
        Me.LnameDataGridViewTextBoxColumn.Name = "LnameDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewCheckBoxColumn
        '
        Me.GenderDataGridViewCheckBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewCheckBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewCheckBoxColumn.Name = "GenderDataGridViewCheckBoxColumn"
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone number "
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone number "
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        '
        'RegistrationDateDataGridViewTextBoxColumn
        '
        Me.RegistrationDateDataGridViewTextBoxColumn.DataPropertyName = "registration date"
        Me.RegistrationDateDataGridViewTextBoxColumn.HeaderText = "registration date"
        Me.RegistrationDateDataGridViewTextBoxColumn.Name = "RegistrationDateDataGridViewTextBoxColumn"
        '
        'DemographicDataGridViewTextBoxColumn
        '
        Me.DemographicDataGridViewTextBoxColumn.DataPropertyName = "demographic"
        Me.DemographicDataGridViewTextBoxColumn.HeaderText = "demographic"
        Me.DemographicDataGridViewTextBoxColumn.Name = "DemographicDataGridViewTextBoxColumn"
        '
        'PatientBindingSource
        '
        Me.PatientBindingSource.DataMember = "Patient"
        Me.PatientBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PatientTableAdapter
        '
        Me.PatientTableAdapter.ClearBeforeFill = True
        '
        'FillBy1PatientsToolStrip
        '
        Me.FillBy1PatientsToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBy1PatientsToolStripButton})
        Me.FillBy1PatientsToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy1PatientsToolStrip.Name = "FillBy1PatientsToolStrip"
        Me.FillBy1PatientsToolStrip.Size = New System.Drawing.Size(800, 25)
        Me.FillBy1PatientsToolStrip.TabIndex = 1
        Me.FillBy1PatientsToolStrip.Text = "Populate"
        '
        'FillBy1PatientsToolStripButton
        '
        Me.FillBy1PatientsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1PatientsToolStripButton.Name = "FillBy1PatientsToolStripButton"
        Me.FillBy1PatientsToolStripButton.Size = New System.Drawing.Size(58, 22)
        Me.FillBy1PatientsToolStripButton.Text = "Populate"
        '
        'viewPatients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.FillBy1PatientsToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "viewPatients"
        Me.Text = "View Patients"
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy1PatientsToolStrip.ResumeLayout(False)
        Me.FillBy1PatientsToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Database1DataSet1 As Database1DataSet
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents PatientBindingSource As BindingSource
    Friend WithEvents PatientTableAdapter As Database1DataSetTableAdapters.PatientTableAdapter
    Friend WithEvents PatientIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RegistrationDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DemographicDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FillBy1PatientsToolStrip As ToolStrip
    Friend WithEvents FillBy1PatientsToolStripButton As ToolStripButton
End Class
