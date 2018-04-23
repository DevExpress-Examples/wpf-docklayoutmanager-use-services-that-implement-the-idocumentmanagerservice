Imports DevExpress.Mvvm.POCO
Imports DXDocumentUIServiceSample.ViewModel
Imports System
Imports System.Collections.ObjectModel
Imports System.Linq

Namespace DXDocumentUIServiceSample.Common
	Public NotInheritable Class DataHelper

		Private Sub New()
		End Sub

		Private Shared r As New Random()
		Public Shared Function GetUsers() As ObservableCollection(Of UserViewModel)
			Dim temp As New ObservableCollection(Of UserViewModel)()

			temp.Add(ViewModelSource.Create(Function() New UserViewModel() With {.ID = 1, .NickName = "Alex", .Rating = 3455, .Registration = Date.Now.AddDays(-436)}))
			temp.LastOrDefault().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault().Registration)
			temp.LastOrDefault().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault().Registration)

			temp.Add(ViewModelSource.Create(Function() New UserViewModel() With {.ID = 2, .NickName = "Jack", .Rating = 1210, .Registration = Date.Now.AddDays(-231)}))
			temp.LastOrDefault().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault().Registration)
			temp.LastOrDefault().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault().Registration)

			temp.Add(ViewModelSource.Create(Function() New UserViewModel() With {.ID = 3, .NickName = "Ann", .Rating = 3243, .Registration = Date.Now.AddDays(-243)}))
			temp.LastOrDefault().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault().Registration)
			temp.LastOrDefault().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault().Registration)

			temp.Add(ViewModelSource.Create(Function() New UserViewModel() With {.ID = 4, .NickName = "John", .Rating = 1533, .Registration = Date.Now.AddDays(-123)}))
			temp.LastOrDefault().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault().Registration)
			temp.LastOrDefault().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault().Registration)

			temp.Add(ViewModelSource.Create(Function() New UserViewModel() With {.ID = 5, .NickName = "Mike", .Rating = 5356, .Registration = Date.Now.AddDays(-342)}))
			temp.LastOrDefault().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault().Registration)
			temp.LastOrDefault().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault().Registration)

			temp.Add(ViewModelSource.Create(Function() New UserViewModel() With {.ID = 6, .NickName = "Deny", .Rating = 4323, .Registration = Date.Now.AddDays(-234)}))
			temp.LastOrDefault().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault().Registration)
			temp.LastOrDefault().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault().Registration)

			temp.Add(ViewModelSource.Create(Function() New UserViewModel() With {.ID = 7, .NickName = "Paul", .Rating = 7871, .Registration = Date.Now.AddDays(-182)}))
			temp.LastOrDefault().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault().Registration)
			temp.LastOrDefault().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault().Registration)

			temp.Add(ViewModelSource.Create(Function() New UserViewModel() With {.ID = 8, .NickName = "Jessica", .Rating = 234, .Registration = Date.Now.AddDays(-65)}))
			temp.LastOrDefault().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault().Registration)
			temp.LastOrDefault().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault().Registration)

			temp.Add(ViewModelSource.Create(Function() New UserViewModel() With {.ID = 9, .NickName = "Ted", .Rating = 3212, .Registration = Date.Now.AddDays(-364)}))
			temp.LastOrDefault().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault().Registration)
			temp.LastOrDefault().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault().Registration)

			temp.Add(ViewModelSource.Create(Function() New UserViewModel() With {.ID = 10, .NickName = "Nickol", .Rating = 4514, .Registration = Date.Now.AddDays(-423)}))
			temp.LastOrDefault().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault().Registration)
			temp.LastOrDefault().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault().Registration)

			temp.Add(ViewModelSource.Create(Function() New UserViewModel() With {.ID = 11, .NickName = "Nick", .Rating = 2214, .Registration = Date.Now.AddDays(-71)}))
			temp.LastOrDefault().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault().Registration)
			temp.LastOrDefault().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault().Registration)

			temp.Add(ViewModelSource.Create(Function() New UserViewModel() With {.ID = 5, .NickName = "Jonny", .Rating = 2112, .Registration = Date.Now.AddDays(-212)}))
			temp.LastOrDefault().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault().Registration)
			temp.LastOrDefault().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault().Registration)

			Return temp
		End Function

		Private Shared Function GetGlobalUserActions(ByVal start As Date) As ObservableCollection(Of ActionsPerMonth)
			Dim actions As New ObservableCollection(Of ActionsPerMonth)()
			Do While start < Date.Now
				actions.Add(ViewModelSource.Create(Function() New ActionsPerMonth() With {.Count = r.Next(1000), .Month = start}))
				start = start.AddMonths(1)
			Loop
			Return actions
		End Function

		Private Shared Function GetLocalUserActions(ByVal start As Date) As ObservableCollection(Of ActionsPerMonth)
			Dim actions As New ObservableCollection(Of ActionsPerMonth)()
			Do While start < Date.Now
				actions.Add(ViewModelSource.Create(Function() New ActionsPerMonth() With {.Count = r.Next(500), .Month = start}))
				start = start.AddMonths(1)
			Loop
			Return actions
		End Function
	End Class
End Namespace
