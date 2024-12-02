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
        Me.btnChangeWallpaper = New System.Windows.Forms.Button()
        Me.cmbWallpapers = New System.Windows.Forms.ComboBox()
        Me.lblCurrentWallpaper = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnChangeWallpaper
        '
        Me.btnChangeWallpaper.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnChangeWallpaper.BackColor = System.Drawing.Color.Teal
        Me.btnChangeWallpaper.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeWallpaper.ForeColor = System.Drawing.Color.SpringGreen
        Me.btnChangeWallpaper.Location = New System.Drawing.Point(266, 317)
        Me.btnChangeWallpaper.Name = "btnChangeWallpaper"
        Me.btnChangeWallpaper.Size = New System.Drawing.Size(146, 59)
        Me.btnChangeWallpaper.TabIndex = 0
        Me.btnChangeWallpaper.Text = "Change Wallpaper"
        Me.btnChangeWallpaper.UseVisualStyleBackColor = False
        '
        'cmbWallpapers
        '
        Me.cmbWallpapers.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.cmbWallpapers.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbWallpapers.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cmbWallpapers.FormattingEnabled = True
        Me.cmbWallpapers.Location = New System.Drawing.Point(210, 70)
        Me.cmbWallpapers.Name = "cmbWallpapers"
        Me.cmbWallpapers.Size = New System.Drawing.Size(253, 21)
        Me.cmbWallpapers.TabIndex = 1
        '
        'lblCurrentWallpaper
        '
        Me.lblCurrentWallpaper.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblCurrentWallpaper.AutoSize = True
        Me.lblCurrentWallpaper.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentWallpaper.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentWallpaper.ForeColor = System.Drawing.Color.SpringGreen
        Me.lblCurrentWallpaper.Location = New System.Drawing.Point(12, 405)
        Me.lblCurrentWallpaper.Name = "lblCurrentWallpaper"
        Me.lblCurrentWallpaper.Size = New System.Drawing.Size(177, 17)
        Me.lblCurrentWallpaper.TabIndex = 2
        Me.lblCurrentWallpaper.Text = "Wallpapers Available🔽"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.BackgroundImage = Global.Account.My.Resources.Resources.icon1
        Me.PictureBox1.Location = New System.Drawing.Point(210, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 241)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(317, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 34)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CRIB🖐"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(260, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 34)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "FRioo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Account.My.Resources.Resources.triangle_light_dark_shape_88545_1920x1080
        Me.ClientSize = New System.Drawing.Size(662, 444)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCurrentWallpaper)
        Me.Controls.Add(Me.cmbWallpapers)
        Me.Controls.Add(Me.btnChangeWallpaper)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "📶"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnChangeWallpaper As Button
    Friend WithEvents cmbWallpapers As ComboBox
    Friend WithEvents lblCurrentWallpaper As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
