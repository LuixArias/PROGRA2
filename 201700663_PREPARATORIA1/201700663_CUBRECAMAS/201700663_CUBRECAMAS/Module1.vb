Module Module1
    Public TOTAL As Double
    Public Const lino = 15
    Public Const algodon = 23.99
    Public Const seda = 30.99
    Public Const hilo = 39.99
    Public TotalYardas As Double
    Public PrecioVenta As Double
    Sub LIMPIAR_ENTRADAS()
        Form1.TXTLINO.Clear()
        Form1.TXTALGODON.Clear()
        Form1.TXTSEDA.Clear()
        Form1.TXTHILO.Clear()
        Form1.CBLINO.Checked = False
        Form1.CBALGODON.Checked = False
        Form1.CBSEDA.Checked = False
        Form1.CBHILO.Checked = False
        Form1.RBIMPERIAL.Focus()
    End Sub
End Module
