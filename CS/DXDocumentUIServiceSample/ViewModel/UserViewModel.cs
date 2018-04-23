using DevExpress.Mvvm;
using DXDocumentUIServiceSample.Common;
using System;
using System.Collections.ObjectModel;

namespace DXDocumentUIServiceSample.ViewModel {
    public class UserViewModel : IDocumentContent {
        public virtual int ID { get; set; }
        public virtual string NickName { get; set; }
        public virtual DateTime Registration { get; set; }
        public virtual Decimal Rating { get; set; }
        public virtual ObservableCollection<ActionsPerMonth> GlobalUserActivity { get; set; }
        public virtual ObservableCollection<ActionsPerMonth> LocalUserActivity { get; set; }

        public void Close() {
            DocumentOwner.Close(this, false);
        }

        #region IDocumentContent
        public IDocumentOwner DocumentOwner { get; set; }

        public void OnClose(System.ComponentModel.CancelEventArgs e) { }

        public void OnDestroy() { }

        public object Title {
            get { return String.Format("{1} ({2})",ID, NickName, Registration.ToShortDateString()); }
        }
        #endregion
    }
}
