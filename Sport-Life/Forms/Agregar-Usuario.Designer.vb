<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Usuario))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblNomCli = New System.Windows.Forms.Label()
        Me.LblApeCli = New System.Windows.Forms.Label()
        Me.TbxNomCli = New System.Windows.Forms.TextBox()
        Me.TbxApeCli = New System.Windows.Forms.TextBox()
        Me.LblDni = New System.Windows.Forms.Label()
        Me.TbxDniCli = New System.Windows.Forms.TextBox()
        Me.DateTPFNacCli = New System.Windows.Forms.DateTimePicker()
        Me.LblTlefCli = New System.Windows.Forms.Label()
        Me.TbxTelefCli = New System.Windows.Forms.TextBox()
        Me.LblDirCli = New System.Windows.Forms.Label()
        Me.TbxDirCli = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TbxEmailCli = New System.Windows.Forms.TextBox()
        Me.BtLimpiarCli = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.LblFNacCli = New System.Windows.Forms.Label()
        Me.LblTipoCli = New System.Windows.Forms.Label()
        Me.CbxTipoCli = New System.Windows.Forms.ComboBox()
        Me.LblSexoCli = New System.Windows.Forms.Label()
        Me.CbxSexoCli = New System.Windows.Forms.ComboBox()
        Me.GrpBxDatosCli = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpBxDatosCli.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Sport_Life.My.Resources.Resources.logo_s1
        Me.PictureBox1.Location = New System.Drawing.Point(324, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(297, 89)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'LblNomCli
        '
        Me.LblNomCli.AutoSize = True
        Me.LblNomCli.BackColor = System.Drawing.Color.Transparent
        Me.LblNomCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNomCli.Location = New System.Drawing.Point(36, 27)
        Me.LblNomCli.Name = "LblNomCli"
        Me.LblNomCli.Size = New System.Drawing.Size(69, 20)
        Me.LblNomCli.TabIndex = 2
        Me.LblNomCli.Text = "Nombre:"
        '
        'LblApeCli
        '
        Me.LblApeCli.AutoSize = True
        Me.LblApeCli.BackColor = System.Drawing.Color.Transparent
        Me.LblApeCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblApeCli.Location = New System.Drawing.Point(36, 79)
        Me.LblApeCli.Name = "LblApeCli"
        Me.LblApeCli.Size = New System.Drawing.Size(69, 20)
        Me.LblApeCli.TabIndex = 3
        Me.LblApeCli.Text = "Apellido:"
        '
        'TbxNomCli
        '
        Me.TbxNomCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxNomCli.Location = New System.Drawing.Point(40, 50)
        Me.TbxNomCli.Name = "TbxNomCli"
        Me.TbxNomCli.Size = New System.Drawing.Size(202, 26)
        Me.TbxNomCli.TabIndex = 5
        '
        'TbxApeCli
        '
        Me.TbxApeCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxApeCli.Location = New System.Drawing.Point(40, 105)
        Me.TbxApeCli.Name = "TbxApeCli"
        Me.TbxApeCli.Size = New System.Drawing.Size(202, 26)
        Me.TbxApeCli.TabIndex = 6
        '
        'LblDni
        '
        Me.LblDni.AutoSize = True
        Me.LblDni.BackColor = System.Drawing.Color.Transparent
        Me.LblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDni.Location = New System.Drawing.Point(36, 134)
        Me.LblDni.Name = "LblDni"
        Me.LblDni.Size = New System.Drawing.Size(41, 20)
        Me.LblDni.TabIndex = 7
        Me.LblDni.Text = "DNI:"
        '
        'TbxDniCli
        '
        Me.TbxDniCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxDniCli.Location = New System.Drawing.Point(40, 157)
        Me.TbxDniCli.MaxLength = 8
        Me.TbxDniCli.Name = "TbxDniCli"
        Me.TbxDniCli.Size = New System.Drawing.Size(202, 26)
        Me.TbxDniCli.TabIndex = 8
        '
        'DateTPFNacCli
        '
        Me.DateTPFNacCli.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTPFNacCli.Location = New System.Drawing.Point(40, 209)
        Me.DateTPFNacCli.Name = "DateTPFNacCli"
        Me.DateTPFNacCli.Size = New System.Drawing.Size(200, 20)
        Me.DateTPFNacCli.TabIndex = 9
        '
        'LblTlefCli
        '
        Me.LblTlefCli.AutoSize = True
        Me.LblTlefCli.BackColor = System.Drawing.Color.Transparent
        Me.LblTlefCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTlefCli.Location = New System.Drawing.Point(307, 27)
        Me.LblTlefCli.Name = "LblTlefCli"
        Me.LblTlefCli.Size = New System.Drawing.Size(75, 20)
        Me.LblTlefCli.TabIndex = 10
        Me.LblTlefCli.Text = "Telefono:"
        '
        'TbxTelefCli
        '
        Me.TbxTelefCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxTelefCli.Location = New System.Drawing.Point(311, 50)
        Me.TbxTelefCli.Name = "TbxTelefCli"
        Me.TbxTelefCli.Size = New System.Drawing.Size(202, 26)
        Me.TbxTelefCli.TabIndex = 11
        '
        'LblDirCli
        '
        Me.LblDirCli.AutoSize = True
        Me.LblDirCli.BackColor = System.Drawing.Color.Transparent
        Me.LblDirCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDirCli.Location = New System.Drawing.Point(307, 79)
        Me.LblDirCli.Name = "LblDirCli"
        Me.LblDirCli.Size = New System.Drawing.Size(83, 20)
        Me.LblDirCli.TabIndex = 12
        Me.LblDirCli.Text = "Direccion: "
        '
        'TbxDirCli
        '
        Me.TbxDirCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxDirCli.Location = New System.Drawing.Point(309, 105)
        Me.TbxDirCli.Name = "TbxDirCli"
        Me.TbxDirCli.Size = New System.Drawing.Size(202, 26)
        Me.TbxDirCli.TabIndex = 13
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.BackColor = System.Drawing.Color.Transparent
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.Location = New System.Drawing.Point(307, 134)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(52, 20)
        Me.LblEmail.TabIndex = 14
        Me.LblEmail.Text = "Email:"
        '
        'TbxEmailCli
        '
        Me.TbxEmailCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxEmailCli.Location = New System.Drawing.Point(309, 157)
        Me.TbxEmailCli.Name = "TbxEmailCli"
        Me.TbxEmailCli.Size = New System.Drawing.Size(202, 26)
        Me.TbxEmailCli.TabIndex = 15
        '
        'BtLimpiarCli
        '
        Me.BtLimpiarCli.BackColor = System.Drawing.Color.Transparent
        Me.BtLimpiarCli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtLimpiarCli.Location = New System.Drawing.Point(280, 466)
        Me.BtLimpiarCli.Name = "BtLimpiarCli"
        Me.BtLimpiarCli.Size = New System.Drawing.Size(115, 31)
        Me.BtLimpiarCli.TabIndex = 16
        Me.BtLimpiarCli.Text = "Limpiar"
        Me.BtLimpiarCli.UseVisualStyleBackColor = False
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackColor = System.Drawing.Color.Transparent
        Me.BtnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnRegistrar.Enabled = False
        Me.BtnRegistrar.Location = New System.Drawing.Point(443, 466)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(115, 31)
        Me.BtnRegistrar.TabIndex = 17
        Me.BtnRegistrar.Text = "Guardar"
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.Location = New System.Drawing.Point(603, 466)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(115, 31)
        Me.BtnCancelar.TabIndex = 18
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'LblFNacCli
        '
        Me.LblFNacCli.AutoSize = True
        Me.LblFNacCli.BackColor = System.Drawing.Color.Transparent
        Me.LblFNacCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFNacCli.Location = New System.Drawing.Point(36, 186)
        Me.LblFNacCli.Name = "LblFNacCli"
        Me.LblFNacCli.Size = New System.Drawing.Size(163, 20)
        Me.LblFNacCli.TabIndex = 19
        Me.LblFNacCli.Text = "Fecha de Nacimiento:"
        '
        'LblTipoCli
        '
        Me.LblTipoCli.AutoSize = True
        Me.LblTipoCli.BackColor = System.Drawing.Color.Transparent
        Me.LblTipoCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTipoCli.Location = New System.Drawing.Point(307, 186)
        Me.LblTipoCli.Name = "LblTipoCli"
        Me.LblTipoCli.Size = New System.Drawing.Size(118, 20)
        Me.LblTipoCli.TabIndex = 21
        Me.LblTipoCli.Text = "Tipo de Cliente:"
        '
        'CbxTipoCli
        '
        Me.CbxTipoCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxTipoCli.ForeColor = System.Drawing.Color.Black
        Me.CbxTipoCli.FormattingEnabled = True
        Me.CbxTipoCli.Items.AddRange(New Object() {"Persona", "Empresa"})
        Me.CbxTipoCli.Location = New System.Drawing.Point(309, 212)
        Me.CbxTipoCli.Name = "CbxTipoCli"
        Me.CbxTipoCli.Size = New System.Drawing.Size(114, 21)
        Me.CbxTipoCli.TabIndex = 22
        '
        'LblSexoCli
        '
        Me.LblSexoCli.AutoSize = True
        Me.LblSexoCli.BackColor = System.Drawing.Color.Transparent
        Me.LblSexoCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSexoCli.Location = New System.Drawing.Point(431, 186)
        Me.LblSexoCli.Name = "LblSexoCli"
        Me.LblSexoCli.Size = New System.Drawing.Size(49, 20)
        Me.LblSexoCli.TabIndex = 23
        Me.LblSexoCli.Text = "Sexo:"
        '
        'CbxSexoCli
        '
        Me.CbxSexoCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxSexoCli.ForeColor = System.Drawing.Color.Black
        Me.CbxSexoCli.FormattingEnabled = True
        Me.CbxSexoCli.Items.AddRange(New Object() {"Hombre", "Mujer"})
        Me.CbxSexoCli.Location = New System.Drawing.Point(431, 212)
        Me.CbxSexoCli.Name = "CbxSexoCli"
        Me.CbxSexoCli.Size = New System.Drawing.Size(82, 21)
        Me.CbxSexoCli.TabIndex = 24
        '
        'GrpBxDatosCli
        '
        Me.GrpBxDatosCli.BackColor = System.Drawing.Color.Transparent
        Me.GrpBxDatosCli.Controls.Add(Me.LblNomCli)
        Me.GrpBxDatosCli.Controls.Add(Me.CbxSexoCli)
        Me.GrpBxDatosCli.Controls.Add(Me.TbxNomCli)
        Me.GrpBxDatosCli.Controls.Add(Me.LblSexoCli)
        Me.GrpBxDatosCli.Controls.Add(Me.LblApeCli)
        Me.GrpBxDatosCli.Controls.Add(Me.CbxTipoCli)
        Me.GrpBxDatosCli.Controls.Add(Me.TbxApeCli)
        Me.GrpBxDatosCli.Controls.Add(Me.LblTipoCli)
        Me.GrpBxDatosCli.Controls.Add(Me.LblDni)
        Me.GrpBxDatosCli.Controls.Add(Me.LblFNacCli)
        Me.GrpBxDatosCli.Controls.Add(Me.TbxDniCli)
        Me.GrpBxDatosCli.Controls.Add(Me.LblTlefCli)
        Me.GrpBxDatosCli.Controls.Add(Me.DateTPFNacCli)
        Me.GrpBxDatosCli.Controls.Add(Me.TbxTelefCli)
        Me.GrpBxDatosCli.Controls.Add(Me.LblDirCli)
        Me.GrpBxDatosCli.Controls.Add(Me.TbxEmailCli)
        Me.GrpBxDatosCli.Controls.Add(Me.TbxDirCli)
        Me.GrpBxDatosCli.Controls.Add(Me.LblEmail)
        Me.GrpBxDatosCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GrpBxDatosCli.Location = New System.Drawing.Point(168, 150)
        Me.GrpBxDatosCli.Name = "GrpBxDatosCli"
        Me.GrpBxDatosCli.Size = New System.Drawing.Size(650, 289)
        Me.GrpBxDatosCli.TabIndex = 25
        Me.GrpBxDatosCli.TabStop = False
        Me.GrpBxDatosCli.Text = "Datos Personales"
        '
        'Agregar_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Sport_Life.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(994, 525)
        Me.Controls.Add(Me.GrpBxDatosCli)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.BtLimpiarCli)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1002, 552)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1002, 552)
        Me.Name = "Agregar_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Cliente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpBxDatosCli.ResumeLayout(False)
        Me.GrpBxDatosCli.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblNomCli As Label
    Friend WithEvents LblApeCli As Label
    Friend WithEvents TbxNomCli As TextBox
    Friend WithEvents TbxApeCli As TextBox
    Friend WithEvents LblDni As Label
    Friend WithEvents TbxDniCli As TextBox
    Friend WithEvents DateTPFNacCli As DateTimePicker
    Friend WithEvents LblTlefCli As Label
    Friend WithEvents TbxTelefCli As TextBox
    Friend WithEvents LblDirCli As Label
    Friend WithEvents TbxDirCli As TextBox
    Friend WithEvents LblEmail As Label
    Friend WithEvents TbxEmailCli As TextBox
    Friend WithEvents BtLimpiarCli As Button
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents LblFNacCli As Label
    Friend WithEvents LblTipoCli As Label
    Friend WithEvents CbxTipoCli As ComboBox
    Friend WithEvents LblSexoCli As Label
    Friend WithEvents CbxSexoCli As ComboBox
    Friend WithEvents GrpBxDatosCli As GroupBox
End Class
