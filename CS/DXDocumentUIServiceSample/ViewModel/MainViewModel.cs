using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Xpf;
using DXDocumentUIServiceSample.Common;
using System.Collections.ObjectModel;
using System.Linq;

namespace DXDocumentUIServiceSample.ViewModel {
    public class MainViewModel : ViewModelBase {
        IDocumentManagerService DocumentManagerService { get { return this.GetService<IDocumentManagerService>(); } }
        public ObservableCollection<UserViewModel> Users {
            get { return GetValue<ObservableCollection<UserViewModel>>(); }
            set { SetValue(value); }
        }

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