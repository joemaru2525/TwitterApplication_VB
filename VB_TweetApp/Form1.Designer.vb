<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTwitterPost
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
        Me.butAuthorize = New System.Windows.Forms.Button()
        Me.TxtPIN = New System.Windows.Forms.TextBox()
        Me.txtTweet = New System.Windows.Forms.TextBox()
        Me.utPIN = New System.Windows.Forms.Button()
        Me.butTweet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'butAuthorize
        '
        Me.butAuthorize.Location = New System.Drawing.Point(10, 15)
        Me.butAuthorize.Name = "butAuthorize"
        Me.butAuthorize.Size = New System.Drawing.Size(74, 23)
        Me.butAuthorize.TabIndex = 0
        Me.butAuthorize.Text = "Twitter連係"
        Me.butAuthorize.UseVisualStyleBackColor = True
        '
        'TxtPIN
        '
        Me.TxtPIN.Location = New System.Drawing.Point(10, 52)
        Me.TxtPIN.Name = "TxtPIN"
        Me.TxtPIN.Size = New System.Drawing.Size(164, 19)
        Me.TxtPIN.TabIndex = 1
        '
        'txtTweet
        '
        Me.txtTweet.Location = New System.Drawing.Point(10, 82)
        Me.txtTweet.Multiline = True
        Me.txtTweet.Name = "txtTweet"
        Me.txtTweet.Size = New System.Drawing.Size(265, 138)
        Me.txtTweet.TabIndex = 2
        '
        'utPIN
        '
        Me.utPIN.Location = New System.Drawing.Point(180, 49)
        Me.utPIN.Name = "utPIN"
        Me.utPIN.Size = New System.Drawing.Size(95, 24)
        Me.utPIN.TabIndex = 3
        Me.utPIN.Text = "PIN 入力"
        Me.utPIN.UseVisualStyleBackColor = True
        '
        'butTweet
        '
        Me.butTweet.Location = New System.Drawing.Point(180, 227)
        Me.butTweet.Name = "butTweet"
        Me.butTweet.Size = New System.Drawing.Size(95, 22)
        Me.butTweet.TabIndex = 4
        Me.butTweet.Text = "Tweet"
        Me.butTweet.UseVisualStyleBackColor = True
        '
        'FormTwitterPost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.butTweet)
        Me.Controls.Add(Me.utPIN)
        Me.Controls.Add(Me.txtTweet)
        Me.Controls.Add(Me.TxtPIN)
        Me.Controls.Add(Me.butAuthorize)
        Me.Name = "FormTwitterPost"
        Me.Text = "Twitter投稿"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents butAuthorize As Button
    Friend WithEvents TxtPIN As TextBox
    Friend WithEvents txtTweet As TextBox
    Friend WithEvents utPIN As Button
    Friend WithEvents butTweet As Button
End Class
