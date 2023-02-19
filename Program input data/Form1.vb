Public Class Form1
    Dim jml_data As Byte = 5
    Dim indeks_data As Byte = 0
    Dim data_mahasiswa(5, 4) As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If indeks_data > jml_data - 1 Then
            MsgBox("DATA SUDAH PENUH")
        Else
            data_mahasiswa(indeks_data, 0) = TextBox1.Text
            data_mahasiswa(indeks_data, 1) = TextBox2.Text
            data_mahasiswa(indeks_data, 2) = TextBox3.Text
            data_mahasiswa(indeks_data, 3) = TextBox4.Text

            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox1.Focus()
            indeks_data = indeks_data + 1
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i As Byte
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        If indeks_data > 0 Then
            For i = 0 To indeks_data - 1

                ListBox1.Items.Add(data_mahasiswa(i, 0))
                ListBox2.Items.Add(data_mahasiswa(i, 1))
                ListBox3.Items.Add(data_mahasiswa(i, 2))
                ListBox4.Items.Add(data_mahasiswa(i, 3))
            Next
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
