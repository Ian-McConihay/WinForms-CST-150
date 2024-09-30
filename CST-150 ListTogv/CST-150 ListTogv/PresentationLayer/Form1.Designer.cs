namespace CST_150_ListTogv
{
    partial class FrmInventory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gvInv = new DataGridView();
            btnIncQty = new Button();
            ((System.ComponentModel.ISupportInitialize)gvInv).BeginInit();
            SuspendLayout();
            // 
            // gvInv
            // 
            gvInv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvInv.Location = new Point(103, 90);
            gvInv.Name = "gvInv";
            gvInv.Size = new Size(581, 231);
            gvInv.TabIndex = 0;
            gvInv.Click += GridView_ClickEventHandler;
            // 
            // btnIncQty
            // 
            btnIncQty.Location = new Point(77, 37);
            btnIncQty.Name = "btnIncQty";
            btnIncQty.Size = new Size(75, 23);
            btnIncQty.TabIndex = 1;
            btnIncQty.Text = "Inc Qty";
            btnIncQty.UseVisualStyleBackColor = true;
            btnIncQty.Click += BtnIncQty_ClickEventHandler;
            // 
            // FrmInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIncQty);
            Controls.Add(gvInv);
            Name = "FrmInventory";
            Text = "Inventory";
            Load += PopulateGrid_LoadEventHandler;
            ((System.ComponentModel.ISupportInitialize)gvInv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gvInv;
        private Button btnIncQty;
    }
}
