<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Multiplication_Table
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStartFrom = New System.Windows.Forms.TextBox()
        Me.txtEndBy = New System.Windows.Forms.TextBox()
        Me.lst1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "End By"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Start From"
        '
        'txtStartFrom
        '
        Me.txtStartFrom.Location = New System.Drawing.Point(110, 12)
        Me.txtStartFrom.Name = "txtStartFrom"
        Me.txtStartFrom.Size = New System.Drawing.Size(50, 22)
        Me.txtStartFrom.TabIndex = 3
        '
        'txtEndBy
        '
        Me.txtEndBy.Location = New System.Drawing.Point(261, 12)
        Me.txtEndBy.Name = "txtEndBy"
        Me.txtEndBy.Size = New System.Drawing.Size(50, 22)
        Me.txtEndBy.TabIndex = 4
        '
        'lst1
        '
        Me.lst1.FormattingEnabled = True
        Me.lst1.ItemHeight = 16
        Me.lst1.Location = New System.Drawing.Point(15, 54)
        Me.lst1.Name = "lst1"
        Me.lst1.Size = New System.Drawing.Size(427, 580)
        Me.lst1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(335, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 37)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Multiplication_Table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 732)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lst1)
        Me.Controls.Add(Me.txtEndBy)
        Me.Controls.Add(Me.txtStartFrom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Multiplication_Table"
        Me.Text = "Multiplication Table"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtStartFrom As TextBox
    Friend WithEvents txtEndBy As TextBox
    Friend WithEvents lst1 As ListBox
    Friend WithEvents Button1 As Button
End Class
