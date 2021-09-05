Module Module1
    Public Const Residencial1 As Double = 0.99
    Public Const Residencial2 As Double = 1.2
    Public Const Residencial3 As Double = 3

    Public Const Industrial1 As Double = 1.99
    Public Const Industrial2 As Double = 2.2
    Public Const Industrial3 As Double = 4

    Public indice As Byte = 0

    Public total_pagoini(11) As Double
    Public total_pagopar As Double
    Public descuento_social = 0.2
    Public descuento_nosocial = 0.1
    Public pagoinicial As Double

    Public Cliente(11) As String
    Public Servicio(11) As String
    Public tarifa(11) As String
    Public Saldoanterior(11) As Double
    Public Consumo(11) As Double
    Public PagoParcial(11) As Double
    Public Mora(11) As Double
    Public PMora(11) As String
    Public Descuento(11) As Double
    Public PagoTotal(11) As Double
    Sub Limpiar_Entradas()
        Form1.TXTNOMBRE.Clear()
        Form1.TXTNIT.Clear()
        Form1.TXTSALDOANTERIOR.Clear()
        Form1.TXTWATTS.Clear()
        Form1.TXTNOMBRE.Focus()

    End Sub

    Sub mostrar()
        Form1.LST_CLIENTE.Items.Add(Cliente(indice))
        Form1.LST_TipoDeServicio.Items.Add(Servicio(indice))
        Form1.LST_TipoTarifa.Items.Add(tarifa(indice))
        Form1.LST_SaldoAnterior.Items.Add(Saldoanterior(indice))
        Form1.LST_PagoInicial.Items.Add(total_pagoini(indice))
        Form1.LST_MORA.Items.Add(Mora(indice))
        Form1.LST_DESCUENTO.Items.Add(PagoParcial(indice))
        Form1.LST_TOTAL.Items.Add(PagoTotal(indice))
    End Sub
End Module
