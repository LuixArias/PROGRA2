Imports System.Math
Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub SALIRToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem1.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            Limpiar_Entradas()
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LST_TipoTarifa.SelectedIndexChanged

    End Sub

    Private Sub AGREGARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AGREGARToolStripMenuItem1.Click
        If (indice < 11) Then
            Cliente(indice) = TXTNOMBRE.Text
            Servicio(indice) = ComboBox1.Text
            tarifa(indice) = ComboBox2.Text
            Saldoanterior(indice) = Val(TXTSALDOANTERIOR.Text)
            Consumo(indice) = Val(TXTWATTS.Text)
            If Saldoanterior(indice) > 0 Then
                Mora(indice) = Round(Saldoanterior(indice) * 0.02, 2)
            End If
            If Consumo(indice) > 0 And Consumo(indice) <= 100 Then
                Select Case (ComboBox1.SelectedIndex)
                    Case 0 : total_pagoini(indice) = Round(Consumo(indice) * Residencial1, 2)
                        Select Case (ComboBox2.SelectedIndex)
                            Case 0 : PagoParcial(indice) = Round(total_pagoini(indice) * descuento_social, 2)
                            Case 1 : PagoParcial(indice) = Round(total_pagoini(indice) * descuento_nosocial, 2)
                        End Select
                    Case 1 : total_pagoini(indice) = Round(Consumo(indice) * Industrial1, 2)
                        Select Case (ComboBox2.SelectedIndex)
                            Case 0 : PagoParcial(indice) = Round(total_pagoini(indice) * descuento_social, 2)
                            Case 1 : PagoParcial(indice) = Round(total_pagoini(indice) * descuento_nosocial, 2)
                        End Select
                    Case Else
                        MsgBox("Error, no seleccionó tipo de servicio")
                        ComboBox1.Focus() : Exit Sub
                End Select
                PagoTotal(indice) = Round(Val(total_pagoini(indice)) - Val(PagoParcial(indice)) + Val(Mora(indice)) + Val(Saldoanterior(indice)), 2)
                mostrar()
                Limpiar_Entradas()
                indice = indice + 1
            ElseIf Consumo(indice) > 100 And Consumo(indice) <= 300 Then
                Select Case (ComboBox1.SelectedIndex)
                    Case 0 : total_pagoini(indice) = Round(Consumo(indice) * Residencial2, 2)
                        Select Case (ComboBox2.SelectedIndex)
                            Case 0 : PagoParcial(indice) = Round(total_pagoini(indice) * descuento_social, 2)
                            Case 1 : PagoParcial(indice) = Round(total_pagoini(indice) * descuento_nosocial, 2)
                        End Select
                    Case 1 : total_pagoini(indice) = Round(Consumo(indice) * Industrial2, 2)
                        Select Case (ComboBox2.SelectedIndex)
                            Case 0 : PagoParcial(indice) = Round(total_pagoini(indice) * descuento_social, 2)
                            Case 1 : PagoParcial(indice) = Round(total_pagoini(indice) * descuento_nosocial, 2)
                        End Select
                    Case Else
                        MsgBox("Error, no seleccionó tipo de servicio")
                        ComboBox1.Focus() : Exit Sub
                End Select
                PagoTotal(indice) = Round(Val(total_pagoini(indice)) - Val(PagoParcial(indice)) + Val(Mora(indice)) + Val(Saldoanterior(indice)), 2)
                mostrar()
                Limpiar_Entradas()
                indice = indice + 1
            ElseIf Consumo(indice) > 300 Then
                Select Case (ComboBox1.SelectedIndex)
                    Case 0 : total_pagoini(indice) = Round(Consumo(indice) * Residencial3, 2)
                        Select Case (ComboBox2.SelectedIndex)
                            Case 0 : PagoParcial(indice) = Round(total_pagoini(indice) * descuento_social, 2)
                            Case 1 : PagoParcial(indice) = Round(total_pagoini(indice) * descuento_nosocial, 2)
                        End Select
                    Case 1 : total_pagoini(indice) = Round(Consumo(indice) * Industrial3, 2)
                        Select Case (ComboBox2.SelectedIndex)
                            Case 0 : PagoParcial(indice) = Round(total_pagoini(indice) * descuento_social, 2)
                            Case 1 : PagoParcial(indice) = Round(total_pagoini(indice) * descuento_nosocial, 2)
                        End Select
                    Case Else
                        MsgBox("Error, no seleccionó tipo de servicio")
                        ComboBox1.Focus() : Exit Sub
                End Select
                PagoTotal(indice) = Round(Val(total_pagoini(indice)) - Val(PagoParcial(indice)) + Val(Mora(indice)) + Val(Saldoanterior(indice)), 2)
                mostrar()
                Limpiar_Entradas()

                indice = indice + 1
            End If
            If (indice = 11) Then
                MsgBox("VECTORES LLENOS")
            End If

        End If

    End Sub

    Private Sub LIMPIARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem1.Click
        Limpiar_Entradas()

    End Sub

    Private Sub LVECTORESToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LVECTORESToolStripMenuItem1.Click
        indice = 0

        LST_CLIENTE.Items.Clear()
        LST_TipoDeServicio.Items.Clear()
        LST_TipoTarifa.Items.Clear()
        LST_SaldoAnterior.Items.Clear()
        LST_PagoInicial.Items.Clear()
        LST_MORA.Items.Clear()
        LST_DESCUENTO.Items.Clear()
        LST_TOTAL.Items.Clear()
    End Sub
End Class
