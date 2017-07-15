<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FormSkin1 = New URL_Shortner.FormSkin()
        Me.FlatClose1 = New URL_Shortner.FlatClose()
        Me.txtUrl = New URL_Shortner.FlatTextBox()
        Me.rbtnAdfly = New URL_Shortner.RadioButton()
        Me.rbtnGoogle = New URL_Shortner.RadioButton()
        Me.btnSubmit = New URL_Shortner.FlatButton()
        Me.txtShort = New URL_Shortner.FlatTextBox()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.txtShort)
        Me.FormSkin1.Controls.Add(Me.btnSubmit)
        Me.FormSkin1.Controls.Add(Me.rbtnGoogle)
        Me.FormSkin1.Controls.Add(Me.rbtnAdfly)
        Me.FormSkin1.Controls.Add(Me.txtUrl)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(417, 247)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "URL Shortner By TCWLIGHTNING"
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(387, 13)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 0
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtUrl
        '
        Me.txtUrl.BackColor = System.Drawing.Color.Transparent
        Me.txtUrl.Location = New System.Drawing.Point(76, 68)
        Me.txtUrl.MaxLength = 32767
        Me.txtUrl.Multiline = False
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.ReadOnly = False
        Me.txtUrl.Size = New System.Drawing.Size(253, 29)
        Me.txtUrl.TabIndex = 1
        Me.txtUrl.Text = "Url"
        Me.txtUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUrl.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUrl.UseSystemPasswordChar = False
        '
        'rbtnAdfly
        '
        Me.rbtnAdfly.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.rbtnAdfly.Checked = False
        Me.rbtnAdfly.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnAdfly.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rbtnAdfly.Location = New System.Drawing.Point(254, 117)
        Me.rbtnAdfly.Name = "rbtnAdfly"
        Me.rbtnAdfly.Options = URL_Shortner.RadioButton._Options.Style1
        Me.rbtnAdfly.Size = New System.Drawing.Size(100, 22)
        Me.rbtnAdfly.TabIndex = 2
        Me.rbtnAdfly.Text = "Adfly"
        '
        'rbtnGoogle
        '
        Me.rbtnGoogle.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.rbtnGoogle.Checked = True
        Me.rbtnGoogle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnGoogle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rbtnGoogle.Location = New System.Drawing.Point(97, 117)
        Me.rbtnGoogle.Name = "rbtnGoogle"
        Me.rbtnGoogle.Options = URL_Shortner.RadioButton._Options.Style1
        Me.rbtnGoogle.Size = New System.Drawing.Size(100, 22)
        Me.rbtnGoogle.TabIndex = 3
        Me.rbtnGoogle.Text = "Google"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmit.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnSubmit.Location = New System.Drawing.Point(152, 203)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Rounded = False
        Me.btnSubmit.Size = New System.Drawing.Size(106, 32)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Shorten"
        Me.btnSubmit.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'txtShort
        '
        Me.txtShort.BackColor = System.Drawing.Color.Transparent
        Me.txtShort.Location = New System.Drawing.Point(76, 157)
        Me.txtShort.MaxLength = 32767
        Me.txtShort.Multiline = False
        Me.txtShort.Name = "txtShort"
        Me.txtShort.ReadOnly = False
        Me.txtShort.Size = New System.Drawing.Size(253, 29)
        Me.txtShort.TabIndex = 5
        Me.txtShort.Text = "FlatTextBox2"
        Me.txtShort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtShort.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtShort.UseSystemPasswordChar = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 247)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "URL Shortner"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents txtShort As FlatTextBox
    Friend WithEvents btnSubmit As FlatButton
    Friend WithEvents rbtnGoogle As RadioButton
    Friend WithEvents rbtnAdfly As RadioButton
    Friend WithEvents txtUrl As FlatTextBox
End Class
