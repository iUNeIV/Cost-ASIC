Public Class Form1



    Function Minute(ByVal Nombre As Double, ByVal watt As Double, ByVal prixwatt As Double) As Double
        Dim Cout As Double
        Cout = FormatNumber((NumericUpDown1.Value * (NumericUpDown2.Value * 24) / 1000) * NumericUpDown3.Value * 0.00069444444, 4) 'Calcul du cout, FormatNumber sert à mettre 2 chiffres après la virgule
        Return Cout
    End Function

    Function Hour(ByVal Nombre As Double, ByVal watt As Double, ByVal prixwatt As Double) As Double
        Dim Cout As Double
        Cout = FormatNumber((NumericUpDown1.Value * (NumericUpDown2.Value * 24) / 1000) * NumericUpDown3.Value * 0.04166666666, 4) 'Calcul du cout, FormatNumber sert à mettre 2 chiffres après la virgule
        Return Cout
    End Function
    Function Day(ByVal Nombre As Double, ByVal watt As Double, ByVal prixwatt As Double) As Double
        Dim Cout As Double
        Cout = FormatNumber((NumericUpDown1.Value * (NumericUpDown2.Value * 24) / 1000) * NumericUpDown3.Value, 4) 'Calcul du cout, FormatNumber sert à mettre 2 chiffres après la virgule
        Return Cout
    End Function
    Function Week(ByVal Nombre As Double, ByVal watt As Double, ByVal prixwatt As Double) As Double
        Dim Cout As Double
        Cout = FormatNumber((NumericUpDown1.Value * (NumericUpDown2.Value * 24) / 1000) * NumericUpDown3.Value * 7, 4) 'Calcul du cout, FormatNumber sert à mettre 2 chiffres après la virgule
        Return Cout
    End Function
    Function Month(ByVal Nombre As Double, ByVal watt As Double, ByVal prixwatt As Double) As Double
        Dim Cout As Double
        Cout = FormatNumber((NumericUpDown1.Value * (NumericUpDown2.Value * 24) / 1000) * NumericUpDown3.Value * 30.4166666667, 4) 'Calcul du cout, FormatNumber sert à mettre 2 chiffres après la virgule
        Return Cout
    End Function
    Function Year(ByVal Nombre As Double, ByVal watt As Double, ByVal prixwatt As Double) As Double
        Dim Cout As Double
        Cout = FormatNumber((NumericUpDown1.Value * (NumericUpDown2.Value * 24) / 1000) * NumericUpDown3.Value * 365, 4) 'Calcul du cout, FormatNumber sert à mettre 2 chiffres après la virgule
        Return Cout
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Label12.Text = Minute(Me.NumericUpDown1.Value, Me.NumericUpDown2.Value, Me.NumericUpDown3.Value) & " $"
        Me.Label13.Text = Hour(Me.NumericUpDown1.Value, Me.NumericUpDown2.Value, Me.NumericUpDown3.Value) & " $"
        Me.Label14.Text = Day(Me.NumericUpDown1.Value, Me.NumericUpDown2.Value, Me.NumericUpDown3.Value) & " $"
        Me.Label15.Text = Week(Me.NumericUpDown1.Value, Me.NumericUpDown2.Value, Me.NumericUpDown3.Value) & " $"
        Me.Label16.Text = Month(Me.NumericUpDown1.Value, Me.NumericUpDown2.Value, Me.NumericUpDown3.Value) & " $"
        Me.Label17.Text = Year(Me.NumericUpDown1.Value, Me.NumericUpDown2.Value, Me.NumericUpDown3.Value) & " $"
    End Sub

    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox2.KeyPress
        e.Handled = True
    End Sub

    Private Sub ComboBox3_KeyPress(sender As Object, e As KeyPressEventArgs)
        e.Handled = True
    End Sub
    Function Bloc(ByVal Nombre As Double, ByVal watt As Double, ByVal prixwatt As Double) As Double
        Dim Cout As Double
        Cout = FormatNumber(NumericUpDown4.Value / NumericUpDown5.Value * NumericUpDown6.Value, 0)
        Return Cout
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            MessageBox.Show("With your calculating power it gives you. " & vbNewLine & "- " & Bloc(Me.NumericUpDown4.Value, Me.NumericUpDown5.Value, Me.NumericUpDown6.Value) & " - block find in theoretical.", "Bloc find in theoretical", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
