﻿Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim startFrom As Integer = 0
        Dim endWith As Integer = 0
        Dim Multiplication As Integer = 0
        Dim loopNo As Integer = 0

        lst1.Items.Clear()

        If IsNumeric(txtStartFrom.Text) Then
        ElseIf IsNumeric(txtEndBy.Text) Then
        Else
            MessageBox.Show("Please enter numbers")
        End If

        startFrom = Convert.ToInt32(txtStartFrom.Text)
        endWith = Convert.ToInt32(txtEndBy.Text)

        If startFrom >= endWith Then
            MessageBox.Show("'Start From' Number should be smaller than 'End With' Number")
            txtStartFrom.Text = ""
            txtEndBy.Text = ""
        End If

        For loopNo = startFrom To endWith
            For Multiplication = 1 To 12
                lst1.Items.Add(Multiplication.ToString() + " X " + loopNo.ToString() + " = " + (Multiplication * loopNo).ToString())
            Next
            lst1.Items.Add("")
        Next



    End Sub

End Class