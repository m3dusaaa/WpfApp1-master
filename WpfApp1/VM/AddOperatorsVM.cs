﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class AddOperatorsVM
  {
        public class AddOperatorsVM
        {
            public Operator AddOperator { get; set; }
            public CommandVM SaveOperator { get; set; }

            private CurrentPageControl currentPageControl;
            public AddOperatorsVM(CurrentPageControl currentPageControl)
            {
                this.currentPageControl = currentPageControl;
                AddOperator = new Operator();
                InitCommand();
            }
            public AddOperatorsVM(AddOperator AddOperator, CurrentPageControl currentPageControl)
            {
                this.currentPageControl = currentPageControl;
                AddOperator = AddOperator;
                InitCommand();
            }

            private void InitCommand()
            {
                SaveOperator = new CommandVM(() =>
                {
                    var model = SqlModel.GetInstance();
                    if (AddOperator.ID == 0)
                        model.Insert(AddOperator);
                    else
                        model.Update(AddOperator);
                    currentPageControl.Back();
                });
            }



        }
    }
}
