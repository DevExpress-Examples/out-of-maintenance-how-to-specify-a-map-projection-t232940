Namespace MapProjections
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.lbProjection = New System.Windows.Forms.ListBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.panel1 = New System.Windows.Forms.Panel()
            CType(Me.mapControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'mapControl
            '
            Me.mapControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mapControl.Location = New System.Drawing.Point(5, 5)
            Me.mapControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.Size = New System.Drawing.Size(683, 630)
            Me.mapControl.TabIndex = 0
            '
            'lbProjection
            '
            Me.lbProjection.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lbProjection.FormattingEnabled = True
            Me.lbProjection.ItemHeight = 16
            Me.lbProjection.Location = New System.Drawing.Point(5, 22)
            Me.lbProjection.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.lbProjection.Name = "lbProjection"
            Me.lbProjection.Size = New System.Drawing.Size(257, 608)
            Me.lbProjection.TabIndex = 1
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.label1.Location = New System.Drawing.Point(5, 5)
            Me.label1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(111, 17)
            Me.label1.TabIndex = 2
            Me.label1.Text = "Projection class:"
            '
            'panel1
            '
            Me.panel1.Controls.Add(Me.lbProjection)
            Me.panel1.Controls.Add(Me.label1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(688, 5)
            Me.panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.panel1.Name = "panel1"
            Me.panel1.Padding = New System.Windows.Forms.Padding(5, 5, 5, 0)
            Me.panel1.Size = New System.Drawing.Size(267, 630)
            Me.panel1.TabIndex = 3
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(960, 640)
            Me.Controls.Add(Me.mapControl)
            Me.Controls.Add(Me.panel1)
            Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
            Me.Name = "Form1"
            Me.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
            Me.Text = "Form1"
            CType(Me.mapControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private mapControl As DevExpress.XtraMap.MapControl
        Private WithEvents lbProjection As System.Windows.Forms.ListBox
        Private label1 As System.Windows.Forms.Label
        Private panel1 As System.Windows.Forms.Panel
    End Class
End Namespace

