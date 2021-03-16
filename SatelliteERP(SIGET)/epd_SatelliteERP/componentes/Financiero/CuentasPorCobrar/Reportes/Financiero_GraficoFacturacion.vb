Imports Nexus.Windows.Forms

Public Class Financiero_GraficoFacturacion
    Private Sub Financiero_GraficoFacturacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        PieChart1.Items.Add(New PieChartItem(10, Color.BurlyWood, "Factura - Credito", "Pago Factura Consumidor Final Credito", 0))
        PieChart1.Items.Add(New PieChartItem(10, Color.Gold, "Facura Contado", "Pago Factura Consumidor Final Contado", 0))
        PieChart1.Items.Add(New PieChartItem(10, Color.Chocolate, "Factura - Cheque", "Pago Factura Consumidor Final Cheque", 50))
        PieChart1.Items.Add(New PieChartItem(20, Color.DarkRed, "CF - Credito", "Pago Credifo Fiscal Credito", 0))
        PieChart1.Items.Add(New PieChartItem(20, Color.DarkSalmon, "CF - Contado", "Pago Credifo Fiscal Contado", 0))
        PieChart1.Items.Add(New PieChartItem(20, Color.DodgerBlue, "CF - Cheque", "Pago Credifo Fiscal Cheque", 0))


        PieChart1.ItemStyle.SurfaceAlphaTransparency = 0.75F
        PieChart1.FocusedItemStyle.SurfaceAlphaTransparency = 0.75F
        PieChart1.FocusedItemStyle.SurfaceBrightnessFactor = 0.3F

    End Sub

    Private Sub trkRadius_Scroll(sender As Object, e As EventArgs) Handles trkRadius.Scroll
        PieChart1.Radius = trkRadius.Value
    End Sub
End Class
