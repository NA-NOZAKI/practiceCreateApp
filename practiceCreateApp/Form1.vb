Imports System.Security.Cryptography.X509Certificates

Public Class Form1

    '変数
    Public Shared quetionArray() As String = {"リンゴ", "学校", "鉛筆", "机", "鞄", "本", "部屋", "コップ", "椅子", "頭"}
    Public Shared answerArray() As String = {"apple", "school", "pencil", "desk", "bag", "book", "room", "cup", "chair", "head"}
    Public Shared quetionNum() As String = {"第1問", "第2問", "第3問", "第4問", "第5問", "第6問", "第7問", "第8問", "第9問", "第10問"}
    Public Shared count As Integer = 1

    '問題番号
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles quetionNumLabel.Click

    End Sub

    '正誤
    Public Shared Sub Label1_Click_1(sender As Object, e As EventArgs) Handles tfLabel.Click

    End Sub

    'next button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        count += 1
        Dim f = New Form1
        f.Show()
    End Sub

    'previous button
    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        count -= 1
        Dim f = New Form1
        f.Show()
    End Sub

    'submit button
    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        If answerLabel.Text = answerBox.Text Then
            tfLabel.Text = "○"
            tfLabel.ForeColor = Color.Red
            tfLabel.Visible = True
            answerLabel.Visible = True
        Else
            tfLabel.Text = "×"
            tfLabel.ForeColor = Color.Blue
            tfLabel.Visible = True
            answerLabel.Visible = True
        End If
    End Sub

    'load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '表示非表示
        ''ボタン群
        If count = 1 Then
            previousBtn.Enabled = False
            previousBtn.Visible = False
        Else
            previousBtn.Enabled = True
            previousBtn.Visible = True
        End If

        If count = 10 Then
            nextBtn.Enabled = False
            nextBtn.Visible = False
        Else
            nextBtn.Enabled = True
            nextBtn.Visible = True
        End If

        ''正答
        answerLabel.Visible = False
        answerLabel.Text = ""

        ''正誤
        tfLabel.Visible = False
        tfLabel.Text = ""

        '問題番号
        quetionNumLabel.Text = ""
        If count Then
            quetionNumLabel.Text = quetionNum(count - 1)
        End If

        '問題
        jpQLabel.Text = ""
        If count Then
            jpQLabel.Text = quetionArray(count - 1)
        End If

        '正解
        answerLabel.Text = ""
        If count Then
            answerLabel.Text = AnswerArray(count - 1)
        End If

    End Sub
End Class