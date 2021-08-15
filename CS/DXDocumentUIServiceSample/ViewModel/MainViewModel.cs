using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.Xpf;
using DXDocumentUIServiceSample.Common;
using System.Collections.ObjectModel;
using System.Linq;

namespace DXDocumentUIServiceSample.ViewModel {
    [POCOViewModel]
    public class MainViewModel {
        protected IDocumentManagerService DocumentManagerService { get { return this.GetService<IDocumentManagerService>(); } }
        public virtual ObservableCollection<UserViewModel> Users { get; set; }

        public MainViewModel() {
            Users = DataHelper.GetUsers();
        }

        [Command]
        public void DoubleClick(RowClickArgs args) {
            CreateDocument(args.Item);
        }

        [Command]
        public void CreateDocument(object viewModel) {
            var doc = DocumentManagerService.FindDocument(viewModel);
            if(doc == null) {
                doc = DocumentManagerService.CreateDocument("DetailedView", viewModel);
                doc.Id = DocumentManagerService.Documents.Count();
            }
            doc.Show();
        }
    }
}
