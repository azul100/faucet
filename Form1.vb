Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LTC.Navigate("https://ltcfaucet.top/", False)
        DOGE.Navigate("https://dogecoinfaucet.top/", False)
        DASH.Navigate("https://freedash.club/", False)
        BNB.Navigate("https://bnbfaucet.top/", False)
        ETH.Navigate("https://ethfaucet.top/", False)
        ZEC.Navigate("https://zecfaucet.net/", False)
        DGB.Navigate("https://freedgb.club/", False)
        TRX.Navigate("https://tronfaucet.top/", False)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try








            Dim fdsq1 As HtmlElementCollection = LTC.Document.All
            For Each Webpageelement As HtmlElement In fdsq1
                LTC.Document.GetElementById("adr").InnerText = t1.Text
                If Webpageelement.GetAttribute("value") = "Get Free LTC!" Then

                    Webpageelement.InvokeMember("click")
                    MsgBox("eror..address   LTC")
                End If
            Next

            Dim fdsq2 As HtmlElementCollection = DOGE.Document.All

            For Each Webpageelement As HtmlElement In fdsq2
                DOGE.Document.GetElementById("adr").InnerText = t2.Text
                If Webpageelement.GetAttribute("value") = "Get Free DOGE!" Then
                    Webpageelement.InvokeMember("click")
                    MsgBox("eror..address   DOGE")
                End If
            Next
            Dim fdsq3 As HtmlElementCollection = DGB.Document.All

            For Each Webpageelement As HtmlElement In fdsq3
                DGB.Document.GetElementById("adr").InnerText = t3.Text
                If Webpageelement.GetAttribute("value") = "Get Free DGB!" Then
                    Webpageelement.InvokeMember("click")
                    MsgBox("eror..address   DGB")
                End If
            Next
            Dim fdsq4 As HtmlElementCollection = BNB.Document.All

            For Each Webpageelement As HtmlElement In fdsq4
                BNB.Document.GetElementById("adr").InnerText = t4.Text
                If Webpageelement.GetAttribute("value") = "Get Free BNB!" Then
                    Webpageelement.InvokeMember("click")
                    MsgBox("eror..address   BNB")
                End If
            Next

            Dim fdsq5 As HtmlElementCollection = ETH.Document.All
            For Each Webpageelement As HtmlElement In fdsq5
                ETH.Document.GetElementById("adr").InnerText = t5.Text
                If Webpageelement.GetAttribute("value") = "Get Free ETH!" Then
                    Webpageelement.InvokeMember("click")
                    MsgBox("eror..address   ETH")
                End If
            Next
            Dim fdsq6 As HtmlElementCollection = ZEC.Document.All
            For Each Webpageelement As HtmlElement In fdsq6
                ZEC.Document.GetElementById("adr").InnerText = t6.Text
                If Webpageelement.GetAttribute("value") = "Get Free ZEC!" Then
                    Webpageelement.InvokeMember("click")
                    MsgBox("eror..address   ZEC")
                End If
            Next

            Dim fdsq7 As HtmlElementCollection = DASH.Document.All
            For Each Webpageelement As HtmlElement In fdsq7
                DASH.Document.GetElementById("adr").InnerText = t7.Text
                If Webpageelement.GetAttribute("value") = "Get Free DASH!" Then
                    Webpageelement.InvokeMember("click")
                    MsgBox("eror..address   DASH")
                End If
            Next
        Catch ex As Exception
            Dim fdsq8 As HtmlElementCollection = TRX.Document.All
            For Each Webpageelement As HtmlElement In fdsq8
                TRX.Document.GetElementById("adr").InnerText = t8.Text
                If Webpageelement.GetAttribute("value") = "Get Free TRX!" Then
                    Webpageelement.InvokeMember("click")
                    MsgBox("eror..address   TRX")
                End If
            Next

        End Try





    End Sub
End Class