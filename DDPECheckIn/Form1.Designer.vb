<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDDPECheckIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDDPECheckIn))
        Me.btnSetRegistry = New System.Windows.Forms.Button()
        Me.btnChkRegKeys = New System.Windows.Forms.Button()
        Me.lblRegInvStatus = New System.Windows.Forms.Label()
        Me.lblRegInvKey = New System.Windows.Forms.Label()
        Me.lblRegPingStatus = New System.Windows.Forms.Label()
        Me.lblRegPingKey = New System.Windows.Forms.Label()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSetRegistry
        '
        Me.btnSetRegistry.Location = New System.Drawing.Point(164, 12)
        Me.btnSetRegistry.Name = "btnSetRegistry"
        Me.btnSetRegistry.Size = New System.Drawing.Size(137, 51)
        Me.btnSetRegistry.TabIndex = 0
        Me.btnSetRegistry.Text = "Create Keys"
        Me.btnSetRegistry.UseVisualStyleBackColor = True
        '
        'btnChkRegKeys
        '
        Me.btnChkRegKeys.Location = New System.Drawing.Point(12, 12)
        Me.btnChkRegKeys.Name = "btnChkRegKeys"
        Me.btnChkRegKeys.Size = New System.Drawing.Size(123, 51)
        Me.btnChkRegKeys.TabIndex = 1
        Me.btnChkRegKeys.Text = "Check Resgistry Status"
        Me.btnChkRegKeys.UseVisualStyleBackColor = True
        '
        'lblRegInvStatus
        '
        Me.lblRegInvStatus.AutoSize = True
        Me.lblRegInvStatus.Location = New System.Drawing.Point(9, 83)
        Me.lblRegInvStatus.Name = "lblRegInvStatus"
        Me.lblRegInvStatus.Size = New System.Drawing.Size(91, 13)
        Me.lblRegInvStatus.TabIndex = 2
        Me.lblRegInvStatus.Text = "InventoryRefresh:"
        '
        'lblRegInvKey
        '
        Me.lblRegInvKey.AutoSize = True
        Me.lblRegInvKey.Location = New System.Drawing.Point(106, 83)
        Me.lblRegInvKey.Name = "lblRegInvKey"
        Me.lblRegInvKey.Size = New System.Drawing.Size(24, 13)
        Me.lblRegInvKey.TabIndex = 3
        Me.lblRegInvKey.Text = "Idle"
        '
        'lblRegPingStatus
        '
        Me.lblRegPingStatus.AutoSize = True
        Me.lblRegPingStatus.Location = New System.Drawing.Point(9, 99)
        Me.lblRegPingStatus.Name = "lblRegPingStatus"
        Me.lblRegPingStatus.Size = New System.Drawing.Size(54, 13)
        Me.lblRegPingStatus.TabIndex = 4
        Me.lblRegPingStatus.Text = "PingPoxy:"
        '
        'lblRegPingKey
        '
        Me.lblRegPingKey.AutoSize = True
        Me.lblRegPingKey.Location = New System.Drawing.Point(106, 99)
        Me.lblRegPingKey.Name = "lblRegPingKey"
        Me.lblRegPingKey.Size = New System.Drawing.Size(24, 13)
        Me.lblRegPingKey.TabIndex = 5
        Me.lblRegPingKey.Text = "Idle"
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(274, 84)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(27, 28)
        Me.btnHelp.TabIndex = 6
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'frmDDPECheckIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 126)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblRegPingKey)
        Me.Controls.Add(Me.lblRegPingStatus)
        Me.Controls.Add(Me.lblRegInvKey)
        Me.Controls.Add(Me.lblRegInvStatus)
        Me.Controls.Add(Me.btnChkRegKeys)
        Me.Controls.Add(Me.btnSetRegistry)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDDPECheckIn"
        Me.Text = "DDPE Check In Utility"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSetRegistry As System.Windows.Forms.Button
    Friend WithEvents btnChkRegKeys As System.Windows.Forms.Button
    Friend WithEvents lblRegInvStatus As System.Windows.Forms.Label
    Friend WithEvents lblRegInvKey As System.Windows.Forms.Label
    Friend WithEvents lblRegPingStatus As System.Windows.Forms.Label
    Friend WithEvents lblRegPingKey As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button

End Class
