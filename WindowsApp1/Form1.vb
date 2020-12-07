Imports System.Text.RegularExpressions
Imports Renci.SshNet
Imports Renci.SshNet.Common
Imports MaterialSkin
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports Newtonsoft.Json
Imports Syncfusion.DocIO.DLS
Imports Microsoft.Office.Interop

Public Class Form1
    Inherits MaterialSkin.Controls.MaterialForm
    Dim client As SshClient
    Dim stream As ShellStream
    Dim port As String = 22
    Dim appPath As String = Path.GetDirectoryName(Application.ExecutablePath)

    Private Sub InitSettings()
        LoadSetting()
        Console.WriteLine(appPath)
    End Sub

    Sub NewSetting()
        Try
            Dim json As String = File.ReadAllText(appPath + "\savedSettings.json")
            Dim Jobj = JObject.Parse(json)
            Dim config As List(Of JToken) = Jobj.Children().ToList
            Dim server As String
            Dim pass As String
            For Each item As JProperty In config
                item.CreateReader()
                Select Case item.Name
                    Case "MySettings"
                        For Each subitem As JObject In item.Values
                            server = subitem("server")
                            TxtConnectIpAddr.Items.Add(server)
                            Console.WriteLine("server: " + server + "|" + "pass : " + pass)
                        Next
                End Select
            Next
        Catch ex As Exception
            Console.WriteLine("No settings found")
        End Try


    End Sub

    Sub LoadSetting()
        Try
            Dim json As String = File.ReadAllText(appPath + "\savedSettings.json")
            Dim Jobj = JObject.Parse(json)
            Dim config As List(Of JToken) = Jobj.Children().ToList
            Dim server As String
            Dim pass As String

            Dim user As String
            TxtConnectIpAddr.Text = Jobj.Item("server")

            TxtPw.Text = Jobj.Item("pass").ToString
            TxtUser.Text = Jobj.Item("user").ToString
            For Each item As JProperty In config
                item.CreateReader()
                ' Select Case item.Name
                '  Case "MySettings"
                ' For Each subitem As JObject In item.Values

                '   If server = serverName Then
                Console.WriteLine(item.Children.Values)


                '  End If
                '  Next
                ' End Select
            Next
        Catch ex As Exception
            Console.WriteLine("No setting file")
        End Try



    End Sub
    Sub Form1_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        InitSettings()
        Try
            '   TxtConnectIpAddr.Text = TxtConnectIpAddr.Items(0)
        Catch ex As Exception
            '   Console.WriteLine("Couldnt find settings")
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT

        SkinManager.ColorScheme = New ColorScheme(Primary.Blue900, Primary.Blue700, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE)
        Panel2.Visible = False
    End Sub
    Private Sub BtnConnect_Click() Handles BtnConnect.Click


        saveSetting()

        If BtnConnect.Text Like "Connect" Then
            If TxtConnectIpAddr.Text.Length > 0 Then
                BtnConnect.Enabled = False
            Else MessageBox.Show("Missing Information")
                Return
            End If
            If TxtUser.Text.Length > 0 Then
                BtnConnect.Enabled = False
            Else MessageBox.Show("Missing Information")
                Return
            End If
            If TxtPw.Text.Length > 0 Then
                BtnConnect.Enabled = False
            Else MessageBox.Show("Missing Information")
                Return
            End If

            Dim password = TxtPw.Text
            port = 22
            Dim username = TxtUser.Text
            Dim server = TxtConnectIpAddr.Text
            Dim connectionInfo = New PasswordConnectionInfo(server, port, username, password)
            TxtResp.AppendText("Connecting..." & vbCrLf)
            connectionInfo.Timeout = TimeSpan.FromSeconds(15)
                Connect(connectionInfo)


            ElseIf BtnConnect.Text Like "Disconnect" Then
                Disconnect()
        End If
    End Sub

    Private Sub Connect(connectionInfo As [PasswordConnectionInfo])
        Try
            ' Create a SshClient
            client = New SshClient(connectionInfo)
            Try
                client.Connect()

            Catch ex As Exception
                MessageBox.Show("Unable to connect")
                TxtResp.AppendText("Connection failed -- Check login information")
            End Try


            'If it doesn't throw an exception set the button name to Disconnect.
            BtnConnect.Text = "Disconnect"

            stream = client.CreateShellStream("CLI", 0, 0, 0, 0, 1024)

            ' Connected.
            TxtResp.AppendText("Connected." & vbCrLf)
            stream.Flush()
            TimerRecv.Enabled = True
            Panel1.Visible = False
            Panel2.Visible = True
            DocsBtn.Visible = True

        Catch e As ArgumentException
            Debug.WriteLine("Host or Username is invalid: {0}", e)
            BtnConnect.Text = "Connect"
        Catch e As SshException
            Debug.WriteLine("SshException: {0}", e)
            BtnConnect.Text = "Connect"
        End Try
    End Sub

    Private Sub BtnSend_Click() Handles BtnSend.Click
        Try
            ' Send the message to the connected DUT. 
            Dim cmd = TxtSend.Text
            stream.WriteLine(cmd)
            stream.Flush()
            TxtResp.AppendText("Sent: " & cmd & vbCrLf)
            Debug.WriteLine("Sent:" & cmd)
            TxtSend.Clear()
            'Enable a 1000ms receive timer to compensate for network delay.
            TimerRecv.Enabled = True
        Catch e As ArgumentNullException
            Debug.WriteLine("ArgumentNullException: {0}", e)
            'Console.WriteLine("ArgumentNullException: {0}", e)

        End Try
    End Sub

    Private Sub Wait() Handles TimerRecv.Tick
        TimerRecv.Enabled = False
        GetResponse()
    End Sub
    Private Sub Wait2() Handles TimerRecv2.Tick
        TimerRecv2.Enabled = False
        LoansLoad()
    End Sub
    Private Sub Wait3() Handles TimerRecv3.Tick
        TimerRecv3.Enabled = False
        PTypesLoad()
    End Sub
    Private Sub Wait4() Handles TimerRecv4.Tick
        TimerRecv4.Enabled = False
        GetResponse2()
    End Sub
    Private Sub Wait5() Handles TimerRecv5.Tick
        TimerRecv5.Enabled = False
        DocsLoad()
    End Sub
    Private Sub Wait6() Handles TimerRecv6.Tick
        TimerRecv6.Enabled = False
        DocsCreateResponse()
    End Sub

    Private Sub GetResponse()
        ' Read the first batch of the SshServer response .
        If stream.DataAvailable Then
            Dim strResponse = stream.Read()

            TxtResp.AppendText("Received: " & strResponse & vbCrLf)
            Debug.WriteLine("Received:" & strResponse)

        Else
            TxtResp.AppendText("No response" & vbCrLf)
            Debug.WriteLine("No response")
        End If

    End Sub
    Private Sub GetResponse2()

        ' Clear the list before populating 
        packageName.Enabled = True
        packageName.Items.Clear()
        Dim cmdLength = 24 + packageType.SelectedItem.ToString.Length
        If stream.DataAvailable Then
            Dim strResponse = stream.Read()
            strResponse = strResponse.Remove(0, cmdLength)
            strResponse = Replace(strResponse, ">", "")
            strResponse = Replace(strResponse, vbCrLf, "")
            Console.WriteLine(strResponse)
            Console.WriteLine("Made it GetResponse2 function")
            Dim x As New List(Of String)(strResponse.Split("�"c))
            For Each item In x

                packageName.Items.Add(item)
            Next

        Else
            Debug.WriteLine("No response")
        End If

    End Sub
    Private Sub PTypesLoad()
        packageType.Enabled = True
        packageType.DropDownStyle = ComboBoxStyle.DropDown
        ' Clear the list before populating 
        packageType.Items.Clear()
        Dim cmdLength = 25 + loanTypesList.SelectedItem.ToString.Length
        If stream.DataAvailable Then
            Dim strResponse = stream.Read()
            strResponse = strResponse.Remove(0, cmdLength)
            strResponse = strResponse.TrimEnd(">")
            strResponse = Replace(strResponse, vbCrLf, "")
            Console.WriteLine(strResponse)
            Dim y As New List(Of String)(strResponse.Split("0."))
            y(1).TrimStart("0.")

            Dim x As New List(Of String)(y(1).Split("�"c))
            x(0) = x(0).TrimStart(".")
            Console.WriteLine(x(0))
            For Each item In x
                TxtResp.AppendText(item)
                packageType.Items.Add(item)
            Next
            packageType.DropDownStyle = ComboBoxStyle.DropDownList
        Else
            TxtResp.AppendText("No response" & vbCrLf)
            Debug.WriteLine("No response")
        End If

    End Sub

    Private Sub ClientRef_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ClientRef.KeyDown

        If e.KeyCode = Keys.Enter Then
            Try
                ' Send the message to the connected DUT. 
                stream.Flush()
                Dim cmd = "HEX.GET.ACCS " + ClientRef.Text
                stream.WriteLine(cmd)
                stream.Flush()
                Debug.WriteLine("Sent:" & cmd)
                'Enable a 1000ms receive timer to compensate for network delay.
                ' Load the Loan List
                TimerRecv2.Enabled = True


            Catch err As ArgumentNullException
                Debug.WriteLine("ArgumentNullException: {0}", err)
                'Console.WriteLine("ArgumentNullException: {0}", e)
            End Try


        End If

    End Sub

    Private Sub Disconnect()
        Try
            TxtResp.AppendText("Disconnecting...")
            stream.WriteLine("OFF")
            stream.Close()
            client.Disconnect()
            BtnConnect.Text = "Connect"
            TxtResp.AppendText("Done!" & vbCrLf)
        Catch e As ObjectDisposedException
            Debug.WriteLine("ObjectDisposedException: {0}", e)
        End Try

    End Sub

    Private Sub LoansLoad()
        loanTypesList.Enabled = True
        loanTypesList.DropDownStyle = ComboBoxStyle.DropDown
        ' Clear the list before populating 
        loanTypesList.Items.Clear()
        packageType.Items.Clear()
        packageName.Items.Clear()
        packageType.Enabled = False
        packageName.Enabled = False
        Dim lengthClient = ClientRef.Text.Length
        Dim cmdLength = 13 + lengthClient
        If stream.DataAvailable Then
            Dim strResponse = stream.Read()
            strResponse = strResponse.Remove(0, cmdLength)
            strResponse = strResponse.TrimEnd(">")
            strResponse = Replace(strResponse, vbCrLf, "")
            Console.WriteLine(strResponse)
            Console.WriteLine("Made it loansload function")
            Dim x As New List(Of String)(strResponse.Split("�"c))
            For Each item In x

                TxtResp.AppendText(item)
                loanTypesList.Items.Add(item)
            Next
            loanTypesList.DropDownStyle = ComboBoxStyle.DropDownList
        Else
            TxtResp.AppendText("No response" & vbCrLf)
            Debug.WriteLine("No response")
        End If
    End Sub




    Private Sub BtnExit_Click_1(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim confirm = MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.YesNo)
        Console.WriteLine(confirm)
        If confirm = 6 Then
            Disconnect()
            Me.Close()
        End If

    End Sub

    Function saveSetting()
        If TxtConnectIpAddr.Text = "" Or TxtPw.Text = "" Or TxtUser.Text = "" Then

        Else
            Console.WriteLine("saving..")
            Dim myPlayer As New Players()
            myPlayer.server = TxtConnectIpAddr.Text
            myPlayer.user = TxtUser.Text
            myPlayer.pass = TxtPw.Text
            ' Dim location As String = My.Computer.FileSystem.SpecialDirectories.Desktop
            Dim json As String = Newtonsoft.Json.JsonConvert.SerializeObject(myPlayer)
            Try
                My.Computer.FileSystem.DeleteFile(appPath + "\savedSettings.json")
            Catch ex As Exception
                Console.WriteLine("No setting file to delete")
            End Try

            Dim file As IO.StreamWriter

            file = My.Computer.FileSystem.OpenTextFileWriter(appPath + "\savedSettings.json", True)
            file.Write(json)
            file.Close()
        End If
    End Function



    Private Sub DocsBtn_Click(sender As Object, e As EventArgs) Handles DocsBtn.Click
        Panel1.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub loanTypesList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles loanTypesList.SelectedIndexChanged
        Try
            ' Send the message to the connected DUT. 
            Dim cmd = "RUN HEX.BP HEX.GETPTYPES " + loanTypesList.SelectedItem.ToString
            stream.WriteLine(cmd)
            stream.Flush()
            Debug.WriteLine("Sent:" & cmd)
            'Enable a 1000ms receive timer to compensate for network delay.
            ' Load the Package List
            TimerRecv3.Enabled = True


        Catch err As ArgumentNullException
            Debug.WriteLine("ArgumentNullException: {0}", err)
            'Console.WriteLine("ArgumentNullException: {0}", e)
        End Try
    End Sub

    Private Sub packageType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles packageType.SelectedIndexChanged
        Try
            ' Send the message to the connected DUT. 
            Dim cmd = "RUN HEX.BP HEX.GETPACKS " + packageType.SelectedItem.ToString
            stream.WriteLine(cmd)
            stream.Flush()
            Debug.WriteLine("Sent:" & cmd)
            'Enable a 1000ms receive timer to compensate for network delay.
            ' Load the Package List
            TimerRecv4.Enabled = True


        Catch err As ArgumentNullException
            Debug.WriteLine("ArgumentNullException: {0}", err)
            'Console.WriteLine("ArgumentNullException: {0}", e)
        End Try
    End Sub
    Private Sub GetDocs()
        Try

            Dim cmd = "RUN HEX.BP HEX.GETPACKDOCS " + packageType.SelectedItem.ToString + "~" + packageName.SelectedItem.ToString
            stream.WriteLine(cmd)
            stream.Flush()
            Debug.WriteLine("Sent:" & cmd)
            'Enable a 1000ms receive timer to compensate for network delay.
            ' Load the Package List
            TimerRecv5.Enabled = True
            CreateDoc.Enabled = True

        Catch err As ArgumentNullException
            Debug.WriteLine("ArgumentNullException: {0}", err)
            'Console.WriteLine("ArgumentNullException: {0}", e)
        End Try
    End Sub
    Private Sub DocsLoad()

        ' Clear the list before populating 
        DocsList.Items.Clear()
        Dim cmdLength = 28 + packageType.SelectedItem.ToString.Length + packageName.SelectedItem.ToString.Length
        If stream.DataAvailable Then
            Dim strResponse = stream.Read()
            strResponse = strResponse.TrimStart
            strResponse = strResponse.Remove(0, cmdLength)
            strResponse = strResponse.TrimEnd(">")
            strResponse = Replace(strResponse, vbCrLf, "")
            Console.WriteLine(strResponse)
            Console.WriteLine("Made it GetResponse2 function")
            Dim x As New List(Of String)(strResponse.Split("�"c))
            For Each item In x

                DocsList.Items.Add(item)
            Next

        Else
            Debug.WriteLine("No response")
        End If

    End Sub

    Private Sub packageName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles packageName.SelectedIndexChanged
        GetDocs()
    End Sub
    ' ---------------------------------------------------------------------------------------------------------------------------------
    ' SFTP Setup and Functions 
    Function SftpFiles(List)

        Dim RemoteFiles = List
        Dim server As String = TxtConnectIpAddr.Text
        Dim username As String = TxtUser.Text
        Dim password As String = TxtPw.Text
        Dim connectionInfo = New PasswordConnectionInfo(server, port, username, password)
        Dim downloadedFiles As New List(Of String)
        Using sftp As New SftpClient(connectionInfo)

            'connect to the server
            sftp.Connect()

            'the name of the remote file we want to transfer to the PC


            'download the file as a memory stream and convert to a file stream
            Using ms As New MemoryStream
                Dim WorkingDirectory As String = "/vtcudev/VTU.TRN/HEX.DOCDUMP/"


                'Try
                'sftp.ChangeDirectory(WorkingDirectory)
                'Console.WriteLine("SFTP working directory = " + sftp.WorkingDirectory)
                'Catch e As Exception
                'Console.WriteLine(e)
                'End Try


                For Each file In List
                    Dim localPath = file.remove(0, WorkingDirectory.Length)
                    Dim filePaths As String = "C:\Users\dotto\Downloads\" + localPath + ".txt"
                    downloadedFiles.Add(filePaths)
                    Try
                        Console.WriteLine(filePaths)
                        'download as memory stream
                        sftp.DownloadFile(file.ToString, ms)
                        'create a file stream
                        Dim fs As New FileStream(filePaths, FileMode.Create, FileAccess.Write)
                        'write the memory stream to the file stream
                        ms.WriteTo(fs)
                        ' TimerRecv7.Enabled = True

                        'close file stream
                        fs.Close()
                    Catch err As Exception
                        Console.WriteLine(err)
                    End Try

                Next


                'close memory stream
                ms.Close()
            End Using

            'disconnect from the server
            sftp.Disconnect()


        End Using
        MsgBox("The file has been downloaded from the server.", MsgBoxStyle.Information)
        WordOpen(downloadedFiles)

    End Function

    Private Sub CreateDoc_Click(sender As Object, e As EventArgs) Handles CreateDoc.Click
        CreateDocs()
    End Sub

    Private Sub CreateDocs()
        Try
            ' Send the message to the connected DUT. 
            Dim cmd = "RUN HEX.BP HEX.MERGEDOC " + ClientRef.Text + loanTypesList.Text + " " + packageType.Text + "~" + packageName.Text
            stream.WriteLine(cmd)
            stream.Flush()
            Debug.WriteLine("Sent:" & cmd)
            'Enable a 1000ms receive timer to compensate for network delay.
            TimerRecv6.Enabled = True
        Catch err As ArgumentNullException
            Debug.WriteLine("ArgumentNullException: {0}", err)
            'Console.WriteLine("ArgumentNullException: {0}", e)
        End Try
    End Sub
    Private Sub DocsCreateResponse()

        Console.WriteLine(stream.DataAvailable)
        Dim cmdLength = 28 + packageType.SelectedItem.ToString.Length + packageName.SelectedItem.ToString.Length
        cmdLength = cmdLength + 7
        If stream.DataAvailable Then
            Dim strResponse = stream.Read()
            Console.WriteLine("Initial Response:" + strResponse)
            strResponse = strResponse.TrimStart
            strResponse = strResponse.Remove(0, cmdLength)
            strResponse = strResponse.TrimEnd(">")
            strResponse = Replace(strResponse, vbCrLf, "")
            Console.WriteLine("Response: " + vbCrLf + strResponse)
            Dim x As New List(Of String)(strResponse.Split("�"c))
            Dim LocalFiles As New List(Of String)
            Dim RemoteFiles As New List(Of String)
            For Each item In x
                If item.ToString.Contains(":\") Then
                    LocalFiles.Add(item)
                    Console.WriteLine("Local File:" + item.ToString)

                ElseIf item.ToString.Contains(ClientRef.Text) Then
                    Console.WriteLine("Download Path :" + item.ToString)
                    RemoteFiles.Add(item)
                End If

            Next
            SftpFiles(RemoteFiles)
        Else
            Debug.WriteLine("No response")
        End If

    End Sub

    Private Sub TxtConnectIpAddr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TxtConnectIpAddr.SelectedIndexChanged
        '         LoadSetting(TxtConnectIpAddr.Text)
    End Sub
    Private Sub WordOpen(fp)
        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        For Each item In fp

            oWord = CreateObject("Word.Application")
            oWord.Visible = True

            oDoc = oWord.Documents.Add(Template:="C:\Users\dotto\Documents\HEXD\test.doc")
            oDoc.MailMerge.MainDocumentType = Word.WdMailMergeMainDocType.wdFormLetters
            oDoc.MailMerge.OpenDataSource(Name:=item.ToString)


            With oDoc.MailMerge
                .Destination = Word.WdMailMergeDestination.wdSendToNewDocument
                .SuppressBlankLines = True

                With .DataSource
                    .FirstRecord = 1
                    .LastRecord = 1

                End With
                .Execute(Pause:=True)
            End With

            ' Me.Close()

        Next
        'Start Word and open the document template.

    End Sub


End Class


