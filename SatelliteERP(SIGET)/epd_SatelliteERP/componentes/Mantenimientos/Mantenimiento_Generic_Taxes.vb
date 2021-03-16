Public Class Mantenimiento_Generic_Taxes
    Private objDatos As New Generic_SQLServer
    Private dtCollectingAgency As DataTable
    Property Id_Tax As Long
    Property Id_Company_FK As Long
    Property Id_CollectingAgency_FK As Long
    Property Name_Tax As String
    Property Name_CollectingAgency As String
    Property Is_TaxParent As Boolean
    Property Is_TaxLine As Boolean
    Property Is_TaxProduct As Boolean
    Property IsPercent As Boolean
    Property Value As Decimal

    Private Sub Mantenimiento_Generic_Taxes_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtCollectingAgency = objDatos.GetCollectingAgency(Data_Id_Company)
        comboListCollectingAgency.DataSource = dtCollectingAgency
        comboListCollectingAgency.DisplayMember = "Name_CollectingAgency"
        comboListCollectingAgency.ValueMember = "Id_CollectingAgency"
        GetData()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Close()
    End Sub
    Private Sub GetData()
        REM        Property Id_CollectingAgency_FK As Long
        txtNameTax.Text = _Name_Tax
        comboListCollectingAgency.Text = Name_CollectingAgency
        rb_Parent.Checked = _Is_TaxParent
        RB_Line.Checked = Is_TaxLine

        RB_Product.Checked = Is_TaxProduct
        CheckBox1.Checked = IsPercent
        txtMontoHacer.Text = Value

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If comboListCollectingAgency.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione un colector de impuesto", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If txtNameTax.Text = "" Then
            MessageBox.Show("Ingrese un nombre de impuesto", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'If txtNameTax.Text = "" Then
        '    MessageBox.Show("Debe ingresar marca un tipo de impuesto", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If

        Id_CollectingAgency_FK = comboListCollectingAgency.SelectedValue
        If Id_Tax > 0 Then ' Es modificacion
            Dim resp As String = objDatos.SetTaxes(Id_Tax, Data_Id_Company, Id_CollectingAgency_FK, txtNameTax.Text, rb_Parent.Checked, RB_Line.Checked, RB_Product.Checked,
                                 CheckBox1.Checked, txtMontoHacer.Text)
            If resp = "OK" Then
                DialogResult = DialogResult.OK
                MessageBox.Show("Registro actualizado exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Else
                If resp.Split("|")(0) = "ER" Then
                    MessageBox.Show("Error al actualizar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'Else
                    '  MessageBox.Show("Error al actualizar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        Else
            Dim resp As String = objDatos.InsertTaxes(Data_Id_Company, Id_CollectingAgency_FK, txtNameTax.Text, rb_Parent.Checked, RB_Line.Checked, RB_Product.Checked,
                                 CheckBox1.Checked, txtMontoHacer.Text)
            If resp = "OK" Then
                DialogResult = DialogResult.OK
                MessageBox.Show("Registro insertar exitosamente", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Else
                If resp.Split("|")(0) = "ER" Then
                    MessageBox.Show("Error al insertar datos, " & resp.Split("|")(1), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ' Else
                    ' MessageBox.Show("Error al insertar datos", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

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