﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Tunnel = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Tunnel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(577, 188)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 41)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(20, 42)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(362, 444)
        Me.ListBox1.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(438, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(429, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Reason"
        '
        'Tunnel
        '
        Me.Tunnel.Controls.Add(Me.Label5)
        Me.Tunnel.Controls.Add(Me.ListBox2)
        Me.Tunnel.Controls.Add(Me.Label4)
        Me.Tunnel.Controls.Add(Me.TextBox4)
        Me.Tunnel.Controls.Add(Me.PictureBox1)
        Me.Tunnel.Controls.Add(Me.TextBox3)
        Me.Tunnel.Controls.Add(Me.Label3)
        Me.Tunnel.Controls.Add(Me.TextBox2)
        Me.Tunnel.Controls.Add(Me.TextBox1)
        Me.Tunnel.Controls.Add(Me.Label2)
        Me.Tunnel.Controls.Add(Me.Label1)
        Me.Tunnel.Controls.Add(Me.ListBox1)
        Me.Tunnel.Controls.Add(Me.Button2)
        Me.Tunnel.Location = New System.Drawing.Point(50, 21)
        Me.Tunnel.Name = "Tunnel"
        Me.Tunnel.Size = New System.Drawing.Size(1445, 771)
        Me.Tunnel.TabIndex = 56
        Me.Tunnel.TabStop = False
        Me.Tunnel.Text = "Tunnel Status"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(532, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(242, 20)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Update Tunnels DELAY reason"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(527, 302)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(258, 184)
        Me.ListBox2.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(888, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Delay"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(797, 42)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(258, 27)
        Me.TextBox4.TabIndex = 64
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.KDM_TunnelStatus.My.Resources.Resources.Petra_Diamonds
        Me.PictureBox1.Location = New System.Drawing.Point(1090, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(349, 151)
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(527, 132)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(258, 27)
        Me.TextBox3.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(395, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Last Update"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(527, 87)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(258, 27)
        Me.TextBox2.TabIndex = 61
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(527, 42)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(258, 27)
        Me.TextBox1.TabIndex = 60
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 120000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1805, 1002)
        Me.Controls.Add(Me.Tunnel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master - Details (SQL Server) - Tunnel Status"
        Me.Tunnel.ResumeLayout(False)
        Me.Tunnel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Tunnel As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Timer1 As Timer
End Class
