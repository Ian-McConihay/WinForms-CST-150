namespace CST_150_Activity_2
{
    partial class FrmTest
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
            btnRun = new Button();
            label1 = new Label();
            label2 = new Label();
            lblResults = new Label();
            txtUserEntry = new TextBox();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRun.Location = new Point(355, 122);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(139, 27);
            btnRun.TabIndex = 0;
            btnRun.Text = "Apply Seconds";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += ManageSecondsEventHandler;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 88);
            label1.Name = "label1";
            label1.Size = new Size(300, 25);
            label1.TabIndex = 1;
            label1.Text = "Enter the Number of Seconds:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(538, 93);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 2;
            label2.Text = "seconds";
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResults.Location = new Point(218, 240);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(70, 25);
            lblResults.TabIndex = 3;
            lblResults.Text = "label3";
            // 
            // txtUserEntry
            // 
            txtUserEntry.Location = new Point(355, 93);
            txtUserEntry.Name = "txtUserEntry";
            txtUserEntry.Size = new Size(161, 23);
            txtUserEntry.TabIndex = 4;
            // 
            // FrmTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtUserEntry);
            Controls.Add(lblResults);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRun);
            Name = "FrmTest";
            Text = "Activity 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private Label label1;
        private Label label2;
        private Label lblResults;
        private TextBox txtUserEntry;
    }
}
