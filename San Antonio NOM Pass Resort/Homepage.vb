Imports System.Security.Cryptography.X509Certificates

Public Class Homepage
    Private Sub btnRoom_Click(sender As Object, e As EventArgs)
        Hide
        Rooms.Show

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Hide
        Contact.Show
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        Me.Hide()
        AboutUs.Show()
    End Sub

    Private Sub Booking_Click(sender As Object, e As EventArgs) Handles btnBooking.Click
        Me.Hide()
        Room.Show()

    End Sub
End Class
