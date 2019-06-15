Public Class OperationsUtils
    'Here are called the utils and direct comunication with the front end. This is also a singelton

    Dim actionsUtils As ActionsUtils = ActionsUtils.GetInstance
    Dim fileUtils As FileUtils = FileUtils.GetInstance

    Private Sub New()

    End Sub

    Public Shared ReadOnly Property GetInstance As OperationsUtils
        Get
            Static Instance As OperationsUtils = New OperationsUtils
            Return Instance
        End Get
    End Property

    Public Sub insert(heatingModel As Heating)
        actionsUtils.insert(heatingModel)
    End Sub

    Public Function fetchAllHeatingData() As DataSet
        Return actionsUtils.fetchAllHeatingData()
    End Function

    Public Function filterData(filter As Filter) As DataSet
        Return actionsUtils.filterData(filter)
    End Function

    Public Function exportToFile(list As ArrayList) As Boolean
        Return fileUtils.exportToFile(list)
    End Function

End Class
