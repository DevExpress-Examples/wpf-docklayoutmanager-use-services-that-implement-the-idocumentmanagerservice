Imports DXDocumentUIServiceSample.ViewModel
Imports System
Imports System.Collections.ObjectModel
Imports System.Linq

Namespace DXDocumentUIServiceSample.Common
	Public Module DataHelper
		Private r As New Random()
		Public Function GetUsers() As ObservableCollection(Of UserViewModel)
			Dim temp As New ObservableCollection(Of UserViewModel)()

			temp.Add(New UserViewModel() With {
				.ID = 1,
				.NickName = "Alex",
				.Rating = 3455,
				.Registration = DateTime.Now.AddDays(-436)
			})
			RegisterLastOrDefault(temp)

			temp.Add(New UserViewModel() With {
				.ID = 2,
				.NickName = "Jack",
				.Rating = 1210,
				.Registration = DateTime.Now.AddDays(-231)
			})
			RegisterLastOrDefault(temp)

			temp.Add(New UserViewModel() With {
				.ID = 3,
				.NickName = "Ann",
				.Rating = 3243,
				.Registration = DateTime.Now.AddDays(-243)
			})
			RegisterLastOrDefault(temp)

			temp.Add(New UserViewModel() With {
				.ID = 4,
				.NickName = "John",
				.Rating = 1533,
				.Registration = DateTime.Now.AddDays(-123)
			})
			RegisterLastOrDefault(temp)

			temp.Add(New UserViewModel() With {
				.ID = 5,
				.NickName = "Mike",
				.Rating = 5356,
				.Registration = DateTime.Now.AddDays(-342)
			})
			RegisterLastOrDefault(temp)

			temp.Add(New UserViewModel() With {
				.ID = 6,
				.NickName = "Deny",
				.Rating = 4323,
				.Registration = DateTime.Now.AddDays(-234)
			})
			RegisterLastOrDefault(temp)

			temp.Add(New UserViewModel() With {
				.ID = 7,
				.NickName = "Paul",
				.Rating = 7871,
				.Registration = DateTime.Now.AddDays(-182)
			})
			RegisterLastOrDefault(temp)

			temp.Add(New UserViewModel() With {
				.ID = 8,
				.NickName = "Jessica",
				.Rating = 234,
				.Registration = DateTime.Now.AddDays(-65)
			})
			RegisterLastOrDefault(temp)

			temp.Add(New UserViewModel() With {
				.ID = 9,
				.NickName = "Ted",
				.Rating = 3212,
				.Registration = DateTime.Now.AddDays(-364)
			})
			RegisterLastOrDefault(temp)

			temp.Add(New UserViewModel() With {
				.ID = 10,
				.NickName = "Nickol",
				.Rating = 4514,
				.Registration = DateTime.Now.AddDays(-423)
			})
			RegisterLastOrDefault(temp)

			temp.Add(New UserViewModel() With {
				.ID = 11,
				.NickName = "Nick",
				.Rating = 2214,
				.Registration = DateTime.Now.AddDays(-71)
			})
			RegisterLastOrDefault(temp)

			temp.Add(New UserViewModel() With {
				.ID = 5,
				.NickName = "Jonny",
				.Rating = 2112,
				.Registration = DateTime.Now.AddDays(-212)
			})
			RegisterLastOrDefault(temp)

			Return temp
		End Function


		Private Function RegisterLastOrDefault(ByVal temp As ObservableCollection(Of UserViewModel)) As ObservableCollection(Of UserViewModel)

			temp.LastOrDefault().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault().Registration)
			temp.LastOrDefault().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault().Registration)
			Return temp
		End Function

		Private Function GetGlobalUserActions(ByVal start As DateTime) As ObservableCollection(Of ActionsPerMonth)
			Dim actions As New ObservableCollection(Of ActionsPerMonth)()
			Do While start < DateTime.Now
				actions.Add(New ActionsPerMonth() With {
					.Count = r.Next(1000),
					.Month = start
				})
				start = start.AddMonths(1)
			Loop
			Return actions
		End Function

		Private Function GetLocalUserActions(ByVal start As DateTime) As ObservableCollection(Of ActionsPerMonth)
			Dim actions As New ObservableCollection(Of ActionsPerMonth)()
			Do While start < DateTime.Now
				actions.Add(New ActionsPerMonth() With {
					.Count = r.Next(500),
					.Month = start
				})
				start = start.AddMonths(1)
			Loop
			Return actions
		End Function
	End Module
End Namespace
