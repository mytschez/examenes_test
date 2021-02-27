<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExamenes))
        Me.lblNumPregunta = New System.Windows.Forms.Label()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.btnCorregir = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.picBoxErr4 = New System.Windows.Forms.PictureBox()
        Me.ChkbResp4 = New System.Windows.Forms.CheckBox()
        Me.picBoxOk4 = New System.Windows.Forms.PictureBox()
        Me.TimerPreg = New System.Windows.Forms.Timer(Me.components)
        Me.ProBarTiempo = New System.Windows.Forms.ProgressBar()
        Me.pnlPuntuacion = New System.Windows.Forms.Panel()
        Me.lblPuntuacion = New System.Windows.Forms.Label()
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.picBoxErr = New System.Windows.Forms.PictureBox()
        Me.picBoxOk = New System.Windows.Forms.PictureBox()
        Me.lblTiempoRest = New System.Windows.Forms.Label()
        Me.pnlResp4 = New System.Windows.Forms.Panel()
        Me.pnlResp3 = New System.Windows.Forms.Panel()
        Me.picBoxOk3 = New System.Windows.Forms.PictureBox()
        Me.ChkbResp3 = New System.Windows.Forms.CheckBox()
        Me.picBoxErr3 = New System.Windows.Forms.PictureBox()
        Me.pnlResp2 = New System.Windows.Forms.Panel()
        Me.picBoxOk2 = New System.Windows.Forms.PictureBox()
        Me.ChkbResp2 = New System.Windows.Forms.CheckBox()
        Me.picBoxErr2 = New System.Windows.Forms.PictureBox()
        Me.pnlResp1 = New System.Windows.Forms.Panel()
        Me.picBoxOk1 = New System.Windows.Forms.PictureBox()
        Me.ChkbResp1 = New System.Windows.Forms.CheckBox()
        Me.picboxErr1 = New System.Windows.Forms.PictureBox()
        CType(Me.picBoxErr4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxOk4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPuntuacion.SuspendLayout()
        CType(Me.picBoxErr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxOk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlResp4.SuspendLayout()
        Me.pnlResp3.SuspendLayout()
        CType(Me.picBoxOk3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxErr3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlResp2.SuspendLayout()
        CType(Me.picBoxOk2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoxErr2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlResp1.SuspendLayout()
        CType(Me.picBoxOk1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxErr1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNumPregunta
        '
        Me.lblNumPregunta.AutoSize = True
        Me.lblNumPregunta.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblNumPregunta.Location = New System.Drawing.Point(42, 26)
        Me.lblNumPregunta.Name = "lblNumPregunta"
        Me.lblNumPregunta.Size = New System.Drawing.Size(0, 23)
        Me.lblNumPregunta.TabIndex = 0
        '
        'lblPregunta
        '
        Me.lblPregunta.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblPregunta.Location = New System.Drawing.Point(38, 70)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(810, 174)
        Me.lblPregunta.TabIndex = 1
        '
        'btnNuevo
        '
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(919, 53)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(193, 66)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo examen"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFinalizar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFinalizar.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizar.Location = New System.Drawing.Point(919, 140)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(193, 66)
        Me.btnFinalizar.TabIndex = 3
        Me.btnFinalizar.Text = "Finalizar examen"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'btnCorregir
        '
        Me.btnCorregir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCorregir.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnCorregir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCorregir.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCorregir.Location = New System.Drawing.Point(919, 227)
        Me.btnCorregir.Name = "btnCorregir"
        Me.btnCorregir.Size = New System.Drawing.Size(193, 66)
        Me.btnCorregir.TabIndex = 4
        Me.btnCorregir.Text = "Corregir examen"
        Me.btnCorregir.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(919, 385)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(193, 66)
        Me.btnSiguiente.TabIndex = 1
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnterior.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnterior.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(919, 468)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(193, 66)
        Me.btnAnterior.TabIndex = 2
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(919, 620)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(193, 66)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'picBoxErr4
        '
        Me.picBoxErr4.Image = Global.ProyectoFinal_Examenes.My.Resources.Resources._Error
        Me.picBoxErr4.Location = New System.Drawing.Point(22, 9)
        Me.picBoxErr4.Name = "picBoxErr4"
        Me.picBoxErr4.Size = New System.Drawing.Size(46, 35)
        Me.picBoxErr4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxErr4.TabIndex = 15
        Me.picBoxErr4.TabStop = False
        '
        'ChkbResp4
        '
        Me.ChkbResp4.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkbResp4.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkbResp4.Location = New System.Drawing.Point(87, 9)
        Me.ChkbResp4.Name = "ChkbResp4"
        Me.ChkbResp4.Size = New System.Drawing.Size(740, 54)
        Me.ChkbResp4.TabIndex = 19
        Me.ChkbResp4.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkbResp4.UseVisualStyleBackColor = True
        '
        'picBoxOk4
        '
        Me.picBoxOk4.Image = CType(resources.GetObject("picBoxOk4.Image"), System.Drawing.Image)
        Me.picBoxOk4.Location = New System.Drawing.Point(22, 9)
        Me.picBoxOk4.Name = "picBoxOk4"
        Me.picBoxOk4.Size = New System.Drawing.Size(46, 35)
        Me.picBoxOk4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxOk4.TabIndex = 23
        Me.picBoxOk4.TabStop = False
        '
        'TimerPreg
        '
        Me.TimerPreg.Interval = 1000
        '
        'ProBarTiempo
        '
        Me.ProBarTiempo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ProBarTiempo.ForeColor = System.Drawing.Color.Brown
        Me.ProBarTiempo.Location = New System.Drawing.Point(622, 19)
        Me.ProBarTiempo.Name = "ProBarTiempo"
        Me.ProBarTiempo.Size = New System.Drawing.Size(490, 25)
        Me.ProBarTiempo.Step = 1
        Me.ProBarTiempo.TabIndex = 24
        Me.ProBarTiempo.Value = 100
        '
        'pnlPuntuacion
        '
        Me.pnlPuntuacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPuntuacion.Controls.Add(Me.lblPuntuacion)
        Me.pnlPuntuacion.Controls.Add(Me.lblTexto)
        Me.pnlPuntuacion.Controls.Add(Me.lblNombre)
        Me.pnlPuntuacion.Controls.Add(Me.picBoxErr)
        Me.pnlPuntuacion.Controls.Add(Me.picBoxOk)
        Me.pnlPuntuacion.Location = New System.Drawing.Point(308, 214)
        Me.pnlPuntuacion.Name = "pnlPuntuacion"
        Me.pnlPuntuacion.Size = New System.Drawing.Size(475, 240)
        Me.pnlPuntuacion.TabIndex = 25
        '
        'lblPuntuacion
        '
        Me.lblPuntuacion.AutoSize = True
        Me.lblPuntuacion.Font = New System.Drawing.Font("Century Gothic", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPuntuacion.Location = New System.Drawing.Point(163, 170)
        Me.lblPuntuacion.Name = "lblPuntuacion"
        Me.lblPuntuacion.Size = New System.Drawing.Size(0, 38)
        Me.lblPuntuacion.TabIndex = 25
        '
        'lblTexto
        '
        Me.lblTexto.AutoSize = True
        Me.lblTexto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto.Location = New System.Drawing.Point(27, 96)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(287, 28)
        Me.lblTexto.TabIndex = 24
        Me.lblTexto.Text = "Tu puntuación ha sido..."
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(22, 23)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(0, 28)
        Me.lblNombre.TabIndex = 23
        '
        'picBoxErr
        '
        Me.picBoxErr.Image = Global.ProyectoFinal_Examenes.My.Resources.Resources._Error
        Me.picBoxErr.Location = New System.Drawing.Point(367, 151)
        Me.picBoxErr.Name = "picBoxErr"
        Me.picBoxErr.Size = New System.Drawing.Size(73, 66)
        Me.picBoxErr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxErr.TabIndex = 22
        Me.picBoxErr.TabStop = False
        '
        'picBoxOk
        '
        Me.picBoxOk.Image = CType(resources.GetObject("picBoxOk.Image"), System.Drawing.Image)
        Me.picBoxOk.Location = New System.Drawing.Point(371, 151)
        Me.picBoxOk.Name = "picBoxOk"
        Me.picBoxOk.Size = New System.Drawing.Size(69, 66)
        Me.picBoxOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxOk.TabIndex = 21
        Me.picBoxOk.TabStop = False
        '
        'lblTiempoRest
        '
        Me.lblTiempoRest.AutoSize = True
        Me.lblTiempoRest.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoRest.Location = New System.Drawing.Point(369, 19)
        Me.lblTiempoRest.Name = "lblTiempoRest"
        Me.lblTiempoRest.Size = New System.Drawing.Size(183, 22)
        Me.lblTiempoRest.TabIndex = 26
        Me.lblTiempoRest.Text = "Tiempo (min : seg): "
        '
        'pnlResp4
        '
        Me.pnlResp4.Controls.Add(Me.ChkbResp4)
        Me.pnlResp4.Controls.Add(Me.picBoxErr4)
        Me.pnlResp4.Controls.Add(Me.picBoxOk4)
        Me.pnlResp4.Location = New System.Drawing.Point(21, 588)
        Me.pnlResp4.Name = "pnlResp4"
        Me.pnlResp4.Size = New System.Drawing.Size(868, 66)
        Me.pnlResp4.TabIndex = 27
        '
        'pnlResp3
        '
        Me.pnlResp3.Controls.Add(Me.picBoxOk3)
        Me.pnlResp3.Controls.Add(Me.ChkbResp3)
        Me.pnlResp3.Controls.Add(Me.picBoxErr3)
        Me.pnlResp3.Location = New System.Drawing.Point(21, 485)
        Me.pnlResp3.Name = "pnlResp3"
        Me.pnlResp3.Size = New System.Drawing.Size(868, 66)
        Me.pnlResp3.TabIndex = 28
        '
        'picBoxOk3
        '
        Me.picBoxOk3.Image = CType(resources.GetObject("picBoxOk3.Image"), System.Drawing.Image)
        Me.picBoxOk3.Location = New System.Drawing.Point(22, 9)
        Me.picBoxOk3.Name = "picBoxOk3"
        Me.picBoxOk3.Size = New System.Drawing.Size(46, 35)
        Me.picBoxOk3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxOk3.TabIndex = 25
        Me.picBoxOk3.TabStop = False
        '
        'ChkbResp3
        '
        Me.ChkbResp3.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkbResp3.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkbResp3.Location = New System.Drawing.Point(87, 9)
        Me.ChkbResp3.Name = "ChkbResp3"
        Me.ChkbResp3.Size = New System.Drawing.Size(740, 54)
        Me.ChkbResp3.TabIndex = 24
        Me.ChkbResp3.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkbResp3.UseVisualStyleBackColor = True
        '
        'picBoxErr3
        '
        Me.picBoxErr3.Image = Global.ProyectoFinal_Examenes.My.Resources.Resources._Error
        Me.picBoxErr3.Location = New System.Drawing.Point(22, 9)
        Me.picBoxErr3.Name = "picBoxErr3"
        Me.picBoxErr3.Size = New System.Drawing.Size(46, 35)
        Me.picBoxErr3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxErr3.TabIndex = 23
        Me.picBoxErr3.TabStop = False
        '
        'pnlResp2
        '
        Me.pnlResp2.Controls.Add(Me.picBoxOk2)
        Me.pnlResp2.Controls.Add(Me.ChkbResp2)
        Me.pnlResp2.Controls.Add(Me.picBoxErr2)
        Me.pnlResp2.Location = New System.Drawing.Point(21, 391)
        Me.pnlResp2.Name = "pnlResp2"
        Me.pnlResp2.Size = New System.Drawing.Size(868, 66)
        Me.pnlResp2.TabIndex = 29
        '
        'picBoxOk2
        '
        Me.picBoxOk2.Image = CType(resources.GetObject("picBoxOk2.Image"), System.Drawing.Image)
        Me.picBoxOk2.Location = New System.Drawing.Point(22, 9)
        Me.picBoxOk2.Name = "picBoxOk2"
        Me.picBoxOk2.Size = New System.Drawing.Size(46, 35)
        Me.picBoxOk2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxOk2.TabIndex = 24
        Me.picBoxOk2.TabStop = False
        '
        'ChkbResp2
        '
        Me.ChkbResp2.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkbResp2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkbResp2.Location = New System.Drawing.Point(87, 9)
        Me.ChkbResp2.Name = "ChkbResp2"
        Me.ChkbResp2.Size = New System.Drawing.Size(740, 54)
        Me.ChkbResp2.TabIndex = 23
        Me.ChkbResp2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkbResp2.UseVisualStyleBackColor = True
        '
        'picBoxErr2
        '
        Me.picBoxErr2.Image = Global.ProyectoFinal_Examenes.My.Resources.Resources._Error
        Me.picBoxErr2.Location = New System.Drawing.Point(22, 9)
        Me.picBoxErr2.Name = "picBoxErr2"
        Me.picBoxErr2.Size = New System.Drawing.Size(46, 35)
        Me.picBoxErr2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxErr2.TabIndex = 22
        Me.picBoxErr2.TabStop = False
        '
        'pnlResp1
        '
        Me.pnlResp1.Controls.Add(Me.picBoxOk1)
        Me.pnlResp1.Controls.Add(Me.ChkbResp1)
        Me.pnlResp1.Controls.Add(Me.picboxErr1)
        Me.pnlResp1.Location = New System.Drawing.Point(21, 299)
        Me.pnlResp1.Name = "pnlResp1"
        Me.pnlResp1.Size = New System.Drawing.Size(868, 66)
        Me.pnlResp1.TabIndex = 30
        '
        'picBoxOk1
        '
        Me.picBoxOk1.Image = CType(resources.GetObject("picBoxOk1.Image"), System.Drawing.Image)
        Me.picBoxOk1.Location = New System.Drawing.Point(22, 9)
        Me.picBoxOk1.Name = "picBoxOk1"
        Me.picBoxOk1.Size = New System.Drawing.Size(46, 35)
        Me.picBoxOk1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoxOk1.TabIndex = 23
        Me.picBoxOk1.TabStop = False
        '
        'ChkbResp1
        '
        Me.ChkbResp1.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkbResp1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkbResp1.Location = New System.Drawing.Point(87, 9)
        Me.ChkbResp1.Name = "ChkbResp1"
        Me.ChkbResp1.Size = New System.Drawing.Size(740, 54)
        Me.ChkbResp1.TabIndex = 22
        Me.ChkbResp1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ChkbResp1.UseVisualStyleBackColor = True
        '
        'picboxErr1
        '
        Me.picboxErr1.Image = Global.ProyectoFinal_Examenes.My.Resources.Resources._Error
        Me.picboxErr1.Location = New System.Drawing.Point(22, 9)
        Me.picboxErr1.Name = "picboxErr1"
        Me.picboxErr1.Size = New System.Drawing.Size(46, 35)
        Me.picboxErr1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picboxErr1.TabIndex = 21
        Me.picboxErr1.TabStop = False
        '
        'frmExamenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1171, 711)
        Me.Controls.Add(Me.pnlPuntuacion)
        Me.Controls.Add(Me.pnlResp1)
        Me.Controls.Add(Me.pnlResp2)
        Me.Controls.Add(Me.pnlResp3)
        Me.Controls.Add(Me.pnlResp4)
        Me.Controls.Add(Me.lblTiempoRest)
        Me.Controls.Add(Me.ProBarTiempo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.btnCorregir)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.lblPregunta)
        Me.Controls.Add(Me.lblNumPregunta)
        Me.Name = "frmExamenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuestionario"
        CType(Me.picBoxErr4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxOk4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPuntuacion.ResumeLayout(False)
        Me.pnlPuntuacion.PerformLayout()
        CType(Me.picBoxErr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxOk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlResp4.ResumeLayout(False)
        Me.pnlResp3.ResumeLayout(False)
        CType(Me.picBoxOk3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxErr3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlResp2.ResumeLayout(False)
        CType(Me.picBoxOk2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoxErr2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlResp1.ResumeLayout(False)
        CType(Me.picBoxOk1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxErr1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumPregunta As Label
    Friend WithEvents lblPregunta As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents btnCorregir As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents picBoxErr4 As PictureBox
    Friend WithEvents ChkbResp4 As CheckBox
    Friend WithEvents picBoxOk4 As PictureBox
    Friend WithEvents TimerPreg As Timer
    Friend WithEvents ProBarTiempo As ProgressBar
    Friend WithEvents pnlPuntuacion As Panel
    Friend WithEvents lblPuntuacion As Label
    Friend WithEvents lblTexto As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents picBoxErr As PictureBox
    Friend WithEvents picBoxOk As PictureBox
    Friend WithEvents lblTiempoRest As Label
    Friend WithEvents pnlResp4 As Panel
    Friend WithEvents pnlResp3 As Panel
    Friend WithEvents picBoxOk3 As PictureBox
    Friend WithEvents ChkbResp3 As CheckBox
    Friend WithEvents picBoxErr3 As PictureBox
    Friend WithEvents pnlResp2 As Panel
    Friend WithEvents picBoxOk2 As PictureBox
    Friend WithEvents ChkbResp2 As CheckBox
    Friend WithEvents picBoxErr2 As PictureBox
    Friend WithEvents pnlResp1 As Panel
    Friend WithEvents picBoxOk1 As PictureBox
    Friend WithEvents ChkbResp1 As CheckBox
    Friend WithEvents picboxErr1 As PictureBox
End Class
