Public Class frmPizzaSelection

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnDeepDish_Click(sender As Object, e As EventArgs) Handles btnDeepDish.Click
        picDeepDish.Visible = True 'Makes Deep Dish photo visible
        picThinCrust.Visible = False 'Hides thin crust pizza
        btnSelect.Enabled = True 'Enables select button




    End Sub

    Private Sub picThinCrust_Click(sender As Object, e As EventArgs) Handles picThinCrust.Click


    End Sub

    Private Sub btnThinCrust_Click(sender As Object, e As EventArgs) Handles btnThinCrust.Click
        picThinCrust.Visible = True
        picDeepDish.Visible = False
        btnSelect.Enabled = True
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        lblEnjoyYourPizza.Visible = True
        btnExit.Visible = True
        btnDeepDish.Visible = False
        btnThinCrust.Visible = False
        picDeepDish.Visible = False
        picThinCrust.Visible = False
        lblChooseYourPizza.Visible = False
        btnSelect.Visible = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
