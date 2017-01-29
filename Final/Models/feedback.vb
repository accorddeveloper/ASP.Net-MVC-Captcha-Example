Public Class feedback
    Public Property Id() As Integer
        Get
            Return m_Id
        End Get
        Set
            m_Id = Value
        End Set
    End Property
    Private m_Id As Integer
    Public Property Title() As String
        Get
            Return m_Title
        End Get
        Set
            m_Title = Value
        End Set
    End Property
    Private m_Title As String
    Public Property Comment() As String
        Get
            Return m_Comment
        End Get
        Set
            m_Comment = Value
        End Set
    End Property
    Private m_Comment As String

End Class
