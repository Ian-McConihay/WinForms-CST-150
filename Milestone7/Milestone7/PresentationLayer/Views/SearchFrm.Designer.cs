namespace CST_150_ListTogv.PresentationLayer
{
    partial class SearchFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gvSearchResults = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gvSearchResults).BeginInit();
            SuspendLayout();
            // 
            // gvSearchResults
            // 
            gvSearchResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvSearchResults.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gvSearchResults.BackgroundColor = SystemColors.Info;
            gvSearchResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvSearchResults.Location = new Point(10, 12);
            gvSearchResults.Name = "gvSearchResults";
            gvSearchResults.Size = new Size(735, 243);
            gvSearchResults.TabIndex = 0;
            // 
            // SearchFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(757, 314);
            Controls.Add(gvSearchResults);
            Name = "SearchFrm";
            Text = "Generated Inventory List";
            Load += FrmLoad_EventHandler;
            Click += closeButton_Click;
            ((System.ComponentModel.ISupportInitialize)gvSearchResults).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gvSearchResults;
    }
}