Public Class Form1

    Private Sub CB1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB1.SelectedIndexChanged
            string a= CB1.SelectedItem.ToString();
            MessageBox.Show(a);
            T1.Text = a;
    End Sub

    Private Sub T1_TextChanged(sender As Object, e As EventArgs) Handles T1.TextChanged

    End Sub
End Class
