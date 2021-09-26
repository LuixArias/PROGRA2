Public Class Form1
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub CBMARCA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMARCA.SelectedIndexChanged
        'TXTPRECIOS.Text = Str(CBMARCA.Text)
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub PROCESOSToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub SALIRToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        salir()

    End Sub

    Private Sub CalcularToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        'precio(indice) = TXTPRECIOS.Text

        If (TXTNIT.Text <> "") And (TXTPLACA.Text <> "") And (TXTDIAS.Text <> "") Then
            dias(indice) = Str(TXTDIAS.Text)
            Placa(indice) = Str(TXTPLACA.Text)
            Marca(indice) = CBMARCA.SelectedItem.ToString
            If CBMARCA.SelectedIndex = 0 Then
                parcial(indice) = alquilerHonda * dias(indice)
                TXTPRECIOS.Text = alquilerHonda
                TextBox7.Text = parcial(indice)
                If CheckBox1.Checked = True Then
                    total(indice) = parcial(indice) - (parcial(indice) * descuento)
                    If CheckBox2.Checked = True Then
                        total(indice) = parcial(indice) + (parcial(indice) * recargo)
                    End If
                End If
            ElseIf CBMARCA.SelectedIndex = 1 Then
                parcial(indice) = alquilerMercedes * dias(indice)
                TXTPRECIOS.Text = alquilerMercedes
                TextBox7.Text = parcial(indice)
                If CheckBox1.Checked = True Then
                    total(indice) = parcial(indice) - (parcial(indice) * descuento)
                    If CheckBox2.Checked = True Then
                        total(indice) = parcial(indice) + (parcial(indice) * recargo)
                    End If
                End If
            ElseIf CBMARCA.SelectedIndex = 2 Then
                parcial(indice) = alquilerToyota * dias(indice)
                TXTPRECIOS.Text = alquilerToyota
                TextBox7.Text = parcial(indice)
                If CheckBox1.Checked = True Then
                    total(indice) = parcial(indice) - (parcial(indice) * descuento)
                    If CheckBox2.Checked = True Then
                        total(indice) = parcial(indice) + (parcial(indice) * recargo)
                    End If
                End If
            ElseIf CBMARCA.SelectedIndex = 3 Then
                parcial(indice) = alquilerMazda * dias(indice)
                TXTPRECIOS.Text = alquilerMazda
                TextBox7.Text = parcial(indice)
                If CheckBox1.Checked = True Then
                    total(indice) = parcial(indice) - (parcial(indice) * descuento)
                    If CheckBox2.Checked = True Then
                        total(indice) = parcial(indice) + (parcial(indice) * recargo)
                    End If
                End If
            Else
                MsgBox("ERROR, FORMULARIO IMCOMPLETO")
                TXTNIT.Focus()
            End If
        End If
        Dim alquiler As Integer = costoAlquiler()

        If indice = 5 Then
            MsgBox("VECTORES LLENOS")
            limpiar_entradas()

        End If
        muestre_totales()
        indice = indice + 1
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        LIMPIAR_VECTORES()

    End Sub
End Class
