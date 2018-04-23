using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataAnnotations;
using System.Linq;
using System.Collections.ObjectModel;
using DXDocumentUIServiceSample.Common;

namespace DXDocumentUIServiceSample.ViewModel {
    [POCOViewModel]
    public class MainViewModel {
        protected IDocumentManagerService DocumentManagerService { get { return this.GetService<IDocumentManagerService>(); } }
        public virtual ObservableCollection<UserViewModel> Users { get; set; }

        public MainViewModel() {
            Users = DataHelper.GetUsers();   
        }

        public void CreateDocument(object arg) {
            IDocument doc = DocumentManagerService.FindDocument(arg);
            if (doc == null) {
                doc = DocumentManagerService.CreateDocument("DetailedView", arg);
                doc.Id = DocumentManagerService.Documents.Count<IDocument>();
            }
            doc.Show();
        }
    }
}
