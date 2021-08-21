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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTLIMPIAR = New System.Windows.Forms.Button()
        Me.BTCALCULAR = New System.Windows.Forms.Button()
        Me.BTSALIR = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBKING = New System.Windows.Forms.RadioButton()
        Me.RBQUEEN = New System.Windows.Forms.RadioButton()
        Me.RBMATRIMONIAL = New System.Windows.Forms.RadioButton()
        Me.RBIMPERIAL = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CBHILO = New System.Windows.Forms.CheckBox()
        Me.CBSEDA = New System.Windows.Forms.CheckBox()
        Me.CBALGODON = New System.Windows.Forms.CheckBox()
        Me.CBLINO = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TXTHILO = New System.Windows.Forms.TextBox()
        Me.TXTSEDA = New System.Windows.Forms.TextBox()
        Me.TXTALGODON = New System.Windows.Forms.TextBox()
        Me.TXTLINO = New System.Windows.Forms.TextBox()
        Me.LRESULTADOS = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LVENTA = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTLIMPIAR)
        Me.GroupBox2.Controls.Add(Me.BTCALCULAR)
        Me.GroupBox2.Controls.Add(Me.BTSALIR)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(329, 265)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(222, 69)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ACCIONES"
        '
        'BTLIMPIAR
        '
        Me.BTLIMPIAR.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.BTLIMPIAR.Image = Global._201700663_CUBRECAMAS.My.Resources.Resources.icons8_borrar_24
        Me.BTLIMPIAR.Location = New System.Drawing.Point(99, 15)
        Me.BTLIMPIAR.Name = "BTLIMPIAR"
        Me.BTLIMPIAR.Size = New System.Drawing.Size(63, 44)
        Me.BTLIMPIAR.TabIndex = 1
        Me.BTLIMPIAR.Text = "LIMPIAR"
        Me.BTLIMPIAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTLIMPIAR.UseVisualStyleBackColor = False
        '
        'BTCALCULAR
        '
        Me.BTCALCULAR.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.BTCALCULAR.Image = Global._201700663_CUBRECAMAS.My.Resources.Resources.icons8_calculadora_24
        Me.BTCALCULAR.Location = New System.Drawing.Point(16, 15)
        Me.BTCALCULAR.Name = "BTCALCULAR"
        Me.BTCALCULAR.Size = New System.Drawing.Size(78, 44)
        Me.BTCALCULAR.TabIndex = 0
        Me.BTCALCULAR.Text = " CALCULAR"
        Me.BTCALCULAR.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTCALCULAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTCALCULAR.UseVisualStyleBackColor = False
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBKING)
        Me.GroupBox1.Controls.Add(Me.RBQUEEN)
        Me.GroupBox1.Controls.Add(Me.RBMATRIMONIAL)
        Me.GroupBox1.Controls.Add(Me.RBIMPERIAL)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(39, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(134, 133)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tamaños Cubrecama"
        '
        'RBKING
        '
        Me.RBKING.AutoSize = True
        Me.RBKING.Location = New System.Drawing.Point(20, 96)
        Me.RBKING.Name = "RBKING"
        Me.RBKING.Size = New System.Drawing.Size(51, 17)
        Me.RBKING.TabIndex = 3
        Me.RBKING.TabStop = True
        Me.RBKING.Text = "KING"
        Me.RBKING.UseVisualStyleBackColor = True
        '
        'RBQUEEN
        '
        Me.RBQUEEN.AutoSize = True
        Me.RBQUEEN.Location = New System.Drawing.Point(20, 73)
        Me.RBQUEEN.Name = "RBQUEEN"
        Me.RBQUEEN.Size = New System.Drawing.Size(63, 17)
        Me.RBQUEEN.TabIndex = 2
        Me.RBQUEEN.TabStop = True
        Me.RBQUEEN.Text = "QUEEN"
        Me.RBQUEEN.UseVisualStyleBackColor = True
        '
        'RBMATRIMONIAL
        '
        Me.RBMATRIMONIAL.AutoSize = True
        Me.RBMATRIMONIAL.Location = New System.Drawing.Point(20, 50)
        Me.RBMATRIMONIAL.Name = "RBMATRIMONIAL"
        Me.RBMATRIMONIAL.Size = New System.Drawing.Size(100, 17)
        Me.RBMATRIMONIAL.TabIndex = 1
        Me.RBMATRIMONIAL.TabStop = True
        Me.RBMATRIMONIAL.Text = "MATRIMONIAL"
        Me.RBMATRIMONIAL.UseVisualStyleBackColor = True
        '
        'RBIMPERIAL
        '
        Me.RBIMPERIAL.AutoSize = True
        Me.RBIMPERIAL.Location = New System.Drawing.Point(20, 27)
        Me.RBIMPERIAL.Name = "RBIMPERIAL"
        Me.RBIMPERIAL.Size = New System.Drawing.Size(75, 17)
        Me.RBIMPERIAL.TabIndex = 0
        Me.RBIMPERIAL.TabStop = True
        Me.RBIMPERIAL.Text = "IMPERIAL"
        Me.RBIMPERIAL.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CBHILO)
        Me.GroupBox3.Controls.Add(Me.CBSEDA)
        Me.GroupBox3.Controls.Add(Me.CBALGODON)
        Me.GroupBox3.Controls.Add(Me.CBLINO)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(208, 30)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(102, 133)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Materiales"
        '
        'CBHILO
        '
        Me.CBHILO.AutoSize = True
        Me.CBHILO.Location = New System.Drawing.Point(17, 110)
        Me.CBHILO.Name = "CBHILO"
        Me.CBHILO.Size = New System.Drawing.Size(75, 17)
        Me.CBHILO.TabIndex = 3
        Me.CBHILO.Text = "Hilo Crudo"
        Me.CBHILO.UseVisualStyleBackColor = True
        '
        'CBSEDA
        '
        Me.CBSEDA.AutoSize = True
        Me.CBSEDA.Location = New System.Drawing.Point(17, 81)
        Me.CBSEDA.Name = "CBSEDA"
        Me.CBSEDA.Size = New System.Drawing.Size(51, 17)
        Me.CBSEDA.TabIndex = 2
        Me.CBSEDA.Text = "Seda"
        Me.CBSEDA.UseVisualStyleBackColor = True
        '
        'CBALGODON
        '
        Me.CBALGODON.AutoSize = True
        Me.CBALGODON.Location = New System.Drawing.Point(17, 51)
        Me.CBALGODON.Name = "CBALGODON"
        Me.CBALGODON.Size = New System.Drawing.Size(65, 17)
        Me.CBALGODON.TabIndex = 1
        Me.CBALGODON.Text = "Algodon"
        Me.CBALGODON.UseVisualStyleBackColor = True
        '
        'CBLINO
        '
        Me.CBLINO.AutoSize = True
        Me.CBLINO.Location = New System.Drawing.Point(17, 27)
        Me.CBLINO.Name = "CBLINO"
        Me.CBLINO.Size = New System.Drawing.Size(46, 17)
        Me.CBLINO.TabIndex = 0
        Me.CBLINO.Text = "Lino"
        Me.CBLINO.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TXTHILO)
        Me.GroupBox4.Controls.Add(Me.TXTSEDA)
        Me.GroupBox4.Controls.Add(Me.TXTALGODON)
        Me.GroupBox4.Controls.Add(Me.TXTLINO)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox4.Location = New System.Drawing.Point(329, 30)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(75, 133)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Yardas"
        '
        'TXTHILO
        '
        Me.TXTHILO.Enabled = False
        Me.TXTHILO.Location = New System.Drawing.Point(7, 104)
        Me.TXTHILO.Name = "TXTHILO"
        Me.TXTHILO.Size = New System.Drawing.Size(46, 20)
        Me.TXTHILO.TabIndex = 3
        Me.TXTHILO.Text = "0"
        Me.TXTHILO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTSEDA
        '
        Me.TXTSEDA.Enabled = False
        Me.TXTSEDA.Location = New System.Drawing.Point(7, 78)
        Me.TXTSEDA.Name = "TXTSEDA"
        Me.TXTSEDA.Size = New System.Drawing.Size(46, 20)
        Me.TXTSEDA.TabIndex = 2
        Me.TXTSEDA.Text = "0"
        Me.TXTSEDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTALGODON
        '
        Me.TXTALGODON.Enabled = False
        Me.TXTALGODON.Location = New System.Drawing.Point(7, 50)
        Me.TXTALGODON.Name = "TXTALGODON"
        Me.TXTALGODON.Size = New System.Drawing.Size(46, 20)
        Me.TXTALGODON.TabIndex = 1
        Me.TXTALGODON.Text = "0"
        Me.TXTALGODON.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTLINO
        '
        Me.TXTLINO.Enabled = False
        Me.TXTLINO.Location = New System.Drawing.Point(7, 24)
        Me.TXTLINO.Name = "TXTLINO"
        Me.TXTLINO.Size = New System.Drawing.Size(46, 20)
        Me.TXTLINO.TabIndex = 0
        Me.TXTLINO.Text = "0"
        Me.TXTLINO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LRESULTADOS
        '
        Me.LRESULTADOS.AutoSize = True
        Me.LRESULTADOS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LRESULTADOS.Location = New System.Drawing.Point(160, 207)
        Me.LRESULTADOS.Name = "LRESULTADOS"
        Me.LRESULTADOS.Size = New System.Drawing.Size(13, 13)
        Me.LRESULTADOS.TabIndex = 7
        Me.LRESULTADOS.Text = "--"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(56, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Precio de Costo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(56, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Precio de Venta:"
        '
        'LVENTA
        '
        Me.LVENTA.AutoSize = True
        Me.LVENTA.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LVENTA.Location = New System.Drawing.Point(160, 235)
        Me.LVENTA.Name = "LVENTA"
        Me.LVENTA.Size = New System.Drawing.Size(13, 13)
        Me.LVENTA.TabIndex = 9
        Me.LVENTA.Text = "--"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(554, 335)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LVENTA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LRESULTADOS)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LA BODEGONA"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTLIMPIAR As Button
    Friend WithEvents BTCALCULAR As Button
    Friend WithEvents BTSALIR As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBKING As RadioButton
    Friend WithEvents RBQUEEN As RadioButton
    Friend WithEvents RBMATRIMONIAL As RadioButton
    Friend WithEvents RBIMPERIAL As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CBHILO As CheckBox
    Friend WithEvents CBSEDA As CheckBox
    Friend WithEvents CBALGODON As CheckBox
    Friend WithEvents CBLINO As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TXTHILO As TextBox
    Friend WithEvents TXTSEDA As TextBox
    Friend WithEvents TXTALGODON As TextBox
    Friend WithEvents TXTLINO As TextBox
    Friend WithEvents LRESULTADOS As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LVENTA As Label
End Class
