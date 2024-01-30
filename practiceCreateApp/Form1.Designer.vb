<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.quetionNumLabel = New System.Windows.Forms.Label()
        Me.jpQLabel = New System.Windows.Forms.Label()
        Me.answerBox = New System.Windows.Forms.TextBox()
        Me.submitBtn = New System.Windows.Forms.Button()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.tfLabel = New System.Windows.Forms.Label()
        Me.answerLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'quetionNumLabel
        '
        Me.quetionNumLabel.AutoSize = True
        Me.quetionNumLabel.Location = New System.Drawing.Point(44, 43)
        Me.quetionNumLabel.Name = "quetionNumLabel"
        Me.quetionNumLabel.Size = New System.Drawing.Size(35, 12)
        Me.quetionNumLabel.TabIndex = 0
        Me.quetionNumLabel.Text = "第0問"
        '
        'jpQLabel
        '
        Me.jpQLabel.AutoSize = True
        Me.jpQLabel.Location = New System.Drawing.Point(105, 85)
        Me.jpQLabel.Name = "jpQLabel"
        Me.jpQLabel.Size = New System.Drawing.Size(65, 12)
        Me.jpQLabel.TabIndex = 1
        Me.jpQLabel.Text = "日本語問題"
        '
        'answerBox
        '
        Me.answerBox.Location = New System.Drawing.Point(408, 85)
        Me.answerBox.Name = "answerBox"
        Me.answerBox.Size = New System.Drawing.Size(100, 19)
        Me.answerBox.TabIndex = 2
        '
        'submitBtn
        '
        Me.submitBtn.Location = New System.Drawing.Point(86, 155)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(75, 23)
        Me.submitBtn.TabIndex = 3
        Me.submitBtn.Text = "答え"
        Me.submitBtn.UseVisualStyleBackColor = True
        '
        'previousBtn
        '
        Me.previousBtn.Location = New System.Drawing.Point(59, 329)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(75, 23)
        Me.previousBtn.TabIndex = 4
        Me.previousBtn.Text = "前の問題"
        Me.previousBtn.UseVisualStyleBackColor = True
        '
        'nextBtn
        '
        Me.nextBtn.Location = New System.Drawing.Point(437, 329)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(75, 23)
        Me.nextBtn.TabIndex = 5
        Me.nextBtn.Text = "次の問題"
        Me.nextBtn.UseVisualStyleBackColor = True
        '
        'tfLabel
        '
        Me.tfLabel.AutoSize = True
        Me.tfLabel.ForeColor = System.Drawing.Color.Red
        Me.tfLabel.Location = New System.Drawing.Point(462, 155)
        Me.tfLabel.Name = "tfLabel"
        Me.tfLabel.Size = New System.Drawing.Size(17, 12)
        Me.tfLabel.TabIndex = 6
        Me.tfLabel.Text = "□"
        '
        'answerLabel
        '
        Me.answerLabel.AutoSize = True
        Me.answerLabel.Location = New System.Drawing.Point(282, 155)
        Me.answerLabel.Name = "answerLabel"
        Me.answerLabel.Size = New System.Drawing.Size(50, 12)
        Me.answerLabel.TabIndex = 7
        Me.answerLabel.Text = "英語答え"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.answerLabel)
        Me.Controls.Add(Me.tfLabel)
        Me.Controls.Add(Me.nextBtn)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.submitBtn)
        Me.Controls.Add(Me.answerBox)
        Me.Controls.Add(Me.jpQLabel)
        Me.Controls.Add(Me.quetionNumLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents quetionNumLabel As Label
    Friend WithEvents jpQLabel As Label
    Friend WithEvents answerBox As TextBox
    Friend WithEvents submitBtn As Button
    Friend WithEvents previousBtn As Button
    Friend WithEvents nextBtn As Button
    Friend WithEvents tfLabel As Label
    Friend WithEvents answerLabel As Label
End Class
