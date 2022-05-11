using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class AddClientsVM
{
    public class AddClientsVM
    {
        public Client AddClient { get; set; }
        public CommandVM SaveClient { get; set; }

        private CurrentPageControl currentPageControl;
        public AddClientsVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            AddClient = new Client();
            InitCommand();
        }
        public AddClientsVM(Client AddClient, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            AddClient = AddClient;
            InitCommand();
        }

        private void InitCommand()
        {
            SaveClient = new CommandVM(() => {
                var model = SqlModel.GetInstance();
                if (AddClient.ID == 0)
                    model.Insert(AddClient);
                else
                    model.Update(AddClient);
                currentPageControl.Back();
            });
        }



    }
}
