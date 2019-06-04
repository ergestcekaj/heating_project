Public Class Class1
    Private dbvolume, dbtemperature As Double
    Dim intmaterial, intcountry, strcountry As Integer
    'I used Then Enum as I found it easier to work with 
    Public Enum MaterialEnum
        GAS
        ELECTRICITY
        COAL
    End Enum

    Public Enum CountriesEnum
        SWEDEN
        ITALY
        GERMANY
    End Enum

    Public Sub New(ByVal dbvolume As Double, ByVal Dbtemperature As Double, ByVal strcountry As Integer, ByVal intmaterial As Integer)

        Me.dbvolume = dbvolume
        Me.dbtemperature = Dbtemperature
        Me.strcountry = strcountry
        Me.intmaterial = intmaterial
    End Sub
    'here I started declaring the properties of the variables
    Property volume() As Double
        Get
            Return Dbvolume
        End Get
        Set(ByVal Value As Double)
            Dbvolume = Value
        End Set
    End Property
    Property temperature() As Double
        Get
            Return Dbtemperature
        End Get
        Set(ByVal Value As Double)
            Dbtemperature = Value
        End Set
    End Property
    Property material() As Double
        Get
            Return intmaterial
        End Get
        Set(ByVal Value As Double)
            intmaterial = Value
        End Set
    End Property
    Property country() As String
        Get
            Return strcountry
        End Get
        Set(ByVal Value As String)
            strcountry = Value
        End Set
    End Property

    Public Function GETEnergy() As Double
        Dim dbenergy As Double
        dbenergy = dbvolume * dbtemperature * 0.037 * 1.006
        Return dbenergy
    End Function

    Public Function Getcost() As Double
        Dim dbcost As Double
        Dim dbenergy As Double

        dbenergy = GETEnergy()

        If intmaterial = MaterialEnum.GAS Then
            If strcountry = CountriesEnum.SWEDEN Then dbcost = dbenergy * 0.11 * 100 / 3664.528
            If strcountry = CountriesEnum.ITALY Then dbcost = dbenergy * 0.07 * 100 / 3664.528
            If strcountry = CountriesEnum.GERMANY Then dbcost = dbenergy * 0.06 * 100 / 3664.528


            Return dbcost

        End If

        If intmaterial = MaterialEnum.ELECTRICITY Then
            If strcountry = CountriesEnum.SWEDEN Then dbcost = dbenergy * 0.1917 * 100 / 3599.9
            If strcountry = CountriesEnum.ITALY Then dbcost = dbenergy * 0.2067 * 100 / 3599.9
            If strcountry = CountriesEnum.GERMANY Then dbcost = dbenergy * 0.295 * 100 / 3599.9

            Return dbcost

        End If

        If intmaterial = MaterialEnum.COAL Then
            If strcountry = CountriesEnum.SWEDEN Then dbcost = dbenergy * 65.7 * 100 / 22274564.264
            If strcountry = CountriesEnum.ITALY Then dbcost = dbenergy * 64.2 * 100 / 22274564.264
            If strcountry = CountriesEnum.GERMANY Then dbcost = dbenergy * 63.1 * 100 / 22274564.264


            Return dbcost

        End If

        Return 0

    End Function

End Class