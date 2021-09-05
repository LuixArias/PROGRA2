<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.TXTNIT = New System.Windows.Forms.TextBox()
        Me.TXTSALDOANTERIOR = New System.Windows.Forms.TextBox()
        Me.TXTWATTS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.AGREGARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LVECTORESToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LST_TipoDeServicio = New System.Windows.Forms.ListBox()
        Me.LST_TipoTarifa = New System.Windows.Forms.ListBox()
        Me.LST_SaldoAnterior = New System.Windows.Forms.ListBox()
        Me.LST_PagoInicial = New System.Windows.Forms.ListBox()
        Me.LST_MORA = New System.Windows.Forms.ListBox()
        Me.LST_DESCUENTO = New System.Windows.Forms.ListBox()
        Me.LST_TOTAL = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LST_CLIENTE = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(130, 21)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(100, 20)
        Me.TXTNOMBRE.TabIndex = 0
        '
        'TXTNIT
        '
        Me.TXTNIT.Location = New System.Drawing.Point(130, 47)
        Me.TXTNIT.Name = "TXTNIT"
        Me.TXTNIT.Size = New System.Drawing.Size(100, 20)
        Me.TXTNIT.TabIndex = 1
        '
        'TXTSALDOANTERIOR
        '
        Me.TXTSALDOANTERIOR.Location = New System.Drawing.Point(130, 73)
        Me.TXTSALDOANTERIOR.Name = "TXTSALDOANTERIOR"
        Me.TXTSALDOANTERIOR.Size = New System.Drawing.Size(100, 20)
        Me.TXTSALDOANTERIOR.TabIndex = 2
        '
        'TXTWATTS
        '
        Me.TXTWATTS.Location = New System.Drawing.Point(130, 99)
        Me.TXTWATTS.Name = "TXTWATTS"
        Me.TXTWATTS.Size = New System.Drawing.Size(100, 20)
        Me.TXTWATTS.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "NOMBRE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NIT:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "SALDO ANTERIOR:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "CONSUMO(kW):"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXTNOMBRE)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXTNIT)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXTSALDOANTERIOR)
        Me.GroupBox1.Controls.Add(Me.TXTWATTS)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 138)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(315, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(151, 53)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de Servicio"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Residenciales", "Industrial"})
        Me.ComboBox1.Location = New System.Drawing.Point(15, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(315, 114)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(151, 53)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de Tarifa"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Social", "No Social"})
        Me.ComboBox2.Location = New System.Drawing.Point(15, 19)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 0
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AGREGARToolStripMenuItem1, Me.LIMPIARToolStripMenuItem1, Me.SALIRToolStripMenuItem1, Me.LVECTORESToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(791, 24)
        Me.MenuStrip2.TabIndex = 11
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'AGREGARToolStripMenuItem1
        '
        Me.AGREGARToolStripMenuItem1.Name = "AGREGARToolStripMenuItem1"
        Me.AGREGARToolStripMenuItem1.Size = New System.Drawing.Size(71, 20)
        Me.AGREGARToolStripMenuItem1.Text = "AGREGAR"
        '
        'LIMPIARToolStripMenuItem1
        '
        Me.LIMPIARToolStripMenuItem1.Name = "LIMPIARToolStripMenuItem1"
        Me.LIMPIARToolStripMenuItem1.Size = New System.Drawing.Size(64, 20)
        Me.LIMPIARToolStripMenuItem1.Text = "LIMPIAR"
        '
        'SALIRToolStripMenuItem1
        '
        Me.SALIRToolStripMenuItem1.Name = "SALIRToolStripMenuItem1"
        Me.SALIRToolStripMenuItem1.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem1.Text = "SALIR"
        '
        'LVECTORESToolStripMenuItem1
        '
        Me.LVECTORESToolStripMenuItem1.Name = "LVECTORESToolStripMenuItem1"
        Me.LVECTORESToolStripMenuItem1.Size = New System.Drawing.Size(121, 20)
        Me.LVECTORESToolStripMenuItem1.Text = "LIMPIAR VECTORES"
        '
        'LST_TipoDeServicio
        '
        Me.LST_TipoDeServicio.FormattingEnabled = True
        Me.LST_TipoDeServicio.Location = New System.Drawing.Point(116, 63)
        Me.LST_TipoDeServicio.Name = "LST_TipoDeServicio"
        Me.LST_TipoDeServicio.Size = New System.Drawing.Size(82, 95)
        Me.LST_TipoDeServicio.TabIndex = 12
        '
        'LST_TipoTarifa
        '
        Me.LST_TipoTarifa.FormattingEnabled = True
        Me.LST_TipoTarifa.Location = New System.Drawing.Point(213, 63)
        Me.LST_TipoTarifa.Name = "LST_TipoTarifa"
        Me.LST_TipoTarifa.Size = New System.Drawing.Size(82, 95)
        Me.LST_TipoTarifa.TabIndex = 13
        '
        'LST_SaldoAnterior
        '
        Me.LST_SaldoAnterior.FormattingEnabled = True
        Me.LST_SaldoAnterior.Location = New System.Drawing.Point(301, 63)
        Me.LST_SaldoAnterior.Name = "LST_SaldoAnterior"
        Me.LST_SaldoAnterior.Size = New System.Drawing.Size(82, 95)
        Me.LST_SaldoAnterior.TabIndex = 14
        '
        'LST_PagoInicial
        '
        Me.LST_PagoInicial.FormattingEnabled = True
        Me.LST_PagoInicial.Location = New System.Drawing.Point(389, 63)
        Me.LST_PagoInicial.Name = "LST_PagoInicial"
        Me.LST_PagoInicial.Size = New System.Drawing.Size(82, 95)
        Me.LST_PagoInicial.TabIndex = 15
        '
        'LST_MORA
        '
        Me.LST_MORA.FormattingEnabled = True
        Me.LST_MORA.Location = New System.Drawing.Point(477, 63)
        Me.LST_MORA.Name = "LST_MORA"
        Me.LST_MORA.Size = New System.Drawing.Size(82, 95)
        Me.LST_MORA.TabIndex = 16
        '
        'LST_DESCUENTO
        '
        Me.LST_DESCUENTO.FormattingEnabled = True
        Me.LST_DESCUENTO.Location = New System.Drawing.Point(565, 63)
        Me.LST_DESCUENTO.Name = "LST_DESCUENTO"
        Me.LST_DESCUENTO.Size = New System.Drawing.Size(82, 95)
        Me.LST_DESCUENTO.TabIndex = 17
        '
        'LST_TOTAL
        '
        Me.LST_TOTAL.FormattingEnabled = True
        Me.LST_TOTAL.Location = New System.Drawing.Point(653, 63)
        Me.LST_TOTAL.Name = "LST_TOTAL"
        Me.LST_TOTAL.Size = New System.Drawing.Size(82, 95)
        Me.LST_TOTAL.TabIndex = 18
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.LST_CLIENTE)
        Me.GroupBox4.Controls.Add(Me.LST_TipoDeServicio)
        Me.GroupBox4.Controls.Add(Me.LST_TOTAL)
        Me.GroupBox4.Controls.Add(Me.LST_TipoTarifa)
        Me.GroupBox4.Controls.Add(Me.LST_DESCUENTO)
        Me.GroupBox4.Controls.Add(Me.LST_SaldoAnterior)
        Me.GroupBox4.Controls.Add(Me.LST_MORA)
        Me.GroupBox4.Controls.Add(Me.LST_PagoInicial)
        Me.GroupBox4.Location = New System.Drawing.Point(25, 201)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(754, 164)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DETALLE"
        '
        'LST_CLIENTE
        '
        Me.LST_CLIENTE.FormattingEnabled = True
        Me.LST_CLIENTE.Location = New System.Drawing.Point(28, 63)
        Me.LST_CLIENTE.Name = "LST_CLIENTE"
        Me.LST_CLIENTE.Size = New System.Drawing.Size(82, 95)
        Me.LST_CLIENTE.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "CLIENTE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(116, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "SERVICIO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(210, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "TARIFA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(562, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "DESCUENTO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(650, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "TOTAL"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(474, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "MORA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(389, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Pago Inicial"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(301, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Pago Parcial"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 377)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recibo de Luz"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents TXTNIT As TextBox
    Friend WithEvents TXTSALDOANTERIOR As TextBox
    Friend WithEvents TXTWATTS As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents AGREGARToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LIMPIARToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LVECTORESToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LST_TipoDeServicio As ListBox
    Friend WithEvents LST_TipoTarifa As ListBox
    Friend WithEvents LST_SaldoAnterior As ListBox
    Friend WithEvents LST_PagoInicial As ListBox
    Friend WithEvents LST_MORA As ListBox
    Friend WithEvents LST_DESCUENTO As ListBox
    Friend WithEvents LST_TOTAL As ListBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LST_CLIENTE As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
