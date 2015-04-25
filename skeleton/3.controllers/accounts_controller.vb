Public Class accounts_controller
    Private _accounts As Dictionary(Of Long, Account)
    Private _connectType As EnumConnectType = EnumConnectType.HTTP

    Private _countOfProgress As Long = 0
    Private _maxOfProgress As Long = 0

    Public Sub New()
        Me._connectType = EnumConnectType.HTTP
        Me._accounts = Nothing
    End Sub

    Public ReadOnly Property show() As Dictionary(Of Long, account)
        Get
            Return Me._accounts
        End Get
    End Property

    Public ReadOnly Property show(ID As Long) As account
        Get
            Return Me._accounts(ID)
        End Get
    End Property


    Public Function valid(a As Account) As Long

        Return 0
    End Function

    Public Function add(_account As Account) As Long

        Return 0
    End Function

    Public Function destroy(ID As Long) As Long
        Dim target As Account = Me._accounts(ID)
        target.AccountStatus = EnumAccountStatus.INVALID
        target.ModifyAt = Now

        Return 0
    End Function

    Public Function modify(_account As Account) As Long



        Return 0
    End Function


    Private Function Flash2Http() As Long
        Return 0
    End Function

    Public Function Flash2Direct() As Long
        Return 0
    End Function

End Class

