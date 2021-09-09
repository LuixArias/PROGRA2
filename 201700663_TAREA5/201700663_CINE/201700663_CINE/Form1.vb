Imports System.Math
Public Class Form1
    Private Sub LIMPIARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LIMPIARToolStripMenuItem1.Click
        limpiar_entradas()
    End Sub

    Private Sub SALIRToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem1.Click
        If (MsgBox("DESEA SALIR", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            End
        Else
            limpiar_entradas()
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AGREGARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AGREGARToolStripMenuItem1.Click

        If (indice < 9) Then
            CINE(indice) = ComboBox1.Text
            FUNCION(indice) = ComboBox2.Text
            If (TXTENTRADAS.Text <> "") Then
                Entradas(indice) = Val(TXTENTRADAS.Text)
            Else
                MsgBox("Error, no ingresó cant. de entradas")
                TXTENTRADAS.Focus() : Exit Sub
            End If

            Select Case (ComboBox1.SelectedIndex)
                Case 0
                    Select Case (ComboBox2.SelectedIndex)
                        Case 0 : Subtotal(indice) = Entradas(indice) * 30
                        Case 1 : Subtotal(indice) = Entradas(indice) * 35
                        Case 2 : Subtotal(indice) = Entradas(indice) * 40
                        Case 3 : Subtotal(indice) = Entradas(indice) * 40
                    End Select
                Case 1
                    Select Case (ComboBox2.SelectedIndex)
                        Case 0 : Subtotal(indice) = Entradas(indice) * 24
                        Case 1 : Subtotal(indice) = Entradas(indice) * 34
                        Case 2 : Subtotal(indice) = Entradas(indice) * 44
                        Case 3 : Subtotal(indice) = Entradas(indice) * 44
                    End Select
                Case 2
                    Select Case (ComboBox2.SelectedIndex)
                        Case 0 : Subtotal(indice) = Entradas(indice) * 35
                        Case 1 : Subtotal(indice) = Entradas(indice) * 40
                        Case 2 : Subtotal(indice) = Entradas(indice) * 50
                        Case 3 : Subtotal(indice) = Entradas(indice) * 50
                    End Select
                Case Else
                    MsgBox("Error, no seleccionó tipo de funcion")
                    ComboBox2.Focus() : Exit Sub
            End Select
            If (ComboBox2.SelectedIndex = 2 Or ComboBox2.SelectedIndex = 3) And (ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 2) Then
                Descuento1(indice) = Round(Val(Subtotal(indice) * 0.055), 2)
            ElseIf ComboBox2.SelectedIndex = 0 And (ComboBox1.SelectedIndex = 1 Or ComboBox1.SelectedIndex = 2) Then
                Descuento1(indice) = Round(Val(Subtotal(indice) * 0.03), 2)
            ElseIf ComboBox2.SelectedIndex = 1 And ComboBox1.SelectedIndex = 0 Then
                Descuento1(indice) = Round(Val(Subtotal(indice) * 0.015), 2)
            End If
            If Subtotal(indice) >= 100 And Subtotal(indice) <= 300 Then
                Descuento2(indice) = Round(Val(Subtotal(indice) * 0.02), 2)
            ElseIf Subtotal(indice) > 300 And Subtotal(indice) <= 500 Then
                Descuento2(indice) = Round(Val(Subtotal(indice) * 0.04), 2)
            ElseIf Subtotal(indice) > 500 And Subtotal(indice) <= 1000 Then
                Descuento2(indice) = Round(Val(Subtotal(indice) * 0.06), 2)
            End If
            PagoTotal(indice) = Val(Subtotal(indice)) - Val(Descuento1(indice)) - Val(Descuento2(indice))
            mostrar()

            indice = indice + 1
        End If
        If (indice = 9) Then
            MsgBox("Vectores llenos")
        End If
    End Sub

    Private Sub LVECTORESToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LVECTORESToolStripMenuItem1.Click
        limpiar_vectores()
    End Sub
End Class
