using DevExpress.Mvvm;
using System.Linq;
using System.Collections.ObjectModel;
using DXDocumentUIServiceSample.Common;
using DevExpress.Mvvm.DataAnnotations;

namespace DXDocumentUIServiceSample.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        IDocumentManagerService DocumentManagerService { get { return this.GetService<IDocumentManagerService>(); } }
        public ObservableCollection<UserViewModel> Users {
            get { return GetValue<ObservableCollection<UserViewModel>>(); }
            set { SetValue(value); }
        }

        public MainViewModel()
        {
            Users = DataHelper.GetUsers();
        }
        [Command]
        public void CreateDocument(object arg)
        {
            IDocument doc = DocumentManagerService.FindDocument(arg);
            if (doc == null)
            {
                doc = DocumentManagerService.CreateDocument("DetailedView", arg);
                doc.Id = DocumentManagerService.Documents.Count<IDocument>();
            }
            doc.Show();
        }
    }
}