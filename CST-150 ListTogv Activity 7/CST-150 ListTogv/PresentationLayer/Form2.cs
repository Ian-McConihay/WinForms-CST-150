/*
* Ian McConihay
* CST-150
* Activity 7
* Oct 6 2024
* 
*/

using CST_150_ListTogv.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_150_ListTogv.PresentationLayer
{
    public partial class FrmSecondary : Form
    {
        // Class level List
        List<InvItem> mySearch = new List<InvItem>();

        public FrmSecondary(List<InvItem> invSearch)
        {
            InitializeComponent();

            this.mySearch = invSearch;
        }

        /// <summary>
        /// When the form is loaded populate the gird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLoad_EventHandler(object sender, EventArgs e)
        {
            gvSearchResults.DataSource = this.mySearch;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
