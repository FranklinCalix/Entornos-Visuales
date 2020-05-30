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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.SUMA = New System.Windows.Forms.Button()
        Me.RESTA = New System.Windows.Forms.Button()
        Me.MULTI = New System.Windows.Forms.Button()
        Me.DIV = New System.Windows.Forms.Button()
        Me.LIMPIAR = New System.Windows.Forms.Button()
        Me.SALIR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(31, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(181, 68)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(99, 231)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 2
        '
        'SUMA
        '
        Me.SUMA.Location = New System.Drawing.Point(1, 153)
        Me.SUMA.Name = "SUMA"
        Me.SUMA.Size = New System.Drawing.Size(75, 23)
        Me.SUMA.TabIndex = 3
        Me.SUMA.Text = "SUMA"
        Me.SUMA.UseVisualStyleBackColor = True
        '
        'RESTA
        '
        Me.RESTA.Location = New System.Drawing.Point(79, 153)
        Me.RESTA.Name = "RESTA"
        Me.RESTA.Size = New System.Drawing.Size(75, 23)
        Me.RESTA.TabIndex = 4
        Me.RESTA.Text = "RESTA"
        Me.RESTA.UseVisualStyleBackColor = True
        '
        'MULTI
        '
        Me.MULTI.Location = New System.Drawing.Point(157, 153)
        Me.MULTI.Name = "MULTI"
        Me.MULTI.Size = New System.Drawing.Size(75, 23)
        Me.MULTI.TabIndex = 5
        Me.MULTI.Text = "MULTI"
        Me.MULTI.UseVisualStyleBackColor = True
        '
        'DIV
        '
        Me.DIV.Location = New System.Drawing.Point(234, 153)
        Me.DIV.Name = "DIV"
        Me.DIV.Size = New System.Drawing.Size(75, 23)
        Me.DIV.TabIndex = 6
        Me.DIV.Text = "DIV"
        Me.DIV.UseVisualStyleBackColor = True
        '
        'LIMPIAR
        '
        Me.LIMPIAR.Location = New System.Drawing.Point(119, 189)
        Me.LIMPIAR.Name = "LIMPIAR"
        Me.LIMPIAR.Size = New System.Drawing.Size(75, 23)
        Me.LIMPIAR.TabIndex = 7
        Me.LIMPIAR.Text = "LIMPIAR"
        Me.LIMPIAR.UseVisualStyleBackColor = True
        '
        'SALIR
        '
        Me.SALIR.Location = New System.Drawing.Point(119, 295)
        Me.SALIR.Name = "SALIR"
        Me.SALIR.Size = New System.Drawing.Size(75, 23)
        Me.SALIR.TabIndex = 8
        Me.SALIR.Text = "SALIR"
        Me.SALIR.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(312, 401)
        Me.Controls.Add(Me.SALIR)
        Me.Controls.Add(Me.LIMPIAR)
        Me.Controls.Add(Me.DIV)
        Me.Controls.Add(Me.MULTI)
        Me.Controls.Add(Me.RESTA)
        Me.Controls.Add(Me.SUMA)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "PRUEBA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents SUMA As Button
    Friend WithEvents RESTA As Button
    Friend WithEvents MULTI As Button
    Friend WithEvents DIV As Button
    Friend WithEvents LIMPIAR As Button
    Friend WithEvents SALIR As Button
End Class
