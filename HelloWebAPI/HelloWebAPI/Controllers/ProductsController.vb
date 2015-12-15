Imports System.Web.Http
Imports System.Web.Script.Serialization

Public Class ProductsController
    Inherits ApiController

    ' GET /api/Products
    ''' <summary>
    ''' 取得所有產品列表
    ''' </summary>
    ''' <returns>所有產品列表</returns>
    Public Function GetAllProducts() As IEnumerable(Of Products)
        Return New List(Of Products) From {
            New Products() With {.Id = 1, .Name = "BMW 2系列雙門跑車", .fileName = "small1.jpg"},
            New Products() With {.Id = 2, .Name = "BMW 5系列四門房車", .fileName = "small2.jpg"},
            New Products() With {.Id = 3, .Name = "BMW 5系列Tourings", .fileName = "small3.jpg"}}
    End Function

    Public Function GetProductById(id As Integer) As Products

        Dim jss As New Script.Serialization.JavaScriptSerializer
        Dim result As IEnumerable(Of Products) = GetAllProducts()

        Return result.Where(Function(x) x.Id = id).SingleOrDefault

    End Function
End Class