Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraGrid
Imports System.IO
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Grid

Namespace WindowsApplication1
	Public Class GridExportHelper
		Private _GridControl As GridControl
		Private layoutStream As New MemoryStream()


		Public Shared Sub ExportGridControl(ByVal gc As GridControl, ByVal fileName As String)

			CType(New GridExportHelper(), GridExportHelper).InternalExportGridControl(gc, fileName)
		End Sub

		Private ReadOnly Property ExportedView() As GridView
			Get
				Return TryCast(_GridControl.MainView, GridView)
			End Get
		End Property
		Private Sub InternalExportGridControl(ByVal gc As GridControl, ByVal fileName As String)
			_GridControl = gc
			Try
				LockUpdate()
				SaveLayout()
				SubscribeEvents(ExportedView)
				CustomizeGridViewBeforeExport(ExportedView)
				DoExport(fileName)
			Finally
				UnsubscribeEvents(ExportedView)
				RestoreLayout()
				UnlockUpdate()
			End Try
		End Sub

		Private Sub LockUpdate()
			_GridControl.BeginUpdate()

		End Sub
		Private Sub UnlockUpdate()
			_GridControl.EndUpdate()
		End Sub
		Private Sub RestoreLayout()
			layoutStream.Position = 0
			ExportedView.RestoreLayoutFromStream(layoutStream, OptionsLayoutBase.FullLayout)
		End Sub
		Private Sub SaveLayout()
			ExportedView.SaveLayoutToStream(layoutStream, OptionsLayoutBase.FullLayout)
		End Sub

		Private Sub CustomizeGridViewBeforeExport(ByVal view As GridView)
			view.OptionsView.ColumnAutoWidth = False
			view.BestFitColumns()
			view.OptionsPrint.AutoWidth = False
		End Sub


		Private Sub view_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs)
			e.DisplayText = String.Format("[{0}]", e.DisplayText)
		End Sub

		Private Sub SubscribeEvents(ByVal view As GridView)
			AddHandler view.CustomColumnDisplayText, AddressOf view_CustomColumnDisplayText
		End Sub
		Private Sub UnsubscribeEvents(ByVal view As GridView)
			RemoveHandler view.CustomColumnDisplayText, AddressOf view_CustomColumnDisplayText
		End Sub

		Private Sub DoExport(ByVal fileName As String)
			_GridControl.ExportToXls(fileName)
		End Sub
	End Class
End Namespace
