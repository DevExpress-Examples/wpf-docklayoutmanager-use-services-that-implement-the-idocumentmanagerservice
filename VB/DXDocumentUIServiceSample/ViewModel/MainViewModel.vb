Imports DevExpress.Mvvm
Imports System.Linq
Imports System.Collections.ObjectModel
Imports DXDocumentUIServiceSample.Common
Imports DevExpress.Mvvm.DataAnnotations

Namespace DXDocumentUIServiceSample.ViewModel
	Public Class MainViewModel
		Inherits ViewModelBase

		Private ReadOnly Property DocumentManagerService() As IDocumentManagerService
			Get
				Return Me.GetService(Of IDocumentManagerService)()
			End Get
		End Property
		Public Property Users() As ObservableCollection(Of UserViewModel)
			Get
				Return GetValue(Of ObservableCollection(Of UserViewModel))()
			End Get
			Set(ByVal value As ObservableCollection(Of UserViewModel))
				SetValue(value)
			End Set
		End Property

		Public Sub New()
			Users = DataHelper.GetUsers()
		End Sub
		<Command>
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