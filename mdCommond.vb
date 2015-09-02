Module mdCommond
    Public envPath As String = Application.StartupPath & "\SystemData\"
    Public LoadRecord As String
    Public PreInputID As String
    Public showHelpIntro As Boolean = False
    'USER
    Public LoadUserID As String
    Public CanBeEdit As Boolean = False
    ''' <summary>
    ''' 验证身份证号码
    ''' </summary>
    ''' <param name="Id">身份证号码</param>
    ''' <returns>验证成功为True，否则为False</returns>
    Public Function CheckIDCard(ByVal Id As String) As Boolean
        If Id.Length = 18 Then
            Dim check As Boolean = CheckIDCard18(Id)
            Return check
        ElseIf Id.Length = 15 Then
            Dim check As Boolean = CheckIDCard15(Id)
            Return check
        Else
            Return False
        End If
    End Function
#Region "身份证号码验证"
    ''' <summary>
    ''' 验证15位身份证号
    ''' </summary>
    ''' <param name="Id">身份证号</param>
    ''' <returns>验证成功为True，否则为False</returns>
    Private Function CheckIDCard18(ByVal Id As String) As Boolean
        Dim n As Long = 0
        If Long.TryParse(Id.Remove(17), n) = False OrElse n < Math.Pow(10, 16) OrElse Long.TryParse(Id.Replace("x"c, "0"c).Replace("X"c, "0"c), n) = False Then
            '数字验证
            Return False
        End If
        Dim address As String = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91"
        If address.IndexOf(Id.Remove(2)) = -1 Then
            '省份验证
            Return False
        End If
        Dim birth As String = Id.Substring(6, 8).Insert(6, "-").Insert(4, "-")
        Dim time As New DateTime()
        If DateTime.TryParse(birth, time) = False Then
            '生日验证
            Return False
        End If   '更多.net源码和实例，来自乐博网 www.lob.cn
        Dim arrVarifyCode As String() = ("1,0,x,9,8,7,6,5,4,3,2").Split(","c)
        Dim Wi As String() = ("7,9,10,5,8,4,2,1,6,3,7,9,10,5,8,4,2").Split(","c)
        Dim Ai As Char() = Id.Remove(17).ToCharArray()
        Dim sum As Integer = 0
        For i As Integer = 0 To 16
            sum += Integer.Parse(Wi(i)) * Integer.Parse(Ai(i).ToString())
        Next
        Dim y As Integer = -1
        Math.DivRem(sum, 11, y)
        If arrVarifyCode(y) <> Id.Substring(17, 1).ToLower() Then
            '校验码验证
            Return False
        End If
        '符合GB11643-1999标准
        Return True
    End Function
    ''' <summary>
    ''' 验证18位身份证号
    ''' </summary>
    ''' <param name="Id">身份证号</param>
    ''' <returns>验证成功为True，否则为False</returns>
    Private Function CheckIDCard15(ByVal Id As String) As Boolean
        Dim n As Long = 0
        If Long.TryParse(Id, n) = False OrElse n < Math.Pow(10, 14) Then
            '数字验证
            Return False
        End If
        Dim address As String = "11x22x35x44x53x12x23x36x45x54x13x31x37x46x61x14x32x41x50x62x15x33x42x51x63x21x34x43x52x64x65x71x81x82x91"
        If address.IndexOf(Id.Remove(2)) = -1 Then
            '省份验证
            Return False
        End If
        Dim birth As String = Id.Substring(6, 6).Insert(4, "-").Insert(2, "-")
        Dim time As New DateTime()
        If DateTime.TryParse(birth, time) = False Then
            '生日验证
            Return False
        End If
        '符合15位身份证标准
        Return True
    End Function
#End Region

    Public Function isRegUser(ByVal id As String) As String
        Dim xmlDoc As New Xml.XmlDocument
        xmlDoc.Load(envPath & "Users.xml")
        For i = 0 To xmlDoc.SelectSingleNode("UserInfo").SelectNodes("User").Count - 1
            If id.Trim = xmlDoc.SelectSingleNode("UserInfo").SelectNodes("User")(i).SelectSingleNode("id").InnerText.Trim Then
                Return xmlDoc.SelectSingleNode("UserInfo").SelectNodes("User")(i).SelectSingleNode("name").InnerText
            End If
        Next
        Return ""
    End Function
End Module
