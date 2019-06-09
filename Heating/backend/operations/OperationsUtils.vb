Public Class OperationsUtils

    Dim actionsUtils As ActionsUtils = ActionsUtils.GetInstance

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

End Class
