Imports DevExpress.Mvvm
Imports DXDocumentUIServiceSample.Common
Imports System
Imports System.Collections.ObjectModel

Namespace DXDocumentUIServiceSample.ViewModel
	Public Class UserViewModel
		Implements IDocumentContent

		Public Overridable Property ID() As Integer
		Public Overridable Property NickName() As String
		Public Overridable Property Registration() As Date
		Public Overridable Property Rating() As Decimal
		Public Overridable Property GlobalUserActivity() As ObservableCollection(Of ActionsPerMonth)
		Public Overridable Property LocalUserActivity() As ObservableCollection(Of ActionsPerMonth)

		Public Sub Close()
			DocumentOwner.Close(Me, False)
		End Sub

		#Region "IDocumentContent"
		Public Property DocumentOwner() As IDocumentOwner Implements IDocumentContent.DocumentOwner

		Public Sub OnClose(ByVal e As System.ComponentModel.CancelEventArgs) Implements IDocumentContent.OnClose
		End Sub

		Public Sub OnDestroy() Implements IDocumentContent.OnDestroy
		End Sub

		Public ReadOnly Property Title() As Object Implements IDocumentContent.Title
			Get
				Return String.Format("{1} ({2})",ID, NickName, Registration.ToShortDateString())
			End Get
		End Property
		#End Region
	End Class
End Namespace
