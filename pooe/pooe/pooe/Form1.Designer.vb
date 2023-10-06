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
        Me.grbEmpresa = New System.Windows.Forms.GroupBox()
        Me.grbPersonas = New System.Windows.Forms.GroupBox()
        Me.lblSueldo = New System.Windows.Forms.Label()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.lblIsssEmpresas = New System.Windows.Forms.Label()
        Me.lblAfpEmpresas = New System.Windows.Forms.Label()
        Me.lblAfpPersonas = New System.Windows.Forms.Label()
        Me.lblIsssPersonas = New System.Windows.Forms.Label()
        Me.lblVacacionesPersonas = New System.Windows.Forms.Label()
        Me.lblAguinaldoPersonas = New System.Windows.Forms.Label()
        Me.lblTotalDeducciones = New System.Windows.Forms.Label()
        Me.lblSueldoNeto = New System.Windows.Forms.Label()
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.cboTiempo = New System.Windows.Forms.ComboBox()
        Me.lblIsrPersonas = New System.Windows.Forms.Label()
        Me.erpDeducciones = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grbEmpresa.SuspendLayout()
        Me.grbPersonas.SuspendLayout()
        CType(Me.erpDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbEmpresa
        '
        Me.grbEmpresa.Controls.Add(Me.lblAfpEmpresas)
        Me.grbEmpresa.Controls.Add(Me.lblIsssEmpresas)
        Me.grbEmpresa.Location = New System.Drawing.Point(24, 94)
        Me.grbEmpresa.Name = "grbEmpresa"
        Me.grbEmpresa.Size = New System.Drawing.Size(174, 204)
        Me.grbEmpresa.TabIndex = 0
        Me.grbEmpresa.TabStop = False
        Me.grbEmpresa.Text = "Deducciones Empresas"
        '
        'grbPersonas
        '
        Me.grbPersonas.Controls.Add(Me.lblIsrPersonas)
        Me.grbPersonas.Controls.Add(Me.lblAguinaldoPersonas)
        Me.grbPersonas.Controls.Add(Me.lblVacacionesPersonas)
        Me.grbPersonas.Controls.Add(Me.lblAfpPersonas)
        Me.grbPersonas.Controls.Add(Me.lblIsssPersonas)
        Me.grbPersonas.Location = New System.Drawing.Point(213, 94)
        Me.grbPersonas.Name = "grbPersonas"
        Me.grbPersonas.Size = New System.Drawing.Size(202, 204)
        Me.grbPersonas.TabIndex = 1
        Me.grbPersonas.TabStop = False
        Me.grbPersonas.Text = "Deducciones Personas"
        '
        'lblSueldo
        '
        Me.lblSueldo.AutoSize = True
        Me.lblSueldo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSueldo.Location = New System.Drawing.Point(21, 29)
        Me.lblSueldo.Name = "lblSueldo"
        Me.lblSueldo.Size = New System.Drawing.Size(61, 18)
        Me.lblSueldo.TabIndex = 2
        Me.lblSueldo.Text = "Sueldo:"
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(88, 30)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(110, 20)
        Me.txtSueldo.TabIndex = 3
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(455, 175)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(175, 73)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'lblIsssEmpresas
        '
        Me.lblIsssEmpresas.AutoSize = True
        Me.lblIsssEmpresas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIsssEmpresas.Location = New System.Drawing.Point(6, 40)
        Me.lblIsssEmpresas.Name = "lblIsssEmpresas"
        Me.lblIsssEmpresas.Size = New System.Drawing.Size(61, 18)
        Me.lblIsssEmpresas.TabIndex = 5
        Me.lblIsssEmpresas.Text = "ISSS: ?"
        '
        'lblAfpEmpresas
        '
        Me.lblAfpEmpresas.AutoSize = True
        Me.lblAfpEmpresas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAfpEmpresas.Location = New System.Drawing.Point(6, 81)
        Me.lblAfpEmpresas.Name = "lblAfpEmpresas"
        Me.lblAfpEmpresas.Size = New System.Drawing.Size(57, 18)
        Me.lblAfpEmpresas.TabIndex = 6
        Me.lblAfpEmpresas.Text = "AFP: ?"
        '
        'lblAfpPersonas
        '
        Me.lblAfpPersonas.AutoSize = True
        Me.lblAfpPersonas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAfpPersonas.Location = New System.Drawing.Point(20, 71)
        Me.lblAfpPersonas.Name = "lblAfpPersonas"
        Me.lblAfpPersonas.Size = New System.Drawing.Size(57, 18)
        Me.lblAfpPersonas.TabIndex = 8
        Me.lblAfpPersonas.Text = "AFP: ?"
        '
        'lblIsssPersonas
        '
        Me.lblIsssPersonas.AutoSize = True
        Me.lblIsssPersonas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIsssPersonas.Location = New System.Drawing.Point(20, 40)
        Me.lblIsssPersonas.Name = "lblIsssPersonas"
        Me.lblIsssPersonas.Size = New System.Drawing.Size(61, 18)
        Me.lblIsssPersonas.TabIndex = 7
        Me.lblIsssPersonas.Text = "ISSS: ?"
        '
        'lblVacacionesPersonas
        '
        Me.lblVacacionesPersonas.AutoSize = True
        Me.lblVacacionesPersonas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVacacionesPersonas.Location = New System.Drawing.Point(20, 136)
        Me.lblVacacionesPersonas.Name = "lblVacacionesPersonas"
        Me.lblVacacionesPersonas.Size = New System.Drawing.Size(129, 18)
        Me.lblVacacionesPersonas.TabIndex = 9
        Me.lblVacacionesPersonas.Text = "VACACIONES: ?"
        '
        'lblAguinaldoPersonas
        '
        Me.lblAguinaldoPersonas.AutoSize = True
        Me.lblAguinaldoPersonas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAguinaldoPersonas.Location = New System.Drawing.Point(20, 173)
        Me.lblAguinaldoPersonas.Name = "lblAguinaldoPersonas"
        Me.lblAguinaldoPersonas.Size = New System.Drawing.Size(117, 18)
        Me.lblAguinaldoPersonas.TabIndex = 10
        Me.lblAguinaldoPersonas.Text = "AGUINALDO: ?"
        '
        'lblTotalDeducciones
        '
        Me.lblTotalDeducciones.AutoSize = True
        Me.lblTotalDeducciones.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDeducciones.Location = New System.Drawing.Point(233, 320)
        Me.lblTotalDeducciones.Name = "lblTotalDeducciones"
        Me.lblTotalDeducciones.Size = New System.Drawing.Size(195, 18)
        Me.lblTotalDeducciones.TabIndex = 11
        Me.lblTotalDeducciones.Text = "TOTAL DEDUCCIONES: ?"
        '
        'lblSueldoNeto
        '
        Me.lblSueldoNeto.AutoSize = True
        Me.lblSueldoNeto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSueldoNeto.Location = New System.Drawing.Point(233, 362)
        Me.lblSueldoNeto.Name = "lblSueldoNeto"
        Me.lblSueldoNeto.Size = New System.Drawing.Size(138, 18)
        Me.lblSueldoNeto.TabIndex = 12
        Me.lblSueldoNeto.Text = "SUELDO NETO: ?"
        '
        'lblTiempo
        '
        Me.lblTiempo.AutoSize = True
        Me.lblTiempo.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempo.Location = New System.Drawing.Point(229, 32)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(64, 18)
        Me.lblTiempo.TabIndex = 13
        Me.lblTiempo.Text = "Tiempo:"
        '
        'cboTiempo
        '
        Me.cboTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTiempo.FormattingEnabled = True
        Me.cboTiempo.Items.AddRange(New Object() {"Menos de 1 año.", "Entre 1 y 3 años.", "Entre 3 y 10 años.", "10 o mas años."})
        Me.cboTiempo.Location = New System.Drawing.Point(294, 33)
        Me.cboTiempo.Name = "cboTiempo"
        Me.cboTiempo.Size = New System.Drawing.Size(121, 21)
        Me.cboTiempo.TabIndex = 14
        '
        'lblIsrPersonas
        '
        Me.lblIsrPersonas.AutoSize = True
        Me.lblIsrPersonas.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIsrPersonas.Location = New System.Drawing.Point(20, 106)
        Me.lblIsrPersonas.Name = "lblIsrPersonas"
        Me.lblIsrPersonas.Size = New System.Drawing.Size(50, 18)
        Me.lblIsrPersonas.TabIndex = 11
        Me.lblIsrPersonas.Text = "ISR: ?"
        '
        'erpDeducciones
        '
        Me.erpDeducciones.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 430)
        Me.Controls.Add(Me.cboTiempo)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.lblSueldoNeto)
        Me.Controls.Add(Me.lblTotalDeducciones)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.lblSueldo)
        Me.Controls.Add(Me.grbPersonas)
        Me.Controls.Add(Me.grbEmpresa)
        Me.Name = "Form1"
        Me.Text = "CONVERSOR"
        Me.grbEmpresa.ResumeLayout(False)
        Me.grbEmpresa.PerformLayout()
        Me.grbPersonas.ResumeLayout(False)
        Me.grbPersonas.PerformLayout()
        CType(Me.erpDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents lblSueldo As Label
    Friend WithEvents grbPersonas As GroupBox
    Friend WithEvents grbEmpresa As GroupBox
    Friend WithEvents lblSueldoNeto As Label
    Friend WithEvents lblTotalDeducciones As Label
    Friend WithEvents lblAguinaldoPersonas As Label
    Friend WithEvents lblVacacionesPersonas As Label
    Friend WithEvents lblAfpPersonas As Label
    Friend WithEvents lblIsssPersonas As Label
    Friend WithEvents lblAfpEmpresas As Label
    Friend WithEvents lblIsssEmpresas As Label
    Friend WithEvents cboTiempo As ComboBox
    Friend WithEvents lblTiempo As Label
    Friend WithEvents lblIsrPersonas As Label
    Friend WithEvents erpDeducciones As ErrorProvider
End Class
