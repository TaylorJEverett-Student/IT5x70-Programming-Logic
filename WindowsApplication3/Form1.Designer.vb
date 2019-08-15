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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblLogoa = New System.Windows.Forms.Label()
        Me.lblLogob = New System.Windows.Forms.Label()
        Me.lblLogoc = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.srcBar = New System.Windows.Forms.HScrollBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picBox = New System.Windows.Forms.PictureBox()
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLogoa
        '
        Me.lblLogoa.AutoSize = True
        Me.lblLogoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogoa.ForeColor = System.Drawing.Color.Green
        Me.lblLogoa.Location = New System.Drawing.Point(534, 50)
        Me.lblLogoa.Name = "lblLogoa"
        Me.lblLogoa.Size = New System.Drawing.Size(51, 51)
        Me.lblLogoa.TabIndex = 0
        Me.lblLogoa.Text = "A"
        '
        'lblLogob
        '
        Me.lblLogob.AutoSize = True
        Me.lblLogob.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogob.ForeColor = System.Drawing.Color.Blue
        Me.lblLogob.Location = New System.Drawing.Point(581, 50)
        Me.lblLogob.Name = "lblLogob"
        Me.lblLogob.Size = New System.Drawing.Size(51, 51)
        Me.lblLogob.TabIndex = 1
        Me.lblLogob.Text = "B"
        '
        'lblLogoc
        '
        Me.lblLogoc.AutoSize = True
        Me.lblLogoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogoc.ForeColor = System.Drawing.Color.Yellow
        Me.lblLogoc.Location = New System.Drawing.Point(626, 50)
        Me.lblLogoc.Name = "lblLogoc"
        Me.lblLogoc.Size = New System.Drawing.Size(53, 51)
        Me.lblLogoc.TabIndex = 2
        Me.lblLogoc.Text = "C"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(41, 70)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(109, 38)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(176, 70)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(109, 38)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(306, 70)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(109, 38)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(520, 234)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(109, 38)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(520, 158)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(188, 20)
        Me.txtEmail.TabIndex = 7
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(520, 208)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(188, 20)
        Me.txtPhone.TabIndex = 8
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(517, 181)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(78, 13)
        Me.lblPhone.TabIndex = 9
        Me.lblPhone.Text = "Phone Number"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(517, 132)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 10
        Me.lblEmail.Text = "Email"
        '
        'srcBar
        '
        Me.srcBar.Location = New System.Drawing.Point(44, 19)
        Me.srcBar.Name = "srcBar"
        Me.srcBar.Size = New System.Drawing.Size(371, 35)
        Me.srcBar.TabIndex = 11
        '
        'Timer1
        '
        '
        'picBox
        '
        Me.picBox.Image = CType(resources.GetObject("picBox.Image"), System.Drawing.Image)
        Me.picBox.Location = New System.Drawing.Point(-100, 291)
        Me.picBox.Name = "picBox"
        Me.picBox.Size = New System.Drawing.Size(105, 82)
        Me.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox.TabIndex = 12
        Me.picBox.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 416)
        Me.Controls.Add(Me.picBox)
        Me.Controls.Add(Me.srcBar)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblLogoc)
        Me.Controls.Add(Me.lblLogob)
        Me.Controls.Add(Me.lblLogoa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLogoa As Label
    Friend WithEvents lblLogob As Label
    Friend WithEvents lblLogoc As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents srcBar As HScrollBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picBox As PictureBox
End Class
