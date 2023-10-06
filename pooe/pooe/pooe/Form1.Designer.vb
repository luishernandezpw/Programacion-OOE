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
        Me.components = New System.ComponentModel.Container()
        Me.lblSerie = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.erpDeducciones = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblMedia = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        CType(Me.erpDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSerie
        '
        Me.lblSerie.AutoSize = True
        Me.lblSerie.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerie.Location = New System.Drawing.Point(21, 29)
        Me.lblSerie.Name = "lblSerie"
        Me.lblSerie.Size = New System.Drawing.Size(50, 18)
        Me.lblSerie.TabIndex = 2
        Me.lblSerie.Text = "Serie:"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(77, 30)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(316, 20)
        Me.txtSerie.TabIndex = 3
        '
        'erpDeducciones
        '
        Me.erpDeducciones.ContainerControl = Me
        '
        'lblMedia
        '
        Me.lblMedia.AutoSize = True
        Me.lblMedia.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedia.Location = New System.Drawing.Point(188, 103)
        Me.lblMedia.Name = "lblMedia"
        Me.lblMedia.Size = New System.Drawing.Size(129, 18)
        Me.lblMedia.TabIndex = 4
        Me.lblMedia.Text = "Media aritmetica:"
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(24, 89)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(136, 45)
        Me.btnCalcular.TabIndex = 5
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 162)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblMedia)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.lblSerie)
        Me.Name = "Form1"
        Me.Text = "Media"
        CType(Me.erpDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents lblSerie As Label
    Friend WithEvents erpDeducciones As ErrorProvider
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lblMedia As Label
End Class
