<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnFuncion1 = New System.Windows.Forms.Button()
        Me.btnFuncion2 = New System.Windows.Forms.Button()
        Me.btnFuncion3 = New System.Windows.Forms.Button()
        Me.btnFuncion4 = New System.Windows.Forms.Button()
        Me.btnFuncion5 = New System.Windows.Forms.Button()
        Me.btnFuncion6 = New System.Windows.Forms.Button()
        Me.btnFuncion7 = New System.Windows.Forms.Button()
        Me.txtPalabra = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFuncion1
        '
        Me.btnFuncion1.Location = New System.Drawing.Point(12, 34)
        Me.btnFuncion1.Name = "btnFuncion1"
        Me.btnFuncion1.Size = New System.Drawing.Size(75, 23)
        Me.btnFuncion1.TabIndex = 0
        Me.btnFuncion1.Text = "FUNCION 1"
        Me.btnFuncion1.UseVisualStyleBackColor = True
        '
        'btnFuncion2
        '
        Me.btnFuncion2.Location = New System.Drawing.Point(12, 63)
        Me.btnFuncion2.Name = "btnFuncion2"
        Me.btnFuncion2.Size = New System.Drawing.Size(75, 23)
        Me.btnFuncion2.TabIndex = 1
        Me.btnFuncion2.Text = "FUNCION 2"
        Me.btnFuncion2.UseVisualStyleBackColor = True
        '
        'btnFuncion3
        '
        Me.btnFuncion3.Location = New System.Drawing.Point(12, 92)
        Me.btnFuncion3.Name = "btnFuncion3"
        Me.btnFuncion3.Size = New System.Drawing.Size(75, 23)
        Me.btnFuncion3.TabIndex = 2
        Me.btnFuncion3.Text = "FUNCION 3"
        Me.btnFuncion3.UseVisualStyleBackColor = True
        '
        'btnFuncion4
        '
        Me.btnFuncion4.Location = New System.Drawing.Point(12, 121)
        Me.btnFuncion4.Name = "btnFuncion4"
        Me.btnFuncion4.Size = New System.Drawing.Size(75, 23)
        Me.btnFuncion4.TabIndex = 3
        Me.btnFuncion4.Text = "FUNCION 4"
        Me.btnFuncion4.UseVisualStyleBackColor = True
        '
        'btnFuncion5
        '
        Me.btnFuncion5.Location = New System.Drawing.Point(12, 150)
        Me.btnFuncion5.Name = "btnFuncion5"
        Me.btnFuncion5.Size = New System.Drawing.Size(75, 23)
        Me.btnFuncion5.TabIndex = 4
        Me.btnFuncion5.Text = "FUNCION 5"
        Me.btnFuncion5.UseVisualStyleBackColor = True
        '
        'btnFuncion6
        '
        Me.btnFuncion6.Location = New System.Drawing.Point(12, 179)
        Me.btnFuncion6.Name = "btnFuncion6"
        Me.btnFuncion6.Size = New System.Drawing.Size(75, 23)
        Me.btnFuncion6.TabIndex = 5
        Me.btnFuncion6.Text = "FUNCION 6"
        Me.btnFuncion6.UseVisualStyleBackColor = True
        '
        'btnFuncion7
        '
        Me.btnFuncion7.Location = New System.Drawing.Point(12, 208)
        Me.btnFuncion7.Name = "btnFuncion7"
        Me.btnFuncion7.Size = New System.Drawing.Size(75, 23)
        Me.btnFuncion7.TabIndex = 6
        Me.btnFuncion7.Text = "FUNCION 7"
        Me.btnFuncion7.UseVisualStyleBackColor = True
        '
        'txtPalabra
        '
        Me.txtPalabra.Location = New System.Drawing.Point(119, 60)
        Me.txtPalabra.Name = "txtPalabra"
        Me.txtPalabra.Size = New System.Drawing.Size(198, 20)
        Me.txtPalabra.TabIndex = 7
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(119, 131)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(198, 20)
        Me.txtResultado.TabIndex = 8
        '
        'lblTexto
        '
        Me.lblTexto.AutoSize = True
        Me.lblTexto.Location = New System.Drawing.Point(158, 44)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(139, 13)
        Me.lblTexto.TabIndex = 9
        Me.lblTexto.Text = "TEXTO A TRANSFORMAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(183, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "RESULTADO"
        '
        'txtCerrar
        '
        Me.txtCerrar.Location = New System.Drawing.Point(298, 226)
        Me.txtCerrar.Name = "txtCerrar"
        Me.txtCerrar.Size = New System.Drawing.Size(75, 23)
        Me.txtCerrar.TabIndex = 11
        Me.txtCerrar.Text = "CERRAR"
        Me.txtCerrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 261)
        Me.Controls.Add(Me.txtCerrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTexto)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtPalabra)
        Me.Controls.Add(Me.btnFuncion7)
        Me.Controls.Add(Me.btnFuncion6)
        Me.Controls.Add(Me.btnFuncion5)
        Me.Controls.Add(Me.btnFuncion4)
        Me.Controls.Add(Me.btnFuncion3)
        Me.Controls.Add(Me.btnFuncion2)
        Me.Controls.Add(Me.btnFuncion1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFuncion1 As Button
    Friend WithEvents btnFuncion2 As Button
    Friend WithEvents btnFuncion3 As Button
    Friend WithEvents btnFuncion4 As Button
    Friend WithEvents btnFuncion5 As Button
    Friend WithEvents btnFuncion6 As Button
    Friend WithEvents btnFuncion7 As Button
    Friend WithEvents txtPalabra As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents lblTexto As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCerrar As Button
End Class
