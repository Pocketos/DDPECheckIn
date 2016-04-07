Public Class frmDDPECheckIn
    REM Creates registry values
    Dim InvRefresh As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\CMGShield"
    Dim Ping As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Credant\CMGShield\Notify"
    Dim RegInvRefresh As String = "SOFTWARE\Microsoft\Windows NT\CurrentVersion\Winlogon\CMGShield"
    Dim RegPing As String = "SOFTWARE\Credant\CMGShield\Notify"
    Dim InvReadValue As String
    Dim PingReadValue As String
    Dim version As Integer = 1


    Private Sub btnSetRegistry_Click(sender As Object, e As EventArgs) Handles btnSetRegistry.Click
        My.Computer.Registry.LocalMachine.CreateSubKey(RegInvRefresh)
        My.Computer.Registry.SetValue(InvRefresh, "RefreshInventory", 1)
        My.Computer.Registry.LocalMachine.CreateSubKey(RegPing)
        My.Computer.Registry.SetValue(Ping, "PingProxy", 1)
        MessageBox.Show("Entries addes Successfully!", "Entries added")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnChkRegKeys.Click
        If My.Computer.Registry.GetValue(InvRefresh, "RefreshInventory", Nothing) Is Nothing Then
            MsgBox("RefreshInventory Value Doesn't Exist")
            InvReadValue = "No RefreshInventory Value Exists"
        Else
            InvReadValue = My.Computer.Registry.GetValue(InvRefresh, "RefreshInventory", Nothing)
            MsgBox("Value Exisits!" & InvReadValue)
        End If

        If My.Computer.Registry.GetValue(Ping, "PingProxy", Nothing) Is Nothing Then
            MsgBox("PingProxy Value Doesn't Exist")
            PingReadValue = "No PingProxy Value Exists"
        Else
            PingReadValue = My.Computer.Registry.GetValue(Ping, "PingProxy", Nothing)
            MsgBox("Value Exisits!" & PingReadValue)
        End If

        lblRegInvKey.Text = InvReadValue
        lblRegPingKey.Text = PingReadValue
    End Sub

    Private Sub frmDDPECheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.Registry.GetValue(InvRefresh, "RefreshInventory", Nothing) Is Nothing Then
            InvReadValue = "No RefreshInventory Value Exists"
        Else
            InvReadValue = My.Computer.Registry.GetValue(InvRefresh, "RefreshInventory", Nothing)
        End If

        If My.Computer.Registry.GetValue(Ping, "PingProxy", Nothing) Is Nothing Then
            PingReadValue = "No PingProxy Value Exists"
        Else
            PingReadValue = My.Computer.Registry.GetValue(Ping, "PingProxy", Nothing)
        End If

        lblRegInvKey.Text = InvReadValue
        lblRegPingKey.Text = PingReadValue

    End Sub

    Private Sub lblRegPingKey_Click(sender As Object, e As EventArgs) Handles lblRegPingKey.Click

    End Sub

    Private Sub lblRegInvKey_Click(sender As Object, e As EventArgs) Handles lblRegInvKey.Click

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MessageBox.Show("Version " & version, "Help")
    End Sub
End Class
