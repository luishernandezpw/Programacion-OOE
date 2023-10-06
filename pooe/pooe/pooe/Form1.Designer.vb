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
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.txtCantidadConversor = New System.Windows.Forms.TextBox()
        Me.lblTipoConversor = New System.Windows.Forms.Label()
        Me.cboTipoConversor = New System.Windows.Forms.ComboBox()
        Me.lblDeConversor = New System.Windows.Forms.Label()
        Me.cboDeConversor = New System.Windows.Forms.ComboBox()
        Me.cboAConversor = New System.Windows.Forms.ComboBox()
        Me.lblAConversor = New System.Windows.Forms.Label()
        Me.lblCantidadConversor = New System.Windows.Forms.Label()
        Me.lblRespuestaConversor = New System.Windows.Forms.Label()
        Me.erpConversor = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.erpConversor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConvertir
        '
        Me.btnConvertir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvertir.Location = New System.Drawing.Point(50, 309)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(264, 72)
        Me.btnConvertir.TabIndex = 0
        Me.btnConvertir.Text = "CONVERTIR"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'txtCantidadConversor
        '
        Me.txtCantidadConversor.Location = New System.Drawing.Point(129, 226)
        Me.txtCantidadConversor.Name = "txtCantidadConversor"
        Me.txtCantidadConversor.Size = New System.Drawing.Size(185, 20)
        Me.txtCantidadConversor.TabIndex = 1
        '
        'lblTipoConversor
        '
        Me.lblTipoConversor.AutoSize = True
        Me.lblTipoConversor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoConversor.Location = New System.Drawing.Point(47, 47)
        Me.lblTipoConversor.Name = "lblTipoConversor"
        Me.lblTipoConversor.Size = New System.Drawing.Size(42, 18)
        Me.lblTipoConversor.TabIndex = 2
        Me.lblTipoConversor.Text = "Tipo:"
        '
        'cboTipoConversor
        '
        Me.cboTipoConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoConversor.FormattingEnabled = True
        Me.cboTipoConversor.Items.AddRange(New Object() {"Monedas", "Longitud", "Tiempo", "Masa"})
        Me.cboTipoConversor.Location = New System.Drawing.Point(95, 48)
        Me.cboTipoConversor.Name = "cboTipoConversor"
        Me.cboTipoConversor.Size = New System.Drawing.Size(219, 21)
        Me.cboTipoConversor.TabIndex = 3
        '
        'lblDeConversor
        '
        Me.lblDeConversor.AutoSize = True
        Me.lblDeConversor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeConversor.Location = New System.Drawing.Point(47, 108)
        Me.lblDeConversor.Name = "lblDeConversor"
        Me.lblDeConversor.Size = New System.Drawing.Size(35, 18)
        Me.lblDeConversor.TabIndex = 4
        Me.lblDeConversor.Text = "DE:"
        '
        'cboDeConversor
        '
        Me.cboDeConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDeConversor.FormattingEnabled = True
        Me.cboDeConversor.Location = New System.Drawing.Point(95, 109)
        Me.cboDeConversor.Name = "cboDeConversor"
        Me.cboDeConversor.Size = New System.Drawing.Size(219, 21)
        Me.cboDeConversor.TabIndex = 5
        '
        'cboAConversor
        '
        Me.cboAConversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAConversor.FormattingEnabled = True
        Me.cboAConversor.Location = New System.Drawing.Point(95, 172)
        Me.cboAConversor.Name = "cboAConversor"
        Me.cboAConversor.Size = New System.Drawing.Size(219, 21)
        Me.cboAConversor.TabIndex = 7
        '
        'lblAConversor
        '
        Me.lblAConversor.AutoSize = True
        Me.lblAConversor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAConversor.Location = New System.Drawing.Point(47, 171)
        Me.lblAConversor.Name = "lblAConversor"
        Me.lblAConversor.Size = New System.Drawing.Size(23, 18)
        Me.lblAConversor.TabIndex = 6
        Me.lblAConversor.Text = "A:"
        '
        'lblCantidadConversor
        '
        Me.lblCantidadConversor.AutoSize = True
        Me.lblCantidadConversor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadConversor.Location = New System.Drawing.Point(47, 225)
        Me.lblCantidadConversor.Name = "lblCantidadConversor"
        Me.lblCantidadConversor.Size = New System.Drawing.Size(76, 18)
        Me.lblCantidadConversor.TabIndex = 8
        Me.lblCantidadConversor.Text = "Cantidad:"
        '
        'lblRespuestaConversor
        '
        Me.lblRespuestaConversor.AutoSize = True
        Me.lblRespuestaConversor.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaConversor.Location = New System.Drawing.Point(355, 171)
        Me.lblRespuestaConversor.Name = "lblRespuestaConversor"
        Me.lblRespuestaConversor.Size = New System.Drawing.Size(100, 18)
        Me.lblRespuestaConversor.TabIndex = 9
        Me.lblRespuestaConversor.Text = "Respuesta: ?"
        '
        'erpConversor
        '
        Me.erpConversor.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 415)
        Me.Controls.Add(Me.lblRespuestaConversor)
        Me.Controls.Add(Me.lblCantidadConversor)
        Me.Controls.Add(Me.cboAConversor)
        Me.Controls.Add(Me.lblAConversor)
        Me.Controls.Add(Me.cboDeConversor)
        Me.Controls.Add(Me.lblDeConversor)
        Me.Controls.Add(Me.cboTipoConversor)
        Me.Controls.Add(Me.lblTipoConversor)
        Me.Controls.Add(Me.txtCantidadConversor)
        Me.Controls.Add(Me.btnConvertir)
        Me.Name = "Form1"
        Me.Text = "CONVERSOR"
        CType(Me.erpConversor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvertir As Button
    Friend WithEvents txtCantidadConversor As TextBox
    Friend WithEvents lblTipoConversor As Label
    Friend WithEvents cboTipoConversor As ComboBox
    Friend WithEvents lblDeConversor As Label
    Friend WithEvents cboDeConversor As ComboBox
    Friend WithEvents cboAConversor As ComboBox
    Friend WithEvents lblAConversor As Label
    Friend WithEvents lblCantidadConversor As Label
    Friend WithEvents lblRespuestaConversor As Label
    Friend WithEvents erpConversor As ErrorProvider
End Class
