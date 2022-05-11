﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class ViewOperatorsVM
    {
        class ViewOperatorsVM : BaseVM
        {
            private List<Operator> operators;
            private List<int> pageIndexes;
            private int selectedIndex;
            private int viewRowsCount;

            public List<Operator> Operators
            {
                get => operators;
                set
                {
                    operators = value;
                    Signal();
                }
            }
            public CommandVM ViewBack { get; set; }
            public CommandVM ViewForward { get; set; }
            public List<int> PageIndexes
            {
                get => pageIndexes;
                set
                {
                    pageIndexes = value;
                    Signal();
                }
            }
            public int SelectedIndex
            {
                get => selectedIndex;
                set
                {
                    selectedIndex = value;
                    Operators = SqlModel.GetInstance().SelectOperatorsRange((selectedIndex - 1) * ViewRowsCount, ViewRowsCount);
                    Signal();
                }
            }
            public int[] RowsCountVariants { get; set; }
            public int ViewRowsCount
            {
                get => viewRowsCount;
                set
                {
                    viewRowsCount = value;
                    InitPages();
                    Signal();
                }
            }

            public ViewOperatorsVM()
            {
                RowsCountVariants = new int[] { 2, 5, 10 };
                ViewRowsCount = 5;

                ViewBack = new CommandVM(() =>
                {
                    if (SelectedIndex > 1)
                        SelectedIndex--;
                });

                ViewForward = new CommandVM(() =>
                {
                    if (SelectedIndex < PageIndexes.Last())
                        SelectedIndex++;
                });
            }

            private void InitPages()
            {
                var sqlModel = SqlModel.GetInstance();
                int pageCount = (sqlModel.GetNumRows(typeof(Operator)) / ViewRowsCount) + 1;
                PageIndexes = new List<int>(Enumerable.Range(1, pageCount));
                SelectedIndex = 1;
            }
        }
    }
}