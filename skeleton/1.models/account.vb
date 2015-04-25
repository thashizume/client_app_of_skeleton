Public Class Account

    Private _id As Long = 0
    Private _nickName As String = String.Empty
    Private _passwordDegest As String = String.Empty
    Private _accountType As EnumAccountType = EnumAccountType.SYSTEM
    Private _accountRole As EnumAccountRole = EnumAccountRole.USERS
    Private _token As String = String.Empty
    Private _lastUseAt As Date = Nothing
    Private _accountStatus As EnumAccountStatus = EnumAccountStatus.GUEST
    Private _nameFirst As String = String.Empty
    Private _nameLast As String = String.Empty
    Private _nameFirstKana As String = String.Empty
    Private _nameLastKana As String = String.Empty
    Private _birthday As Date = Nothing
    Private _createAt As Date = Nothing
    Private _modifyAt As Date = Nothing

    Public Property ID As Long
        Get
            Return Me._id
        End Get
        Set(value As Long)
            Me._id = value
        End Set
    End Property

    Public Property NickName() As String
        Get
            Return Me._nickName
        End Get
        Set(value As String)
            Me._nickName = value
        End Set
    End Property

    Public Property AccountType() As EnumAccountType
        Get
            Return Me._accountType
        End Get
        Set(value As EnumAccountType)
            Me._accountType = value
        End Set
    End Property

    Public Property TOKEN As String
        Get
            Return Me._token
        End Get
        Set(value As String)
            Me._token = value
        End Set
    End Property

    Public Property LAST_USE_AT As Date
        Get
            Return Me._lastUseAt
        End Get
        Set(value As Date)
            Me._lastUseAt = value
        End Set
    End Property

    Public Property AccountStatus As EnumAccountStatus
        Get
            Return Me._accountStatus
        End Get
        Set(value As EnumAccountStatus)
            Me._accountStatus = value
        End Set
    End Property

    Public Property NameFirst As String
        Get
            Return Me._nameFirst
        End Get
        Set(value As String)
            Me._nameFirst = value
        End Set
    End Property

    Public Property NameLast As String
        Get
            Return Me._nameLast
        End Get
        Set(value As String)
            Me._nameLast = value
        End Set
    End Property

    Public Property NameFirstKana As String
        Get
            Return Me._nameFirstKana
        End Get
        Set(value As String)
            Me._nameFirstKana = value
        End Set
    End Property

    Public Property NameLastKana As String
        Get
            Return Me._nameLastKana
        End Get
        Set(value As String)
            Me._nameLastKana = value
        End Set
    End Property

    Public Property Birthday As Date
        Get
            Return Me._birthday
        End Get
        Set(value As Date)
            Me._birthday = value
        End Set
    End Property

    Public Property CrateAt As Date
        Get
            Return Me._createAt
        End Get
        Set(value As Date)
            Me._createAt = value
        End Set
    End Property

    Public Property ModifyAt As Date
        Get
            Return Me._modifyAt
        End Get
        Set(value As Date)
            Me._modifyAt = value
        End Set
    End Property

    Public Overloads Overrides Function Equals(obj As [Object]) As Boolean
        If obj Is Nothing Or Not Me.GetType() Is obj.GetType() Then
            Return False
        End If
        Dim r As Account = CType(obj, Account)
        ' Use Equals to compare instance variables.
        Return Me._id.Equals(r._id) And Me._nickName.Equals(r._nickName) And Me._accountType.Equals(r._accountType) _
            And Me._accountRole.Equals(r._accountRole) And Me._token.Equals(r._token) And Me._lastUseAt.Equals(r._lastUseAt) _
            And Me._accountStatus.Equals(r.AccountStatus) And Me._nameFirst.Equals(r._nameFirst) And Me._nameLast.Equals(r._nameLast) _
            And Me._nameFirstKana.Equals(r.NameFirstKana) And Me._nameLastKana.Equals(r._nameLastKana) And Me._birthday.Equals(r.Birthday)
    End Function

    Public Overrides Function GetHashCode() As Integer
        Return _id.GetHashCode ^ _nickName.GetHashCode ^ _accountType.GetHashCode ^ _
            _accountRole.GetHashCode ^ _token.GetHashCode ^ _lastUseAt.GetHashCode ^ _
            _accountStatus.GetHashCode ^ _nameFirst.GetHashCode ^ _nameLast.GetHashCode ^ _
            _nameFirstKana.GetHashCode ^ _nameLastKana.GetHashCode ^ _birthday.GetHashCode

    End Function

End Class


Public Enum EnumAccountType As Integer
    SYSTEM = 0
    FACEBOOK = 1
    LINKEDIN = 2
    GOOGLE = 3

End Enum

Public Enum EnumAccountRole As Integer
    USERS = 0
    ORGANIZATION_POWER_USER = 1
    ORGANIZATION_ADMINISTRATOR = 2
    ADMiNSTRATOR = 3
    BATCH_USERS = 4

End Enum

Public Enum EnumAccountStatus As Integer
    GUEST = 0
    INDIVISUAL = 1
    LOCKED = 2
    INVALID = 3
End Enum



