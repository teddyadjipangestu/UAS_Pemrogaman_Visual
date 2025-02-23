Imports System.IO

Module Program
    Sub Main()
        ' Membaca file teks
        Dim filePath As String = "data.txt"

        If File.Exists(filePath) Then
            Console.WriteLine("Isi file:")
            Dim lines() As String = File.ReadAllLines(filePath)

            ' Perulangan untuk membaca isi file
            For Each line In lines
                Console.WriteLine(line)
            Next
        Else
            Console.WriteLine("File tidak ditemukan. Membuat file baru...")
            File.WriteAllText(filePath, "Ini adalah contoh dari ganjil genap")
        End If

        ' Contoh percabangan
        Console.Write("Masukkan angka: ")
        Dim input As Integer = Convert.ToInt32(Console.ReadLine())

        If input Mod 2 = 0 Then
            Console.WriteLine("Angka genap")
        Else
            Console.WriteLine("Angka ganjil")
        End If

        ' Memanggil prosedur
        TampilkanPesan()

        ' Menunggu input sebelum keluar
        Console.WriteLine("Tekan Enter untuk keluar...")
        Console.ReadLine()
    End Sub

    ' Procedure sederhana
    Sub TampilkanPesan()
        Console.WriteLine("Halo! Ini adalah angka yang anda panggil")
    End Sub
End Module
