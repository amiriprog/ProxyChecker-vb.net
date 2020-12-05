Imports System
Imports System.Linq
Imports System.Text
Imports System.Net
Imports System.IO
Imports System.Threading
Imports System.Windows.Forms


Class ProxyChecker
    Public Shared Property good As Integer
    Public Shared Property bad As Integer
    Public Shared ProxysList As List(Of String) = New List(Of String)()
    Private Shared Timeout As Integer = 10000
    Dim remaining As Integer
    Private [stop] As Boolean = True
    Private ThreadList As List(Of Thread) = New List(Of Thread)()

    Private Sub Btn_Start_Click(sender As Object, e As EventArgs) Handles Btn_Start.Click
        If TxtPath.Text <> "" Then
            goodlabel.Text = 0
            Badlabel.Text = 0
            TxtGood.Clear()
            TxtBad.Clear()
            Lbl_All.Text = ProxysList.Count.ToString() & " Proxy(s)."
            Timeout = CInt((Me.TimeoutCount.Value * 1000L))

            Me.[stop] = False
            Me.ThreadList.Clear()
            Dim num3 As Integer = 0
            While CLng(num3) < Me.Socks_ThreadsCount.Value
                Dim item As New Thread(New ThreadStart(AddressOf Me.Sock_DoWork))
                Me.ThreadList.Add(item)
                item.Start()
                num3 += 1
            End While
        Else
            MsgBox("Please select Path file!", MsgBoxStyle.Critical, "Proxy Checker")
            Btn_Path_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub Sock_DoWork()
        While Not Me.[stop] AndAlso ProxysList.Count > 0
            Dim text As String = String.Empty
            Dim flag As Boolean = False
            Dim obj As ProxyChecker
            Try
                obj = Me
                Monitor.Enter(Me, flag)
                If ProxysList.Count > 0 Then
                    text = ProxysList(0)
                    ProxysList.RemoveAt(0)
                End If
            Finally
                If flag Then
                    Monitor.[Exit](obj)
                End If
            End Try
            If String.IsNullOrEmpty(text) Then
                Thread.Sleep(500)
            Else
                CheckProxies(text)
            End If
        End While
    End Sub

    Private Sub Btn_Path_Click(sender As Object, e As EventArgs) Handles Btn_Path.Click
        Dim OpenFileDialog1 As OpenFileDialog = New OpenFileDialog()
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt"
        OpenFileDialog1.Title = "Select a Proxy List File"
        OpenFileDialog1.ShowDialog()
        TxtPath.Text = OpenFileDialog1.FileName
        If TxtPath.Text <> "" Then
            ProxysList = Enumerable.ToList(Of String)(Enumerable.Distinct(Of String)(File.ReadAllLines(TxtPath.Text)))
        End If
    End Sub

    Public Sub CheckProxies(proxy As String)
        goodlabel.Invoke(Sub() goodlabel.Text = "Good: " & good)
        Badlabel.Invoke(Sub() Badlabel.Text = "Bad: " & bad)
        Thread.Sleep(800)
        If ProxyCheck(proxy) = True Then
            TxtGood.Invoke(Sub() TxtGood.Text += proxy & vbCrLf)
            good += 1
        Else
            TxtBad.Invoke(Sub() TxtBad.Text += proxy & vbCrLf)
            bad += 1
        End If

        goodlabel.Invoke(Sub() goodlabel.Text = "Good: " & good)
        Badlabel.Invoke(Sub() Badlabel.Text = "Bad: " & bad & vbCrLf)
        If Val(bad) + Val(good) = Val(Lbl_All.Text) Then
            MsgBox("Work Done.", MsgBoxStyle.Information, "Proxy Checker")
        End If
    End Sub

    Public Shared Function ProxyCheck(ByVal ipAddressport As String) As Boolean
        Dim data As String() = ipAddressport.Split(":"c)
        Dim port As Integer = 0
        Try
            port = Integer.Parse(data(1))
        Catch
            Return False
        End Try

        Try
            Dim proxy As IWebProxy = New WebProxy(data(0), port)
            Dim wc As WebClient = New WebClient()
            wc.Timeout = Timeout
            wc.Proxy = proxy
            wc.Encoding = Encoding.UTF8
            Dim result As String = wc.DownloadString("http://ip-api.com/line/?fields=8192")
            Return True
        Catch
            Return False
        End Try
    End Function


    Private Class WebClient
        Inherits System.Net.WebClient
        Public Property Timeout As Integer

        Protected Overrides Function GetWebRequest(ByVal uri As Uri) As WebRequest
            Dim lWebRequest As WebRequest = MyBase.GetWebRequest(uri)
            lWebRequest.Timeout = Timeout
            CType(lWebRequest, HttpWebRequest).ReadWriteTimeout = Timeout
            Return lWebRequest
        End Function
    End Class
 
End Class

