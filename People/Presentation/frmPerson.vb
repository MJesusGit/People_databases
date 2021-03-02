Public Class frmPersons
    Private P As Person
    Private Sub Form1_load(Sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.ofdPath.ShowDialog = DialogResult.OK Then


            btnOpenDB.Enabled = True




        End If

    End Sub


    Private Sub btnDBSelect_Click(sender As Object, e As EventArgs) Handles btnDBSelect.Click

    End Sub

    Private Sub btnOpenDB_Click(sender As Object, e As EventArgs) Handles btnOpenDB.Click
        Dim.plux As Person
        Me.P = New Person
        Try
            'If Me.insertPerson() <> 1 Then

            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtID.Text <> String.Empty Or txtName.Text <> String.Empty Then
            P = New Person(txtID.Text)
            P.PersonName = txtName.Text
            Try
                If Me.InsertPerson() <>  Then
           Catch ex As Exception

            End Try





        End If
        MessageB
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtID.Text = String.Empty
        txtName.Text = String.Empty
    End Sub
End Class
