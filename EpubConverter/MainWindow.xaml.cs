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
using Microsoft.Win32;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.IO;
using EpubSharp;

namespace EpubConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void browsebutton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            if(openFileDialog.ShowDialog() == true)
            {
                pdftextbox.Text = openFileDialog.FileName;
            }
        }

        private void ConvertPdfToEpub(string pdfpath)
        {
            PdfDocument pdf = PdfReader.Open(pdfpath, PdfDocumentOpenMode.ReadOnly);
            string textcontext = "";
            foreach(PdfPage page in pdf.Pages)
            {
                textcontext += PdfTextExtracting.GetText();
            }
        }
    }
}
