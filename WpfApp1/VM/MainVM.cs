using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.VM
{
    class MainVM : BaseVM
    {
        CurrentPageControl currentPageControl;

        public Page CurrentPage
        {
            get => currentPageControl.Page;
        }

        public CommandVM CreateClient { get; set; }
        public CommandVM ViewClients { get; set; }
        public CommandVM CreateOperator { get; set; }
        public CommandVM ViewOperators { get; set; }

        public CommandVM CreateOplata { get; set; }
        public CommandVM ViewOplata { get; set; }
        public CommandVM CreateTour { get; set; }
        public CommandVM ViewTour { get; set; }

        public MainVM()
        {
            currentPageControl = new CurrentPageControl();
            currentPageControl.PageChanged += CurrentPageControl_PageChanged;
            currentPageControl.SetPage(new GenerateXlsxPage());
            CreateClient = new CommandVM(() => {
                currentPageControl.SetPage(new AddClientPage(new AddClientsVM(currentPageControl)));
            });
            ViewClient = new CommandVM(() => {
                currentPageControl.SetPage(new ViewClientPage());
            });
            CreateOperator = new CommandVM(() => {
                currentPageControl.SetPage(new AddOperatorPage(new AddOperatorsVM(currentPageControl)));
            });
            ViewOperator = new CommandVM(() => {
                currentPageControl.SetPage(new ViewOperatorPage(null));
            });

            CreateOplata = new CommandVM(() => {
                currentPageControl.SetPage(new AddOplataPage(new AddOplatasVM(currentPageControl)));
            });

            ViewOplata = new CommandVM(() =>
            {
                currentPageControl.SetPage(new ViewOplataPage());
            });
            CreateTour = new CommandVM(() => {
                currentPageControl.SetPage(new AddTourPage(new AddToursVM(currentPageControl)));
            });

            ViewTour = new CommandVM(() =>
            {
                currentPageControl.SetPage(new ViewTourPage());
            });
        }

        private void CurrentPageControl_PageChanged(object sender, EventArgs e)
        {
            Signal(nameof(CurrentPage));
        }
    }
}