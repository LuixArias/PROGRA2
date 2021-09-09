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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TXTENTRADAS = New System.Windows.Forms.TextBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.AGREGARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LVECTORESToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LST_CINE = New System.Windows.Forms.ListBox()
        Me.LST_FUNCION = New System.Windows.Forms.ListBox()
        Me.LST_TOTAL = New System.Windows.Forms.ListBox()
        Me.LST_ENTRADA = New System.Windows.Forms.ListBox()
        Me.LST_subtotal = New System.Windows.Forms.ListBox()
        Me.LST_DESCUENTO2 = New System.Windows.Forms.ListBox()
        Me.LST_DESCUENTO1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 55)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CINE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(172, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 55)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FUNCIONES"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TXTENTRADAS)
        Me.GroupBox3.Location = New System.Drawing.Point(306, 32)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(128, 55)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "CANT. ENTRADAS"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.ComboBox2.Location = New System.Drawing.Point(21, 19)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(89, 21)
        Me.ComboBox2.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"A", "B", "C"})
        Me.ComboBox1.Location = New System.Drawing.Point(20, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(89, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'TXTENTRADAS
        '
        Me.TXTENTRADAS.Location = New System.Drawing.Point(20, 19)
        Me.TXTENTRADAS.Name = "TXTENTRADAS"
        Me.TXTENTRADAS.Size = New System.Drawing.Size(89, 20)
        Me.TXTENTRADAS.TabIndex = 0
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AGREGARToolStripMenuItem1, Me.LIMPIARToolStripMenuItem1, Me.SALIRToolStripMenuItem1, Me.LVECTORESToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(716, 24)
        Me.MenuStrip2.TabIndex = 12
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
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.LST_CINE)
        Me.GroupBox5.Controls.Add(Me.LST_FUNCION)
        Me.GroupBox5.Controls.Add(Me.LST_TOTAL)
        Me.GroupBox5.Controls.Add(Me.LST_ENTRADA)
        Me.GroupBox5.Controls.Add(Me.LST_subtotal)
        Me.GroupBox5.Controls.Add(Me.LST_DESCUENTO2)
        Me.GroupBox5.Controls.Add(Me.LST_DESCUENTO1)
        Me.GroupBox5.Location = New System.Drawing.Point(38, 107)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(663, 164)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "DETALLE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(301, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Sub Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(389, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "DESCUENTO 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(474, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "DESCUENTO 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(563, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "TOTAL"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(210, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "ENTRADAS"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(116, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "FUNCION"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(25, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "CINE"
        '
        'LST_CINE
        '
        Me.LST_CINE.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_CINE.FormattingEnabled = True
        Me.LST_CINE.Location = New System.Drawing.Point(28, 47)
        Me.LST_CINE.Name = "LST_CINE"
        Me.LST_CINE.Size = New System.Drawing.Size(82, 95)
        Me.LST_CINE.TabIndex = 19
        '
        'LST_FUNCION
        '
        Me.LST_FUNCION.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_FUNCION.FormattingEnabled = True
        Me.LST_FUNCION.Location = New System.Drawing.Point(116, 47)
        Me.LST_FUNCION.Name = "LST_FUNCION"
        Me.LST_FUNCION.Size = New System.Drawing.Size(82, 95)
        Me.LST_FUNCION.TabIndex = 12
        '
        'LST_TOTAL
        '
        Me.LST_TOTAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LST_TOTAL.FormattingEnabled = True
        Me.LST_TOTAL.Location = New System.Drawing.Point(565, 47)
        Me.LST_TOTAL.Name = "LST_TOTAL"
        Me.LST_TOTAL.Size = New System.Drawing.Size(82, 95)
        Me.LST_TOTAL.TabIndex = 18
        '
        'LST_ENTRADA
        '
        Me.LST_ENTRADA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_ENTRADA.FormattingEnabled = True
        Me.LST_ENTRADA.Location = New System.Drawing.Point(213, 47)
        Me.LST_ENTRADA.Name = "LST_ENTRADA"
        Me.LST_ENTRADA.Size = New System.Drawing.Size(82, 95)
        Me.LST_ENTRADA.TabIndex = 13
        '
        'LST_subtotal
        '
        Me.LST_subtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_subtotal.FormattingEnabled = True
        Me.LST_subtotal.Location = New System.Drawing.Point(301, 47)
        Me.LST_subtotal.Name = "LST_subtotal"
        Me.LST_subtotal.Size = New System.Drawing.Size(82, 95)
        Me.LST_subtotal.TabIndex = 14
        '
        'LST_DESCUENTO2
        '
        Me.LST_DESCUENTO2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_DESCUENTO2.FormattingEnabled = True
        Me.LST_DESCUENTO2.Location = New System.Drawing.Point(477, 47)
        Me.LST_DESCUENTO2.Name = "LST_DESCUENTO2"
        Me.LST_DESCUENTO2.Size = New System.Drawing.Size(82, 95)
        Me.LST_DESCUENTO2.TabIndex = 16
        '
        'LST_DESCUENTO1
        '
        Me.LST_DESCUENTO1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_DESCUENTO1.FormattingEnabled = True
        Me.LST_DESCUENTO1.Location = New System.Drawing.Point(389, 47)
        Me.LST_DESCUENTO1.Name = "LST_DESCUENTO1"
        Me.LST_DESCUENTO1.Size = New System.Drawing.Size(82, 95)
        Me.LST_DESCUENTO1.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(716, 305)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "CINEPOLIS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TXTENTRADAS As TextBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents AGREGARToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LIMPIARToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LVECTORESToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LST_CINE As ListBox
    Friend WithEvents LST_FUNCION As ListBox
    Friend WithEvents LST_TOTAL As ListBox
    Friend WithEvents LST_ENTRADA As ListBox
    Friend WithEvents LST_subtotal As ListBox
    Friend WithEvents LST_DESCUENTO2 As ListBox
    Friend WithEvents LST_DESCUENTO1 As ListBox
End Class
