Public Class FormVisor

    Private Sub BtnSeleccionarImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSeleccionarImagen.Click
        ' Mostrar el cuadro de dialogo Abrir Archivo
        If ofdSeleccionarImagen.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Cargar la imagen en el cuadro de imagen
            PicMostrarImagen.Image = Image.FromFile(ofdSeleccionarImagen.FileName)
            'Mostrar el nombre del archivo como titulo del formulario 
            Me.Text = "Visor de Imagenes(" & ofdSeleccionarImagen.FileName & ")"




        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        'Cerrar la ventana y salir de la aplicación
        Me.Close()

    End Sub
End Class
