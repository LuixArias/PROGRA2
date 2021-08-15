Public Class Form1
    Private Sub BTSALIR_Click(sender As Object, e As EventArgs) Handles BTSALIR.Click
        If MsgBox("DESEA SALIR?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Me.Close()
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTLIMPIAR.Click
        LIMPIAR_ENTRADAS()

    End Sub

    Private Sub BTCALCULAR_Click(sender As Object, e As EventArgs) Handles BTCALCULAR.Click
        SaldoNuevo = Val(TXTSALDOANTERIOR.Text) + Val(TXTCOTROBANCO.Text) + Val(TXTCPROPIO.Text) + Val(TXTEFECTIVO.Text)
        SaldoAnterior = Val(TXTSALDOANTERIOR.Text)
        If RBAHORRO.Checked Then
            TXTINTERESES.Text = Val(SaldoNuevo)
        End If
        If RBMONETARIO.Checked Then
            If SaldoNuevo > 0 And SaldoNuevo < 1001 Then
                INTERESAHORRO = SaldoNuevo * IMONETARIO
                TXTSALDONUEVO.Text = Val(INTERESAHORRO)
                TXTINTERESES.Text = Val(INTERESAHORRO) + SaldoNuevo
            ElseIf SaldoNuevo >= 1001 And SaldoNuevo < 5001 Then
                INTERESAHORRO = SaldoNuevo * IMPREMIER
                TXTSALDONUEVO.Text = Val(INTERESAHORRO)
                TXTINTERESES.Text = Val(INTERESAHORRO) + SaldoNuevo
            ElseIf SaldoNuevo >= 5001 And SaldoNuevo < 15001 Then
                INTERESAHORRO = SaldoNuevo * IAHORRO
                TXTSALDONUEVO.Text = Val(INTERESAHORRO)
                TXTINTERESES.Text = Val(INTERESAHORRO) + SaldoNuevo
            ElseIf SaldoNuevo >= 15001 Then
                INTERESAHORRO = SaldoNuevo * DIEZCIENTO
                TXTSALDONUEVO.Text = Val(INTERESAHORRO)
                TXTINTERESES.Text = Val(INTERESAHORRO) + SaldoNuevo
            Else
                MsgBox("DATO INCORRECTO")
            End If
        End If
        If RBPREMIER.Checked Then
            If SaldoAnterior > 0 And SaldoAnterior < 10001 Then
                INTERESAHORRO = SaldoAnterior * IMPREMIER
                TXTSALDONUEVO.Text = Val(INTERESAHORRO)
                TXTINTERESES.Text = Val(INTERESAHORRO) + SaldoNuevo
            ElseIf SaldoAnterior >= 10001 And SaldoAnterior < 15001 Then
                INTERESAHORRO = SaldoAnterior * (3 / 100)
                TXTSALDONUEVO.Text = Val(INTERESAHORRO)
                TXTINTERESES.Text = Val(INTERESAHORRO) + SaldoNuevo
            ElseIf SaldoAnterior >= 15001 And SaldoNuevo < 15001 Then
                INTERESAHORRO = SaldoNuevo * (4.5 / 100)
                TXTSALDONUEVO.Text = Val(INTERESAHORRO)
                TXTINTERESES.Text = Val(INTERESAHORRO) + SaldoNuevo
            Else
                MsgBox("DATO INCORRECTO")
            End If
        End If

    End Sub

    Private Sub TXTSALDONUEVO_TextChanged(sender As Object, e As EventArgs) Handles TXTSALDONUEVO.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CBPROPIOS_CheckedChanged(sender As Object, e As EventArgs) Handles CBPROPIOS.CheckedChanged
        If CBPROPIOS.Checked Then
            TXTCPROPIO.Enabled = True
        Else
            TXTCPROPIO.Enabled = False
        End If
    End Sub

    Private Sub CBOTROBANCO_CheckedChanged(sender As Object, e As EventArgs) Handles CBOTROBANCO.CheckedChanged
        If CBOTROBANCO.Checked Then
            TXTCOTROBANCO.Enabled = True
        Else
            TXTCOTROBANCO.Enabled = False
        End If

    End Sub

    Private Sub CBEFECTIVO_CheckedChanged(sender As Object, e As EventArgs) Handles CBEFECTIVO.CheckedChanged
        If CBEFECTIVO.Checked Then
            TXTEFECTIVO.Enabled = True
        Else
            TXTEFECTIVO.Enabled = False
        End If
    End Sub
End Class
