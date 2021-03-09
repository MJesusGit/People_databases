Public Class frmPersons

    'Creacion de objetos para el main purpose
    Private p As Person
    'Como Hacer que la ventana se mueva arrastrando con el raton
    Dim x, y As Integer
    Dim newpoint As New Point

    Private Sub frmCalculoSimonFranco_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub frmCalculoSimonFranco_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    'Como hacer los botones de Cerrar aplicacion y minimizar la ventana
    'Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
    'Application.Exit()
    'End Sub

    'Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
    ' Me.WindowState = FormWindowState.Minimized
    'End Sub

    'Como hacer todo lo demás


    'Select and Open the database

    Private Sub btnDBSelect_Click(sender As Object, e As EventArgs) Handles btnDBSelect.Click
        If Me.ofdPath.ShowDialog = DialogResult.OK Then
            btnOpenDB.Enabled = True
        End If
    End Sub

    Private Sub btnOpenDB_Click(sender As Object, e As EventArgs) Handles btnOpenDB.Click
        Me.p = New Person
        Dim pAux As Person
        Try
            Me.p.ReadAllPersons(ofdPath.FileName)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        For Each pAux In Me.p.PerDAO.Persons
            Me.lstPersons.Items.Add(pAux.PersonID)
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
            Me.lstPersons.Items.Add(p.PersonID)
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
        p.PersonID = lstPersons.SelectedItem.ToString
        p.ReadPerson()
        If p.PersonName = txtName.Text Then
            MessageBox.Show("You're not changing a thing", "Custom Error", MessageBoxButtons.OK)
        Else
            p.PersonName = txtName.Text
        End If
        p.UpdatePerson()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Do you really want to delete this person?", "Custom Error", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        End If
        If txtID.Text <> String.Empty Then
            Me.p = New Person
            p.PersonID = txtID.Text
            p.ReadPerson()
            If p.PersonName <> txtName.Text Then
                MessageBox.Show("You're not speciying the same name", "Custom Error", MessageBoxButtons.OK)
                Exit Sub
            End If
            Try
                If p.DeletePerson() <> 1 Then
                    MessageBox.Show("INSERT <> -1", "Custom Error", MessageBoxButtons.OK)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.lstPersons.Items.Remove(p.PersonID)
        Else
            MessageBox.Show("Unable to delete information, all needed fields must be filled", "Custom Error", MessageBoxButtons.OK)
        End If
    End Sub


    'Show info about the selected items in the list

    Private Sub lstPersons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPersons.SelectedIndexChanged
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        Try
            Me.p = New Person
            p.PersonID = lstPersons.SelectedItem.ToString
            p.ReadPerson()
            txtID.Text = lstPersons.SelectedItem.ToString
            txtName.Text = p.PersonName
        Catch ex As Exception
            lstPersons.SelectedIndex = -1
        End Try
    End Sub

    Private Sub txtID_Click(sender As Object, e As EventArgs) Handles txtID.Click
        txtID.Clear()
    End Sub



    Private Sub txtName_Click(sender As Object, e As EventArgs) Handles txtName.Click
        txtName.Clear()
    End Sub
End Class
