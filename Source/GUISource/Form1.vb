Option Strict Off
Option Explicit On 
Imports VB = Microsoft.VisualBasic
Public Class Form1
    Inherits System.Windows.Forms.Form
    ' valor a receber e a actualizar da posição dos braços
    Public valSend As String = " "
    Public valArm1 As Integer = 0
    Public valArm2 As Integer = 0
    Public valArm3 As Integer = 0
    Public valArm4 As Integer = 0
    Public valArm5 As Integer = 0
    Public valArm6 As Integer = 0
    'valor local da posição dos braços
    Public valBut1 As Integer = 128
    Public valBut2 As Integer = 128
    Public valBut3 As Integer = 128
    Public valBut4 As Integer = 128
    Public valBut5 As Integer = 128
    Friend WithEvents posMotor1 As System.Windows.Forms.TextBox
    Friend WithEvents posMotor2 As System.Windows.Forms.TextBox
    Friend WithEvents posMotor3 As System.Windows.Forms.TextBox
    Friend WithEvents posMotor4 As System.Windows.Forms.TextBox
    Friend WithEvents posMotor5 As System.Windows.Forms.TextBox
    Friend WithEvents posMotor6 As System.Windows.Forms.TextBox
    Public valBut6 As Integer = 128

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents grpBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents grpBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents grpBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents grpBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents grpBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents but1Up As System.Windows.Forms.Button
    Friend WithEvents but1Down As System.Windows.Forms.Button
    Friend WithEvents but1Stop As System.Windows.Forms.Button
    Friend WithEvents pos1 As System.Windows.Forms.TrackBar
    Friend WithEvents but2Stop As System.Windows.Forms.Button
    Friend WithEvents but2Down As System.Windows.Forms.Button
    Friend WithEvents pos2 As System.Windows.Forms.TrackBar
    Friend WithEvents but2Up As System.Windows.Forms.Button
    Friend WithEvents but3Stop As System.Windows.Forms.Button
    Friend WithEvents but3Down As System.Windows.Forms.Button
    Friend WithEvents pos3 As System.Windows.Forms.TrackBar
    Friend WithEvents but3Up As System.Windows.Forms.Button
    Friend WithEvents but4Stop As System.Windows.Forms.Button
    Friend WithEvents but4Down As System.Windows.Forms.Button
    Friend WithEvents pos4 As System.Windows.Forms.TrackBar
    Friend WithEvents but4Up As System.Windows.Forms.Button
    Friend WithEvents but5Stop As System.Windows.Forms.Button
    Friend WithEvents but5Down As System.Windows.Forms.Button
    Friend WithEvents pos5 As System.Windows.Forms.TrackBar
    Friend WithEvents but5Up As System.Windows.Forms.Button
    Friend WithEvents but6Stop As System.Windows.Forms.Button
    Friend WithEvents but6Down As System.Windows.Forms.Button
    Friend WithEvents pos6 As System.Windows.Forms.TrackBar
    Friend WithEvents but6Up As System.Windows.Forms.Button
    Friend WithEvents picBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents picBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents picRed As System.Windows.Forms.PictureBox
    Friend WithEvents picGreen As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Timers.Timer
    Friend WithEvents MSComm1 As AxMSCommLib.AxMSComm
    Friend WithEvents pwrButton As System.Windows.Forms.Button
    Friend WithEvents stpButton As System.Windows.Forms.Button
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtVal1 As System.Windows.Forms.TextBox
    Friend WithEvents txtVal2 As System.Windows.Forms.TextBox
    Friend WithEvents txtVal3 As System.Windows.Forms.TextBox
    Friend WithEvents txtVal4 As System.Windows.Forms.TextBox
    Friend WithEvents txtVal5 As System.Windows.Forms.TextBox
    Friend WithEvents txtVal6 As System.Windows.Forms.TextBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents Timer2 As System.Timers.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.but1Up = New System.Windows.Forms.Button
        Me.but1Down = New System.Windows.Forms.Button
        Me.but1Stop = New System.Windows.Forms.Button
        Me.pos1 = New System.Windows.Forms.TrackBar
        Me.grpBox1 = New System.Windows.Forms.GroupBox
        Me.txtVal1 = New System.Windows.Forms.TextBox
        Me.picBox1 = New System.Windows.Forms.PictureBox
        Me.grpBox2 = New System.Windows.Forms.GroupBox
        Me.but2Stop = New System.Windows.Forms.Button
        Me.but2Down = New System.Windows.Forms.Button
        Me.pos2 = New System.Windows.Forms.TrackBar
        Me.but2Up = New System.Windows.Forms.Button
        Me.picBox2 = New System.Windows.Forms.PictureBox
        Me.txtVal2 = New System.Windows.Forms.TextBox
        Me.grpBox3 = New System.Windows.Forms.GroupBox
        Me.but3Stop = New System.Windows.Forms.Button
        Me.but3Down = New System.Windows.Forms.Button
        Me.pos3 = New System.Windows.Forms.TrackBar
        Me.but3Up = New System.Windows.Forms.Button
        Me.txtVal3 = New System.Windows.Forms.TextBox
        Me.grpBox4 = New System.Windows.Forms.GroupBox
        Me.but4Stop = New System.Windows.Forms.Button
        Me.but4Down = New System.Windows.Forms.Button
        Me.pos4 = New System.Windows.Forms.TrackBar
        Me.but4Up = New System.Windows.Forms.Button
        Me.picBox4 = New System.Windows.Forms.PictureBox
        Me.txtVal4 = New System.Windows.Forms.TextBox
        Me.grpBox5 = New System.Windows.Forms.GroupBox
        Me.but5Stop = New System.Windows.Forms.Button
        Me.but5Down = New System.Windows.Forms.Button
        Me.pos5 = New System.Windows.Forms.TrackBar
        Me.but5Up = New System.Windows.Forms.Button
        Me.picBox5 = New System.Windows.Forms.PictureBox
        Me.txtVal5 = New System.Windows.Forms.TextBox
        Me.grpBox6 = New System.Windows.Forms.GroupBox
        Me.but6Stop = New System.Windows.Forms.Button
        Me.but6Down = New System.Windows.Forms.Button
        Me.pos6 = New System.Windows.Forms.TrackBar
        Me.but6Up = New System.Windows.Forms.Button
        Me.picBox6 = New System.Windows.Forms.PictureBox
        Me.txtVal6 = New System.Windows.Forms.TextBox
        Me.picBox3 = New System.Windows.Forms.PictureBox
        Me.picRed = New System.Windows.Forms.PictureBox
        Me.picGreen = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Timers.Timer
        Me.MSComm1 = New AxMSCommLib.AxMSComm
        Me.pwrButton = New System.Windows.Forms.Button
        Me.stpButton = New System.Windows.Forms.Button
        Me.txtStatus = New System.Windows.Forms.TextBox
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.Timer2 = New System.Timers.Timer
        Me.posMotor1 = New System.Windows.Forms.TextBox
        Me.posMotor2 = New System.Windows.Forms.TextBox
        Me.posMotor3 = New System.Windows.Forms.TextBox
        Me.posMotor4 = New System.Windows.Forms.TextBox
        Me.posMotor5 = New System.Windows.Forms.TextBox
        Me.posMotor6 = New System.Windows.Forms.TextBox
        CType(Me.pos1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBox1.SuspendLayout()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBox2.SuspendLayout()
        CType(Me.pos2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBox3.SuspendLayout()
        CType(Me.pos3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBox4.SuspendLayout()
        CType(Me.pos4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBox5.SuspendLayout()
        CType(Me.pos5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBox6.SuspendLayout()
        CType(Me.pos6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MSComm1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Timer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'but1Up
        '
        Me.but1Up.Image = CType(resources.GetObject("but1Up.Image"), System.Drawing.Image)
        Me.but1Up.Location = New System.Drawing.Point(8, 48)
        Me.but1Up.Name = "but1Up"
        Me.but1Up.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.but1Up.Size = New System.Drawing.Size(56, 56)
        Me.but1Up.TabIndex = 0
        '
        'but1Down
        '
        Me.but1Down.Image = CType(resources.GetObject("but1Down.Image"), System.Drawing.Image)
        Me.but1Down.Location = New System.Drawing.Point(8, 160)
        Me.but1Down.Name = "but1Down"
        Me.but1Down.Size = New System.Drawing.Size(56, 56)
        Me.but1Down.TabIndex = 1
        '
        'but1Stop
        '
        Me.but1Stop.Image = CType(resources.GetObject("but1Stop.Image"), System.Drawing.Image)
        Me.but1Stop.Location = New System.Drawing.Point(8, 104)
        Me.but1Stop.Name = "but1Stop"
        Me.but1Stop.Size = New System.Drawing.Size(56, 56)
        Me.but1Stop.TabIndex = 12
        '
        'pos1
        '
        Me.pos1.Enabled = False
        Me.pos1.Location = New System.Drawing.Point(64, 40)
        Me.pos1.Maximum = 51
        Me.pos1.Name = "pos1"
        Me.pos1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.pos1.Size = New System.Drawing.Size(45, 184)
        Me.pos1.TabIndex = 24
        Me.pos1.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'grpBox1
        '
        Me.grpBox1.Controls.Add(Me.posMotor1)
        Me.grpBox1.Controls.Add(Me.txtVal1)
        Me.grpBox1.Controls.Add(Me.but1Stop)
        Me.grpBox1.Controls.Add(Me.but1Down)
        Me.grpBox1.Controls.Add(Me.pos1)
        Me.grpBox1.Controls.Add(Me.but1Up)
        Me.grpBox1.Controls.Add(Me.picBox1)
        Me.grpBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBox1.Location = New System.Drawing.Point(16, 184)
        Me.grpBox1.Name = "grpBox1"
        Me.grpBox1.Size = New System.Drawing.Size(120, 256)
        Me.grpBox1.TabIndex = 26
        Me.grpBox1.TabStop = False
        Me.grpBox1.Text = "ARM 0"
        '
        'txtVal1
        '
        Me.txtVal1.Enabled = False
        Me.txtVal1.Location = New System.Drawing.Point(0, 224)
        Me.txtVal1.Name = "txtVal1"
        Me.txtVal1.Size = New System.Drawing.Size(64, 20)
        Me.txtVal1.TabIndex = 33
        Me.txtVal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picBox1
        '
        Me.picBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBox1.Enabled = False
        Me.picBox1.Image = CType(resources.GetObject("picBox1.Image"), System.Drawing.Image)
        Me.picBox1.Location = New System.Drawing.Point(16, 24)
        Me.picBox1.Name = "picBox1"
        Me.picBox1.Size = New System.Drawing.Size(88, 16)
        Me.picBox1.TabIndex = 32
        Me.picBox1.TabStop = False
        '
        'grpBox2
        '
        Me.grpBox2.Controls.Add(Me.posMotor2)
        Me.grpBox2.Controls.Add(Me.but2Stop)
        Me.grpBox2.Controls.Add(Me.but2Down)
        Me.grpBox2.Controls.Add(Me.pos2)
        Me.grpBox2.Controls.Add(Me.but2Up)
        Me.grpBox2.Controls.Add(Me.picBox2)
        Me.grpBox2.Controls.Add(Me.txtVal2)
        Me.grpBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBox2.Location = New System.Drawing.Point(144, 184)
        Me.grpBox2.Name = "grpBox2"
        Me.grpBox2.Size = New System.Drawing.Size(120, 256)
        Me.grpBox2.TabIndex = 27
        Me.grpBox2.TabStop = False
        Me.grpBox2.Text = "ARM 1"
        '
        'but2Stop
        '
        Me.but2Stop.Image = CType(resources.GetObject("but2Stop.Image"), System.Drawing.Image)
        Me.but2Stop.Location = New System.Drawing.Point(8, 104)
        Me.but2Stop.Name = "but2Stop"
        Me.but2Stop.Size = New System.Drawing.Size(56, 56)
        Me.but2Stop.TabIndex = 12
        '
        'but2Down
        '
        Me.but2Down.Image = CType(resources.GetObject("but2Down.Image"), System.Drawing.Image)
        Me.but2Down.Location = New System.Drawing.Point(8, 160)
        Me.but2Down.Name = "but2Down"
        Me.but2Down.Size = New System.Drawing.Size(56, 56)
        Me.but2Down.TabIndex = 1
        '
        'pos2
        '
        Me.pos2.Enabled = False
        Me.pos2.Location = New System.Drawing.Point(64, 40)
        Me.pos2.Maximum = 51
        Me.pos2.Name = "pos2"
        Me.pos2.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.pos2.Size = New System.Drawing.Size(45, 184)
        Me.pos2.TabIndex = 24
        Me.pos2.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'but2Up
        '
        Me.but2Up.Image = CType(resources.GetObject("but2Up.Image"), System.Drawing.Image)
        Me.but2Up.Location = New System.Drawing.Point(8, 48)
        Me.but2Up.Name = "but2Up"
        Me.but2Up.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.but2Up.Size = New System.Drawing.Size(56, 56)
        Me.but2Up.TabIndex = 0
        '
        'picBox2
        '
        Me.picBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBox2.Enabled = False
        Me.picBox2.Image = CType(resources.GetObject("picBox2.Image"), System.Drawing.Image)
        Me.picBox2.Location = New System.Drawing.Point(16, 24)
        Me.picBox2.Name = "picBox2"
        Me.picBox2.Size = New System.Drawing.Size(88, 16)
        Me.picBox2.TabIndex = 33
        Me.picBox2.TabStop = False
        '
        'txtVal2
        '
        Me.txtVal2.Enabled = False
        Me.txtVal2.Location = New System.Drawing.Point(0, 224)
        Me.txtVal2.Name = "txtVal2"
        Me.txtVal2.Size = New System.Drawing.Size(64, 20)
        Me.txtVal2.TabIndex = 40
        Me.txtVal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpBox3
        '
        Me.grpBox3.Controls.Add(Me.posMotor3)
        Me.grpBox3.Controls.Add(Me.but3Stop)
        Me.grpBox3.Controls.Add(Me.but3Down)
        Me.grpBox3.Controls.Add(Me.pos3)
        Me.grpBox3.Controls.Add(Me.but3Up)
        Me.grpBox3.Controls.Add(Me.txtVal3)
        Me.grpBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBox3.Location = New System.Drawing.Point(272, 184)
        Me.grpBox3.Name = "grpBox3"
        Me.grpBox3.Size = New System.Drawing.Size(120, 256)
        Me.grpBox3.TabIndex = 28
        Me.grpBox3.TabStop = False
        Me.grpBox3.Text = "ARM 2"
        '
        'but3Stop
        '
        Me.but3Stop.Image = CType(resources.GetObject("but3Stop.Image"), System.Drawing.Image)
        Me.but3Stop.Location = New System.Drawing.Point(8, 104)
        Me.but3Stop.Name = "but3Stop"
        Me.but3Stop.Size = New System.Drawing.Size(56, 56)
        Me.but3Stop.TabIndex = 12
        '
        'but3Down
        '
        Me.but3Down.Image = CType(resources.GetObject("but3Down.Image"), System.Drawing.Image)
        Me.but3Down.Location = New System.Drawing.Point(8, 160)
        Me.but3Down.Name = "but3Down"
        Me.but3Down.Size = New System.Drawing.Size(56, 56)
        Me.but3Down.TabIndex = 1
        '
        'pos3
        '
        Me.pos3.Enabled = False
        Me.pos3.Location = New System.Drawing.Point(64, 40)
        Me.pos3.Maximum = 51
        Me.pos3.Name = "pos3"
        Me.pos3.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.pos3.Size = New System.Drawing.Size(45, 184)
        Me.pos3.TabIndex = 24
        Me.pos3.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'but3Up
        '
        Me.but3Up.Image = CType(resources.GetObject("but3Up.Image"), System.Drawing.Image)
        Me.but3Up.Location = New System.Drawing.Point(8, 48)
        Me.but3Up.Name = "but3Up"
        Me.but3Up.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.but3Up.Size = New System.Drawing.Size(56, 56)
        Me.but3Up.TabIndex = 0
        '
        'txtVal3
        '
        Me.txtVal3.Enabled = False
        Me.txtVal3.Location = New System.Drawing.Point(0, 222)
        Me.txtVal3.Name = "txtVal3"
        Me.txtVal3.Size = New System.Drawing.Size(64, 20)
        Me.txtVal3.TabIndex = 40
        Me.txtVal3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpBox4
        '
        Me.grpBox4.Controls.Add(Me.posMotor4)
        Me.grpBox4.Controls.Add(Me.but4Stop)
        Me.grpBox4.Controls.Add(Me.but4Down)
        Me.grpBox4.Controls.Add(Me.pos4)
        Me.grpBox4.Controls.Add(Me.but4Up)
        Me.grpBox4.Controls.Add(Me.picBox4)
        Me.grpBox4.Controls.Add(Me.txtVal4)
        Me.grpBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBox4.Location = New System.Drawing.Point(400, 184)
        Me.grpBox4.Name = "grpBox4"
        Me.grpBox4.Size = New System.Drawing.Size(120, 256)
        Me.grpBox4.TabIndex = 29
        Me.grpBox4.TabStop = False
        Me.grpBox4.Text = "ARM 3"
        '
        'but4Stop
        '
        Me.but4Stop.Image = CType(resources.GetObject("but4Stop.Image"), System.Drawing.Image)
        Me.but4Stop.Location = New System.Drawing.Point(8, 104)
        Me.but4Stop.Name = "but4Stop"
        Me.but4Stop.Size = New System.Drawing.Size(56, 56)
        Me.but4Stop.TabIndex = 12
        '
        'but4Down
        '
        Me.but4Down.Image = CType(resources.GetObject("but4Down.Image"), System.Drawing.Image)
        Me.but4Down.Location = New System.Drawing.Point(8, 160)
        Me.but4Down.Name = "but4Down"
        Me.but4Down.Size = New System.Drawing.Size(56, 56)
        Me.but4Down.TabIndex = 1
        '
        'pos4
        '
        Me.pos4.Enabled = False
        Me.pos4.Location = New System.Drawing.Point(64, 40)
        Me.pos4.Maximum = 51
        Me.pos4.Name = "pos4"
        Me.pos4.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.pos4.Size = New System.Drawing.Size(45, 184)
        Me.pos4.TabIndex = 24
        Me.pos4.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'but4Up
        '
        Me.but4Up.Image = CType(resources.GetObject("but4Up.Image"), System.Drawing.Image)
        Me.but4Up.Location = New System.Drawing.Point(8, 48)
        Me.but4Up.Name = "but4Up"
        Me.but4Up.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.but4Up.Size = New System.Drawing.Size(56, 56)
        Me.but4Up.TabIndex = 0
        '
        'picBox4
        '
        Me.picBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBox4.Enabled = False
        Me.picBox4.Image = CType(resources.GetObject("picBox4.Image"), System.Drawing.Image)
        Me.picBox4.Location = New System.Drawing.Point(16, 24)
        Me.picBox4.Name = "picBox4"
        Me.picBox4.Size = New System.Drawing.Size(88, 16)
        Me.picBox4.TabIndex = 34
        Me.picBox4.TabStop = False
        '
        'txtVal4
        '
        Me.txtVal4.Enabled = False
        Me.txtVal4.Location = New System.Drawing.Point(0, 222)
        Me.txtVal4.Name = "txtVal4"
        Me.txtVal4.Size = New System.Drawing.Size(64, 20)
        Me.txtVal4.TabIndex = 40
        Me.txtVal4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpBox5
        '
        Me.grpBox5.Controls.Add(Me.posMotor5)
        Me.grpBox5.Controls.Add(Me.but5Stop)
        Me.grpBox5.Controls.Add(Me.but5Down)
        Me.grpBox5.Controls.Add(Me.pos5)
        Me.grpBox5.Controls.Add(Me.but5Up)
        Me.grpBox5.Controls.Add(Me.picBox5)
        Me.grpBox5.Controls.Add(Me.txtVal5)
        Me.grpBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBox5.Location = New System.Drawing.Point(528, 184)
        Me.grpBox5.Name = "grpBox5"
        Me.grpBox5.Size = New System.Drawing.Size(120, 256)
        Me.grpBox5.TabIndex = 30
        Me.grpBox5.TabStop = False
        Me.grpBox5.Text = "ARM 4"
        '
        'but5Stop
        '
        Me.but5Stop.Image = CType(resources.GetObject("but5Stop.Image"), System.Drawing.Image)
        Me.but5Stop.Location = New System.Drawing.Point(8, 104)
        Me.but5Stop.Name = "but5Stop"
        Me.but5Stop.Size = New System.Drawing.Size(56, 56)
        Me.but5Stop.TabIndex = 12
        '
        'but5Down
        '
        Me.but5Down.Image = CType(resources.GetObject("but5Down.Image"), System.Drawing.Image)
        Me.but5Down.Location = New System.Drawing.Point(8, 160)
        Me.but5Down.Name = "but5Down"
        Me.but5Down.Size = New System.Drawing.Size(56, 56)
        Me.but5Down.TabIndex = 1
        '
        'pos5
        '
        Me.pos5.Enabled = False
        Me.pos5.Location = New System.Drawing.Point(64, 40)
        Me.pos5.Maximum = 51
        Me.pos5.Name = "pos5"
        Me.pos5.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.pos5.Size = New System.Drawing.Size(45, 184)
        Me.pos5.TabIndex = 24
        Me.pos5.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'but5Up
        '
        Me.but5Up.Image = CType(resources.GetObject("but5Up.Image"), System.Drawing.Image)
        Me.but5Up.Location = New System.Drawing.Point(8, 48)
        Me.but5Up.Name = "but5Up"
        Me.but5Up.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.but5Up.Size = New System.Drawing.Size(56, 56)
        Me.but5Up.TabIndex = 0
        '
        'picBox5
        '
        Me.picBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBox5.Enabled = False
        Me.picBox5.Image = CType(resources.GetObject("picBox5.Image"), System.Drawing.Image)
        Me.picBox5.Location = New System.Drawing.Point(16, 24)
        Me.picBox5.Name = "picBox5"
        Me.picBox5.Size = New System.Drawing.Size(88, 16)
        Me.picBox5.TabIndex = 34
        Me.picBox5.TabStop = False
        '
        'txtVal5
        '
        Me.txtVal5.Enabled = False
        Me.txtVal5.Location = New System.Drawing.Point(0, 224)
        Me.txtVal5.Name = "txtVal5"
        Me.txtVal5.Size = New System.Drawing.Size(64, 20)
        Me.txtVal5.TabIndex = 40
        Me.txtVal5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpBox6
        '
        Me.grpBox6.Controls.Add(Me.posMotor6)
        Me.grpBox6.Controls.Add(Me.but6Stop)
        Me.grpBox6.Controls.Add(Me.but6Down)
        Me.grpBox6.Controls.Add(Me.pos6)
        Me.grpBox6.Controls.Add(Me.but6Up)
        Me.grpBox6.Controls.Add(Me.picBox6)
        Me.grpBox6.Controls.Add(Me.txtVal6)
        Me.grpBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBox6.Location = New System.Drawing.Point(656, 184)
        Me.grpBox6.Name = "grpBox6"
        Me.grpBox6.Size = New System.Drawing.Size(120, 256)
        Me.grpBox6.TabIndex = 31
        Me.grpBox6.TabStop = False
        Me.grpBox6.Text = "ARM 5"
        '
        'but6Stop
        '
        Me.but6Stop.Image = CType(resources.GetObject("but6Stop.Image"), System.Drawing.Image)
        Me.but6Stop.Location = New System.Drawing.Point(8, 104)
        Me.but6Stop.Name = "but6Stop"
        Me.but6Stop.Size = New System.Drawing.Size(56, 56)
        Me.but6Stop.TabIndex = 12
        '
        'but6Down
        '
        Me.but6Down.Image = CType(resources.GetObject("but6Down.Image"), System.Drawing.Image)
        Me.but6Down.Location = New System.Drawing.Point(8, 160)
        Me.but6Down.Name = "but6Down"
        Me.but6Down.Size = New System.Drawing.Size(56, 56)
        Me.but6Down.TabIndex = 1
        '
        'pos6
        '
        Me.pos6.Enabled = False
        Me.pos6.Location = New System.Drawing.Point(64, 40)
        Me.pos6.Maximum = 51
        Me.pos6.Name = "pos6"
        Me.pos6.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.pos6.Size = New System.Drawing.Size(45, 184)
        Me.pos6.TabIndex = 24
        Me.pos6.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'but6Up
        '
        Me.but6Up.Image = CType(resources.GetObject("but6Up.Image"), System.Drawing.Image)
        Me.but6Up.Location = New System.Drawing.Point(8, 48)
        Me.but6Up.Name = "but6Up"
        Me.but6Up.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.but6Up.Size = New System.Drawing.Size(56, 56)
        Me.but6Up.TabIndex = 0
        '
        'picBox6
        '
        Me.picBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBox6.Enabled = False
        Me.picBox6.Image = CType(resources.GetObject("picBox6.Image"), System.Drawing.Image)
        Me.picBox6.Location = New System.Drawing.Point(16, 24)
        Me.picBox6.Name = "picBox6"
        Me.picBox6.Size = New System.Drawing.Size(88, 16)
        Me.picBox6.TabIndex = 34
        Me.picBox6.TabStop = False
        '
        'txtVal6
        '
        Me.txtVal6.Enabled = False
        Me.txtVal6.Location = New System.Drawing.Point(0, 224)
        Me.txtVal6.Name = "txtVal6"
        Me.txtVal6.Size = New System.Drawing.Size(64, 20)
        Me.txtVal6.TabIndex = 40
        Me.txtVal6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picBox3
        '
        Me.picBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picBox3.Enabled = False
        Me.picBox3.Image = CType(resources.GetObject("picBox3.Image"), System.Drawing.Image)
        Me.picBox3.Location = New System.Drawing.Point(288, 208)
        Me.picBox3.Name = "picBox3"
        Me.picBox3.Size = New System.Drawing.Size(88, 16)
        Me.picBox3.TabIndex = 33
        Me.picBox3.TabStop = False
        '
        'picRed
        '
        Me.picRed.Image = CType(resources.GetObject("picRed.Image"), System.Drawing.Image)
        Me.picRed.Location = New System.Drawing.Point(224, 512)
        Me.picRed.Name = "picRed"
        Me.picRed.Size = New System.Drawing.Size(88, 16)
        Me.picRed.TabIndex = 34
        Me.picRed.TabStop = False
        '
        'picGreen
        '
        Me.picGreen.Image = CType(resources.GetObject("picGreen.Image"), System.Drawing.Image)
        Me.picGreen.Location = New System.Drawing.Point(224, 480)
        Me.picGreen.Name = "picGreen"
        Me.picGreen.Size = New System.Drawing.Size(88, 16)
        Me.picGreen.TabIndex = 35
        Me.picGreen.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.SynchronizingObject = Me
        '
        'MSComm1
        '
        Me.MSComm1.Enabled = True
        Me.MSComm1.Location = New System.Drawing.Point(728, 16)
        Me.MSComm1.Name = "MSComm1"
        Me.MSComm1.OcxState = CType(resources.GetObject("MSComm1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MSComm1.Size = New System.Drawing.Size(38, 38)
        Me.MSComm1.TabIndex = 36
        '
        'pwrButton
        '
        Me.pwrButton.Location = New System.Drawing.Point(16, 16)
        Me.pwrButton.Name = "pwrButton"
        Me.pwrButton.Size = New System.Drawing.Size(104, 32)
        Me.pwrButton.TabIndex = 37
        Me.pwrButton.Text = "Ligar"
        '
        'stpButton
        '
        Me.stpButton.Image = CType(resources.GetObject("stpButton.Image"), System.Drawing.Image)
        Me.stpButton.Location = New System.Drawing.Point(16, 56)
        Me.stpButton.Name = "stpButton"
        Me.stpButton.Size = New System.Drawing.Size(104, 104)
        Me.stpButton.TabIndex = 38
        '
        'txtStatus
        '
        Me.txtStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtStatus.Location = New System.Drawing.Point(784, 16)
        Me.txtStatus.Multiline = True
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtStatus.Size = New System.Drawing.Size(176, 424)
        Me.txtStatus.TabIndex = 39
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        Me.Timer2.SynchronizingObject = Me
        '
        'posMotor1
        '
        Me.posMotor1.Enabled = False
        Me.posMotor1.Location = New System.Drawing.Point(58, 224)
        Me.posMotor1.Name = "posMotor1"
        Me.posMotor1.Size = New System.Drawing.Size(64, 20)
        Me.posMotor1.TabIndex = 34
        Me.posMotor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'posMotor2
        '
        Me.posMotor2.Enabled = False
        Me.posMotor2.Location = New System.Drawing.Point(58, 224)
        Me.posMotor2.Name = "posMotor2"
        Me.posMotor2.Size = New System.Drawing.Size(64, 20)
        Me.posMotor2.TabIndex = 40
        Me.posMotor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'posMotor3
        '
        Me.posMotor3.Enabled = False
        Me.posMotor3.Location = New System.Drawing.Point(58, 222)
        Me.posMotor3.Name = "posMotor3"
        Me.posMotor3.Size = New System.Drawing.Size(64, 20)
        Me.posMotor3.TabIndex = 40
        Me.posMotor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'posMotor4
        '
        Me.posMotor4.Enabled = False
        Me.posMotor4.Location = New System.Drawing.Point(56, 222)
        Me.posMotor4.Name = "posMotor4"
        Me.posMotor4.Size = New System.Drawing.Size(64, 20)
        Me.posMotor4.TabIndex = 40
        Me.posMotor4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'posMotor5
        '
        Me.posMotor5.Enabled = False
        Me.posMotor5.Location = New System.Drawing.Point(58, 224)
        Me.posMotor5.Name = "posMotor5"
        Me.posMotor5.Size = New System.Drawing.Size(64, 20)
        Me.posMotor5.TabIndex = 40
        Me.posMotor5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'posMotor6
        '
        Me.posMotor6.Enabled = False
        Me.posMotor6.Location = New System.Drawing.Point(56, 224)
        Me.posMotor6.Name = "posMotor6"
        Me.posMotor6.Size = New System.Drawing.Size(64, 20)
        Me.posMotor6.TabIndex = 40
        Me.posMotor6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(974, 460)
        Me.Controls.Add(Me.txtStatus)
        Me.Controls.Add(Me.stpButton)
        Me.Controls.Add(Me.pwrButton)
        Me.Controls.Add(Me.MSComm1)
        Me.Controls.Add(Me.picGreen)
        Me.Controls.Add(Me.picRed)
        Me.Controls.Add(Me.picBox3)
        Me.Controls.Add(Me.grpBox6)
        Me.Controls.Add(Me.grpBox5)
        Me.Controls.Add(Me.grpBox4)
        Me.Controls.Add(Me.grpBox3)
        Me.Controls.Add(Me.grpBox2)
        Me.Controls.Add(Me.grpBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "Form1"
        Me.Text = "ARMPower"
        CType(Me.pos1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBox1.ResumeLayout(False)
        Me.grpBox1.PerformLayout()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBox2.ResumeLayout(False)
        Me.grpBox2.PerformLayout()
        CType(Me.pos2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBox3.ResumeLayout(False)
        Me.grpBox3.PerformLayout()
        CType(Me.pos3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBox4.ResumeLayout(False)
        Me.grpBox4.PerformLayout()
        CType(Me.pos4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBox5.ResumeLayout(False)
        Me.grpBox5.PerformLayout()
        CType(Me.pos5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBox6.ResumeLayout(False)
        Me.grpBox6.PerformLayout()
        CType(Me.pos6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MSComm1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Timer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MSComm1.PortOpen = True
        actPos11()
        actPos22()
        actPos33()
        actPos44()
        actPos55()
        actPos66()

    End Sub

    Private Sub but1Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but1Up.Click
        If (valBut1 + 1) <= 255 Then ' validação de dados
            valBut1 = valBut1 + 1
        End If
        txtVal1.Text = valBut1
    End Sub
    Private Sub but1Up_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles but1Up.KeyUp
        actPos1()
    End Sub

    Private Sub but1Up_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles but1Up.MouseClick
        actPos1()
    End Sub


    Private Sub but2Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but2Up.Click
        If (valBut2 + 1) <= 255 Then ' validação de dados
            valBut2 = valBut2 + 1
        End If
        txtVal2.Text = valBut2
    End Sub
    Private Sub but2Up_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles but2Up.KeyUp
        actPos2()
    End Sub
    Private Sub but2Up_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles but2Up.MouseClick
        actPos2()
    End Sub

    Private Sub but3Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but3Up.Click
        If (valBut3 + 1) <= 255 Then ' validação de dados
            valBut3 = valBut3 + 1
        End If
        txtVal3.Text = valBut3
    End Sub
    Private Sub but3Up_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles but3Up.KeyUp
        actPos3()
    End Sub
    Private Sub but3Up_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles but3Up.MouseClick
        actPos3()
    End Sub


    Private Sub but4Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but4Up.Click
        If (valBut4 + 1) <= 255 Then ' validação de dados
            valBut4 = valBut4 + 1
        End If
        txtVal4.Text = valBut4
    End Sub

    Private Sub but4Up_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles but4Up.KeyUp
        actPos4()
    End Sub
    Private Sub but4Up_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles but4Up.MouseClick
        actPos4()
    End Sub

    Private Sub but5Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but5Up.Click
        If (valBut5 + 1) <= 255 Then ' validação de dados
            valBut5 = valBut5 + 1
        End If
        txtVal5.Text = valBut5

    End Sub
    Private Sub but5Up_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles but5Up.KeyUp
        actPos5()
    End Sub
    Private Sub but5Up_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles but5Up.MouseClick
        actPos5()
    End Sub

    Private Sub but6Up_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but6Up.Click
        If (valBut6 + 1) <= 255 Then ' validação de dados
            valBut6 = valBut6 + 1
        End If
        txtVal6.Text = valBut6
    End Sub
    Private Sub but6Up_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles but6Up.KeyUp
        actPos6()
    End Sub
    Private Sub but6Up_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles but6Up.MouseClick
        actPos6()
    End Sub

    Private Sub but1Down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but1Down.Click
        If (valBut1 - 1) >= 0 Then 'validação de dados
            valBut1 = valBut1 - 1
        End If
        txtVal1.Text = valBut1
    End Sub
    Private Sub but1Down_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles but1Down.KeyUp
        actPos1()
    End Sub
    Private Sub but1Down_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles but1Down.MouseClick
        actPos1()
    End Sub

    Private Sub but2Down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but2Down.Click
        If (valBut2 - 1) >= 0 Then 'validação de dados
            valBut2 = valBut2 - 1
        End If
        txtVal2.Text = valBut2
    End Sub
    Private Sub but2Down_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles but2Down.KeyUp
        actPos2()
    End Sub
    Private Sub but2Down_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles but2Down.MouseClick
        actPos2()
    End Sub
    Private Sub but3Down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but3Down.Click
        If (valBut3 - 1) >= 0 Then 'validação de dados
            valBut3 = valBut3 - 1
        End If
        txtVal3.Text = valBut3
    End Sub
    Private Sub but3Down_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles but3Down.KeyUp
        actPos3()
    End Sub
    Private Sub but3Down_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles but3Down.MouseClick
        actPos3()
    End Sub
    Private Sub but4Down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but4Down.Click
        If (valBut4 - 1) >= 0 Then 'validação de dados
            valBut4 = valBut4 - 1
        End If
        txtVal4.Text = valBut4
    End Sub
    Private Sub but4Down_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles but4Down.KeyUp
        actPos4()
    End Sub
    Private Sub but4Down_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles but4Down.MouseClick
        actPos4()
    End Sub


    Private Sub but5Down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but5Down.Click
        If (valBut5 - 1) >= 0 Then 'validação de dados
            valBut5 = valBut5 - 1
        End If
        txtVal5.Text = valBut5
    End Sub
    Private Sub but5Down_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles but5Down.KeyUp
        actPos5()
    End Sub
    Private Sub but5Down_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles but5Down.MouseClick
        actPos5()
    End Sub
    Private Sub but6Down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but6Down.Click
        If (valBut6 - 1) >= 0 Then 'validação de dados
            valBut6 = valBut6 - 1
        End If
        txtVal6.Text = valBut6
    End Sub
    Private Sub but6Down_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles but6Down.KeyUp
        actPos6()
    End Sub
    Private Sub but6Down_MouseClick6(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles but6Down.MouseClick
        actPos6()
    End Sub
    Private Sub but1Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but1Stop.Click
        forceStop1()

    End Sub

    Private Sub but2Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but2Stop.Click
        forceStop2()
    End Sub

    Private Sub but3Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but3Stop.Click
        forceStop3()
    End Sub

    Private Sub but4Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but4Stop.Click
        forceStop4()
    End Sub

    Private Sub but5Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but5Stop.Click
        forceStop5()
    End Sub

    Private Sub but6Stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but6Stop.Click
        forceStop6()
    End Sub
    Sub formatVal()
        If (Len(valSend) = 3) Then
            valSend = String.Concat("00", valSend)
        End If
        If (Len(valSend) = 4) Then
            valSend = String.Concat("0", valSend)
        End If
    End Sub
    Sub sendMsg()
        Timer2.Enabled = False
        MSComm1.Output = valSend
        Timer2.Enabled = True
    End Sub
    Sub actPos1() 'procedimento para actualizar barra de posição1
        valSend = String.Concat(valBut1, "a", "|")
        formatVal()
        sendMsg()

        If valArm1 = valBut1 Then
            picBox1.Image = picGreen.Image
            pos1.Value = valArm1 / 5 'a lógica é dividir 255 por 5, que é igual a 51 partes. cada parte representa 5. ou seja, futuros incrementos de 5 em 5
        Else
            picBox1.Image = picRed.Image
        End If
        infoBox(valSend)
    End Sub
    Sub actPos11() 'procedimento para actualizar barra de posição1
        txtVal1.Text = valBut1
        If valArm1 = valBut1 Then
            picBox1.Image = picGreen.Image
            'a lógica é dividir 255 por 5, que é igual a 51 partes. cada parte representa 5. ou seja, futuros incrementos de 5 em 5
        Else
            picBox1.Image = picRed.Image
        End If
        pos1.Value = valArm1 / 5
        posMotor1.Text = valArm1

    End Sub
    Sub actPos22() 'procedimento para actualizar barra de posição1
        txtVal2.Text = valBut2
        If valArm2 = valBut2 Then
            picBox2.Image = picGreen.Image
            'a lógica é dividir 255 por 5, que é igual a 51 partes. cada parte representa 5. ou seja, futuros incrementos de 5 em 5
        Else
            picBox2.Image = picRed.Image
        End If
        pos2.Value = valArm2 / 5
        posMotor2.Text = valArm2
    End Sub
    Sub actPos33() 'procedimento para actualizar barra de posição1
        txtVal3.Text = valBut3
        If valArm3 = valBut3 Then
            picBox3.Image = picGreen.Image
            'a lógica é dividir 255 por 5, que é igual a 51 partes. cada parte representa 5. ou seja, futuros incrementos de 5 em 5
        Else
            picBox3.Image = picRed.Image
        End If
        pos3.Value = valArm3 / 5
        posMotor3.Text = valArm3
    End Sub
    Sub actPos44() 'procedimento para actualizar barra de posição1
        txtVal4.Text = valBut4
        If valArm4 = valBut4 Then
            picBox4.Image = picGreen.Image
            'a lógica é dividir 255 por 5, que é igual a 51 partes. cada parte representa 5. ou seja, futuros incrementos de 5 em 5
        Else
            picBox4.Image = picRed.Image
        End If
        pos4.Value = valArm4 / 5
        posMotor4.Text = valArm4
    End Sub
    Sub actPos55() 'procedimento para actualizar barra de posição1
        txtVal5.Text = valBut5
        If valArm5 = valBut5 Then
            picBox5.Image = picGreen.Image
            'a lógica é dividir 255 por 5, que é igual a 51 partes. cada parte representa 5. ou seja, futuros incrementos de 5 em 5
        Else
            picBox5.Image = picRed.Image
        End If
        pos5.Value = valArm5 / 5
        posMotor5.Text = valArm5
    End Sub
    Sub actPos66() 'procedimento para actualizar barra de posição1
        txtVal6.Text = valBut6
        If valArm6 = valBut6 Then
            picBox6.Image = picGreen.Image
            'a lógica é dividir 255 por 5, que é igual a 51 partes. cada parte representa 5. ou seja, futuros incrementos de 5 em 5
        Else
            picBox6.Image = picRed.Image
        End If
        pos6.Value = valArm6 / 5
        posMotor6.Text = valArm6
    End Sub
    Sub actPos2() 'procedimento para actualizar barra de posição2
        valSend = String.Concat(valBut2, "b", "|")
        formatVal()
        sendMsg()
        txtVal2.Text = valBut2
        If valArm2 = valBut2 Then
            picBox2.Image = picGreen.Image
            pos2.Value = valArm2 / 5
        Else
            picBox2.Image = picRed.Image
        End If
        infoBox(valSend)
    End Sub
    Sub actPos3() 'procedimento para actualizar barra de posição3
        valSend = String.Concat(valBut3, "c", "|")
        formatVal()
        sendMsg()
        txtVal3.Text = valBut3
        If valArm3 = valBut3 Then
            picBox3.Image = picGreen.Image
            pos3.Value = valArm3 / 5
        Else
            picBox3.Image = picRed.Image
        End If
        infoBox(valSend)
    End Sub
    Sub actPos4() 'procedimento para actualizar barra de posição4
        valSend = String.Concat(valBut4, "d", "|")
        formatVal()
        sendMsg()
        txtVal4.Text = valBut4
        If valArm4 = valBut4 Then
            picBox4.Image = picGreen.Image
            pos4.Value = valArm4 / 5
        Else
            picBox4.Image = picRed.Image
        End If
        infoBox(valSend)
    End Sub
    Sub actPos5() 'procedimento para actualizar barra de posição5
        valSend = String.Concat(valBut5, "e", "|")
        formatVal()
        sendMsg()
        txtVal5.Text = valBut5
        If valArm5 = valBut5 Then
            picBox5.Image = picGreen.Image
            pos5.Value = valArm5 / 5
        Else
            picBox5.Image = picRed.Image
        End If
        infoBox(valSend)
    End Sub
    Sub actPos6() 'procedimento para actualizar barra de posição6
        valSend = String.Concat(valBut6, "f", "|")
        formatVal()
        sendMsg()
        txtVal6.Text = valBut6
        If valArm6 = valBut6 Then
            picBox6.Image = picGreen.Image
            pos6.Value = valArm6 / 5
        Else
            picBox6.Image = picRed.Image
        End If
        infoBox(valSend)
    End Sub
    Sub forceStop1()
        valSend = String.Concat("000", "s", "|") 'aqui pode-se trocar o stop para um número fora do valor de 0 a 255
        formatVal()
        sendMsg()
        infoBox(valSend)
    End Sub
    Sub forceStop2()
        valSend = String.Concat("001", "s", "|")
        formatVal()
        sendMsg()
        infoBox(valSend)
    End Sub
    Sub forceStop3()
        valSend = String.Concat("002", "s", "|")
        formatVal()
        sendMsg()
        infoBox(valSend)
    End Sub
    Sub forceStop4()
        valSend = String.Concat("003", "s", "|")
        formatVal()
        sendMsg()
        infoBox(valSend)
    End Sub
    Sub forceStop5()
        valSend = String.Concat("004", "s", "|")
        formatVal()
        sendMsg()
        infoBox(valSend)
    End Sub
    Sub forceStop6()
        valSend = String.Concat("005", "s", "|")
        formatVal()
        sendMsg()
        infoBox(valSend)
    End Sub
    Private Sub MSComm1_OnComm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MSComm1.OnComm

    End Sub

    Private Sub Timer1_Elapsed(ByVal sender As System.Object, ByVal e As System.Timers.ElapsedEventArgs) Handles Timer1.Elapsed
        Dim msg As String
        Dim valMsg As String
        Dim v As Integer
        valMsg = " "
        If MSComm1.InBufferCount >= 1 Then
            msg = MSComm1.Input
            infoBox(msg)


            If InStr(msg, "a") <> 0 Then
                valMsg = msg
                v = Val(valMsg)
                valArm1 = v
                actPos11()
            End If
            If InStr(valMsg, "b") <> 0 Then
                valMsg = VB.Right(valMsg, Len(valMsg) - 5) 'retira-se o indicador do braço a mexer
                v = Val(valMsg)
                valArm2 = v
                actPos22()
            End If

            If InStr(valMsg, "c") <> 0 Then
                valMsg = VB.Right(valMsg, Len(valMsg) - 5) 'retira-se o indicador do braço a mexer
                v = Val(valMsg)
                valArm3 = v
                actPos33()
            End If
            If InStr(valMsg, "d") <> 0 Then
                valMsg = VB.Right(valMsg, Len(valMsg) - 5) 'retira-se o indicador do braço a mexer
                v = Val(valMsg)
                infoBox(valMsg)
                valArm4 = v
                actPos44()
            End If
            If InStr(valMsg, "e") <> 0 Then
                valMsg = VB.Right(valMsg, Len(valMsg) - 5) 'retira-se o indicador do braço a mexer
                v = Val(valMsg)
                valArm5 = v
                actPos55()
            End If
            If InStr(valMsg, "f") <> 0 Then
                valMsg = VB.Right(valMsg, Len(valMsg) - 5) 'retira-se o indicador do braço a mexer
                v = Val(valMsg)
                valArm6 = v
                actPos66()
            End If

        End If
        valMsg = " "
        msg = " "
    End Sub
    ' procedimento que liga e desliga o timer, para leitura da porta rs232
    Private Sub pwrButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pwrButton.Click
        If pwrButton.Text = "Ligar" Then
            pwrButton.Text = "Desligar"
            Timer1.Enabled = True
            Timer2.Enabled = True
            infoBox("Connecting...")
        Else
            pwrButton.Text = "Ligar"
            Timer1.Enabled = False
            Timer2.Enabled = False
            infoBox("Disconnected!!")
        End If
    End Sub

    Private Sub infoBox(ByVal texto As String)
        txtStatus.Text = txtStatus.Text & vbNewLine & texto
        txtStatus.SelectionStart = txtStatus.Text.Length
        txtStatus.ScrollToCaret()
    End Sub

    Private Sub stpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stpButton.Click
        forceStop1()
        forceStop2()
        forceStop3()
        forceStop4()
        forceStop5()
        forceStop6()
    End Sub
    Private Sub Timer2_Elapsed(ByVal sender As System.Object, ByVal e As System.Timers.ElapsedEventArgs) Handles Timer2.Elapsed
        valSend = "jjjj|"
        sendMsg()
    End Sub
End Class
