Public Class Financiero_PreviewDocFiscal
    Property objFactura As Config_Factua
    Private Sub Financiero_PreviewDocFiscal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objFactura.Preview(PPC_ConfigFactura)
    End Sub

    Private Sub cmdMas_Click(sender As Object, e As EventArgs) Handles cmdMas.Click
        PPC_ConfigFactura.Zoom += 0.1
    End Sub

    Private Sub cmdMenos_Click(sender As Object, e As EventArgs) Handles cmdMenos.Click
        PPC_ConfigFactura.Zoom -= 0.1
    End Sub
End Class