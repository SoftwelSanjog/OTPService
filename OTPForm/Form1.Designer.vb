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
        Me.txtOTP = New System.Windows.Forms.TextBox()
        Me.txtVerifyOTP = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtOTP
        '
        Me.txtOTP.Location = New System.Drawing.Point(12, 29)
        Me.txtOTP.Name = "txtOTP"
        Me.txtOTP.Size = New System.Drawing.Size(100, 20)
        Me.txtOTP.TabIndex = 0
        '
        'txtVerifyOTP
        '
        Me.txtVerifyOTP.Location = New System.Drawing.Point(12, 107)
        Me.txtVerifyOTP.Name = "txtVerifyOTP"
        Me.txtVerifyOTP.Size = New System.Drawing.Size(100, 20)
        Me.txtVerifyOTP.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(136, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Verify"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Received OTP Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Verify OTP Code"
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(136, 26)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 6
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(198, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Generated in this Form"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(207, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Verified From Server"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 160)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtVerifyOTP)
        Me.Controls.Add(Me.txtOTP)
        Me.Name = "Form1"
        Me.Text = "OTP CODE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOTP As TextBox
    Friend WithEvents txtVerifyOTP As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
