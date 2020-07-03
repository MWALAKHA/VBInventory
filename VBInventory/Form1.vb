Imports VBInventory

Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPassword.Click
        If txtUsername.Text = "qwerty" And txtPassword.Text = "qwerty" Then
            GroupBox1.Visible = False
        Else
            MessageBox.Show("You have entered incorrect login details", "closing exams",
                            MessageBoxButtons.OK, MessageBoxIcon.Question)
            txtPassword.Clear()
            txtUsername.Clear()
            txtUsername.Focus()
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtPassword.Clear()
        txtUsername.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Closing Exams",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Closing Exams",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (result = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        NewCustomerBindingSource.MoveNext()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TESTDataSet1.members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.TESTDataSet1.members)
        'TODO: This line of code loads data into the 'TESTDataSet.Credit_Control' table. You can move, or remove it, as needed.
        Me.Credit_ControlTableAdapter.Fill(Me.TESTDataSet.Credit_Control)
        'TODO: This line of code loads data into the 'TESTDataSet.New_Customer' table. You can move, or remove it, as needed.
        Me.New_CustomerTableAdapter.Fill(Me.TESTDataSet.New_Customer)
        'TODO: This line of code loads data into the 'TESTDataSet.Customer_Details' table. You can move, or remove it, as needed.
        Me.Customer_DetailsTableAdapter.Fill(Me.TESTDataSet.Customer_Details)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        CustomerDetailsBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        On Error GoTo Feedback

        Me.Validate()
        Me.CustomerDetailsBindingSource.EndEdit()
        Me.Customer_DetailsTableAdapter.Update(Me.InventoryDataset)
Feedback:
        MsgBox("Check your record", vbInformation)
        Exit Sub
    End Sub

    Private Function InventoryDataset() As TESTDataSet.Customer_DetailsDataTable
        Throw New NotImplementedException()
    End Function

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        CustomerDetailsBindingSource.MoveNext()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        CustomerDetailsBindingSource.MovePrevious()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        CustomerDetailsBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        NewCustomerBindingSource.AddNew()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        NewCustomerBindingSource.MovePrevious()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        NewCustomerBindingSource.RemoveCurrent()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        NewCustomerBindingSource.EndEdit()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        On Error GoTo Feedback

        Me.Validate()
        Me.NewCustomerBindingSource.EndEdit()
        Me.New_CustomerTableAdapter.Update2(Me.InventoryDataset)
Feedback:
        MsgBox("Check your record", vbInformation)
        Exit Sub
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub
End Class
