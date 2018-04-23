Public Class MyDataObject
    Private privateItem As String
    Public Property Item() As String
        Get
            Return privateItem
        End Get
        Set(ByVal value As String)
            privateItem = value
        End Set
    End Property
    Private privatePrice As Decimal
    Public Property Price() As Decimal
        Get
            Return privatePrice
        End Get
        Set(ByVal value As Decimal)
            privatePrice = value
        End Set
    End Property
    Private privateAnnounced As DateTime
    Public Property Announced() As DateTime
        Get
            Return privateAnnounced
        End Get
        Set(ByVal value As DateTime)
            privateAnnounced = value
        End Set
    End Property
    Private privateDiscontinued As Boolean
    Public Property Discontinued() As Boolean
        Get
            Return privateDiscontinued
        End Get
        Set(ByVal value As Boolean)
            privateDiscontinued = value
        End Set
    End Property
End Class
