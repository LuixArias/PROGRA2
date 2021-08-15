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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXTSALDOANTERIOR = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTEFECTIVO = New System.Windows.Forms.TextBox()
        Me.TXTCOTROBANCO = New System.Windows.Forms.TextBox()
        Me.TXTCPROPIO = New System.Windows.Forms.TextBox()
        Me.CBEFECTIVO = New System.Windows.Forms.CheckBox()
        Me.CBOTROBANCO = New System.Windows.Forms.CheckBox()
        Me.CBPROPIOS = New System.Windows.Forms.CheckBox()
        Me.RBAHORRO = New System.Windows.Forms.RadioButton()
        Me.RBPREMIER = New System.Windows.Forms.RadioButton()
        Me.RBMONETARIO = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTLIMPIAR = New System.Windows.Forms.Button()
        Me.BTCALCULAR = New System.Windows.Forms.Button()
        Me.BTSALIR = New System.Windows.Forms.Button()
        Me.TXTSALDONUEVO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTINTERESES = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(165, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INTERESE Y CONTROL DE DEPOSITOS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXTSALDOANTERIOR)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXTEFECTIVO)
        Me.GroupBox1.Controls.Add(Me.TXTCOTROBANCO)
        Me.GroupBox1.Controls.Add(Me.TXTCPROPIO)
        Me.GroupBox1.Controls.Add(Me.CBEFECTIVO)
        Me.GroupBox1.Controls.Add(Me.CBOTROBANCO)
        Me.GroupBox1.Controls.Add(Me.CBPROPIOS)
        Me.GroupBox1.Controls.Add(Me.RBAHORRO)
        Me.GroupBox1.Controls.Add(Me.RBPREMIER)
        Me.GroupBox1.Controls.Add(Me.RBMONETARIO)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(490, 192)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESOS"
        '
        'TXTSALDOANTERIOR
        '
        Me.TXTSALDOANTERIOR.Location = New System.Drawing.Point(129, 39)
        Me.TXTSALDOANTERIOR.Name = "TXTSALDOANTERIOR"
        Me.TXTSALDOANTERIOR.Size = New System.Drawing.Size(100, 20)
        Me.TXTSALDOANTERIOR.TabIndex = 1
        Me.TXTSALDOANTERIOR.Tag = ""
        Me.TXTSALDOANTERIOR.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "SALDO ANTERIOR:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(345, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "CANTIDAD"
        '
        'TXTEFECTIVO
        '
        Me.TXTEFECTIVO.Enabled = False
        Me.TXTEFECTIVO.Location = New System.Drawing.Point(323, 157)
        Me.TXTEFECTIVO.Name = "TXTEFECTIVO"
        Me.TXTEFECTIVO.Size = New System.Drawing.Size(100, 20)
        Me.TXTEFECTIVO.TabIndex = 9
        Me.TXTEFECTIVO.Text = "0"
        '
        'TXTCOTROBANCO
        '
        Me.TXTCOTROBANCO.Enabled = False
        Me.TXTCOTROBANCO.Location = New System.Drawing.Point(323, 131)
        Me.TXTCOTROBANCO.Name = "TXTCOTROBANCO"
        Me.TXTCOTROBANCO.Size = New System.Drawing.Size(100, 20)
        Me.TXTCOTROBANCO.TabIndex = 8
        Me.TXTCOTROBANCO.Text = "0"
        '
        'TXTCPROPIO
        '
        Me.TXTCPROPIO.Enabled = False
        Me.TXTCPROPIO.Location = New System.Drawing.Point(323, 105)
        Me.TXTCPROPIO.Multiline = True
        Me.TXTCPROPIO.Name = "TXTCPROPIO"
        Me.TXTCPROPIO.Size = New System.Drawing.Size(100, 20)
        Me.TXTCPROPIO.TabIndex = 7
        Me.TXTCPROPIO.Text = "0"
        '
        'CBEFECTIVO
        '
        Me.CBEFECTIVO.AutoSize = True
        Me.CBEFECTIVO.Location = New System.Drawing.Point(177, 151)
        Me.CBEFECTIVO.Name = "CBEFECTIVO"
        Me.CBEFECTIVO.Size = New System.Drawing.Size(65, 17)
        Me.CBEFECTIVO.TabIndex = 6
        Me.CBEFECTIVO.Text = "Efectivo"
        Me.CBEFECTIVO.UseVisualStyleBackColor = True
        '
        'CBOTROBANCO
        '
        Me.CBOTROBANCO.AutoSize = True
        Me.CBOTROBANCO.Location = New System.Drawing.Point(177, 129)
        Me.CBOTROBANCO.Name = "CBOTROBANCO"
        Me.CBOTROBANCO.Size = New System.Drawing.Size(132, 17)
        Me.CBOTROBANCO.TabIndex = 5
        Me.CBOTROBANCO.Text = "Cheque de otro banco"
        Me.CBOTROBANCO.UseVisualStyleBackColor = True
        '
        'CBPROPIOS
        '
        Me.CBPROPIOS.AutoSize = True
        Me.CBPROPIOS.Location = New System.Drawing.Point(177, 105)
        Me.CBPROPIOS.Name = "CBPROPIOS"
        Me.CBPROPIOS.Size = New System.Drawing.Size(101, 17)
        Me.CBPROPIOS.TabIndex = 4
        Me.CBPROPIOS.Text = "Cheque Propios"
        Me.CBPROPIOS.UseVisualStyleBackColor = True
        '
        'RBAHORRO
        '
        Me.RBAHORRO.AutoSize = True
        Me.RBAHORRO.Location = New System.Drawing.Point(21, 151)
        Me.RBAHORRO.Name = "RBAHORRO"
        Me.RBAHORRO.Size = New System.Drawing.Size(56, 17)
        Me.RBAHORRO.TabIndex = 4
        Me.RBAHORRO.TabStop = True
        Me.RBAHORRO.Text = "Ahorro"
        Me.RBAHORRO.UseVisualStyleBackColor = True
        '
        'RBPREMIER
        '
        Me.RBPREMIER.AutoSize = True
        Me.RBPREMIER.Location = New System.Drawing.Point(21, 128)
        Me.RBPREMIER.Name = "RBPREMIER"
        Me.RBPREMIER.Size = New System.Drawing.Size(110, 17)
        Me.RBPREMIER.TabIndex = 3
        Me.RBPREMIER.TabStop = True
        Me.RBPREMIER.Text = "Monetario Premier"
        Me.RBPREMIER.UseVisualStyleBackColor = True
        '
        'RBMONETARIO
        '
        Me.RBMONETARIO.AutoSize = True
        Me.RBMONETARIO.Location = New System.Drawing.Point(21, 105)
        Me.RBMONETARIO.Name = "RBMONETARIO"
        Me.RBMONETARIO.Size = New System.Drawing.Size(72, 17)
        Me.RBMONETARIO.TabIndex = 2
        Me.RBMONETARIO.TabStop = True
        Me.RBMONETARIO.Text = "Monetario"
        Me.RBMONETARIO.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo de Deposito"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTLIMPIAR)
        Me.GroupBox2.Controls.Add(Me.BTCALCULAR)
        Me.GroupBox2.Controls.Add(Me.BTSALIR)
        Me.GroupBox2.Location = New System.Drawing.Point(339, 260)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(222, 69)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ACCIONES"
        '
        'BTLIMPIAR
        '
        Me.BTLIMPIAR.Image = Global._201700663_DEPOSITOS.My.Resources.Resources.icons8_borrar_24
        Me.BTLIMPIAR.Location = New System.Drawing.Point(99, 15)
        Me.BTLIMPIAR.Name = "BTLIMPIAR"
        Me.BTLIMPIAR.Size = New System.Drawing.Size(63, 44)
        Me.BTLIMPIAR.TabIndex = 1
        Me.BTLIMPIAR.Text = "LIMPIAR"
        Me.BTLIMPIAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTLIMPIAR.UseVisualStyleBackColor = True
        '
        'BTCALCULAR
        '
        Me.BTCALCULAR.Image = Global._201700663_DEPOSITOS.My.Resources.Resources.icons8_calculadora_24
        Me.BTCALCULAR.Location = New System.Drawing.Point(16, 15)
        Me.BTCALCULAR.Name = "BTCALCULAR"
        Me.BTCALCULAR.Size = New System.Drawing.Size(78, 44)
        Me.BTCALCULAR.TabIndex = 0
        Me.BTCALCULAR.Text = " CALCULAR"
        Me.BTCALCULAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTCALCULAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTCALCULAR.UseVisualStyleBackColor = True
        '
        'BTSALIR
        '
        Me.BTSALIR.BackgroundImage = CType(resources.GetObject("BTSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTSALIR.Location = New System.Drawing.Point(168, 15)
        Me.BTSALIR.Name = "BTSALIR"
        Me.BTSALIR.Size = New System.Drawing.Size(48, 44)
        Me.BTSALIR.TabIndex = 3
        Me.BTSALIR.UseVisualStyleBackColor = True
        '
        'TXTSALDONUEVO
        '
        Me.TXTSALDONUEVO.Enabled = False
        Me.TXTSALDONUEVO.Location = New System.Drawing.Point(121, 257)
        Me.TXTSALDONUEVO.Name = "TXTSALDONUEVO"
        Me.TXTSALDONUEVO.Size = New System.Drawing.Size(100, 20)
        Me.TXTSALDONUEVO.TabIndex = 14
        Me.TXTSALDONUEVO.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "INTERESES:"
        '
        'TXTINTERESES
        '
        Me.TXTINTERESES.Enabled = False
        Me.TXTINTERESES.Location = New System.Drawing.Point(121, 283)
        Me.TXTINTERESES.Name = "TXTINTERESES"
        Me.TXTINTERESES.Size = New System.Drawing.Size(100, 20)
        Me.TXTINTERESES.TabIndex = 16
        Me.TXTINTERESES.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "NUEVO SALDO:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 341)
        Me.Controls.Add(Me.TXTINTERESES)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXTSALDONUEVO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "BANCO UNIVERSAL"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTLIMPIAR As Button
    Friend WithEvents BTCALCULAR As Button
    Friend WithEvents BTSALIR As Button
    Friend WithEvents TXTEFECTIVO As TextBox
    Friend WithEvents TXTCOTROBANCO As TextBox
    Friend WithEvents TXTCPROPIO As TextBox
    Friend WithEvents CBEFECTIVO As CheckBox
    Friend WithEvents CBOTROBANCO As CheckBox
    Friend WithEvents CBPROPIOS As CheckBox
    Friend WithEvents RBAHORRO As RadioButton
    Friend WithEvents RBPREMIER As RadioButton
    Friend WithEvents RBMONETARIO As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTSALDOANTERIOR As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTSALDONUEVO As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTINTERESES As TextBox
    Friend WithEvents Label6 As Label
End Class
