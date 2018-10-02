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
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.btn_tampil = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txt_sekolah = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_alamat = New System.Windows.Forms.TextBox()
        Me.txt_agama = New System.Windows.Forms.TextBox()
        Me.txt_tempatlahir = New System.Windows.Forms.TextBox()
        Me.ComboBox_kelamin = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nisn = New System.Windows.Forms.TextBox()
        Me.txt_nis = New System.Windows.Forms.TextBox()
        Me.txt_nama = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(629, 252)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 23)
        Me.btn_update.TabIndex = 54
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(629, 438)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 53
        Me.Button4.Text = "Keluar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(629, 280)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(75, 23)
        Me.btn_hapus.TabIndex = 52
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'btn_simpan
        '
        Me.btn_simpan.Location = New System.Drawing.Point(629, 223)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(75, 23)
        Me.btn_simpan.TabIndex = 51
        Me.btn_simpan.Text = "Simpan"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'btn_tampil
        '
        Me.btn_tampil.Location = New System.Drawing.Point(629, 194)
        Me.btn_tampil.Name = "btn_tampil"
        Me.btn_tampil.Size = New System.Drawing.Size(75, 23)
        Me.btn_tampil.TabIndex = 50
        Me.btn_tampil.Text = "Tampil"
        Me.btn_tampil.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 194)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(602, 267)
        Me.DataGridView1.TabIndex = 49
        '
        'txt_sekolah
        '
        Me.txt_sekolah.Location = New System.Drawing.Point(463, 152)
        Me.txt_sekolah.Name = "txt_sekolah"
        Me.txt_sekolah.Size = New System.Drawing.Size(152, 20)
        Me.txt_sekolah.TabIndex = 48
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(463, 41)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(119, 20)
        Me.DateTimePicker1.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(378, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(378, 155)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Sekolah Asal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(378, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Agama"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(378, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Tanggal Lahir"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(378, 18)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Tempat Lahir"
        '
        'txt_alamat
        '
        Me.txt_alamat.Location = New System.Drawing.Point(463, 93)
        Me.txt_alamat.Multiline = True
        Me.txt_alamat.Name = "txt_alamat"
        Me.txt_alamat.Size = New System.Drawing.Size(188, 50)
        Me.txt_alamat.TabIndex = 41
        '
        'txt_agama
        '
        Me.txt_agama.Location = New System.Drawing.Point(463, 67)
        Me.txt_agama.Name = "txt_agama"
        Me.txt_agama.Size = New System.Drawing.Size(100, 20)
        Me.txt_agama.TabIndex = 40
        '
        'txt_tempatlahir
        '
        Me.txt_tempatlahir.Location = New System.Drawing.Point(463, 15)
        Me.txt_tempatlahir.Name = "txt_tempatlahir"
        Me.txt_tempatlahir.Size = New System.Drawing.Size(100, 20)
        Me.txt_tempatlahir.TabIndex = 39
        '
        'ComboBox_kelamin
        '
        Me.ComboBox_kelamin.FormattingEnabled = True
        Me.ComboBox_kelamin.Items.AddRange(New Object() {"L", "P"})
        Me.ComboBox_kelamin.Location = New System.Drawing.Point(123, 122)
        Me.ComboBox_kelamin.Name = "ComboBox_kelamin"
        Me.ComboBox_kelamin.Size = New System.Drawing.Size(38, 21)
        Me.ComboBox_kelamin.TabIndex = 38
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Nisn"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Nis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Id Siswa"
        '
        'txt_nisn
        '
        Me.txt_nisn.Location = New System.Drawing.Point(123, 93)
        Me.txt_nisn.Name = "txt_nisn"
        Me.txt_nisn.Size = New System.Drawing.Size(100, 20)
        Me.txt_nisn.TabIndex = 32
        '
        'txt_nis
        '
        Me.txt_nis.Location = New System.Drawing.Point(123, 41)
        Me.txt_nis.Name = "txt_nis"
        Me.txt_nis.Size = New System.Drawing.Size(100, 20)
        Me.txt_nis.TabIndex = 31
        '
        'txt_nama
        '
        Me.txt_nama.Location = New System.Drawing.Point(123, 67)
        Me.txt_nama.Name = "txt_nama"
        Me.txt_nama.Size = New System.Drawing.Size(182, 20)
        Me.txt_nama.TabIndex = 30
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(123, 15)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(100, 20)
        Me.txt_id.TabIndex = 29
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 477)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.btn_tampil)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_sekolah)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_alamat)
        Me.Controls.Add(Me.txt_agama)
        Me.Controls.Add(Me.txt_tempatlahir)
        Me.Controls.Add(Me.ComboBox_kelamin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nisn)
        Me.Controls.Add(Me.txt_nis)
        Me.Controls.Add(Me.txt_nama)
        Me.Controls.Add(Me.txt_id)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_update As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btn_hapus As Button
    Friend WithEvents btn_simpan As Button
    Friend WithEvents btn_tampil As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_sekolah As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_alamat As TextBox
    Friend WithEvents txt_agama As TextBox
    Friend WithEvents txt_tempatlahir As TextBox
    Friend WithEvents ComboBox_kelamin As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nisn As TextBox
    Friend WithEvents txt_nis As TextBox
    Friend WithEvents txt_nama As TextBox
    Friend WithEvents txt_id As TextBox
End Class
