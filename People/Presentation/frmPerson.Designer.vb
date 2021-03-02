<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPersons
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnOpenDB = New System.Windows.Forms.Button()
        Me.ofdPath = New System.Windows.Forms.OpenFileDialog()
        Me.lstPersons = New System.Windows.Forms.ListBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDBSelect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOpenDB
        '
        Me.btnOpenDB.Enabled = False
        Me.btnOpenDB.Location = New System.Drawing.Point(60, 204)
        Me.btnOpenDB.Name = "btnOpenDB"
        Me.btnOpenDB.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenDB.TabIndex = 0
        Me.btnOpenDB.Text = "Connect!"
        Me.btnOpenDB.UseVisualStyleBackColor = True
        '
        'ofdPath
        '
        Me.ofdPath.FileName = "OpenFileDialog1"
        '
        'lstPersons
        '
        Me.lstPersons.FormattingEnabled = True
        Me.lstPersons.Location = New System.Drawing.Point(37, 44)
        Me.lstPersons.Name = "lstPersons"
        Me.lstPersons.Size = New System.Drawing.Size(120, 147)
        Me.lstPersons.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(235, 50)
        Me.txtID.Margin = New System.Windows.Forms.Padding(1)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(106, 20)
        Me.txtID.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(235, 88)
        Me.txtName.Margin = New System.Windows.Forms.Padding(1)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(106, 20)
        Me.txtName.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(183, 147)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(54, 33)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Insert"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(252, 147)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(54, 33)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(252, 199)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(54, 33)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(183, 199)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(1)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(54, 33)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "PersonID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name"
        '
        'btnDBSelect
        '
        Me.btnDBSelect.Location = New System.Drawing.Point(60, 233)
        Me.btnDBSelect.Name = "btnDBSelect"
        Me.btnDBSelect.Size = New System.Drawing.Size(75, 23)
        Me.btnDBSelect.TabIndex = 10
        Me.btnDBSelect.Text = "Choose DB"
        Me.btnDBSelect.UseVisualStyleBackColor = True
        '
        'frmPersons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(369, 271)
        Me.Controls.Add(Me.btnDBSelect)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lstPersons)
        Me.Controls.Add(Me.btnOpenDB)
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPersons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Databases - Project2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpenDB As Button
    Friend WithEvents ofdPath As OpenFileDialog
    Friend WithEvents lstPersons As ListBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDBSelect As Button
End Class
