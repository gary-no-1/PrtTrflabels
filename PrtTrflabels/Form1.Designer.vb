<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TrfPrtLabelsDataSet = New PrtTrflabels.TrfPrtLabelsDataSet()
        Me.Trf_itemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Trf_itemsTableAdapter = New PrtTrflabels.TrfPrtLabelsDataSetTableAdapters.trf_itemsTableAdapter()
        Me.TableAdapterManager = New PrtTrflabels.TrfPrtLabelsDataSetTableAdapters.TableAdapterManager()
        Me.Trf_itemsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Trf_itemsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PrintButton = New System.Windows.Forms.ToolStripButton()
        Me.Trf_itemsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prt_line1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prt_line2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TrfPrtLabelsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trf_itemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Trf_itemsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Trf_itemsBindingNavigator.SuspendLayout()
        CType(Me.Trf_itemsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrfPrtLabelsDataSet
        '
        Me.TrfPrtLabelsDataSet.DataSetName = "TrfPrtLabelsDataSet"
        Me.TrfPrtLabelsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Trf_itemsBindingSource
        '
        Me.Trf_itemsBindingSource.DataMember = "trf_items"
        Me.Trf_itemsBindingSource.DataSource = Me.TrfPrtLabelsDataSet
        '
        'Trf_itemsTableAdapter
        '
        Me.Trf_itemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.integersTableAdapter = Nothing
        Me.TableAdapterManager.labels_prtTableAdapter = Nothing
        Me.TableAdapterManager.trf_itemsTableAdapter = Me.Trf_itemsTableAdapter
        Me.TableAdapterManager.UpdateOrder = PrtTrflabels.TrfPrtLabelsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Trf_itemsBindingNavigator
        '
        Me.Trf_itemsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Trf_itemsBindingNavigator.BindingSource = Me.Trf_itemsBindingSource
        Me.Trf_itemsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Trf_itemsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Trf_itemsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Trf_itemsBindingNavigatorSaveItem, Me.PrintButton})
        Me.Trf_itemsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Trf_itemsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Trf_itemsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Trf_itemsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Trf_itemsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Trf_itemsBindingNavigator.Name = "Trf_itemsBindingNavigator"
        Me.Trf_itemsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Trf_itemsBindingNavigator.Size = New System.Drawing.Size(693, 25)
        Me.Trf_itemsBindingNavigator.TabIndex = 0
        Me.Trf_itemsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Trf_itemsBindingNavigatorSaveItem
        '
        Me.Trf_itemsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Trf_itemsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Trf_itemsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Trf_itemsBindingNavigatorSaveItem.Name = "Trf_itemsBindingNavigatorSaveItem"
        Me.Trf_itemsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Trf_itemsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PrintButton
        '
        Me.PrintButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PrintButton.Image = CType(resources.GetObject("PrintButton.Image"), System.Drawing.Image)
        Me.PrintButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(23, 22)
        Me.PrintButton.Text = "Print Labels"
        '
        'Trf_itemsDataGridView
        '
        Me.Trf_itemsDataGridView.AutoGenerateColumns = False
        Me.Trf_itemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Trf_itemsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.prt_line1, Me.prt_line2, Me.DataGridViewTextBoxColumn3})
        Me.Trf_itemsDataGridView.DataSource = Me.Trf_itemsBindingSource
        Me.Trf_itemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Trf_itemsDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.Trf_itemsDataGridView.Name = "Trf_itemsDataGridView"
        Me.Trf_itemsDataGridView.Size = New System.Drawing.Size(693, 419)
        Me.Trf_itemsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "item_code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item Code"
        Me.DataGridViewTextBoxColumn1.MaxInputLength = 15
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'prt_line1
        '
        Me.prt_line1.DataPropertyName = "prt_line1"
        Me.prt_line1.HeaderText = "Label Line 1"
        Me.prt_line1.MaxInputLength = 55
        Me.prt_line1.Name = "prt_line1"
        Me.prt_line1.Width = 200
        '
        'prt_line2
        '
        Me.prt_line2.DataPropertyName = "prt_line2"
        Me.prt_line2.HeaderText = "Label Line 2"
        Me.prt_line2.MaxInputLength = 55
        Me.prt_line2.Name = "prt_line2"
        Me.prt_line2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "prt_count"
        Me.DataGridViewTextBoxColumn3.HeaderText = "No of Labels"
        Me.DataGridViewTextBoxColumn3.MaxInputLength = 3
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 444)
        Me.Controls.Add(Me.Trf_itemsDataGridView)
        Me.Controls.Add(Me.Trf_itemsBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Transformer Labels "
        CType(Me.TrfPrtLabelsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trf_itemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Trf_itemsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Trf_itemsBindingNavigator.ResumeLayout(False)
        Me.Trf_itemsBindingNavigator.PerformLayout()
        CType(Me.Trf_itemsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrfPrtLabelsDataSet As PrtTrflabels.TrfPrtLabelsDataSet
    Friend WithEvents Trf_itemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Trf_itemsTableAdapter As PrtTrflabels.TrfPrtLabelsDataSetTableAdapters.trf_itemsTableAdapter
    Friend WithEvents TableAdapterManager As PrtTrflabels.TrfPrtLabelsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Trf_itemsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Trf_itemsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PrintButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Trf_itemsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prt_line1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prt_line2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
