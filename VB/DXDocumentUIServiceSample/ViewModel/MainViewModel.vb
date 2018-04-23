Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.POCO
Imports DevExpress.Mvvm.DataAnnotations
Imports System.Linq
Imports System.Collections.ObjectModel
Imports DXDocumentUIServiceSample.Common

Namespace DXDocumentUIServiceSample.ViewModel
	<POCOViewModel>
	Public Class MainViewModel
		Protected ReadOnly Property DocumentManagerService() As IDocumentManagerService
			Get
				Return Me.GetService(Of IDocumentManagerService)()
			End Get
		End Property
		Public Overridable Property Users() As ObservableCollection(Of UserViewModel)

		Public Sub New()
			Users = DataHelper.GetUsers()
		End Sub

		Public Sub CreateDocument(ByVal arg As Object)
			Dim doc As IDocument = DocumentManagerService.FindDocument(arg)
			If doc Is Nothing Then
				doc = DocumentManagerService.CreateDocument("DetailedView", arg)
				doc.Id = DocumentManagerService.Documents.Count()
			End If
			doc.Show()
		End Sub
	End Class
End Namespace
