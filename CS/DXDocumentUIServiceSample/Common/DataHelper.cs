using DevExpress.Mvvm.POCO;
using DXDocumentUIServiceSample.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace DXDocumentUIServiceSample.Common {
    public static class DataHelper {
        private static Random r = new Random();
        public static ObservableCollection<UserViewModel> GetUsers() {
            ObservableCollection<UserViewModel> temp = new ObservableCollection<UserViewModel>();

            temp.Add(ViewModelSource.Create(() => new UserViewModel() { ID = 1, NickName = "Alex", Rating = 3455, Registration = DateTime.Now.AddDays(-436) }));
            temp.LastOrDefault<UserViewModel>().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault<UserViewModel>().Registration);
            temp.LastOrDefault<UserViewModel>().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault<UserViewModel>().Registration);

            temp.Add(ViewModelSource.Create(() => new UserViewModel() { ID = 2, NickName = "Jack", Rating = 1210, Registration = DateTime.Now.AddDays(-231) }));
            temp.LastOrDefault<UserViewModel>().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault<UserViewModel>().Registration);
            temp.LastOrDefault<UserViewModel>().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault<UserViewModel>().Registration);

            temp.Add(ViewModelSource.Create(() => new UserViewModel() { ID = 3, NickName = "Ann", Rating = 3243, Registration = DateTime.Now.AddDays(-243) }));
            temp.LastOrDefault<UserViewModel>().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault<UserViewModel>().Registration);
            temp.LastOrDefault<UserViewModel>().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault<UserViewModel>().Registration);

            temp.Add(ViewModelSource.Create(() => new UserViewModel() { ID = 4, NickName = "John", Rating = 1533, Registration = DateTime.Now.AddDays(-123) }));
            temp.LastOrDefault<UserViewModel>().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault<UserViewModel>().Registration);
            temp.LastOrDefault<UserViewModel>().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault<UserViewModel>().Registration);

            temp.Add(ViewModelSource.Create(() => new UserViewModel() { ID = 5, NickName = "Mike", Rating = 5356, Registration = DateTime.Now.AddDays(-342) }));
            temp.LastOrDefault<UserViewModel>().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault<UserViewModel>().Registration);
            temp.LastOrDefault<UserViewModel>().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault<UserViewModel>().Registration);

            temp.Add(ViewModelSource.Create(() => new UserViewModel() { ID = 6, NickName = "Deny", Rating = 4323, Registration = DateTime.Now.AddDays(-234) }));
            temp.LastOrDefault<UserViewModel>().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault<UserViewModel>().Registration);
            temp.LastOrDefault<UserViewModel>().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault<UserViewModel>().Registration);

            temp.Add(ViewModelSource.Create(() => new UserViewModel() { ID = 7, NickName = "Paul", Rating = 7871, Registration = DateTime.Now.AddDays(-182) }));
            temp.LastOrDefault<UserViewModel>().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault<UserViewModel>().Registration);
            temp.LastOrDefault<UserViewModel>().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault<UserViewModel>().Registration);

            temp.Add(ViewModelSource.Create(() => new UserViewModel() { ID = 8, NickName = "Jessica", Rating = 234, Registration = DateTime.Now.AddDays(-65) }));
            temp.LastOrDefault<UserViewModel>().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault<UserViewModel>().Registration);
            temp.LastOrDefault<UserViewModel>().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault<UserViewModel>().Registration);

            temp.Add(ViewModelSource.Create(() => new UserViewModel() { ID = 9, NickName = "Ted", Rating = 3212, Registration = DateTime.Now.AddDays(-364) }));
            temp.LastOrDefault<UserViewModel>().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault<UserViewModel>().Registration);
            temp.LastOrDefault<UserViewModel>().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault<UserViewModel>().Registration);

            temp.Add(ViewModelSource.Create(() => new UserViewModel() { ID = 10, NickName = "Nickol", Rating = 4514, Registration = DateTime.Now.AddDays(-423) }));
            temp.LastOrDefault<UserViewModel>().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault<UserViewModel>().Registration);
            temp.LastOrDefault<UserViewModel>().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault<UserViewModel>().Registration);

            temp.Add(ViewModelSource.Create(() => new UserViewModel() { ID = 11, NickName = "Nick", Rating = 2214, Registration = DateTime.Now.AddDays(-71) }));
            temp.LastOrDefault<UserViewModel>().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault<UserViewModel>().Registration);
            temp.LastOrDefault<UserViewModel>().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault<UserViewModel>().Registration);

            temp.Add(ViewModelSource.Create(() => new UserViewModel() { ID = 5, NickName = "Jonny", Rating = 2112, Registration = DateTime.Now.AddDays(-212) }));
            temp.LastOrDefault<UserViewModel>().GlobalUserActivity = GetGlobalUserActions(temp.LastOrDefault<UserViewModel>().Registration);
            temp.LastOrDefault<UserViewModel>().LocalUserActivity = GetLocalUserActions(temp.LastOrDefault<UserViewModel>().Registration);

            return temp;
        }

        private static ObservableCollection<ActionsPerMonth> GetGlobalUserActions(DateTime start) {
            ObservableCollection<ActionsPerMonth> actions = new ObservableCollection<ActionsPerMonth>();
            while (start < DateTime.Now) {
                actions.Add(ViewModelSource.Create(() => new ActionsPerMonth() { Count = r.Next(1000), Month = start }));
                start = start.AddMonths(1);
            }
            return actions;
        }

        private static ObservableCollection<ActionsPerMonth> GetLocalUserActions(DateTime start) {
            ObservableCollection<ActionsPerMonth> actions = new ObservableCollection<ActionsPerMonth>();
            while (start < DateTime.Now) {
                actions.Add(ViewModelSource.Create(() => new ActionsPerMonth() { Count = r.Next(500), Month = start }));
                start = start.AddMonths(1);
            }
            return actions;
        }
    }
}
