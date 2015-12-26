Imports System.IO

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not Directory.Exists("ppm")) Then
            Directory.CreateDirectory("ppm")
        End If
        tbDestPath.Text = Directory.GetCurrentDirectory
    End Sub

    Private Sub btnChoseSrcPictures_Click(sender As Object, e As EventArgs) Handles btnLoadPictures.Click
        ofd.ShowDialog()
        If ofd.FileNames.Count > 0 Then
            For Each fn As String In ofd.FileNames
                lbPiturePathList.Items.Add(fn)
                lbPictureNameList.Items.Add(fn.Substring(fn.LastIndexOf("\") + 1))
            Next
        End If
    End Sub

    Private Sub lbPictureNameList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbPictureNameList.SelectedIndexChanged
        If lbPictureNameList.SelectedItems.Count = 1 Then
            Dim fs As FileStream
            fs = New FileStream(lbPiturePathList.Items(lbPictureNameList.SelectedIndices(0)), IO.FileMode.Open, IO.FileAccess.Read)
            pbOriginal.Image = System.Drawing.Image.FromStream(fs)
            fs.Close()
            tsslMessage.Text = lbPictureNameList.SelectedItems(0) + " (" + pbOriginal.Image.Height.ToString + "*" + pbOriginal.Image.Width.ToString + ")"

            If rbPixel.Checked Then
                tbHorizontal.Text = pbOriginal.Image.Height
                tbVertical.Text = pbOriginal.Image.Width
            End If

            If pbOriginal.Image.Height <= 470 And pbOriginal.Image.Width <= 434 Then
                pbThumbnail.Height = pbOriginal.Image.Height
                pbThumbnail.Width = pbOriginal.Image.Width
            ElseIf pbOriginal.Image.Height * 434 >= 470 * pbOriginal.Image.Width Then
                pbThumbnail.Height = 470
                pbThumbnail.Width = pbOriginal.Image.Width * 470 / pbOriginal.Image.Height
            Else
                pbThumbnail.Height = pbOriginal.Image.Height * 434 / pbOriginal.Image.Width
                pbThumbnail.Width = 434
            End If
            pbThumbnail.Image = pbOriginal.Image

        End If
    End Sub

    Private Sub lbPictureNameList_KeyUp(sender As Object, e As KeyEventArgs) Handles lbPictureNameList.KeyUp
        If e.KeyCode = Keys.Delete Then
            If lbPictureNameList.SelectedItems.Count > 0 Then
                For i As Integer = lbPictureNameList.SelectedItems.Count - 1 To 0 Step -1
                    lbPiturePathList.Items.RemoveAt(lbPictureNameList.SelectedIndices(i))
                    lbPictureNameList.Items.RemoveAt(lbPictureNameList.SelectedIndices(i))
                Next
            End If
        End If
    End Sub

    Private Sub rbPixel_CheckedChanged(sender As Object, e As EventArgs) Handles rbPixel.CheckedChanged
        If lbPictureNameList.SelectedItems.Count = 1 Then
            tbHorizontal.Text = pbOriginal.Image.Height
            tbVertical.Text = pbOriginal.Image.Width
        Else
            tbHorizontal.Text = 0
            tbVertical.Text = 0
        End If
    End Sub

    Private Sub rbPercentage_CheckedChanged(sender As Object, e As EventArgs) Handles rbPercentage.CheckedChanged
        tbHorizontal.Text = 100
        tbVertical.Text = 100
    End Sub

    Private Sub tbHorizontal_TextChanged(sender As Object, e As EventArgs) Handles tbHorizontal.TextChanged
        If lbPictureNameList.SelectedItems.Count = 1 And cbFixedRatio.Checked Then
            Dim value As Integer = Val(tbHorizontal.Text)
            If rbPixel.Checked Then
                value = pbOriginal.Image.Width * Val(tbHorizontal.Text) / pbOriginal.Image.Height
            End If
            tbVertical.Text = value
        End If
    End Sub

    Private Sub tbVertical_TextChanged(sender As Object, e As EventArgs) Handles tbVertical.TextChanged
        If lbPictureNameList.SelectedItems.Count = 1 And cbFixedRatio.Checked Then
            Dim value As Integer = Val(tbVertical.Text)
            If rbPixel.Checked Then
                value = pbOriginal.Image.Height * Val(tbVertical.Text) / pbOriginal.Image.Width
            End If
            tbHorizontal.Text = value
        End If
    End Sub

    Private Sub btnTransform_Click(sender As Object, e As EventArgs) Handles btnTransform.Click
        If lbPictureNameList.SelectedItems.Count = 1 Then
            Dim fileName As String = lbPictureNameList.SelectedItems(0)
            Dim fileFullPath As String = lbPiturePathList.Items(lbPictureNameList.SelectedIndices(0))
            Dim filePath = fileFullPath.Substring(0, fileFullPath.Length - fileName.Length)
            Dim fileFullPathOrg As String = filePath + fileName + ".original"

            Dim newHeight As Integer = pbOriginal.Image.Height
            Dim newWidth As Integer = pbOriginal.Image.Width

            If rbPixel.Checked Then
                newHeight = Val(tbHorizontal.Text)
                newWidth = Val(tbVertical.Text)
            ElseIf rbPercentage.Checked Then
                newHeight = newHeight * Val(tbHorizontal.Text) / 100
                newWidth = newWidth * Val(tbVertical.Text) / 100
            End If

            If File.Exists(fileFullPathOrg) = False Then
                File.Copy(fileFullPath, fileFullPathOrg)
            End If

            Try
                Dim newPic As New System.Drawing.Bitmap(pbOriginal.Image, newWidth, newHeight)
                If fileName.EndsWith("bmp") Or fileName.EndsWith("BMP") Then
                    newPic.Save(fileFullPath, Drawing.Imaging.ImageFormat.Bmp)
                ElseIf fileName.EndsWith("jpg") Or fileName.EndsWith("JPG") Or fileName.EndsWith("jpeg") Or fileName.EndsWith("JPEG")
                    newPic.Save(fileFullPath, Drawing.Imaging.ImageFormat.Jpeg)
                ElseIf fileName.EndsWith("png") Or fileName.EndsWith("PNG")
                    newPic.Save(fileFullPath, Drawing.Imaging.ImageFormat.Png)
                End If

                lbPictureNameList_SelectedIndexChanged(lbPictureNameList, Nothing)
            Catch ex As Exception
                MsgBox("調整大小失敗！")
            End Try

        Else
            MsgBox("請選擇一張圖片！")
        End If
    End Sub

    Private Sub btnRecovery_Click(sender As Object, e As EventArgs) Handles btnRecovery.Click
        If lbPictureNameList.SelectedItems.Count = 1 Then
            Dim fileName As String = lbPictureNameList.SelectedItems(0)
            Dim fileFullPath As String = lbPiturePathList.Items(lbPictureNameList.SelectedIndices(0))
            Dim filePath = fileFullPath.Substring(0, fileFullPath.Length - fileName.Length)
            Dim fileFullPathOrg As String = filePath + fileName + ".original"

            If File.Exists(fileFullPathOrg) Then
                Try
                    File.Copy(fileFullPathOrg, fileFullPath, True)
                    lbPictureNameList_SelectedIndexChanged(lbPictureNameList, Nothing)
                Catch ex As Exception
                    MsgBox("還原失敗！請確認檔案沒有開啟中")
                End Try
            Else
                MsgBox("沒有圖檔可以還原！")
            End If
        Else
            MsgBox("請選擇一張圖片！")
        End If
    End Sub

    Private Sub btnChoseDestFolder_Click(sender As Object, e As EventArgs) Handles btnChoseDestFolder.Click
        fbd.Description = "請選擇要產生目的地資料夾"
        fbd.ShowDialog()
        If Directory.Exists(fbd.SelectedPath) Then
            tbDestPath.Text = fbd.SelectedPath
        End If
    End Sub

    Public Shared Sub Bitmap2Ppm(ByVal bm As Bitmap, ByVal path As String)
        Using writer As StreamWriter = New StreamWriter(path)
            writer.Write("P6" + vbLf + "#" + vbLf + "Created" + vbLf + "by" + vbLf + "Skyle" + vbLf)
            writer.Write(bm.Width.ToString + vbLf + bm.Height.ToString + vbLf)
            writer.Write("255" + vbLf)

            For x As Integer = 0 To bm.Height - 1
                For y As Integer = 0 To bm.Width - 1
                    Dim c As Color = bm.GetPixel(y, x)
                    writer.Write(c.R.ToString + vbLf)
                    writer.Write(c.G.ToString + vbLf)
                    writer.Write(c.B.ToString + vbLf)
                Next
            Next
        End Using
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        If MsgBox("將覆蓋所有已經存在的檔案？是否繼續？", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            If File.Exists("ascii.exe") = False Then
                MsgBox("遺失 ascii.exe，產生失敗！")
                Exit Sub
            End If

            Dim errorMsg As String = vbNullString

            Try
                Dim p As Process = New Process()
                p.StartInfo.FileName = "ascii.exe"           '設定程序名
                p.StartInfo.UseShellExecute = False        '關閉Shell的使用
                p.StartInfo.RedirectStandardInput = True   '重定向標準輸入
                p.StartInfo.RedirectStandardOutput = True  '重定向標準輸出
                p.StartInfo.RedirectStandardError = True   '重定向錯誤輸出
                p.StartInfo.CreateNoWindow = True          '設置不顯示窗口

                For i As Integer = 0 To lbPictureNameList.Items.Count - 1
                    Dim fileName As String = lbPictureNameList.Items(i)
                    Dim fileFullPath As String = lbPiturePathList.Items(i)
                    Try
                        Dim fileNameWithoutExt As String = fileName.Substring(0, fileName.LastIndexOf("."))
                        Dim fileNamePpm As String = "ppm\" + fileNameWithoutExt + ".ppm"
                        Dim fileNamePixel As String = tbDestPath.Text + "\" + fileNameWithoutExt + ".pixel"
                        Dim fileNameColor As String = tbDestPath.Text + "\" + fileNameWithoutExt + ".color"

                        tsslMessage.Text = fileNameWithoutExt + " 處理中 (" + (i + 1).ToString + "/" + lbPictureNameList.Items.Count.ToString + ")"
                        '
                        Dim fs As FileStream
                        fs = New FileStream(fileFullPath, IO.FileMode.Open, IO.FileAccess.Read)
                        Bitmap2Ppm(New Bitmap(Image.FromStream(fs)), fileNamePpm)
                        fs.Close()
                        '
                        p.StartInfo.Arguments = fileNamePpm + " " + fileNamePixel + " " + fileNameColor + Command()    '設定程式執行參數
                        p.Start() '啟動
                    Catch ex As Exception
                        errorMsg += fileName + " 產生失敗" & vbNewLine
                    End Try
                Next
            Catch ex As Exception
                MsgBox("啟動 ascii.exe 時發生錯誤")
            End Try

            tsslMessage.Text = "產生 pixel && color 檔完畢，共" + lbPictureNameList.Items.Count.ToString + "個"

            If errorMsg <> vbNullString Then
                MsgBox(errorMsg)
            End If

        End If
    End Sub

    Private Sub btnGenerateCode_Click(sender As Object, e As EventArgs) Handles btnGenerateCode.Click
        If lbPictureNameList.Items.Count > 0 Then
            tbCode.Clear()
            For i As Integer = 0 To lbPictureNameList.Items.Count - 1
                Dim fn As String = lbPictureNameList.Items(i)
                Dim var As String = fn.Substring(0, fn.LastIndexOf(".")).Replace(".", "_")
                If lbPictureNameList.Items.Count = 1 Then
                    tbCode.AppendText("Image *" + var + " = read_image(""" + tbFileNamePrefix.Text + var + ".pixel"", """ + tbFileNamePrefix.Text + var + ".color"");" + vbNewLine)
                ElseIf i = 0 Then
                    tbCode.AppendText("Image *" + var + " = read_image(""" + tbFileNamePrefix.Text + var + ".pixel"", """ + tbFileNamePrefix.Text + var + ".color"")," + vbNewLine)
                ElseIf i = lbPictureNameList.Items.Count - 1 Then
                    tbCode.AppendText("      *" + var + " = read_image(""" + tbFileNamePrefix.Text + var + ".pixel"", """ + tbFileNamePrefix.Text + var + ".color"");")
                Else
                    tbCode.AppendText("      *" + var + " = read_image(""" + tbFileNamePrefix.Text + var + ".pixel"", """ + tbFileNamePrefix.Text + var + ".color"")," + vbNewLine)
                End If
            Next
            tbCode.AppendText(vbNewLine)
            For i As Integer = 0 To lbPictureNameList.Items.Count - 1
                Dim fn As String = lbPictureNameList.Items(i)
                Dim var As String = fn.Substring(0, fn.LastIndexOf(".")).Replace(".", "_")
                tbCode.AppendText("show_image(" + var + ", 0, 0);" + vbNewLine)
            Next
            tbCode.AppendText(vbNewLine)
            For i As Integer = 0 To lbPictureNameList.Items.Count - 1
                Dim fn As String = lbPictureNameList.Items(i)
                Dim var As String = fn.Substring(0, fn.LastIndexOf(".")).Replace(".", "_")
                tbCode.AppendText("destroy_image(" + var + ");" + vbNewLine)
            Next
        End If
    End Sub

    Private Sub btnCopyCode_Click(sender As Object, e As EventArgs) Handles btnCopyCode.Click
        tbCode.SelectAll()
        tbCode.Copy()
        tsslMessage.Text = "已複製"
    End Sub

    Private Sub tsslGithub_Click(sender As Object, e As EventArgs) Handles tsslGithub.Click
        Process.Start("https://github.com/skyle0115")
    End Sub

End Class
