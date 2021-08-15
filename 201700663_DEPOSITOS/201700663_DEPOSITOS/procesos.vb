Module procesos
    Public TOTAL As Double, INTERESMONETARIO As Double, INTERESAHORRO As Double
    Public CPROPIO As Double, COTROBANCO As Double, EFECTIVO As Double
    Public SaldoAnterior As Double
    Public SaldoNuevo As Double
    Public Const IMONETARIO = (1.5) / 100
    Public Const IMPREMIER = (2.5) / 100
    Public Const IAHORRO = (7.5) / 100
    Public Const DIEZCIENTO = (10) / 100
    Sub LIMPIAR_ENTRADAS()
        'darse cuenta que en cada instrucción se invoca el nombre de la clase a la que pertenece el objeto respectivo
        Form1.TXTCPROPIO.Clear()
        Form1.TXTCOTROBANCO.Clear()
        Form1.TXTEFECTIVO.Clear()
        Form1.TXTEFECTIVO.Clear()
        Form1.CBPROPIOS.Checked = False
        Form1.CBOTROBANCO.Checked = False
        Form1.CBEFECTIVO.Checked = False
        Form1.TXTSALDOANTERIOR.Focus()
    End Sub
End Module
