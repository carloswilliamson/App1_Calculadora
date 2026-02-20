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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numero2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Sumar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numero1 = New System.Windows.Forms.TextBox()
        Me.Multiplicar = New System.Windows.Forms.Button()
        Me.Restar = New System.Windows.Forms.Button()
        Me.Dividir = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(386, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero 1"
        '
        'numero2
        '
        Me.numero2.Enabled = False
        Me.numero2.Location = New System.Drawing.Point(519, 204)
        Me.numero2.Name = "numero2"
        Me.numero2.Size = New System.Drawing.Size(100, 20)
        Me.numero2.TabIndex = 2
        Me.numero2.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(386, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = " Numero 2"
        '
        'Sumar
        '
        Me.Sumar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sumar.ForeColor = System.Drawing.Color.Black
        Me.Sumar.Location = New System.Drawing.Point(705, 335)
        Me.Sumar.Name = "Sumar"
        Me.Sumar.Size = New System.Drawing.Size(99, 65)
        Me.Sumar.TabIndex = 4
        Me.Sumar.Text = "+"
        Me.Sumar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(679, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(702, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 18)
        Me.Label4.TabIndex = 6
        '
        'numero1
        '
        Me.numero1.Enabled = False
        Me.numero1.Location = New System.Drawing.Point(519, 68)
        Me.numero1.Name = "numero1"
        Me.numero1.Size = New System.Drawing.Size(100, 20)
        Me.numero1.TabIndex = 7
        Me.numero1.Text = "0"
        '
        'Multiplicar
        '
        Me.Multiplicar.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiplicar.ForeColor = System.Drawing.Color.Black
        Me.Multiplicar.Location = New System.Drawing.Point(705, 475)
        Me.Multiplicar.Name = "Multiplicar"
        Me.Multiplicar.Size = New System.Drawing.Size(99, 62)
        Me.Multiplicar.TabIndex = 8
        Me.Multiplicar.Text = "x"
        Me.Multiplicar.UseVisualStyleBackColor = True
        '
        'Restar
        '
        Me.Restar.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Restar.ForeColor = System.Drawing.Color.Black
        Me.Restar.Location = New System.Drawing.Point(705, 404)
        Me.Restar.Name = "Restar"
        Me.Restar.Size = New System.Drawing.Size(99, 67)
        Me.Restar.TabIndex = 9
        Me.Restar.Text = "-"
        Me.Restar.UseVisualStyleBackColor = True
        '
        'Dividir
        '
        Me.Dividir.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dividir.ForeColor = System.Drawing.Color.Black
        Me.Dividir.Location = New System.Drawing.Point(705, 541)
        Me.Dividir.Name = "Dividir"
        Me.Dividir.Size = New System.Drawing.Size(99, 64)
        Me.Dividir.TabIndex = 10
        Me.Dividir.Text = "/"
        Me.Dividir.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button0.ForeColor = System.Drawing.Color.Black
        Me.Button0.Location = New System.Drawing.Point(473, 543)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(102, 64)
        Me.Button0.TabIndex = 12
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(473, 403)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(102, 64)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(360, 475)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 64)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(586, 475)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 64)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(473, 475)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 64)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Black
        Me.Button7.Location = New System.Drawing.Point(360, 335)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(102, 64)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.Location = New System.Drawing.Point(473, 336)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(102, 64)
        Me.Button8.TabIndex = 19
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(586, 404)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(102, 64)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(360, 403)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(102, 64)
        Me.Button4.TabIndex = 21
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Black
        Me.Button9.Location = New System.Drawing.Point(586, 335)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(102, 64)
        Me.Button9.TabIndex = 22
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Borrar
        '
        Me.Borrar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrar.ForeColor = System.Drawing.Color.Black
        Me.Borrar.Location = New System.Drawing.Point(586, 543)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(102, 62)
        Me.Borrar.TabIndex = 23
        Me.Borrar.Text = "C"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.Black
        Me.Button10.Location = New System.Drawing.Point(360, 543)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(102, 63)
        Me.Button10.TabIndex = 24
        Me.Button10.Text = "."
        Me.Button10.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(654, 68)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 25
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(654, 204)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 26
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(1136, 642)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Borrar)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.Dividir)
        Me.Controls.Add(Me.Restar)
        Me.Controls.Add(Me.Multiplicar)
        Me.Controls.Add(Me.numero1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Sumar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numero2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Red
        Me.Name = "Form1"
        Me.Text = "x"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents numero2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Sumar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents numero1 As TextBox
    Friend WithEvents Multiplicar As Button
    Friend WithEvents Restar As Button
    Friend WithEvents Dividir As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Borrar As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
