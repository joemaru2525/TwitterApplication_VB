Public Class FormTwitterPost
    Private Sub FormTwitterPost_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private session As CoreTweet.OAuth.OAuthSession
    Private Sub butAuthorize_Click(sender As Object, e As EventArgs) Handles butAuthorize.Click
        session = CoreTweet.OAuth.Authorize("T5uEJ8CnQd7Nu1FQkyTOQA7Nm", "EAl3tJj2tTiYzBCL9PjFaaswAFSMQr2fXFVkUG8FkCozzu2R80")
        System.Diagnostics.Process.Start(session.AuthorizeUri.ToString())
    End Sub

    Private tokens As CoreTweet.Tokens
    Private Sub utPIN_Click(sender As Object, e As EventArgs) Handles utPIN.Click
        Tokens = CoreTweet.OAuth.GetTokens(session, TxtPIN.Text)
    End Sub

    Private Sub butTweet_Click(sender As Object, e As EventArgs) Handles butTweet.Click
        tokens.Statuses.Update(txtTweet.Text)
    End Sub
End Class
