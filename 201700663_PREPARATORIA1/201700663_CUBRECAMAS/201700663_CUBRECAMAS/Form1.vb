Public Class Form1

    Private Sub BTSALIR_Click(sender As Object, e As EventArgs) Handles BTSALIR.Click
        If MsgBox("DESEA SALIR?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Me.Close()
        Else
            LIMPIAR_ENTRADAS()
        End If
    End Sub

    Private Sub BTLIMPIAR_Click(sender As Object, e As EventArgs) Handles BTLIMPIAR.Click
        LIMPIAR_ENTRADAS()

    End Sub

    Private Sub BTCALCULAR_Click(sender As Object, e As EventArgs) Handles BTCALCULAR.Click
        TotalYardas = Val(TXTLINO.Text) + Val(TXTALGODON.Text) + Val(TXTSEDA.Text) + Val(TXTHILO.Text)
        If RBIMPERIAL.Checked Then
            If TotalYardas = 3 Then
                TOTAL = 65.5 + Val(TXTALGODON.Text) * algodon + Val(TXTLINO.Text) * lino + Val(TXTSEDA.Text) * seda + Val(TXTHILO.Text) * hilo
                LRESULTADOS.Text = Str(TOTAL)
                LVENTA.Text = Str(Val(TOTAL) + (Val(TOTAL) * 0.65))
            ElseIf MsgBox("Yardas insuficientes", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then
            End If
        End If
        If RBMATRIMONIAL.Checked Then
            If TotalYardas = 5 Then
                TOTAL = 85.99 + Val(TXTALGODON.Text) * algodon + Val(TXTLINO.Text) * lino + Val(TXTSEDA.Text) * seda + Val(TXTHILO.Text) * hilo
                LRESULTADOS.Text = Str(TOTAL)
                LVENTA.Text = Str(Val(TOTAL) + (Val(TOTAL) * 0.65))
            ElseIf MsgBox("Yardas insuficientes", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then
            End If
        End If
        If RBQUEEN.Checked Then
            If TotalYardas = 6 Then
                TOTAL = 99.99 + Val(TXTALGODON.Text) * algodon + Val(TXTLINO.Text) * lino + Val(TXTSEDA.Text) * seda + Val(TXTHILO.Text) * hilo
                LRESULTADOS.Text = Str(TOTAL)
                LVENTA.Text = Str(Val(TOTAL) + (Val(TOTAL) * 0.65))
            ElseIf MsgBox("Yardas insuficientes", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then
            End If
        End If
        If RBKING.Checked Then
            If TotalYardas = 7 Then
                TOTAL = 105.99 + Val(TXTALGODON.Text) * algodon + Val(TXTLINO.Text) * lino + Val(TXTSEDA.Text) * seda + Val(TXTHILO.Text) * hilo
                LRESULTADOS.Text = Str(TOTAL)
                LVENTA.Text = Str(Val(TOTAL) + (Val(TOTAL) * 0.65))
            ElseIf MsgBox("Yardas insuficientes", vbQuestion + vbYesNo, "FALTAN DATOS") = vbInformation Then
            End If
        End If
    End Sub

    Private Sub CBLINO_CheckedChanged(sender As Object, e As EventArgs) Handles CBLINO.CheckedChanged
        If CBLINO.Checked Then
            TXTLINO.Enabled = True
        Else
            TXTLINO.Enabled = False
        End If
    End Sub

    Private Sub CBALGODON_CheckedChanged(sender As Object, e As EventArgs) Handles CBALGODON.CheckedChanged
        If CBALGODON.Checked Then
            TXTALGODON.Enabled = True
        Else
            TXTALGODON.Enabled = False
        End If
    End Sub

    Private Sub CBSEDA_CheckedChanged(sender As Object, e As EventArgs) Handles CBSEDA.CheckedChanged
        If CBSEDA.Checked Then
            TXTSEDA.Enabled = True
        Else
            TXTSEDA.Enabled = False
        End If
    End Sub

    Private Sub CBHILO_CheckedChanged(sender As Object, e As EventArgs) Handles CBHILO.CheckedChanged
        If CBHILO.Checked Then
            TXTHILO.Enabled = True
        Else
            TXTHILO.Enabled = False
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LRESULTADOS.Click

    End Sub
End Class
