/*
 * Ian McConihay
 * CST-150
 * Activity 4
 * Sep 15 2024
 * 
 */
namespace CST_150_Activity_3
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            selectFileDialog.InitialDirectory = Application.StartupPath + @"Data";
            selectFileDialog.Title = "Browse Txt Files";
            selectFileDialog.DefaultExt = "txt";
            selectFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            lblResults.Visible = false;
            lblSelectedFile.Visible = false;
            cmbSelectRow.Visible = false;
            lblSelectRow.Visible = false;
        }

        private void BtnReadFileClickEvent(object sender, EventArgs e)
        {
            string txtFile = "";
            string dirLocation = "";
            const int PadSpace = 20;
            string header1 = "Type", header2 = "Color", header3 = "Qty";
            string headerLine1 = "----", headerLine2 = "-----", headerLine3 = "---";
            // cmb Rows
            int numberRows = 1;
            // Var for qty update
            int qtyValue = -1;
            int rowSelected = -1;

            if (this.selectFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFile = this.selectFileDialog.FileName;
                dirLocation = Path.GetFullPath(selectFileDialog.FileName);
                lblSelectedFile.Text = txtFile;
                lblSelectedFile.Visible = true;
            }

            string[] lines = File.ReadAllLines(txtFile);

            lblResults.Text = "";
            lblResults.Text = string.Format("{0}{1}{2}\n", header1.PadRight(PadSpace), header2.PadRight(PadSpace), header3.PadRight(PadSpace));
            lblResults.Text += string.Format("{0}{1}{2}\n", headerLine1.PadRight(PadSpace), headerLine2.PadRight(PadSpace), headerLine3.PadRight(PadSpace));
            foreach (string line in lines)
            {
                //Populates the comboBox
                cmbSelectRow.Items.Add(numberRows);
                numberRows++;

                string[] inventoryList = line.Split(", ");

                for (int i = 0; i < inventoryList.Length; i++)
                {
                    ConvertLowerCase(inventoryList[i]);

                }
                lblResults.Text += "\n";
            }
            lblResults.Visible = true;
            cmbSelectRow.Visible = true;
            lblSelectRow.Visible = true;

            // Get the Row that is selected from the comboBox
            rowSelected = SelectedRow();
            if(rowSelected >= 0)
            {
                qtyValue = GetQty(lines, rowSelected);
                IncDisplayQty(lines, rowSelected, qtyValue, txtFile);
            }
        }



        /// <summary>
        /// Convert input string to all lower case Charachters
        /// </summary>
        /// <param name="textToConvert"></param>
        private void ConvertLowerCase(string textToConvert)
        {
            ResultsToLabel(textToConvert.ToLower());
        }

        /// <summary>
        /// Print results to label
        /// </summary>
        /// <param name="results"></param>
        private void ResultsToLabel(string results)
        {
            const int PadSpace = 20;
            lblResults.Text += results.PadRight(PadSpace);
        }

        /// <summary>
        /// Return the row selected in the pull down
        /// </summary>
        /// <returns>int</returns>
        private int SelectedRow()
        {
            if (cmbSelectRow.SelectedIndex >= 0)
            {
                return cmbSelectRow.SelectedIndex;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Get the Qty value from selected row
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="selectedRow"></param>
        /// <returns></returns>
        private int GetQty(string[] lines, int selectedRow)
        {
            int qty = -1;

            for (int x = 1; x < lines.Length; x++)
            {
                if (x == selectedRow)
                {
                    string[] invRow = lines[x].Split(",");
                    try
                    {
                        qty = int.Parse(invRow[2].Trim());
                        return qty;
                    }
                    catch (FormatException e)
                    {
                        lblResults.Text = e.Message;
                    }
                }

            }
            return qty;
        }

        /// <summary>
        /// This builds the string for file save to file
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="invRowToUpdate"></param>
        /// <param name="qty"></param>
        /// <param name="txtFile"></param>
        private void IncDisplayQty(string[] lines, int invRowToUpdate, int qty, string txtFile)
        {
            string updateLine = "";
            qty++;
            //Split up the row
            string[] invRow = lines[invRowToUpdate].Split(",");
            //Update the element in the string array
            invRow[2] = qty.ToString();
            //Build the string to store in the Lines array
            updateLine = invRow[0].Trim() + ", " + invRow[1].Trim() + ", " + invRow[2].Trim();
            //Update the lines array
            lines[invRowToUpdate] = updateLine;
            //Update the file
            File.WriteAllLines(txtFile, lines);
        }
    }
}

