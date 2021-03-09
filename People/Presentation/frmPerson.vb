Public Class frmPersons

    'Creacion de objetos para el main purpose
    Private p As Person

    Private Sub btnDBSelect_Click(sender As Object, e As EventArgs) Handles btnDBSelect.Click
        If Me.ofdPath.ShowDialog = DialogResult.OK Then
            btnOpenDB.Enabled = True
        End If
    End Sub

    Private Sub btnOpenDB_Click(sender As Object, e As EventArgs) Handles btnOpenDB.Click
        Dim pAux As Person
        Me.p = New Person

        Try
            Me.p.ReadAllPersons(ofdPath.FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        For Each pAux In Me.p.PerDAO.Persons
            Me.lstPeople.Items.Add(pAux.PersonID)
        Next
        btnOpenDB.Enabled = False
        btnAdd.Enabled = True
        btnDBSelect.Enabled = False
    End Sub


    'Common operations Add, Clear, Update , Delete

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtID.Text <> String.Empty And txtName.Text <> String.Empty Then
            p = New Person(txtID.Text)
            p.PersonName = txtName.Text
            Try
                If Me.p.InsertPerson() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            Me.lstPeople.Items.Add(p.PersonID)
        Else
            MessageBox.Show("Id and Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtID.Clear()
        txtName.Clear()
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.p = New Person
        p.PersonID = lstPeople.SelectedItem.ToString
        p.ReadPerson()
        If p.PersonName = txtName.Text Then
            MessageBox.Show("You're not changing a thing", "Custom Error", MessageBoxButtons.OK)
        Else
            p.PersonName = txtName.Text
        End If
        p.UpdatePerson()
        MessageBox.Show("UPDATE!!! Stop clicking, please", "Custom Error", MessageBoxButtons.OK)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure? Do you want to delete permanetly this person?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If
        If txtID.Text <> String.Empty Then
            Me.p = New Person
            p.PersonID = txtID.Text
            p.ReadPerson()
            If p.PersonName <> txtName.Text Then
                MessageBox.Show("This is not the same name", "Custom Error", MessageBoxButtons.OK)
                Exit Sub
            End If
            Try
                If p.DeletePerson() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show("Person deleted", ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information
                                )
                Exit Sub
            End Try
            Me.lstPeople.Items.Remove(p.PersonID)
        Else
            MessageBox.Show("Unable to delete information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub


    'Show info about the selected items in the list

    Private Sub lstPersons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPeople.SelectedIndexChanged
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        If lstPeople.SelectedItem IsNot Nothing Then
            Try
                Me.p = New Person
                p.PersonID = lstPeople.SelectedItem.ToString
                p.ReadPerson()
                txtID.Text = p.PersonID
                txtName.Text = p.PersonName
            Catch ex As Exception
                lstPeople.SelectedIndex = -1
            End Try
        End If
    End Sub

    Private Sub txtID_Click(sender As Object, e As EventArgs) Handles txtID.Click
        txtID.Clear()
    End Sub

    Private Sub txtName_Click(sender As Object, e As EventArgs) Handles txtName.Click
        txtName.Clear()
    End Sub
End Class
