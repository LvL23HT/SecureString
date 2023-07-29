Imports System.Diagnostics
Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim inputString As String = TextBoxInput.Text
            Dim key As String = TextBoxKey.Text

            If String.IsNullOrWhiteSpace(inputString) Or String.IsNullOrWhiteSpace(key) Then
                Throw New ArgumentException("La entrada y la clave no pueden estar vacías.")
            End If

            Dim command As String = $"$key = [System.Text.Encoding]::UTF8.GetBytes('{key}'); $secureString = ConvertTo-SecureString -String '{inputString}' -AsPlainText -Force; $encrypted = ConvertFrom-SecureString -SecureString $secureString -Key $key; $encrypted"

            Dim process As Process = New Process()
            Dim psi As ProcessStartInfo = New ProcessStartInfo()

            psi.FileName = "powershell.exe"
            psi.RedirectStandardInput = True
            psi.RedirectStandardOutput = True
            psi.RedirectStandardError = True
            psi.UseShellExecute = False

            process.StartInfo = psi
            process.Start()

            process.StandardInput.WriteLine(command)
            process.StandardInput.Close()

            Dim errorOutput = process.StandardError.ReadToEnd()
            If Not String.IsNullOrWhiteSpace(errorOutput) Then
                Throw New Exception($"Error de PowerShell: {errorOutput}")
            End If

            Dim penultimateString As String = ""
            Dim lastString As String = ""
            While Not process.StandardOutput.EndOfStream
                Dim line = process.StandardOutput.ReadLine()
                If Not String.IsNullOrWhiteSpace(line) Then
                    penultimateString = lastString
                    lastString = line
                End If
            End While

            TextBoxResult.Text = penultimateString

            process.Close()
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim key As String = TextBoxKey.Text

            Dim encryptedString As String = TextBoxInput.Text.Trim()

            If String.IsNullOrWhiteSpace(encryptedString) Or String.IsNullOrWhiteSpace(key) Then
                Throw New ArgumentException("La entrada cifrada y la clave no pueden estar vacías.")
            End If

            Dim command As String = $"$key = [System.Text.Encoding]::UTF8.GetBytes('{key}'); $secureString = ConvertTo-SecureString -String '{encryptedString}' -Key $key; $BSTR = [System.Runtime.InteropServices.Marshal]::SecureStringToBSTR($secureString); $PlainText = [System.Runtime.InteropServices.Marshal]::PtrToStringAuto($BSTR); [System.Runtime.InteropServices.Marshal]::ZeroFreeBSTR($BSTR); return $PlainText"

            Dim process As Process = New Process()
            Dim psi As ProcessStartInfo = New ProcessStartInfo()

            psi.FileName = "powershell.exe"
            psi.RedirectStandardInput = True
            psi.RedirectStandardOutput = True
            psi.RedirectStandardError = True
            psi.UseShellExecute = False

            process.StartInfo = psi
            process.Start()

            process.StandardInput.WriteLine(command)
            process.StandardInput.Close()

            Dim errorOutput = process.StandardError.ReadToEnd()
            If Not String.IsNullOrWhiteSpace(errorOutput) Then
                Throw New Exception($"Error de PowerShell: {errorOutput}")
            End If

            Dim penultimateString As String = ""
            Dim lastString As String = ""
            While Not process.StandardOutput.EndOfStream
                Dim line = process.StandardOutput.ReadLine()
                If Not String.IsNullOrWhiteSpace(line) Then
                    penultimateString = lastString
                    lastString = line
                End If
            End While


            TextBoxResult.Text = penultimateString

            process.Close()
        Catch ex As Exception

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim psi As New ProcessStartInfo
        psi.UseShellExecute = True
        psi.FileName = "cmd.exe"
        psi.Arguments = "/C start https://level23hacktools.com"
        Process.Start(psi)
    End Sub
End Class
