<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NGD
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
        ynaresBlgdBtn = New Label()
        adminBldgBtn = New Label()
        courtBtn = New Label()
        Label1 = New Label()
        prrcBldgBtn = New Label()
        SuspendLayout()
        ' 
        ' ynaresBlgdBtn
        ' 
        ynaresBlgdBtn.BackColor = Color.Transparent
        ynaresBlgdBtn.Cursor = Cursors.Hand
        ynaresBlgdBtn.Font = New Font("Castellar", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ynaresBlgdBtn.ForeColor = Color.Black
        ynaresBlgdBtn.Location = New Point(405, 183)
        ynaresBlgdBtn.Name = "ynaresBlgdBtn"
        ynaresBlgdBtn.Size = New Size(95, 192)
        ynaresBlgdBtn.TabIndex = 1
        ynaresBlgdBtn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' adminBldgBtn
        ' 
        adminBldgBtn.BackColor = Color.Transparent
        adminBldgBtn.Cursor = Cursors.Hand
        adminBldgBtn.Font = New Font("Castellar", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        adminBldgBtn.ForeColor = SystemColors.Control
        adminBldgBtn.Location = New Point(271, 140)
        adminBldgBtn.Name = "adminBldgBtn"
        adminBldgBtn.Size = New Size(52, 170)
        adminBldgBtn.TabIndex = 1
        adminBldgBtn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' courtBtn
        ' 
        courtBtn.BackColor = Color.Transparent
        courtBtn.Cursor = Cursors.Hand
        courtBtn.Font = New Font("Castellar", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        courtBtn.ForeColor = Color.Black
        courtBtn.Location = New Point(405, 88)
        courtBtn.Name = "courtBtn"
        courtBtn.Size = New Size(121, 73)
        courtBtn.TabIndex = 1
        courtBtn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Castellar", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(281, 375)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 91)
        Label1.TabIndex = 1
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' prrcBldgBtn
        ' 
        prrcBldgBtn.BackColor = Color.Transparent
        prrcBldgBtn.Cursor = Cursors.Hand
        prrcBldgBtn.Font = New Font("Castellar", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        prrcBldgBtn.ForeColor = Color.Black
        prrcBldgBtn.Location = New Point(271, 386)
        prrcBldgBtn.Name = "prrcBldgBtn"
        prrcBldgBtn.Size = New Size(196, 80)
        prrcBldgBtn.TabIndex = 1
        prrcBldgBtn.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' NGD
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._123
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(794, 489)
        Controls.Add(adminBldgBtn)
        Controls.Add(prrcBldgBtn)
        Controls.Add(Label1)
        Controls.Add(courtBtn)
        Controls.Add(ynaresBlgdBtn)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "NGD"
        Text = "NGD"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ynaresBlgdBtn As Label
    Friend WithEvents adminBldgBtn As Label
    Friend WithEvents courtBtn As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents prrcBldgBtn As Label
End Class
