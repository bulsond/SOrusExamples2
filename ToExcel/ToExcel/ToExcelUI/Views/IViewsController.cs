using System.Windows.Forms;
using ToExcelUI.Models;

namespace ToExcelUI.Views
{
    public interface IViewsController
    {
        bool GetChangedPerson(Person person);
        bool GetConfirmationRemove(Person person);
        Form GetMainForm();
        void ShowError(string message);
    }
}