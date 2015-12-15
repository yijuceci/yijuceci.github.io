﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http

Public Class WebApiConfig
    Public Shared Sub Register(ByVal config As HttpConfiguration)
        config.Routes.MapHttpRoute( _
            name:="DefaultApi", _
            routeTemplate:="api/{controller}/{id}", _
            defaults:=New With {.id = RouteParameter.Optional} _
        )
        
        '取消註解以下程式碼行以啟用透過 IQueryable 或 IQueryable(Of T) 傳回類型的動作查詢支援。
        '為了避免處理未預期或惡意佇列，請使用 QueryableAttribute 中的驗證設定來驗證傳入的查詢。
        '如需詳細資訊，請造訪 http://go.microsoft.com/fwlink/?LinkId=279712。
        'config.EnableQuerySupport()
        
        '若要停用您應用程式中的追蹤，請將下列程式碼行標記為註解或加以移除
        '如需詳細資訊，請參閱: http://www.asp.net/web-api
        config.EnableSystemDiagnosticsTracing()
    End Sub
End Class