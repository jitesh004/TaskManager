
using System.Windows.Forms;

namespace SimpleTaskManager1
{
    public partial class WebForm : Form
    {
        public WebForm()
        {
            InitializeComponent();
            ShowWebPage();
        }

        public void ShowWebPage()
        {

           
            this.Controls.Add(wb);
            wb.AllowNavigation = true;
            wb.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(wb_DocumentCompleted);
            string url = "https://www.google.co.in/#q=What+Is+"+Form1.SelectedProcess+"&*";
           
            wb.Navigate(url);
            
        }

        private void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser wb = sender as WebBrowser;
        }

       
    }
}
