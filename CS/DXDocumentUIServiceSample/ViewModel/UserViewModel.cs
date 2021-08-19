using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DXDocumentUIServiceSample.Common;
using System;
using System.Collections.ObjectModel;

namespace DXDocumentUIServiceSample.ViewModel {
    public class UserViewModel : ViewModelBase, IDocumentContent {
        public int ID {
            get { return GetValue<int>(); }
            set { SetValue(value); }
        }
        public string NickName {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public DateTime Registration {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }
        public decimal Rating {
            get { return GetValue<decimal>(); }
            set { SetValue(value); }
        }

        public ObservableCollection<ActionsPerMonth> GlobalUserActivity {
            get { return GetValue<ObservableCollection<ActionsPerMonth>>(); }
            set { SetValue(value); }
        }

        public ObservableCollection<ActionsPerMonth> LocalUserActivity {
            get { return GetValue<ObservableCollection<ActionsPerMonth>>(); }
            set { SetValue(value); }
        }

        [Command]
        public void Close() {
            DocumentOwner.Close(this, false);
        }

        #region IDocumentContent
        public IDocumentOwner DocumentOwner { get; set; }
        public void OnClose(System.ComponentModel.CancelEventArgs e) { }
        public void OnDestroy() { }
        public object Title { get { return $"{NickName} ({Registration.ToShortDateString()})"; } }
        #endregion
    }
}