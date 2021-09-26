Module Module1
    Public NIT(5) As Integer
    Public Placa(5) As Integer
    Public Marca(5) As String
    Public dias(5) As Byte
    Public precio(5) As Integer
    Public efectivo(5) As Double
    Public tarjeta(5) As Double
    Public parcial(5) As Double
    Public total(5) As Double
    Public indice As Byte = 0

    Public Const descuento = 0.05
    Public Const recargo = 0.025

    Public Const alquilerHonda = 250
    Public Const alquilerMercedes = 450
    Public Const alquilerToyota = 325
    Public Const alquilerMazda = 300
    Sub muestre_totales()
        Form1.ListBox1.Items.Add(Placa(indice))
        Form1.ListBox2.Items.Add(Marca(indice))
        Form1.ListBox3.Items.Add(dias(indice))
        Form1.ListBox4.Items.Add(parcial(indice))
        Form1.ListBox5.Items.Add(total(indice))

    End Sub
    Sub salir()
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "mensaje de salida") = vbYes) Then
            End
        Else
            limpiar_entradas()
            LIMPIAR_VECTORES()
        End If
    End Sub
    Sub LIMPIAR_VECTORES()
        indice = 0

        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
    End Sub
    Sub limpiar_entradas()
        Form1.TXTNIT.Clear()
        Form1.TXTPLACA.Clear()
        Form1.TXTDIAS.Clear()
        Form1.TXTPRECIOS.Clear()
        Form1.TXTEFECTIVO.Clear()
        Form1.TXTTARJETA.Clear()

        Form1.CBMARCA.SelectedIndex = -1
        'Form1.ComboBox1.Text = ""
        Form1.CheckBox1.Checked = 0
        Form1.CheckBox2.Checked = 0
        Form1.TXTNIT.Focus()

    End Sub
    Function costoAlquiler()

        If Form1.CBMARCA.SelectedIndex = 0 Then
            Return alquilerHonda
        ElseIf Form1.CBMARCA.SelectedIndex = 1 Then
            Return alquilerMercedes
        ElseIf Form1.CBMARCA.SelectedIndex = 2 Then
            Return alquilerToyota
        ElseIf Form1.CBMARCA.SelectedIndex = 3 Then
            Return alquilerMazda
        End If

        Return -1

    End Function
End Module
