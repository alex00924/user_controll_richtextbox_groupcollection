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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupboxCollection1 = New MetroUC.GroupboxCollection(Me.components)
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(10, 10)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 23)
        Me.TextBox1.TabIndex = 4
        '
        'GroupboxCollection1
        '
        Me.GroupboxCollection1.BorderColor = System.Drawing.Color.Black
        Me.GroupboxCollection1.BorderRadius = 1
        Me.GroupboxCollection1.BorderThickness = 1
        Me.GroupboxCollection1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.GroupboxCollection1.GroupboxCount = 5
        Me.GroupboxCollection1.Location = New System.Drawing.Point(143, 80)
        Me.GroupboxCollection1.Name = "GroupboxCollection1"
        Me.GroupboxCollection1.Size = New System.Drawing.Size(491, 538)
        Me.GroupboxCollection1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 661)
        Me.Controls.Add(Me.GroupboxCollection1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupboxCollection1 As MetroUC.GroupboxCollection
End Class
