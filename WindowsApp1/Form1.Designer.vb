<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TxtResp = New System.Windows.Forms.TextBox()
        Me.TxtPw = New System.Windows.Forms.TextBox()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.TxtSend = New System.Windows.Forms.TextBox()
        Me.TimerRecv = New System.Windows.Forms.Timer(Me.components)
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.FileSystemWatcher2 = New System.IO.FileSystemWatcher()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.BtnSend = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.BtnConnect = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.TxtConnectIpAddr = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DocsBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.packageName = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.packageType = New System.Windows.Forms.ComboBox()
        Me.ClientRef = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.loanTypesList = New System.Windows.Forms.ComboBox()
        Me.loanType = New MaterialSkin.Controls.MaterialLabel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CreateDoc = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.DocsList = New System.Windows.Forms.ListView()
        Me.BtnExit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TimerRecv2 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerRecv3 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerRecv4 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerRecv5 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerRecv6 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerRecv7 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtResp
        '
        Me.TxtResp.Location = New System.Drawing.Point(56, 202)
        Me.TxtResp.Multiline = True
        Me.TxtResp.Name = "TxtResp"
        Me.TxtResp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtResp.Size = New System.Drawing.Size(721, 147)
        Me.TxtResp.TabIndex = 5
        '
        'TxtPw
        '
        Me.TxtPw.Location = New System.Drawing.Point(505, 76)
        Me.TxtPw.Name = "TxtPw"
        Me.TxtPw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPw.Size = New System.Drawing.Size(124, 20)
        Me.TxtPw.TabIndex = 4
        '
        'TxtUser
        '
        Me.TxtUser.Location = New System.Drawing.Point(505, 37)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(124, 20)
        Me.TxtUser.TabIndex = 3
        '
        'TxtSend
        '
        Me.TxtSend.Location = New System.Drawing.Point(354, 153)
        Me.TxtSend.Name = "TxtSend"
        Me.TxtSend.Size = New System.Drawing.Size(275, 20)
        Me.TxtSend.TabIndex = 5
        Me.TxtSend.Visible = False
        '
        'TimerRecv
        '
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'FileSystemWatcher2
        '
        Me.FileSystemWatcher2.EnableRaisingEvents = True
        Me.FileSystemWatcher2.SynchronizingObject = Me
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(173, 39)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(93, 19)
        Me.MaterialLabel2.TabIndex = 15
        Me.MaterialLabel2.Text = "I.P Address :"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(451, 40)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(48, 19)
        Me.MaterialLabel3.TabIndex = 16
        Me.MaterialLabel3.Text = "User :"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(416, 75)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(83, 19)
        Me.MaterialLabel4.TabIndex = 17
        Me.MaterialLabel4.Text = "Password :"
        '
        'BtnSend
        '
        Me.BtnSend.Depth = 0
        Me.BtnSend.Location = New System.Drawing.Point(683, 151)
        Me.BtnSend.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Primary = True
        Me.BtnSend.Size = New System.Drawing.Size(94, 23)
        Me.BtnSend.TabIndex = 19
        Me.BtnSend.Text = "Send"
        Me.BtnSend.UseVisualStyleBackColor = True
        Me.BtnSend.Visible = False
        '
        'BtnConnect
        '
        Me.BtnConnect.Depth = 0
        Me.BtnConnect.Location = New System.Drawing.Point(683, 37)
        Me.BtnConnect.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Primary = True
        Me.BtnConnect.Size = New System.Drawing.Size(94, 33)
        Me.BtnConnect.TabIndex = 6
        Me.BtnConnect.Text = "Connect"
        Me.BtnConnect.UseVisualStyleBackColor = True
        '
        'TxtConnectIpAddr
        '
        Me.TxtConnectIpAddr.FormattingEnabled = True
        Me.TxtConnectIpAddr.Location = New System.Drawing.Point(272, 37)
        Me.TxtConnectIpAddr.Name = "TxtConnectIpAddr"
        Me.TxtConnectIpAddr.Size = New System.Drawing.Size(121, 21)
        Me.TxtConnectIpAddr.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DocsBtn)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Controls.Add(Me.MaterialLabel2)
        Me.Panel1.Controls.Add(Me.TxtConnectIpAddr)
        Me.Panel1.Controls.Add(Me.TxtResp)
        Me.Panel1.Controls.Add(Me.BtnConnect)
        Me.Panel1.Controls.Add(Me.BtnSend)
        Me.Panel1.Controls.Add(Me.TxtPw)
        Me.Panel1.Controls.Add(Me.MaterialLabel4)
        Me.Panel1.Controls.Add(Me.TxtUser)
        Me.Panel1.Controls.Add(Me.MaterialLabel3)
        Me.Panel1.Controls.Add(Me.TxtSend)
        Me.Panel1.Location = New System.Drawing.Point(0, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 379)
        Me.Panel1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(613, 358)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "© Hexagon Technology Ltd Pty"
        '
        'DocsBtn
        '
        Me.DocsBtn.BackColor = System.Drawing.SystemColors.Control
        Me.DocsBtn.Depth = 0
        Me.DocsBtn.Location = New System.Drawing.Point(683, 95)
        Me.DocsBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.DocsBtn.Name = "DocsBtn"
        Me.DocsBtn.Primary = True
        Me.DocsBtn.Size = New System.Drawing.Size(94, 23)
        Me.DocsBtn.TabIndex = 23
        Me.DocsBtn.Text = "Docs.."
        Me.DocsBtn.UseVisualStyleBackColor = False
        Me.DocsBtn.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.Visible = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(31, 22)
        Me.ToolStripLabel1.Text = "Save"
        Me.ToolStripLabel1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.ProgressBar1)
        Me.Panel2.Location = New System.Drawing.Point(0, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(797, 379)
        Me.Panel2.TabIndex = 22
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.MaterialLabel5)
        Me.Panel3.Controls.Add(Me.packageName)
        Me.Panel3.Controls.Add(Me.MaterialLabel7)
        Me.Panel3.Controls.Add(Me.MaterialLabel8)
        Me.Panel3.Controls.Add(Me.packageType)
        Me.Panel3.Controls.Add(Me.ClientRef)
        Me.Panel3.Controls.Add(Me.loanTypesList)
        Me.Panel3.Controls.Add(Me.loanType)
        Me.Panel3.Location = New System.Drawing.Point(-3, -9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 106)
        Me.Panel3.TabIndex = 6
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(12, 16)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(127, 19)
        Me.MaterialLabel5.TabIndex = 2
        Me.MaterialLabel5.Text = "Client Reference :"
        '
        'packageName
        '
        Me.packageName.BackColor = System.Drawing.SystemColors.ControlLight
        Me.packageName.Enabled = False
        Me.packageName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.packageName.FormattingEnabled = True
        Me.packageName.Location = New System.Drawing.Point(571, 61)
        Me.packageName.Name = "packageName"
        Me.packageName.Size = New System.Drawing.Size(121, 21)
        Me.packageName.TabIndex = 4
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(414, 22)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(110, 19)
        Me.MaterialLabel7.TabIndex = 2
        Me.MaterialLabel7.Text = "Package Type :"
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(398, 60)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(126, 19)
        Me.MaterialLabel8.TabIndex = 3
        Me.MaterialLabel8.Text = "Package Names :"
        '
        'packageType
        '
        Me.packageType.BackColor = System.Drawing.SystemColors.ControlLight
        Me.packageType.Enabled = False
        Me.packageType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.packageType.FormattingEnabled = True
        Me.packageType.Location = New System.Drawing.Point(571, 20)
        Me.packageType.Name = "packageType"
        Me.packageType.Size = New System.Drawing.Size(121, 21)
        Me.packageType.TabIndex = 3
        '
        'ClientRef
        '
        Me.ClientRef.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientRef.Depth = 0
        Me.ClientRef.Hint = ""
        Me.ClientRef.Location = New System.Drawing.Point(159, 16)
        Me.ClientRef.MouseState = MaterialSkin.MouseState.HOVER
        Me.ClientRef.Name = "ClientRef"
        Me.ClientRef.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ClientRef.SelectedText = ""
        Me.ClientRef.SelectionLength = 0
        Me.ClientRef.SelectionStart = 0
        Me.ClientRef.Size = New System.Drawing.Size(118, 23)
        Me.ClientRef.TabIndex = 1
        Me.ClientRef.UseSystemPasswordChar = False
        '
        'loanTypesList
        '
        Me.loanTypesList.BackColor = System.Drawing.SystemColors.ControlLight
        Me.loanTypesList.Enabled = False
        Me.loanTypesList.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.loanTypesList.FormattingEnabled = True
        Me.loanTypesList.Location = New System.Drawing.Point(159, 55)
        Me.loanTypesList.Name = "loanTypesList"
        Me.loanTypesList.Size = New System.Drawing.Size(121, 21)
        Me.loanTypesList.TabIndex = 2
        '
        'loanType
        '
        Me.loanType.AutoSize = True
        Me.loanType.Depth = 0
        Me.loanType.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.loanType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.loanType.Location = New System.Drawing.Point(53, 57)
        Me.loanType.MouseState = MaterialSkin.MouseState.HOVER
        Me.loanType.Name = "loanType"
        Me.loanType.Size = New System.Drawing.Size(86, 19)
        Me.loanType.TabIndex = 3
        Me.loanType.Text = "Loan Type :"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.CreateDoc)
        Me.Panel4.Controls.Add(Me.DocsList)
        Me.Panel4.Controls.Add(Me.BtnExit)
        Me.Panel4.Location = New System.Drawing.Point(0, 93)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(794, 268)
        Me.Panel4.TabIndex = 7
        '
        'CreateDoc
        '
        Me.CreateDoc.BackColor = System.Drawing.SystemColors.Control
        Me.CreateDoc.Depth = 0
        Me.CreateDoc.Enabled = False
        Me.CreateDoc.Location = New System.Drawing.Point(711, 216)
        Me.CreateDoc.MouseState = MaterialSkin.MouseState.HOVER
        Me.CreateDoc.Name = "CreateDoc"
        Me.CreateDoc.Primary = True
        Me.CreateDoc.Size = New System.Drawing.Size(75, 23)
        Me.CreateDoc.TabIndex = 8
        Me.CreateDoc.Text = "CREATE"
        Me.CreateDoc.UseVisualStyleBackColor = False
        '
        'DocsList
        '
        Me.DocsList.Location = New System.Drawing.Point(-3, -2)
        Me.DocsList.Name = "DocsList"
        Me.DocsList.Size = New System.Drawing.Size(798, 173)
        Me.DocsList.TabIndex = 7
        Me.DocsList.UseCompatibleStateImageBehavior = False
        Me.DocsList.View = System.Windows.Forms.View.List
        '
        'BtnExit
        '
        Me.BtnExit.Depth = 0
        Me.BtnExit.Location = New System.Drawing.Point(614, 216)
        Me.BtnExit.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Primary = True
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 6
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(-3, 358)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(803, 21)
        Me.ProgressBar1.TabIndex = 5
        '
        'TimerRecv2
        '
        '
        'TimerRecv3
        '
        '
        'TimerRecv4
        '
        '
        'TimerRecv5
        '
        '
        'TimerRecv6
        '
        Me.TimerRecv6.Interval = 500
        '
        'TimerRecv7
        '
        Me.TimerRecv7.Interval = 2000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(800, 450)
        Me.MinimumSize = New System.Drawing.Size(800, 450)
        Me.Name = "Form1"
        Me.Text = "HexDocs"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtResp As TextBox
    Friend WithEvents TxtPw As TextBox
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents TxtSend As TextBox
    Friend WithEvents TimerRecv As Timer
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents FileSystemWatcher2 As IO.FileSystemWatcher
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BtnConnect As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents BtnSend As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents TxtConnectIpAddr As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ClientRef As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents loanType As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents loanTypesList As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents packageName As ComboBox
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents packageType As ComboBox
    Friend WithEvents DocsList As ListView
    Friend WithEvents BtnExit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents DocsBtn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents TimerRecv2 As Timer
    Friend WithEvents TimerRecv3 As Timer
    Friend WithEvents TimerRecv4 As Timer
    Friend WithEvents TimerRecv5 As Timer
    Friend WithEvents CreateDoc As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents TimerRecv6 As Timer
    Friend WithEvents TimerRecv7 As Timer
    Friend WithEvents Label1 As Label
End Class
