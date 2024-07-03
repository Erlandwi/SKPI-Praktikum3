<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Txtnabar = New TextBox()
        Txtharga = New TextBox()
        Txtjumlah = New TextBox()
        Txttotalharga = New TextBox()
        Txtdiskon = New TextBox()
        Txttotalbayar = New TextBox()
        Txtbonus = New TextBox()
        Bthitung = New Button()
        Btulang = New Button()
        Btkeluar = New Button()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(150, 115)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 18)
        Label1.TabIndex = 0
        Label1.Text = "Nama Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(150, 163)
        Label2.Margin = New Padding(6, 0, 6, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 18)
        Label2.TabIndex = 1
        Label2.Text = "Harga Satuan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(150, 212)
        Label3.Margin = New Padding(6, 0, 6, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 18)
        Label3.TabIndex = 2
        Label3.Text = "Jumlah Barang"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(145, 308)
        Label4.Margin = New Padding(6, 0, 6, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 18)
        Label4.TabIndex = 3
        Label4.Text = "Total Harga"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(145, 357)
        Label5.Margin = New Padding(6, 0, 6, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 18)
        Label5.TabIndex = 4
        Label5.Text = "Diskon"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(150, 407)
        Label6.Margin = New Padding(6, 0, 6, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(94, 18)
        Label6.TabIndex = 5
        Label6.Text = "Total Bayar"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(150, 472)
        Label7.Margin = New Padding(6, 0, 6, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 18)
        Label7.TabIndex = 6
        Label7.Text = "Bonus"
        ' 
        ' Txtnabar
        ' 
        Txtnabar.Location = New Point(381, 102)
        Txtnabar.Margin = New Padding(6, 5, 6, 5)
        Txtnabar.Name = "Txtnabar"
        Txtnabar.Size = New Size(333, 32)
        Txtnabar.TabIndex = 7
        ' 
        ' Txtharga
        ' 
        Txtharga.Location = New Point(381, 150)
        Txtharga.Margin = New Padding(6, 5, 6, 5)
        Txtharga.Name = "Txtharga"
        Txtharga.Size = New Size(277, 32)
        Txtharga.TabIndex = 8
        ' 
        ' Txtjumlah
        ' 
        Txtjumlah.Location = New Point(381, 198)
        Txtjumlah.Margin = New Padding(6, 5, 6, 5)
        Txtjumlah.Name = "Txtjumlah"
        Txtjumlah.Size = New Size(277, 32)
        Txtjumlah.TabIndex = 9
        ' 
        ' Txttotalharga
        ' 
        Txttotalharga.Location = New Point(381, 295)
        Txttotalharga.Margin = New Padding(6, 5, 6, 5)
        Txttotalharga.Name = "Txttotalharga"
        Txttotalharga.Size = New Size(333, 32)
        Txttotalharga.TabIndex = 10
        ' 
        ' Txtdiskon
        ' 
        Txtdiskon.Location = New Point(381, 343)
        Txtdiskon.Margin = New Padding(6, 5, 6, 5)
        Txtdiskon.Name = "Txtdiskon"
        Txtdiskon.Size = New Size(333, 32)
        Txtdiskon.TabIndex = 11
        ' 
        ' Txttotalbayar
        ' 
        Txttotalbayar.Location = New Point(381, 393)
        Txttotalbayar.Margin = New Padding(6, 5, 6, 5)
        Txttotalbayar.Name = "Txttotalbayar"
        Txttotalbayar.Size = New Size(333, 32)
        Txttotalbayar.TabIndex = 12
        ' 
        ' Txtbonus
        ' 
        Txtbonus.Location = New Point(381, 458)
        Txtbonus.Margin = New Padding(6, 5, 6, 5)
        Txtbonus.Name = "Txtbonus"
        Txtbonus.Size = New Size(333, 32)
        Txtbonus.TabIndex = 13
        ' 
        ' Bthitung
        ' 
        Bthitung.Font = New Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Bthitung.Location = New Point(381, 247)
        Bthitung.Margin = New Padding(6, 5, 6, 5)
        Bthitung.Name = "Bthitung"
        Bthitung.Size = New Size(139, 38)
        Bthitung.TabIndex = 14
        Bthitung.Text = "Hitung"
        Bthitung.UseVisualStyleBackColor = True
        ' 
        ' Btulang
        ' 
        Btulang.Font = New Font("Rockwell", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Btulang.Location = New Point(578, 247)
        Btulang.Margin = New Padding(6, 5, 6, 5)
        Btulang.Name = "Btulang"
        Btulang.Size = New Size(139, 38)
        Btulang.TabIndex = 15
        Btulang.Text = "Ulang"
        Btulang.UseVisualStyleBackColor = True
        ' 
        ' Btkeluar
        ' 
        Btkeluar.Location = New Point(145, 530)
        Btkeluar.Margin = New Padding(6, 5, 6, 5)
        Btkeluar.Name = "Btkeluar"
        Btkeluar.Size = New Size(572, 38)
        Btkeluar.TabIndex = 16
        Btkeluar.Text = "Keluar"
        Btkeluar.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Stencil", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(381, 50)
        Label8.Margin = New Padding(6, 0, 6, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(267, 25)
        Label8.TabIndex = 17
        Label8.Text = "DC SERVICE HP & LAPTOP"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 749)
        Controls.Add(Label8)
        Controls.Add(Btkeluar)
        Controls.Add(Btulang)
        Controls.Add(Bthitung)
        Controls.Add(Txtbonus)
        Controls.Add(Txttotalbayar)
        Controls.Add(Txtdiskon)
        Controls.Add(Txttotalharga)
        Controls.Add(Txtjumlah)
        Controls.Add(Txtharga)
        Controls.Add(Txtnabar)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(6, 5, 6, 5)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txtnabar As TextBox
    Friend WithEvents Txtharga As TextBox
    Friend WithEvents Txtjumlah As TextBox
    Friend WithEvents Txttotalharga As TextBox
    Friend WithEvents Txtdiskon As TextBox
    Friend WithEvents Txttotalbayar As TextBox
    Friend WithEvents Txtbonus As TextBox
    Friend WithEvents Bthitung As Button
    Friend WithEvents Btulang As Button
    Friend WithEvents Btkeluar As Button
    Friend WithEvents Label8 As Label

End Class
