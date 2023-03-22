using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyBookHub
{
    /// <summary>
    /// Interaction logic for HistoryUC.xaml
    /// </summary>
    public partial class HistoryUC : UserControl
    {
        public HistoryUC()
        {
            InitializeComponent();
        }
        private void ButtonPrint(object sender, RoutedEventArgs e)
        {
            try
            {
                //get the pdf file the user selected
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    DefaultExt = ".pdf",
                    Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
                };
                bool? fileOpenResult = openFileDialog.ShowDialog();
                if (fileOpenResult != true)
                {
                    return;
                }

                //show a printdialog to user where attributes can be changed
                PrintDialog printDialog = new PrintDialog();
                printDialog.PageRangeSelection = PageRangeSelection.AllPages;
                printDialog.UserPageRangeEnabled = true;
                bool? doPrint = printDialog.ShowDialog();
                if (doPrint != true)
                {
                    return;
                }
            }

            finally
            {
                this.IsEnabled = true;
            }
            
            
         

        }
    }
}
