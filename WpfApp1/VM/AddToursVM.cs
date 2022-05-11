using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class AddToursVM
  {
        internal class AddToursVM
        {
            public class AddToursVM
            {
                public Tour AddTour { get; set; }
                public CommandVM SaveTour { get; set; }

                private CurrentPageControl currentPageControl;
                public AddToursVM(CurrentPageControl currentPageControl)
                {
                    this.currentPageControl = currentPageControl;
                    AddTour = new Tour();
                    InitCommand();
                }
                public AddToursVM(AddTour AddTour, CurrentPageControl currentPageControl)
                {
                    this.currentPageControl = currentPageControl;
                    AddTour = AddTour;
                    InitCommand();
                }

                private void InitCommand()
                {
                    SaveTour = new CommandVM(() =>
                    {
                        var model = SqlModel.GetInstance();
                        if (AddTour.ID == 0)
                            model.Insert(AddTour);
                        else
                            model.Update(AddTour);
                        currentPageControl.Back();
                    });
                }



            }
        }
    }
}