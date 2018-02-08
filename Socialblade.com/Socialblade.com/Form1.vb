Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.IO

'//CODED BY X-SLAYER
'THNX FOR 6K SUBSCRIBERS ^_^
'SUBSCRIBE FOR MORE VIDEOS : https://www.youtube.com/c/XSLAYER404
'FACEBOOK PAGE : https://www.facebook.com/XSLAYER404
'FACEBOOK PROFILE : https://www.facebook.com/ihebbriki1
'INSTAGRAM : 

Public Class Form1

    Public SLAYER As New WebClient With {.Proxy = Nothing}

    Public Sub New()
        InitializeComponent()
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub
    Sub info(ByVal ID As String)
        On Error Resume Next
        Dim request As HttpWebRequest = DirectCast(WebRequest.Create(("https://socialblade.com/youtube/channel/" & ID)), HttpWebRequest)
        request.Proxy = Nothing
        request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36"
        request.CookieContainer = New CookieContainer
        Dim response As HttpWebResponse = DirectCast(request.GetResponse, HttpWebResponse)
        Dim reader As New StreamReader(response.GetResponseStream)
        Dim str2 As String = reader.ReadToEnd
        reader.Close()
        Dim Match As Match = Regex.Match(str2, "<img id=""YouTubeUserTopInfoAvatar"" src=""(.*?)"" alt=""(.*?)"" title=""(.*?)"" />")
        photo.Image = Bitmap.FromStream(SLAYER.OpenRead(Match.Groups(1).Value))
        cover.Image = Bitmap.FromStream(SLAYER.OpenRead("http:" & (Regex.Match(str2, "<div id=""YouTubeUserTopHeaderBackground"" style=""background-image: url\('(.*?)'\); background-size:110%; height: 200px; width: 1280px;"">").Groups.Item(1).Value)))
        user.Text = Match.Groups(3).Value
        upload.Text = Regex.Match(str2, "<span id=""youtube-stats-header-uploads"" style=""display: none;"">(.*?)</span>").Groups.Item(1).Value
        subs.Text = Regex.Match(str2, "<span id=""youtube-stats-header-subs"" style=""display: none;"">(.*?)</span>").Groups.Item(1).Value
        count.Text = Regex.Match(str2, "<span id=""youtube-stats-header-views"" style=""display: none;"">(.*?)</span>").Groups.Item(1).Value
        country.Text = Regex.Match(str2, "<span id=""youtube-stats-header-country"" style=""display: none;"">(.*?)</span>").Groups.Item(1).Value
        If CountryL.Images.ContainsKey(country.Text.ToLower & ".png") Then
            pcountry.Image = CountryL.Images.Item(country.Text.ToLower & ".png")
        Else
            pcountry.Image = Nothing
        End If
        type.Text = Regex.Match(str2, "<span id=""youtube-stats-header-channeltype"" style=""display: none;"">(.*?)</span>").Groups.Item(1).Value
        created.Text = Regex.Match(str2, "<div class=""YouTubeUserTopInfo""><span class=""YouTubeUserTopLight"">User Created</span><br /><span style=""font-weight: bold;"">(.*?)</span></div>").Groups.Item(1).Value
        grade.Text = Regex.Match(str2, "<span id=""afd-header-total-grade"" style=""display: none;"">(.*?)</span>").Groups.Item(1).Value
        subsrank.Text = Regex.Match(str2, "<p id=""afd-header-subscriber-rank"" style=""font-size: 1.6em; color:#41a200; padding-top: 10px; font-weight: 600;"">(.*?)</p>").Groups.Item(1).Value
        videorank.Text = Regex.Match(str2, "<p id=""afd-header-videoview-rank"" style=""font-size: 1.6em; color:#41a200; padding-top: 10px; font-weight: 600;"">(.*?)</p>").Groups.Item(1).Value
        sbrank.Text = Regex.Match(str2, "<p id=""afd-header-sb-rank"" style=""font-size: 1.6em; color:#41a200; padding-top: 10px; font-weight: 600;"">(.*?)</p>").Groups.Item(1).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TXT_ID.Text = String.Empty Then
            Exit Sub
        End If
        Dim IHEB As New Thread(Sub() info(TXT_ID.Text)) : IHEB.Start()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://www.youtube.com/c/XSLAYER404")
    End Sub
End Class
