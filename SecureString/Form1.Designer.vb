<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Button1 = New Button()
        TextBoxInput = New TextBox()
        TextBoxKey = New TextBox()
        LinkLabel1 = New LinkLabel()
        Button2 = New Button()
        TextBoxResult = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(514, 241)
        Button1.Name = "Button1"
        Button1.Size = New Size(73, 27)
        Button1.TabIndex = 0
        Button1.Text = "Enc"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBoxInput
        ' 
        TextBoxInput.Location = New Point(28, 47)
        TextBoxInput.Name = "TextBoxInput"
        TextBoxInput.Size = New Size(644, 27)
        TextBoxInput.TabIndex = 1
        ' 
        ' TextBoxKey
        ' 
        TextBoxKey.Location = New Point(514, 125)
        TextBoxKey.Multiline = True
        TextBoxKey.Name = "TextBoxKey"
        TextBoxKey.Size = New Size(158, 110)
        TextBoxKey.TabIndex = 2
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(261, 285)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(165, 20)
        LinkLabel1.TabIndex = 3
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "LeVeL23HackTools.CoM"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(599, 241)
        Button2.Name = "Button2"
        Button2.Size = New Size(73, 27)
        Button2.TabIndex = 4
        Button2.Text = "Dec"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBoxResult
        ' 
        TextBoxResult.Location = New Point(28, 99)
        TextBoxResult.Multiline = True
        TextBoxResult.Name = "TextBoxResult"
        TextBoxResult.Size = New Size(480, 169)
        TextBoxResult.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(28, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 20)
        Label1.TabIndex = 8
        Label1.Text = "Input:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(28, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 20)
        Label2.TabIndex = 9
        Label2.Text = "Output:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(514, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(188, 20)
        Label3.TabIndex = 10
        Label3.Text = "Key: (Long 16, 24, 32 bytes)"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(702, 314)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBoxResult)
        Controls.Add(Button2)
        Controls.Add(LinkLabel1)
        Controls.Add(TextBoxKey)
        Controls.Add(TextBoxInput)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "SecureString by dEEpEst [LeVeL23HackTools.CoM]"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxInput As TextBox
    Friend WithEvents TextBoxKey As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBoxResult As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
