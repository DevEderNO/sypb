<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro_Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lb_usuario = New System.Windows.Forms.Label()
        Me.lb_senha = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.lb_confSenha = New System.Windows.Forms.Label()
        Me.txtConfSenha = New System.Windows.Forms.TextBox()
        Me.comboTipo = New System.Windows.Forms.ComboBox()
        Me.lb_tipo = New System.Windows.Forms.Label()
        Me.bt_cadastrar = New System.Windows.Forms.Button()
        Me.bt_cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lb_usuario
        '
        Me.lb_usuario.AutoSize = True
        Me.lb_usuario.Location = New System.Drawing.Point(12, 9)
        Me.lb_usuario.Name = "lb_usuario"
        Me.lb_usuario.Size = New System.Drawing.Size(43, 13)
        Me.lb_usuario.TabIndex = 0
        Me.lb_usuario.Text = "Usuario"
        '
        'lb_senha
        '
        Me.lb_senha.AutoSize = True
        Me.lb_senha.Location = New System.Drawing.Point(12, 48)
        Me.lb_senha.Name = "lb_senha"
        Me.lb_senha.Size = New System.Drawing.Size(38, 13)
        Me.lb_senha.TabIndex = 1
        Me.lb_senha.Text = "Senha"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(15, 25)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(226, 20)
        Me.txtUsuario.TabIndex = 2
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(15, 64)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtSenha.TabIndex = 3
        '
        'lb_confSenha
        '
        Me.lb_confSenha.AutoSize = True
        Me.lb_confSenha.Location = New System.Drawing.Point(12, 87)
        Me.lb_confSenha.Name = "lb_confSenha"
        Me.lb_confSenha.Size = New System.Drawing.Size(85, 13)
        Me.lb_confSenha.TabIndex = 4
        Me.lb_confSenha.Text = "Confirmar Senha"
        '
        'txtConfSenha
        '
        Me.txtConfSenha.Location = New System.Drawing.Point(15, 103)
        Me.txtConfSenha.Name = "txtConfSenha"
        Me.txtConfSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtConfSenha.TabIndex = 5
        '
        'comboTipo
        '
        Me.comboTipo.FormattingEnabled = True
        Me.comboTipo.Items.AddRange(New Object() {"Usuario", "Administrador"})
        Me.comboTipo.Location = New System.Drawing.Point(15, 142)
        Me.comboTipo.Name = "comboTipo"
        Me.comboTipo.Size = New System.Drawing.Size(153, 21)
        Me.comboTipo.TabIndex = 6
        '
        'lb_tipo
        '
        Me.lb_tipo.AutoSize = True
        Me.lb_tipo.Location = New System.Drawing.Point(16, 126)
        Me.lb_tipo.Name = "lb_tipo"
        Me.lb_tipo.Size = New System.Drawing.Size(87, 13)
        Me.lb_tipo.TabIndex = 7
        Me.lb_tipo.Text = "Tipo de cadastro"
        '
        'bt_cadastrar
        '
        Me.bt_cadastrar.Location = New System.Drawing.Point(12, 169)
        Me.bt_cadastrar.Name = "bt_cadastrar"
        Me.bt_cadastrar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cadastrar.TabIndex = 8
        Me.bt_cadastrar.Text = "Cadastrar"
        Me.bt_cadastrar.UseVisualStyleBackColor = True
        '
        'bt_cancelar
        '
        Me.bt_cancelar.Location = New System.Drawing.Point(93, 169)
        Me.bt_cancelar.Name = "bt_cancelar"
        Me.bt_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.bt_cancelar.TabIndex = 9
        Me.bt_cancelar.Text = "Cancelar"
        Me.bt_cancelar.UseVisualStyleBackColor = True
        '
        'Cadastro_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 204)
        Me.ControlBox = False
        Me.Controls.Add(Me.bt_cancelar)
        Me.Controls.Add(Me.bt_cadastrar)
        Me.Controls.Add(Me.lb_tipo)
        Me.Controls.Add(Me.comboTipo)
        Me.Controls.Add(Me.txtConfSenha)
        Me.Controls.Add(Me.lb_confSenha)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lb_senha)
        Me.Controls.Add(Me.lb_usuario)
        Me.Name = "Cadastro_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro_Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_usuario As System.Windows.Forms.Label
    Friend WithEvents lb_senha As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents lb_confSenha As System.Windows.Forms.Label
    Friend WithEvents txtConfSenha As System.Windows.Forms.TextBox
    Friend WithEvents comboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents lb_tipo As System.Windows.Forms.Label
    Friend WithEvents bt_cadastrar As System.Windows.Forms.Button
    Friend WithEvents bt_cancelar As System.Windows.Forms.Button
End Class
