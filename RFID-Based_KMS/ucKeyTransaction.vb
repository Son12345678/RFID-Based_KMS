'Imports System.Speech
Public Class ucKeyTransaction
    'Private WithEvents Myvoice As New Recognition.SpeechRecognitionEngine


    Private Sub BTNBORROW_Click(sender As Object, e As EventArgs) Handles BTNBORROW.Click


        Dim i As Integer
        For i = PNLTRANSACTION.Controls.Count - 1 To 0
            PNLTRANSACTION.Controls.RemoveAt(i)
        Next

        Dim borrow As New ucBorrow()
        borrow.Parent = PNLTRANSACTION
        borrow.Show()
        borrow.Dock = DockStyle.Fill
    End Sub

    Private Sub ucTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Myvoice.SetInputToDefaultAudioDevice()
        'Dim Grammar As New Recognition.SrgsGrammar.SrgsDocument
        'Dim WordRule As New Recognition.SrgsGrammar.SrgsRule("word")
        'Dim Wordlist As New Recognition.SrgsGrammar.SrgsOneOf("Hey sissy borrow key", "Hey sissy borrowing", "Borrowing", "Hey sissy return key", "Hey sissy returning", "returning")
        'WordRule.Add(Wordlist)
        'Grammar.Rules.Add(WordRule)
        'Grammar.Root = WordRule
        'Myvoice.LoadGrammar(New Recognition.Grammar(Grammar))
        'Myvoice.RecognizeAsync()

        Dim blank As New ucTransactionBlank()
        blank.Parent = PNLTRANSACTION
        blank.Show()
        blank.Dock = DockStyle.Fill
    End Sub

    'Private Sub Myvoice_RecognizeCompleted(sender As Object, e As Recognition.RecognizeCompletedEventArgs) Handles Myvoice.RecognizeCompleted
    '    Myvoice.RecognizeAsync()
    'End Sub

    'Private Sub Myvoice_SpeechRecognized(sender As Object, e As Recognition.SpeechRecognizedEventArgs) Handles Myvoice.SpeechRecognized
    '    If e.Result.Text = "Hey sissy borrow key" Or e.Result.Text = "Hey sissy borrowing" Or e.Result.Text = "Borrowing" Then
    '        Me.BTNBORROW.PerformClick()
    '    ElseIf e.Result.Text = "Hey sissy return key" Or e.Result.Text = "Hey sissy returning" Or e.Result.Text = "returning" Then
    '        Me.BTNRETURN.PerformClick()
    '    End If
    'End Sub

    Private Sub lblClose_Click(sender As Object, e As EventArgs) Handles lblClose.Click
        Dim i As Integer
        For i = FRMAdminMenu.pnlmain.Controls.Count - 1 To 0
            FRMAdminMenu.pnlmain.Controls.RemoveAt(i)
        Next

        Dim home As New ucHome()
        home.Parent = FRMAdminMenu.pnlmain
        home.Show()
        home.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNRETURN_Click(sender As Object, e As EventArgs) Handles BTNRETURN.Click

        Dim i As Integer
        For i = PNLTRANSACTION.Controls.Count - 1 To 0
            PNLTRANSACTION.Controls.RemoveAt(i)
        Next


        Dim returned As New ucReturn()
        returned.Parent = PNLTRANSACTION
        returned.Show()
        returned.Dock = DockStyle.Fill
    End Sub

    Private Sub btnblank_Click(sender As Object, e As EventArgs) Handles btnblank.Click
        Dim i As Integer
        For i = PNLTRANSACTION.Controls.Count - 1 To 0
            PNLTRANSACTION.Controls.RemoveAt(i)
        Next


        Dim blank As New ucTransactionBlank()
        blank.Parent = PNLTRANSACTION
        blank.Show()
        blank.Dock = DockStyle.Fill
    End Sub
End Class
