<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalculateGrade
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnCalculate = New Button()
        BtnExit = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(40, 110)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(75, 23)
        btnCalculate.TabIndex = 2
        btnCalculate.Text = "&Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(193, 110)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(75, 23)
        BtnExit.TabIndex = 3
        BtnExit.Text = "E&xit"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(168, 35)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 1
        TextBox1.Text = "txtNumberGrade"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(168, 72)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 5
        TextBox2.TabStop = False
        TextBox2.Text = "txtLetterGrade"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 15)
        Label1.TabIndex = 0
        Label1.Text = "&NumberGrade:"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 15)
        Label2.TabIndex = 4
        Label2.Text = "LetterGrade:"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' frmCalculateGrade
        ' 
        AcceptButton = btnCalculate
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = BtnExit
        ClientSize = New Size(322, 167)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(BtnExit)
        Controls.Add(btnCalculate)
        Name = "frmCalculateGrade"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calculate Letter Grade"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
