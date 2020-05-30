<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ISVChek = New System.Windows.Forms.CheckBox()
        Me.TextpUnidad = New System.Windows.Forms.TextBox()
        Me.TextCant = New System.Windows.Forms.TextBox()
        Me.DescuentoChek = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextTotal = New System.Windows.Forms.TextBox()
        Me.TextSubTotal = New System.Windows.Forms.TextBox()
        Me.TextDescuento = New System.Windows.Forms.TextBox()
        Me.TextISV = New System.Windows.Forms.TextBox()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Nuevo = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextpUnidad)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.ISVChek)
        Me.GroupBox1.Controls.Add(Me.TextCant)
        Me.GroupBox1.Controls.Add(Me.DescuentoChek)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 263)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Requeridos"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"15%", "17%"})
        Me.ComboBox2.Location = New System.Drawing.Point(19, 227)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(195, 21)
        Me.ComboBox2.TabIndex = 7
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Descuento 1", "Descuento 2", "Descuento 3", "Descuento 4", "Descuento 5", "Descuento 6"})
        Me.ComboBox1.Location = New System.Drawing.Point(19, 157)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(195, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'ISVChek
        '
        Me.ISVChek.AutoSize = True
        Me.ISVChek.Location = New System.Drawing.Point(19, 204)
        Me.ISVChek.Name = "ISVChek"
        Me.ISVChek.Size = New System.Drawing.Size(89, 17)
        Me.ISVChek.TabIndex = 5
        Me.ISVChek.Text = "Aplicar ISV"
        Me.ISVChek.UseVisualStyleBackColor = True
        '
        'TextpUnidad
        '
        Me.TextpUnidad.Location = New System.Drawing.Point(114, 33)
        Me.TextpUnidad.Name = "TextpUnidad"
        Me.TextpUnidad.Size = New System.Drawing.Size(100, 20)
        Me.TextpUnidad.TabIndex = 3
        '
        'TextCant
        '
        Me.TextCant.Location = New System.Drawing.Point(114, 90)
        Me.TextCant.Name = "TextCant"
        Me.TextCant.Size = New System.Drawing.Size(100, 20)
        Me.TextCant.TabIndex = 4
        '
        'DescuentoChek
        '
        Me.DescuentoChek.AutoSize = True
        Me.DescuentoChek.Location = New System.Drawing.Point(19, 134)
        Me.DescuentoChek.Name = "DescuentoChek"
        Me.DescuentoChek.Size = New System.Drawing.Size(130, 17)
        Me.DescuentoChek.TabIndex = 2
        Me.DescuentoChek.Text = "Aplicar Descuento"
        Me.DescuentoChek.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "P. unitario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Subtotal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Descuento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ISV 15%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Total"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextTotal)
        Me.GroupBox2.Controls.Add(Me.TextSubTotal)
        Me.GroupBox2.Controls.Add(Me.TextDescuento)
        Me.GroupBox2.Controls.Add(Me.TextISV)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 334)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 176)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle Factura"
        '
        'TextTotal
        '
        Me.TextTotal.Location = New System.Drawing.Point(114, 146)
        Me.TextTotal.Name = "TextTotal"
        Me.TextTotal.Size = New System.Drawing.Size(100, 20)
        Me.TextTotal.TabIndex = 8
        '
        'TextSubTotal
        '
        Me.TextSubTotal.Location = New System.Drawing.Point(114, 38)
        Me.TextSubTotal.Name = "TextSubTotal"
        Me.TextSubTotal.Size = New System.Drawing.Size(100, 20)
        Me.TextSubTotal.TabIndex = 5
        '
        'TextDescuento
        '
        Me.TextDescuento.Location = New System.Drawing.Point(114, 75)
        Me.TextDescuento.Name = "TextDescuento"
        Me.TextDescuento.Size = New System.Drawing.Size(100, 20)
        Me.TextDescuento.TabIndex = 6
        '
        'TextISV
        '
        Me.TextISV.Location = New System.Drawing.Point(114, 112)
        Me.TextISV.Name = "TextISV"
        Me.TextISV.Size = New System.Drawing.Size(100, 20)
        Me.TextISV.TabIndex = 7
        '
        'Calcular
        '
        Me.Calcular.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calcular.Location = New System.Drawing.Point(260, 51)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(75, 23)
        Me.Calcular.TabIndex = 3
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = False
        '
        'Nuevo
        '
        Me.Nuevo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nuevo.Location = New System.Drawing.Point(260, 118)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.Nuevo.TabIndex = 4
        Me.Nuevo.Text = "Nuevo"
        Me.Nuevo.UseVisualStyleBackColor = False
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salir.Location = New System.Drawing.Point(260, 179)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(75, 23)
        Me.Salir.TabIndex = 5
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(361, 537)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.Nuevo)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "FACTURA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ISVChek As CheckBox
    Friend WithEvents TextpUnidad As TextBox
    Friend WithEvents TextCant As TextBox
    Friend WithEvents DescuentoChek As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextTotal As TextBox
    Friend WithEvents TextSubTotal As TextBox
    Friend WithEvents TextDescuento As TextBox
    Friend WithEvents TextISV As TextBox
    Friend WithEvents Calcular As Button
    Friend WithEvents Nuevo As Button
    Friend WithEvents Salir As Button
End Class
