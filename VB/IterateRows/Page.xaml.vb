Imports System.Collections.ObjectModel

Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
        AgDataGrid1.DataSource = GetData()
    End Sub

    Private Function GetData() As ObservableCollection(Of MyDataObject)
        Dim list As ObservableCollection(Of MyDataObject) = New ObservableCollection(Of MyDataObject)()
        list.Add(New MyDataObject() With {.Item = "SD970 IS", .Price = 379.99D, .Discontinued = False, .Announced = New DateTime(2009, 2, 18)})
        list.Add(New MyDataObject() With {.Item = "G10", .Price = 419.99D, .Discontinued = False, .Announced = New DateTime(2008, 9, 17)})
        list.Add(New MyDataObject() With {.Item = "A580", .Price = 118D, .Discontinued = False, .Announced = New DateTime(2008, 1, 24)})
        list.Add(New MyDataObject() With {.Item = "EOS D30", .Price = 275D, .Discontinued = True, .Announced = New DateTime(2000, 5, 17)})
        Return list
    End Function

    Private Sub BtnGridRows_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim list As String = ""
        For i As Integer = 0 To AgDataGrid1.RowCount - 1
            Dim rowHandle As Integer = AgDataGrid1.GetRowHandleByVisibleIndex(i)
            If rowHandle < 0 Then
                Continue For
            End If
            Dim isDiscontinued As Boolean = CBool(AgDataGrid1.GetCellValue(rowHandle, "Discontinued"))
            If (Not isDiscontinued) Then
                Dim item As String = CStr(AgDataGrid1.GetCellValue(rowHandle, "Item"))
                list &= item & Constants.vbCrLf
            End If
        Next i
        MessageBox.Show(list, "Available items:", MessageBoxButton.OK)
    End Sub

    Private Sub BtnDataRows_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        Dim list As String = ""
        Dim dataList As ObservableCollection(Of MyDataObject)
        dataList = CType(AgDataGrid1.DataSource, ObservableCollection(Of MyDataObject))
        For Each dataObject As MyDataObject In dataList
            If (Not dataObject.Discontinued) Then
                list &= dataObject.Item & Constants.vbCrLf
            End If
        Next dataObject
        MessageBox.Show(list, "Available items:", MessageBoxButton.OK)
    End Sub
End Class
