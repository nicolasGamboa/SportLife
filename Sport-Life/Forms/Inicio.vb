Public Class Inicio
    'habilita/deshabilitar el boton al rellenar campos'
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TbxPasw.TextChanged
        TbxPasw.UseSystemPasswordChar = True 'para ocultar los caracteres de la pasw'
        If (TbxPasw.Text.Length > 0) And (TbxUsuario.Text.Length > 0) Then
            BtnIngresar.Enabled = True
        Else
            BtnIngresar.Enabled = False
        End If
    End Sub


    'habilita/deshabilitar el boton al rellenar campos'
    Private Sub TbxUsuario_TextChanged(sender As Object, e As EventArgs) Handles TbxUsuario.TextChanged
        If (TbxPasw.Text.Length > 0) And (TbxUsuario.Text.Length > 0) Then
            BtnIngresar.Enabled = True
        Else
            BtnIngresar.Enabled = False
        End If
    End Sub
End Class