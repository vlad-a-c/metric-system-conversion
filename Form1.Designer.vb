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
        Me.num_meters = New System.Windows.Forms.TextBox()
        Me.result = New System.Windows.Forms.TextBox()
        Me.yards_selection = New System.Windows.Forms.RadioButton()
        Me.feet_selection = New System.Windows.Forms.RadioButton()
        Me.inches_selection = New System.Windows.Forms.RadioButton()
        Me.show_results = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.button_exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'num_meters
        '
        Me.num_meters.AccessibleName = "enter the number of meters to be converted"
        Me.num_meters.Location = New System.Drawing.Point(0, 0)
        Me.num_meters.Name = "num_meters"
        Me.num_meters.Size = New System.Drawing.Size(100, 22)
        Me.num_meters.TabIndex = 0
        '
        'result
        '
        Me.result.AccessibleName = "result"
        Me.result.Location = New System.Drawing.Point(8, 8)
        Me.result.Name = "result"
        Me.result.ReadOnly = True
        Me.result.Size = New System.Drawing.Size(100, 22)
        Me.result.TabIndex = 1
        Me.result.Visible = False
        '
        'yards_selection
        '
        Me.yards_selection.AccessibleName = "yards"
        Me.yards_selection.AutoSize = True
        Me.yards_selection.Location = New System.Drawing.Point(0, 8)
        Me.yards_selection.Name = "yards_selection"
        Me.yards_selection.Size = New System.Drawing.Size(115, 21)
        Me.yards_selection.TabIndex = 3
        Me.yards_selection.TabStop = True
        Me.yards_selection.Text = "RadioButton1"
        Me.yards_selection.UseVisualStyleBackColor = True
        Me.yards_selection.Visible = False
        '
        'feet_selection
        '
        Me.feet_selection.AccessibleName = "feet"
        Me.feet_selection.AutoSize = True
        Me.feet_selection.Location = New System.Drawing.Point(8, 16)
        Me.feet_selection.Name = "feet_selection"
        Me.feet_selection.Size = New System.Drawing.Size(115, 21)
        Me.feet_selection.TabIndex = 4
        Me.feet_selection.TabStop = True
        Me.feet_selection.Text = "RadioButton1"
        Me.feet_selection.UseVisualStyleBackColor = True
        Me.feet_selection.Visible = False
        '
        'inches_selection
        '
        Me.inches_selection.AccessibleName = "inches"
        Me.inches_selection.AutoSize = True
        Me.inches_selection.Location = New System.Drawing.Point(16, 24)
        Me.inches_selection.Name = "inches_selection"
        Me.inches_selection.Size = New System.Drawing.Size(115, 21)
        Me.inches_selection.TabIndex = 5
        Me.inches_selection.TabStop = True
        Me.inches_selection.Text = "RadioButton1"
        Me.inches_selection.UseVisualStyleBackColor = True
        Me.inches_selection.Visible = False
        '
        'show_results
        '
        Me.show_results.AccessibleName = "show results"
        Me.show_results.Location = New System.Drawing.Point(363, 214)
        Me.show_results.Name = "show_results"
        Me.show_results.Size = New System.Drawing.Size(75, 23)
        Me.show_results.TabIndex = 6
        Me.show_results.Text = "Button1"
        Me.show_results.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.AccessibleName = "reset"
        Me.reset.Location = New System.Drawing.Point(371, 222)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(75, 23)
        Me.reset.TabIndex = 7
        Me.reset.Text = "Button1"
        Me.reset.UseVisualStyleBackColor = True
        '
        'button_exit
        '
        Me.button_exit.AccessibleName = "exit"
        Me.button_exit.Location = New System.Drawing.Point(379, 230)
        Me.button_exit.Name = "button_exit"
        Me.button_exit.Size = New System.Drawing.Size(75, 23)
        Me.button_exit.TabIndex = 8
        Me.button_exit.Text = "Button1"
        Me.button_exit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.button_exit)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.show_results)
        Me.Controls.Add(Me.inches_selection)
        Me.Controls.Add(Me.feet_selection)
        Me.Controls.Add(Me.yards_selection)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.num_meters)
        Me.Name = "Form1"
        Me.Text = "vlad c productions metric system"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents num_meters As TextBox
    Friend WithEvents result As TextBox
    Friend WithEvents yards_selection As RadioButton
    Friend WithEvents feet_selection As RadioButton
    Friend WithEvents inches_selection As RadioButton
    Friend WithEvents show_results As Button
    Friend WithEvents reset As Button
    Friend WithEvents button_exit As Button
End Class
