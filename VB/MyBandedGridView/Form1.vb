Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace MyXtraGrid
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load_1(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim dataTable1 As New DataTable()
			dataTable1.Columns.Add("Column1", GetType(String))
			For i As Integer = 0 To 9
				dataTable1.Rows.Add("Item " & i)
			Next i
			myGridControl1.DataSource = dataTable1
		End Sub
	End Class
End Namespace
