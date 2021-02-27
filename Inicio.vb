
Public Class frmInicio
    'Variables
    Public totalPreg As Integer 'recoge el número de preguntas que va a tener el cuestionario
    Dim max As Integer = frmExamenes.longtabla 'número máximo de preguntas posibles
    Dim minutos As Integer 'recoge el número de minutos marcados para realizar el cuestionario
    Public duracionExamen As Integer 'duración del examen
    'LOAD
    Private Sub frmInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'limpiar el formulario por si tiene datos anteriores
        txtNombre.Clear()
        'minimo 5 preguntas
        txtCantidadPreg.Value = 5
        'minimo 1 minutos
        txtDuracion.Value = 1
        'cantidad máxima de preguntas que se pueden añadir
        lblMax.Text = "(máximo " & max & ")"
    End Sub

    'INICIAR EXAMEN
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        IniciarExamen()
    End Sub

    'establece min y max de preguntas que se pueden elegir
    Private Sub txtCantidadPreg_ValueChanged(sender As Object, e As EventArgs) Handles txtCantidadPreg.ValueChanged
        txtCantidadPreg.Minimum = 5
        txtCantidadPreg.Maximum = max
    End Sub

    'comprobar que el nombre se ha rellenado antes de poder dar a iniciar examen
    Private Sub txtNombre_LostFocus(sender As Object, e As EventArgs) Handles txtNombre.LostFocus
        If txtNombre.Text = "" Then
            errNombre.SetError(txtNombre, "No puede estar vacío")
            btnIniciar.Enabled = False
        Else
            errNombre.SetError(txtNombre, String.Empty)
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        btnIniciar.Enabled = True
    End Sub

    'procedimiento para iniciar el examen
    Private Sub IniciarExamen()
        'cerrar formInicio
        Close()

        'añadir el nombre al título del formulario del cuestionario
        frmExamenes.Text = "Cuestionario: " & txtNombre.Text

        'recoger el número de preguntas seleccionado
        totalPreg = txtCantidadPreg.Value

        'redimensionar los arrays para guardar las respuestas y la preguntas cargadas
        ReDim frmExamenes.respuestas(totalPreg - 1)
        ReDim frmExamenes.posicionRespuestas(totalPreg - 1, 3)

        'recoger el número de minutos marcados
        minutos = txtDuracion.Value
        duracionExamen = minutos * 60



        'visibilizar preguntas y botones
        Inicializar()

            End Sub

    'procedimiento para visibilizar preguntas y botones
    Public Sub Inicializar()
        'preguntas
        frmExamenes.lblNumPregunta.Show()
        frmExamenes.lblPregunta.Show()

        'respuestas
        frmExamenes.ChkbResp1.Checked = False
        frmExamenes.ChkbResp1.Show()
        frmExamenes.ChkbResp2.Checked = False
        frmExamenes.ChkbResp2.Show()
        frmExamenes.ChkbResp3.Checked = False
        frmExamenes.ChkbResp3.Show()
        frmExamenes.ChkbResp4.Checked = False
        frmExamenes.ChkbResp4.Show()

        'botones
        frmExamenes.btnFinalizar.Show()
        frmExamenes.btnSiguiente.Show()
        frmExamenes.btnAnterior.Enabled = False
        frmExamenes.btnAnterior.Show()

        frmExamenes.btnNuevo.Enabled = False

    End Sub
End Class