<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.labels_prtBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrfPrtLabelsDataSet = New PrtTrflabels.TrfPrtLabelsDataSet()
        Me.labels_prtTableAdapter = New PrtTrflabels.TrfPrtLabelsDataSetTableAdapters.labels_prtTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.labels_prtBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrfPrtLabelsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labels_prtBindingSource
        '
        Me.labels_prtBindingSource.DataMember = "labels_prt"
        Me.labels_prtBindingSource.DataSource = Me.TrfPrtLabelsDataSet
        '
        'TrfPrtLabelsDataSet
        '
        Me.TrfPrtLabelsDataSet.DataSetName = "TrfPrtLabelsDataSet"
        Me.TrfPrtLabelsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'labels_prtTableAdapter
        '
        Me.labels_prtTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.labels_prtBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PrtTrflabels.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(499, 331)
        Me.ReportViewer1.TabIndex = 0
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 331)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print these Labels"
        CType(Me.labels_prtBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrfPrtLabelsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents labels_prtBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TrfPrtLabelsDataSet As PrtTrflabels.TrfPrtLabelsDataSet
    Friend WithEvents labels_prtTableAdapter As PrtTrflabels.TrfPrtLabelsDataSetTableAdapters.labels_prtTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
