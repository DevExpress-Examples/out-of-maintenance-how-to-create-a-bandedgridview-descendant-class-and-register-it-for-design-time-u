Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports DevExpress.XtraGrid.Views.BandedGrid.ViewInfo
Imports DevExpress.XtraGrid.Views.BandedGrid

Namespace MyXtraGrid
	Public Class MyBandedGridViewInfo
		Inherits BandedGridViewInfo
		Public Sub New(ByVal gridView As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView)
			MyBase.New(gridView)

		End Sub
		Protected Overrides Function CalcMinRowHeight() As Integer
			Return MyBase.CalcMinRowHeight() + 10
		End Function
	End Class
End Namespace
