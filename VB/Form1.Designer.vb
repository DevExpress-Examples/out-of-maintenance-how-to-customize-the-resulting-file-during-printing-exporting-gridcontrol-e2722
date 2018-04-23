Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 24)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(548, 430)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6, Me.gridColumn7, Me.gridColumn8, Me.gridColumn9, Me.gridColumn10, Me.gridColumn11, Me.gridColumn12})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "Name"
			Me.gridColumn1.FieldName = "Name"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "ID"
			Me.gridColumn2.FieldName = "ID"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 1
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "Number"
			Me.gridColumn3.FieldName = "Number"
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.Visible = True
			Me.gridColumn3.VisibleIndex = 2
			' 
			' gridColumn4
			' 
			Me.gridColumn4.Caption = "Date"
			Me.gridColumn4.FieldName = "Date"
			Me.gridColumn4.Name = "gridColumn4"
			Me.gridColumn4.Visible = True
			Me.gridColumn4.VisibleIndex = 3
			' 
			' gridView2
			' 
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Dock = System.Windows.Forms.DockStyle.Top
			Me.simpleButton1.Location = New System.Drawing.Point(0, 0)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(548, 24)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "Export"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' gridColumn5
			' 
			Me.gridColumn5.Caption = "gridColumn5"
			Me.gridColumn5.FieldName = "Name"
			Me.gridColumn5.Name = "gridColumn5"
			Me.gridColumn5.Visible = True
			Me.gridColumn5.VisibleIndex = 4
			' 
			' gridColumn6
			' 
			Me.gridColumn6.Caption = "gridColumn6"
			Me.gridColumn6.FieldName = "Name"
			Me.gridColumn6.Name = "gridColumn6"
			Me.gridColumn6.Visible = True
			Me.gridColumn6.VisibleIndex = 5
			' 
			' gridColumn7
			' 
			Me.gridColumn7.Caption = "gridColumn7"
			Me.gridColumn7.FieldName = "Name"
			Me.gridColumn7.Name = "gridColumn7"
			Me.gridColumn7.Visible = True
			Me.gridColumn7.VisibleIndex = 6
			' 
			' gridColumn8
			' 
			Me.gridColumn8.Caption = "gridColumn8"
			Me.gridColumn8.FieldName = "Name"
			Me.gridColumn8.Name = "gridColumn8"
			Me.gridColumn8.Visible = True
			Me.gridColumn8.VisibleIndex = 7
			' 
			' gridColumn9
			' 
			Me.gridColumn9.Caption = "gridColumn9"
			Me.gridColumn9.FieldName = "Name"
			Me.gridColumn9.Name = "gridColumn9"
			Me.gridColumn9.Visible = True
			Me.gridColumn9.VisibleIndex = 8
			' 
			' gridColumn10
			' 
			Me.gridColumn10.Caption = "gridColumn10"
			Me.gridColumn10.FieldName = "Name"
			Me.gridColumn10.Name = "gridColumn10"
			Me.gridColumn10.Visible = True
			Me.gridColumn10.VisibleIndex = 9
			' 
			' gridColumn11
			' 
			Me.gridColumn11.Caption = "gridColumn11"
			Me.gridColumn11.FieldName = "Name"
			Me.gridColumn11.Name = "gridColumn11"
			Me.gridColumn11.Visible = True
			Me.gridColumn11.VisibleIndex = 10
			' 
			' gridColumn12
			' 
			Me.gridColumn12.Caption = "gridColumn12"
			Me.gridColumn12.FieldName = "Name"
			Me.gridColumn12.Name = "gridColumn12"
			Me.gridColumn12.Visible = True
			Me.gridColumn12.VisibleIndex = 11
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(548, 454)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.simpleButton1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

