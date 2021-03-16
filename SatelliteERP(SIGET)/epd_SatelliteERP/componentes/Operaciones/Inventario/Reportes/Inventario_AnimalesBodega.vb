Imports System.Windows.Forms.DataVisualization.Charting

Public Class Inventario_AnimalesBodega

	Private _DT_Consolidado As New DataTable
	Private _DT_Detalle As New DataTable

	Property ID_Bodega As Long = 0
	Property NameBodega As String
	Private Sub Inventario_AnimalesBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		GroupBox1.Text = "Animales en: " & NameBodega
		GenerateKPI(2)

	End Sub


	Private Sub GenerateKPI(ByVal Grafico As Integer)
		If (LoadData()) Then
			dgvDetails.DataSource = _DT_Detalle
			If Grafico = 1 Then
				Chart1.Series(0).ChartType = SeriesChartType.Area
			ElseIf Grafico = 2
				Chart1.Series(0).ChartType = SeriesChartType.Column
			ElseIf Grafico = 3
				Chart1.Series(0).ChartType = SeriesChartType.Pie
			ElseIf Grafico = 4
				Chart1.Series(0).ChartType = SeriesChartType.Pyramid
			ElseIf Grafico = 5
				Chart1.Series(0).ChartType = SeriesChartType.Doughnut
			ElseIf Grafico = 6
				Chart1.Series(0).ChartType = SeriesChartType.Candlestick
			ElseIf Grafico = 7
				Chart1.Series(0).ChartType = SeriesChartType.Line
			End If
			Chart1.Series(0)("PieLabelStyle") = "Inside"
			Chart1.Series(0).Font = New System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Regular)

			Chart1.Series(0).BorderWidth = 1
			Chart1.Series(0).BorderColor = System.Drawing.Color.FromArgb(26, 59, 105)


			Chart1.Legends(0).Enabled = True
			Chart1.Legends(0).Docking = Docking.Right
			Chart1.Legends(0).Alignment = System.Drawing.StringAlignment.Center


			Chart1.Series(0).Label = "#VALY (#PERCENT{P0})"
			Chart1.Series(0).LegendText = "Cantidad Animales"
			Chart1.ChartAreas(0).Area3DStyle.Enable3D = True
			Dim series1 As Series = Chart1.Series(0)

			Chart1.DataSource = _DT_Consolidado
			series1.Name = "Envíos"
			Chart1.Series(series1.Name).XValueMember = "Semanas"
			Chart1.Series(series1.Name).YValueMembers = "Cantidad"
		Else
			MessageBox.Show("No existen animales en esta bodega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
			Me.Close()
		End If
	End Sub


	Private Function LoadData() As Boolean
		Dim ds As New DataSet
		Dim resp As Boolean = False
		Using objsql As New Operaciones_SQLServer
			ds = objsql.ERP_Prod_SP_NumberOfAnimals(ID_Bodega)
		End Using
		If Not ds Is Nothing Then
			If ds.Tables.Count = 2 Then
				_DT_Consolidado = ds.Tables(0)
				_DT_Detalle = ds.Tables(1)
				resp = True
			End If
		End If
		Return resp
	End Function

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub
#Region " Move Form "
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub
    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region
End Class