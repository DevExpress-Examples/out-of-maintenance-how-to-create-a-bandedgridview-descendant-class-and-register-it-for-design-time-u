Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraGrid.Views.BandedGrid.Handler
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports System.Windows.Forms

Namespace MyXtraGrid
	Public Class MyBandedGridViewHandler
		Inherits BandedGridHandler
		Public Sub New(ByVal gridView As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView)
			MyBase.New(gridView)
		End Sub
		Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
			MyBase.OnKeyDown(e)
			If e.KeyData = Keys.Delete AndAlso View.State = BandedGridState.Normal Then
				View.DeleteRow(View.FocusedRowHandle)
			End If
			If e.KeyData = Keys.Enter AndAlso View.State = BandedGridState.Normal Then
				View.AddNewRow()
			End If
		End Sub
	End Class
End Namespace
