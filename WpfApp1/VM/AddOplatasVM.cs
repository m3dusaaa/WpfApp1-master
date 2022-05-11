using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.VM
{
    internal class AddOplatasVM
        
    {
        public class AddOplatasVM
        { 

        public Oplata AddOplata { get; set; }
        public CommandVM SaveOplata { get; set; }

        private CurrentPageControl currentPageControl;
        public AddOplatasVM(CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            AddOplata = new ClientOplata();
            InitCommand();
        }
        public AddOplatasVM(Oplata AddOplata, CurrentPageControl currentPageControl)
        {
            this.currentPageControl = currentPageControl;
            AddOplata = AddOplata;
            InitCommand();
        }

        private void InitCommand()
        {
            SaveClient = new CommandVM(() => {
                var model = SqlModel.GetInstance();
                if (AddOplata.ID == 0)
                    model.Insert(AddOplata);
                else
                    model.Update(AddOplata);
                currentPageControl.Back();
            });
        }



    }
}