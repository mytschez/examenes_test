<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Me.components = New System.ComponentModel.Container()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.errNombre = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblCuantasPreg = New System.Windows.Forms.Label()
        Me.txtCantidadPreg = New System.Windows.Forms.NumericUpDown()
        Me.txtDuracion = New System.Windows.Forms.NumericUpDown()
        Me.lbltiempo = New System.Windows.Forms.Label()
        Me.lblMin = New System.Windows.Forms.Label()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.lblMax = New System.Windows.Forms.Label()
        CType(Me.errNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidadPreg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDuracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(58, 94)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(214, 23)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre y apellidos: "
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(278, 91)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(413, 32)
        Me.txtNombre.TabIndex = 1
        '
        'errNombre
        '
        Me.errNombre.ContainerControl = Me
        '
        'lblCuantasPreg
        '
        Me.lblCuantasPreg.AutoSize = True
        Me.lblCuantasPreg.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCuantasPreg.Location = New System.Drawing.Point(64, 196)
        Me.lblCuantasPreg.Name = "lblCuantasPreg"
        Me.lblCuantasPreg.Size = New System.Drawing.Size(372, 23)
        Me.lblCuantasPreg.TabIndex = 2
        Me.lblCuantasPreg.Text = "Cantidad de preguntas del examen: "
        '
        'txtCantidadPreg
        '
        Me.txtCantidadPreg.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadPreg.Location = New System.Drawing.Point(453, 194)
        Me.txtCantidadPreg.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.txtCantidadPreg.Name = "txtCantidadPreg"
        Me.txtCantidadPreg.Size = New System.Drawing.Size(110, 32)
        Me.txtCantidadPreg.TabIndex = 4
        Me.txtCantidadPreg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadPreg.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'txtDuracion
        '
        Me.txtDuracion.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuracion.Location = New System.Drawing.Point(454, 279)
        Me.txtDuracion.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.txtDuracion.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(110, 32)
        Me.txtDuracion.TabIndex = 6
        Me.txtDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDuracion.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbltiempo
        '
        Me.lbltiempo.AutoSize = True
        Me.lbltiempo.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltiempo.Location = New System.Drawing.Point(89, 283)
        Me.lbltiempo.Name = "lbltiempo"
        Me.lbltiempo.Size = New System.Drawing.Size(347, 23)
        Me.lbltiempo.TabIndex = 5
        Me.lbltiempo.Text = "Duración en minutos del examen: "
        '
        'lblMin
        '
        Me.lblMin.AutoSize = True
        Me.lblMin.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMin.Location = New System.Drawing.Point(570, 283)
        Me.lblMin.Name = "lblMin"
        Me.lblMin.Size = New System.Drawing.Size(52, 23)
        Me.lblMin.TabIndex = 7
        Me.lblMin.Text = "min."
        '
        'btnIniciar
        '
        Me.btnIniciar.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.Location = New System.Drawing.Point(568, 372)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(191, 55)
        Me.btnIniciar.TabIndex = 8
        Me.btnIniciar.Text = "Iniciar examen"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMax.Location = New System.Drawing.Point(570, 196)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(0, 23)
        Me.lblMax.TabIndex = 9
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.lblMin)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.lbltiempo)
        Me.Controls.Add(Me.txtCantidadPreg)
        Me.Controls.Add(Me.lblCuantasPreg)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        CType(Me.errNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidadPreg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDuracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents errNombre As ErrorProvider
    Friend WithEvents txtCantidadPreg As NumericUpDown
    Friend WithEvents lblCuantasPreg As Label
    Friend WithEvents lblMin As Label
    Friend WithEvents txtDuracion As NumericUpDown
    Friend WithEvents lbltiempo As Label
    Friend WithEvents btnIniciar As Button
    Friend WithEvents lblMax As Label
End Class
