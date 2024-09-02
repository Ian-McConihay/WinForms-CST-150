namespace Milestone2
{
    partial class Form1
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
            lblInventory = new Label();
            btnShowInventory = new Button();
            SuspendLayout();
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.BorderStyle = BorderStyle.Fixed3D;
            lblInventory.Location = new Point(12, 48);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(30, 17);
            lblInventory.TabIndex = 0;
            lblInventory.Text = "       ";
            // 
            // btnShowInventory
            // 
            btnShowInventory.Cursor = Cursors.Hand;
            btnShowInventory.Location = new Point(12, 12);
            btnShowInventory.Name = "btnShowInventory";
            btnShowInventory.Size = new Size(128, 23);
            btnShowInventory.TabIndex = 1;
            btnShowInventory.Text = "Show Inventory";
            btnShowInventory.UseVisualStyleBackColor = true;
            btnShowInventory.Click += btnShowInventory_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowInventory);
            Controls.Add(lblInventory);
            Name = "Form1";
            Text = "Armory Inventory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInventory;
        private Button btnShowInventory;
    }
}
