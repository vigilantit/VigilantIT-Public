using System;
using System.Windows.Forms;
using WebsiteinForm.Properties;

namespace WebsiteinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            wbPOC.Url = new Uri(Settings.Default.URL);
        }
    }
}
