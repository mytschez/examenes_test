Imports System.Data.SqlClient

Public Class frmExamenes
    'VARIABLES
    Dim pregunta As Integer = 0 'para el número de registros
    Public longtabla As Integer 'para recoger el tamaño de la tabla
    Dim result As DialogResult
    Public respuestas() As Integer 'Vector para guardar las respuestas
    Dim corregir As Boolean = False ' para saber si hay que cargar las preguntas corregidas(con iconos)
    Dim contAcertadas As Integer = 0 ' para contabilizar el nº de aciertos
    Dim pregAleatorias() As Integer 'vector para guardar los nº aleatorios
    Dim numPreg As Integer 'nº de pregunta aleatorio
    'vector para guardar las preguntas cargadas y desordenar las respuestas solo una vez
    Dim pregCargada As ArrayList = New ArrayList()
    'posibles posiciones de los checkbox con las respuestas
    Dim posicionesPosibles() As Point = {New Point(21, 180), New Point(21, 240), New Point(21, 300), New Point(21, 370)}
    'para guardar el Location de los paneles de las respuestas
    Dim posPanel1 As Point
    Dim posPanel2 As Point
    Dim posPanel3 As Point
    Dim posPanel4 As Point
    Public posicionRespuestas(,)

    'Declaramos una variable de tipo sqlConnection para la cadena de conexión
    Dim cnn As New SqlConnection("Data Source=.;Initial Catalog=Examenes;Integrated Security=True")
    Dim dt As New DataTable()

    'LOAD
    Private Sub frmExamenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cargamos la tabla
        cargarTabla()
        'aspecto del formulario
        BtnPorDefecto()
        pnlPuntuacion.Hide()
    End Sub

    'SALIR
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        result = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        Else
            Me.Show()
        End If
    End Sub

    'NUEVO EXAMEN
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        'limpiar formulario
        BtnPorDefecto()
        'abre un formulario
        frmInicio.ShowDialog()
        Nuevo()
    End Sub

    'SIGUIENTE
    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        CambiarPreg("siguiente")
    End Sub

    'ANTERIOR
    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        CambiarPreg("anterior")
    End Sub

    'FINALIZAR EXAMEN
    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        finalizarExamen()
    End Sub

    'CORREGIR EXAMEN
    Private Sub btnCorregir_Click(sender As Object, e As EventArgs) Handles btnCorregir.Click
        corregir = True
        CorregirExamen()
    End Sub

    'procedimiento para cargar la tabla
    Private Sub cargarTabla()
        dt.Clear()
        Dim Consulta As New SqlCommand("SELECT * FROM Cuestionario", cnn)
        Dim da As New SqlDataAdapter(Consulta)
        'cargamos los datos de la tabla de sql en nuestra tabla virtual (.fill)
        da.Fill(dt)

        'tamaño de la tabla
        longtabla = dt.Rows.Count
    End Sub

    'procedimiento para cargar los campos del formulario desde la bbdd
    Private Sub cargarExamen(i As Integer)
        'num de pregunta
        lblNumPregunta.Text = "Pregunta: " & pregunta + 1 & "/" & frmInicio.totalPreg

        'enunciado pregunta
        lblPregunta.Text = dt.Rows(i)("Pregunta")

        'respuestas
        ChkbResp1.Text = dt.Rows(i)("Respuesta1")
        ChkbResp2.Text = dt.Rows(i)("Respuesta2")
        ChkbResp3.Text = dt.Rows(i)("Respuesta3")
        ChkbResp4.Text = dt.Rows(i)("Respuesta4")

        'comprobar si es la primera vez que se carga la pregunta para desordenar las respuestas
        If pregCargada.Contains(i) Then
            pnlResp1.Location = posicionRespuestas(pregunta, 0)
            pnlResp2.Location = posicionRespuestas(pregunta, 1)
            pnlResp3.Location = posicionRespuestas(pregunta, 2)
            pnlResp4.Location = posicionRespuestas(pregunta, 3)
        Else
            pregCargada.Add(i)
            desordenarRespuestas()
        End If

        'para mostrar que respuestas se han seleccionado
        numPreg = pregAleatorias(pregunta) - 1
        ValidarRespuesta(numPreg)
    End Sub

    'procedimiento para desordenar las respuestas 
    Private Sub desordenarRespuestas()
        'variables
        Dim rnd As New Random()
        Dim num As Integer
        Dim respDesordenadas(3) As Integer 'vector para desordenar la posicion de las respuestas
        'generamos 4 nº aleatorios comprendidos entre 0 y 3 ambos inlusive para desordenar las respuestas
        For i = 0 To respDesordenadas.Length - 1
            'verificamos si ya se ha generado ese nº previamente
            Do
                'rnd.next(n,m) genera aleatorios que son mayor o igual que n y menor que m
                num = rnd.Next(1, 5)

            Loop While (respDesordenadas.Contains(num))

            'el nº no está repetido así que lo guardamos en el vector
            respDesordenadas(i) = num
        Next

        'dibujar los paneles con las respuestas
        'guardar las posiciones para que desordene solo una vez
        posPanel1 = posicionesPosibles(respDesordenadas(0) - 1)
        posicionRespuestas(pregunta, 0) = posPanel1
        pnlResp1.Location = posPanel1

        posPanel2 = posicionesPosibles(respDesordenadas(1) - 1)
        posicionRespuestas(pregunta, 1) = posPanel2
        pnlResp2.Location = posPanel2

        posPanel3 = posicionesPosibles(respDesordenadas(2) - 1)
        posicionRespuestas(pregunta, 2) = posPanel3
        pnlResp3.Location = posPanel3

        posPanel4 = posicionesPosibles(respDesordenadas(3) - 1)
        posicionRespuestas(pregunta, 3) = posPanel4
        pnlResp4.Location = posPanel4
    End Sub

    'procedimiento para iniciar un nuevo examen
    Private Sub Nuevo()
        'inicializar la variable pregunta
        pregunta = 0
        'ocultar el btn corregir
        btnCorregir.Hide()
        corregir = False
        'ocultar el panel de la puntuación
        pnlPuntuacion.Hide()
        'habilitar los botones anterior y siguiente
        btnAnteriorSiguiente()
        'inicializamos el contador de las respuestas acertadas
        contAcertadas = 0
        'ocultar los iconos de las correcciones
        OcultarIconos()

        'vaciar el arraylist de preguntas cargadas
        ' pregCargada.Clear()

        'iniciar el timer y mostrar progressbar
        TimerPreg.Start()
        'vaciar el label del tiempo restante
        lblTiempoRest.Text = ""
        ProBarTiempo.Show()

        ProBarTiempo.Maximum = frmInicio.duracionExamen
        ProBarTiempo.Minimum = 0
        ProBarTiempo.Value = frmInicio.duracionExamen

        lblTiempoRest.Show()

        'cargar preguntas
        Generar_Aleatorio()
        numPreg = pregAleatorias(pregunta) - 1
        cargarExamen(numPreg)

    End Sub

    'procedimiento para pasar de pregunta hacia delante y hacia atrás
    Private Sub CambiarPreg(pasar As String)
        If pasar = "siguiente" Then
            guardarRespuesta()
            OcultarIconos()
            pregunta += 1
            btnAnteriorSiguiente()
            numPreg = pregAleatorias(pregunta) - 1
            cargarExamen(numPreg)

        End If
        If pasar = "anterior" Then
            guardarRespuesta()
            OcultarIconos()
            pregunta -= 1
            btnAnteriorSiguiente()
            numPreg = pregAleatorias(pregunta) - 1
            cargarExamen(numPreg)
        End If
    End Sub

    'procedimiento para activar/desactivar los botones anterior y siguiente
    Private Sub btnAnteriorSiguiente()
        'si es la primera pregunta btnAnterior deshabilitado
        If pregunta = 0 Then
            btnAnterior.Enabled = False
            btnSiguiente.Enabled = True
            'si es la última pregunta btnSiguiente deshabilitado
        ElseIf pregunta = frmInicio.totalPreg - 1 Then
            btnAnterior.Enabled = True
            btnSiguiente.Enabled = False
            'si no es ni la primera ni la última ambos habilitados
        ElseIf pregunta > 0 Or pregunta < frmInicio.totalPreg - 1 Then
            btnAnterior.Enabled = True
            btnSiguiente.Enabled = True
        End If
    End Sub

    'procedimiento para guardar las respuestas
    Private Sub guardarRespuesta()
        If ChkbResp1.Checked Then
            respuestas(pregunta) = 1
        ElseIf ChkbResp2.Checked Then
            respuestas(pregunta) = 2
        ElseIf ChkbResp3.Checked Then
            respuestas(pregunta) = 3
        ElseIf ChkbResp4.Checked Then
            respuestas(pregunta) = 4
        Else
            respuestas(pregunta) = 0
        End If

    End Sub

    'procedimiento para ver que respuestas están marcadas
    Private Sub ValidarRespuesta(i As Integer)
        'variable
        Dim respuestaCorrecta As Integer = dt.Rows(i)("Solucion")

        'mostrar la respuesta que se ha marcado y si corregir = true validar respuestas correctas
        Select Case respuestas(pregunta)
            Case 0
                ChkbResp1.Checked = False
                ChkbResp2.Checked = False
                ChkbResp3.Checked = False
                ChkbResp4.Checked = False
            Case 1
                ChkbResp1.Checked = True
                ChkbResp2.Checked = False
                ChkbResp3.Checked = False
                ChkbResp4.Checked = False
                'CORREGIR Y MOSTRAR LOS ERRORES 
                If corregir Then
                    If Not respuestaCorrecta = 1 Then
                        picboxErr1.Show()
                    End If
                End If
            Case 2
                ChkbResp1.Checked = False
                ChkbResp2.Checked = True
                ChkbResp3.Checked = False
                ChkbResp4.Checked = False
                'CORREGIR Y MOSTRAR LOS ERRORES 
                If corregir Then
                    If Not respuestaCorrecta = 2 Then
                        picBoxErr2.Show()
                    End If
                End If
            Case 3
                ChkbResp1.Checked = False
                ChkbResp2.Checked = False
                ChkbResp3.Checked = True
                ChkbResp4.Checked = False
                'CORREGIR Y MOSTRAR LOS ERRORES 
                If corregir Then
                    If Not respuestaCorrecta = 3 Then
                        picBoxErr3.Show()
                    End If
                End If
            Case 4
                ChkbResp1.Checked = False
                ChkbResp2.Checked = False
                ChkbResp3.Checked = False
                ChkbResp4.Checked = True
                'CORREGIR Y MOSTRAR LOS ERRORES 
                If corregir Then
                    If Not respuestaCorrecta = 4 Then
                        picBoxErr4.Show()
                    End If
                End If
        End Select

        'CORREGIR Y MOSTRAR LAS CORRECTAS
        'tanto si se ha respondido, como si se han dejado en blanco
        If corregir Then
            If respuestaCorrecta = 1 Then
                picBoxOk1.Show()
            ElseIf respuestaCorrecta = 2 Then
                picBoxOk2.Show()
            ElseIf respuestaCorrecta = 3 Then
                picBoxOk3.Show()
            ElseIf respuestaCorrecta = 4 Then
                picBoxOk4.Show()
            End If
        End If
    End Sub

    'Procedimiento para finalizar el examen
    Private Sub finalizarExamen()
        'variable
        Dim respuestasEnBlanco As Boolean = False

        'parar el timer
        TimerPreg.Stop()

        guardarRespuesta()

        'recorrer el array de respuestas para: 
        For i As Integer = 0 To frmInicio.totalPreg - 1
            'comprobar si hay respuestas en blanco
            If respuestas(i) = 0 Then
                respuestasEnBlanco = True
            End If
            'comprobar el nº de aciertos
            If respuestas(i) = dt.Rows(i)("Solucion") Then
                contAcertadas += 1
            End If
        Next

        'si hay respuestas en blanco preguntar antes de finalizar el examen
        If respuestasEnBlanco Then
            result = MessageBox.Show("Hay respuestas en blanco, ¿desea finalizar el examen?", "Finalizar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If result = DialogResult.Yes Then
                BtnPorDefecto()
                btnCorregir.Show()
                btnNuevo.Enabled = True

                ResultadoExamen()
            Else
                Me.Show()
            End If
        Else
            BtnPorDefecto()
            btnCorregir.Show()
            btnNuevo.Enabled = True

            ResultadoExamen()
        End If
    End Sub

    'procedimiento para calcular y mostrar el resultado del examen
    Private Sub ResultadoExamen()
        'variable
        Dim resultado As Double 'para mostrar el resultado del cuestionario

        resultado = contAcertadas * 100 / frmInicio.totalPreg
        'si el examen está aprobado muestra un tic verde, sino una cruz roja
        If resultado >= 50 Then
            picBoxErr.Hide()
        Else
            picBoxOk.Hide()
        End If
        'visibilizar el panel para mostrar el resultado del examen
        pnlPuntuacion.Show()
        lblNombre.Text = frmInicio.txtNombre.Text
        lblPuntuacion.Text = Math.Round(resultado, 2) & "/100"
    End Sub

    'procedimiento que hay que hacer para corregir el examen
    Private Sub CorregirExamen()
        'deshabilitar los checkbox para que no se puedan modificar las respuestas y el boton corregir
        deshabilitarCheckbox()
        btnCorregir.Hide()

        'quitar el panel del resultado
        pnlPuntuacion.Hide()

        'habilitar los botones
        frmInicio.Inicializar()
        btnFinalizar.Hide()
        btnNuevo.Enabled = True

        'cargar las preguntas desde la primera
        pregunta = 0
        btnAnteriorSiguiente()
        numPreg = pregAleatorias(pregunta) - 1
        cargarExamen(numPreg)
    End Sub


    'timer para controlar el tiempo que dura el examen
    Private Sub TimerPreg_Tick(sender As Object, e As EventArgs) Handles TimerPreg.Tick
        'variables
        'formatear el tiempo para que lo muestre min:seg
        Dim seg As Integer = (frmInicio.duracionExamen Mod 60)
        Dim min As Integer = (((frmInicio.duracionExamen - seg) / 60) Mod 60)

        If frmInicio.duracionExamen > 0 Then
            frmInicio.duracionExamen = frmInicio.duracionExamen - 1
            ProBarTiempo.Value = frmInicio.duracionExamen
            lblTiempoRest.Text = "Tiempo (min:seg):  " & String.Format("{0: 00}", min) & " : " & String.Format("{0: 00}", seg)
        Else
            TimerPreg.Stop()
            deshabilitarCheckbox()
            MessageBox.Show("Se agotó tu tiempo", frmInicio.txtNombre.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            BtnPorDefecto()
            btnCorregir.Show()
            btnNuevo.Enabled = True
            ResultadoExamen()
        End If
    End Sub

    'procedimiento para deshabilitar los checkbox 
    Private Sub deshabilitarCheckbox()
        ChkbResp1.Enabled = False
        ChkbResp2.Enabled = False
        ChkbResp3.Enabled = False
        ChkbResp4.Enabled = False
    End Sub

    'procedimiento para los botones del formulario por defecto
    Private Sub BtnPorDefecto()
        'preguntas y respuestas no visibles
        lblNumPregunta.Hide()
        lblPregunta.Hide()

        ChkbResp1.Enabled = True
        ChkbResp2.Enabled = True
        ChkbResp3.Enabled = True
        ChkbResp4.Enabled = True

        ChkbResp1.Hide()
        ChkbResp2.Hide()
        ChkbResp3.Hide()
        ChkbResp4.Hide()

        OcultarIconos()

        'botones finalizar, corregir, anterior y siguiente no visibles
        btnFinalizar.Hide()
        btnCorregir.Hide()

        btnAnterior.Hide()
        btnSiguiente.Hide()

        ProBarTiempo.Hide()
        lblTiempoRest.Hide()
    End Sub

    'procedimiento para ocultar los iconos de las correcciones
    Private Sub OcultarIconos()
        picboxErr1.Hide()
        picBoxErr2.Hide()
        picBoxErr3.Hide()
        picBoxErr4.Hide()

        picBoxOk1.Hide()
        picBoxOk2.Hide()
        picBoxOk3.Hide()
        picBoxOk4.Hide()
    End Sub

    'solo se puede elegir una opción
    Private Sub ChkbResp1_CheckedChanged(sender As Object, e As EventArgs)
        If ChkbResp1.Checked Then
            ChkbResp2.Checked = False
            ChkbResp3.Checked = False
            ChkbResp4.Checked = False
        End If
    End Sub

    Private Sub ChkbResp2_CheckedChanged(sender As Object, e As EventArgs)
        If ChkbResp2.Checked Then
            ChkbResp1.Checked = False
            ChkbResp3.Checked = False
            ChkbResp4.Checked = False
        End If
    End Sub

    Private Sub ChkbResp3_CheckedChanged(sender As Object, e As EventArgs)
        If ChkbResp3.Checked Then
            ChkbResp1.Checked = False
            ChkbResp2.Checked = False
            ChkbResp4.Checked = False
        End If
    End Sub

    Private Sub ChkbResp4_CheckedChanged(sender As Object, e As EventArgs) Handles ChkbResp4.CheckedChanged
        If ChkbResp4.Checked Then
            ChkbResp1.Checked = False
            ChkbResp2.Checked = False
            ChkbResp3.Checked = False
        End If
    End Sub

    'función para generar nº aleatorios
    Private Sub Generar_Aleatorio()
        'variables
        Dim rnd As New Random()
        Dim num As Integer
        Dim cantidad As Integer = frmInicio.txtCantidadPreg.Value - 1

        'redimensionar el vector pregAleatorias
        ReDim pregAleatorias(cantidad)

        'generamos tantos nº aleatorios como preguntas tenga el examen
        For i = 0 To cantidad
            'verificamos si ya se ha generado ese nº previamente
            Do
                num = rnd.Next(1, longtabla) 'nº aleatorio comprendido entre 0 y el total de posibles preguntas
                ' Loop While (Existe(num, pregAleatorias) = True)
            Loop While (pregAleatorias.Contains(num))

            'el nº no está repetido así que lo guardamos en el vector
            pregAleatorias(i) = num
        Next

    End Sub

End Class
