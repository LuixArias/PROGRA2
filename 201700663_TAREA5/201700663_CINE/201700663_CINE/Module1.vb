Imports System.Math
Module Module1
    Public indice As Byte = 0

    Public CINE(9) As String
    Public FUNCION(9) As String
    Public Entradas(9) As Double

    Public Subtotal(9) As Double
    Public Descuento1(9) As Double
    Public Descuento2(9) As Double
    Public PagoTotal(9) As Double
    Sub limpiar_grid()
        'Form1.DataGridView1.Rows.Clear()
        'para limpiar vectores hay varias formas, acá se muestra una de ellas, la otra es usando CICLOS que se verán después
        'en clase
        'pero en este caso se hace asignando valor CERO a la variable que controla las filas de los vectores,
        'eso se hace para poder empezar a guardar datos en los vectores desde la posición 0
        'aunque los valores guardados anteriormente aún están en los vectores
        'por lo que los datos que se irán guardando nuevamente caerán encima de los datos ya guardados
        'FILA = 0
        'Form1.ListBox1.Items.Clear()
        'Form1.ListBox2.Items.Clear()
        'Form1.ListBox3.Items.Clear()
        'Form1.ListBox4.Items.Clear()
        'Form1.ListBox5.Items.Clear()
        'Form1.ListBox6.Items.Clear()
        'Form1.ListBox7.Items.Clear()
    End Sub
    Sub limpiar_entradas()
        Form1.TXTENTRADAS.Clear()
        'otra forma de limpiar el combobox es de la siguiente forma, colocando en -1 la propiedad SELECTEDINDEX
        Form1.ComboBox2.SelectedIndex = -1
        Form1.ComboBox1.SelectedIndex = -1

        Form1.LST_CINE.Items.Clear()
        Form1.LST_FUNCION.Items.Clear()
        Form1.LST_ENTRADA.Items.Clear()
        Form1.LST_subtotal.Items.Clear()
        Form1.LST_DESCUENTO1.Items.Clear()
        Form1.LST_DESCUENTO2.Items.Clear()
        Form1.LST_TOTAL.Items.Clear()

        'con la siguiente instrucción también se puede limpiar la selección del combobox
        'Form1.ComboBox1.Text = ""
        Form1.TXTENTRADAS.Focus()
    End Sub
    Sub mostrar()
        Form1.LST_CINE.Items.Add(CINE(indice))
        Form1.LST_FUNCION.Items.Add(FUNCION(indice))
        Form1.LST_ENTRADA.Items.Add(Entradas(indice))
        Form1.LST_subtotal.Items.Add(Subtotal(indice))
        Form1.LST_DESCUENTO1.Items.Add(Descuento1(indice))
        Form1.LST_DESCUENTO2.Items.Add(Descuento2(indice))
        Form1.LST_TOTAL.Items.Add(PagoTotal(indice))

        Form1.TXTENTRADAS.Clear()
        Form1.ComboBox2.SelectedIndex = -1
        Form1.ComboBox1.SelectedIndex = -1
    End Sub
    Sub limpiar_vectores()
        indice = 0

        Form1.TXTENTRADAS.Clear()
        Form1.ComboBox2.SelectedIndex = -1
        Form1.ComboBox1.SelectedIndex = -1

        Form1.LST_CINE.Items.Clear()
        Form1.LST_FUNCION.Items.Clear()
        Form1.LST_ENTRADA.Items.Clear()
        Form1.LST_subtotal.Items.Clear()
        Form1.LST_DESCUENTO1.Items.Clear()
        Form1.LST_DESCUENTO2.Items.Clear()
        Form1.LST_TOTAL.Items.Clear()

        Form1.TXTENTRADAS.Focus()
    End Sub
End Module
