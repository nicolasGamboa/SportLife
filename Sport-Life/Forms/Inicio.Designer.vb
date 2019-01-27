<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblUsuario = New System.Windows.Forms.Label()
        Me.LblPasw = New System.Windows.Forms.Label()
        Me.TbxUsuario = New System.Windows.Forms.TextBox()
        Me.TbxPasw = New System.Windows.Forms.TextBox()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LnkLblRegistrarse = New System.Windows.Forms.LinkLabel()
        Me.LnkLblForgotPasw = New System.Windows.Forms.LinkLabel()
        Me.GrpbxInicio = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpbxInicio.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Sport_Life.My.Resources.Resources.logo_s1
        Me.PictureBox1.Location = New System.Drawing.Point(322, 52)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LblUsuario
        '
        Me.LblUsuario.AutoSize = True
        Me.LblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuario.ForeColor = System.Drawing.Color.White
        Me.LblUsuario.Location = New System.Drawing.Point(127, 16)
        Me.LblUsuario.Name = "LblUsuario"
        Me.LblUsuario.Size = New System.Drawing.Size(74, 24)
        Me.LblUsuario.TabIndex = 2
        Me.LblUsuario.Text = "Usuario"
        '
        'LblPasw
        '
        Me.LblPasw.AutoSize = True
        Me.LblPasw.BackColor = System.Drawing.Color.Transparent
        Me.LblPasw.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPasw.ForeColor = System.Drawing.Color.White
        Me.LblPasw.Location = New System.Drawing.Point(111, 94)
        Me.LblPasw.Name = "LblPasw"
        Me.LblPasw.Size = New System.Drawing.Size(106, 24)
        Me.LblPasw.TabIndex = 3
        Me.LblPasw.Text = "Contraseña"
        '
        'TbxUsuario
        '
        Me.TbxUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxUsuario.Location = New System.Drawing.Point(68, 56)
        Me.TbxUsuario.Name = "TbxUsuario"
        Me.TbxUsuario.Size = New System.Drawing.Size(179, 26)
        Me.TbxUsuario.TabIndex = 4
        '
        'TbxPasw
        '
        Me.TbxPasw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxPasw.Location = New System.Drawing.Point(68, 132)
        Me.TbxPasw.Name = "TbxPasw"
        Me.TbxPasw.Size = New System.Drawing.Size(179, 26)
        Me.TbxPasw.TabIndex = 5
        '
        'BtnIngresar
        '
        Me.BtnIngresar.BackColor = System.Drawing.Color.Transparent
        Me.BtnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnIngresar.Enabled = False
        Me.BtnIngresar.Location = New System.Drawing.Point(102, 214)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(115, 31)
        Me.BtnIngresar.TabIndex = 6
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.Sport_Life.My.Resources.Resources.userpassword_deusuari_787
        Me.PictureBox2.Location = New System.Drawing.Point(142, 174)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(44, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'LnkLblRegistrarse
        '
        Me.LnkLblRegistrarse.ActiveLinkColor = System.Drawing.Color.DarkTurquoise
        Me.LnkLblRegistrarse.AutoSize = True
        Me.LnkLblRegistrarse.BackColor = System.Drawing.Color.Transparent
        Me.LnkLblRegistrarse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkLblRegistrarse.ForeColor = System.Drawing.Color.White
        Me.LnkLblRegistrarse.LinkColor = System.Drawing.Color.Transparent
        Me.LnkLblRegistrarse.Location = New System.Drawing.Point(365, 432)
        Me.LnkLblRegistrarse.Name = "LnkLblRegistrarse"
        Me.LnkLblRegistrarse.Size = New System.Drawing.Size(81, 17)
        Me.LnkLblRegistrarse.TabIndex = 8
        Me.LnkLblRegistrarse.TabStop = True
        Me.LnkLblRegistrarse.Text = "Registrarse"
        '
        'LnkLblForgotPasw
        '
        Me.LnkLblForgotPasw.ActiveLinkColor = System.Drawing.Color.DarkTurquoise
        Me.LnkLblForgotPasw.AutoSize = True
        Me.LnkLblForgotPasw.BackColor = System.Drawing.Color.Transparent
        Me.LnkLblForgotPasw.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnkLblForgotPasw.ForeColor = System.Drawing.Color.White
        Me.LnkLblForgotPasw.LinkColor = System.Drawing.Color.Transparent
        Me.LnkLblForgotPasw.Location = New System.Drawing.Point(461, 432)
        Me.LnkLblForgotPasw.Name = "LnkLblForgotPasw"
        Me.LnkLblForgotPasw.Size = New System.Drawing.Size(152, 17)
        Me.LnkLblForgotPasw.TabIndex = 9
        Me.LnkLblForgotPasw.TabStop = True
        Me.LnkLblForgotPasw.Text = "Recuperar Contraseña"
        '
        'GrpbxInicio
        '
        Me.GrpbxInicio.BackColor = System.Drawing.Color.Transparent
        Me.GrpbxInicio.Controls.Add(Me.LblUsuario)
        Me.GrpbxInicio.Controls.Add(Me.TbxUsuario)
        Me.GrpbxInicio.Controls.Add(Me.LblPasw)
        Me.GrpbxInicio.Controls.Add(Me.BtnIngresar)
        Me.GrpbxInicio.Controls.Add(Me.PictureBox2)
        Me.GrpbxInicio.Controls.Add(Me.TbxPasw)
        Me.GrpbxInicio.Location = New System.Drawing.Point(322, 161)
        Me.GrpbxInicio.Name = "GrpbxInicio"
        Me.GrpbxInicio.Size = New System.Drawing.Size(320, 260)
        Me.GrpbxInicio.TabIndex = 10
        Me.GrpbxInicio.TabStop = False
        Me.GrpbxInicio.Text = "Acceso Al Sistema"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sport_Life.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(994, 525)
        Me.Controls.Add(Me.GrpbxInicio)
        Me.Controls.Add(Me.LnkLblForgotPasw)
        Me.Controls.Add(Me.LnkLblRegistrarse)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1002, 552)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1002, 552)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpbxInicio.ResumeLayout(False)
        Me.GrpbxInicio.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblUsuario As Label
    Friend WithEvents LblPasw As Label
    Friend WithEvents TbxUsuario As TextBox
    Friend WithEvents TbxPasw As TextBox
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LnkLblRegistrarse As LinkLabel
    Friend WithEvents LnkLblForgotPasw As LinkLabel
    Friend WithEvents GrpbxInicio As GroupBox
End Class
