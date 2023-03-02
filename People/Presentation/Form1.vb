Public Class frmPersons
    Private p As Person

    Private Sub BtnOpenDB_Click(sender As Object, e As EventArgs) Handles btnOpenDB.Click
        Dim pAux As Person
        Me.p = New Person

        Try
            Me.p.ReadAllPersons()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        For Each pAux In Me.p.PerDAO.Persons
            Me.lstPersons.Items.Add(pAux.PersonID)
        Next
        btnOpenDB.Enabled = True
        btnAdd.Enabled = True
        btnClear.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True



    End Sub

    Private Sub LstPersons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPersons.SelectedIndexChanged
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        If lstPersons.SelectedItem IsNot Nothing Then
            Try
                Me.p = New Person
                p.PersonID = lstPersons.SelectedItem.ToString
                p.ReadPerson()
                txtID.Text = p.PersonID
                txtName.Text = p.PersonName
            Catch ex As Exception
                lstPersons.SelectedIndex = -1
            End Try
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
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
            Me.lstPersons.Items.Add(p.PersonID)
        Else
            MessageBox.Show("Id and Name were empty, please fill those spaces", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.p = New Person
        p.PersonID = lstPersons.SelectedItem.ToString
        p.ReadPerson()
        If p.PersonName = txtName.Text Then
            MessageBox.Show("You're not changing a thing", "Custom Error", MessageBoxButtons.OK)
        Else
            p.PersonName = txtName.Text
        End If
        p.UpdatePerson()
        MessageBox.Show("UPDATE!!! Stop clicking, please", "Custom Error", MessageBoxButtons.OK)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
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
            Me.lstPersons.Items.Remove(p.PersonID)
        Else
            MessageBox.Show("Unable to delete information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtID.Clear()
        txtName.Clear()

    End Sub

End Class
