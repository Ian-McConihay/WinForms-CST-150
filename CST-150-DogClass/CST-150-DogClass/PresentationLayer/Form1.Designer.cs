namespace CST_150_DogClass
{
    partial class FrmMain
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
            btnAddDog = new Button();
            cmbSit = new ComboBox();
            txtNeck = new TextBox();
            txtColor = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            grbAttributes = new GroupBox();
            txtWeight = new TextBox();
            label7 = new Label();
            label6 = new Label();
            gvShowDogs = new DataGridView();
            lblErrorMessage = new Label();
            grbAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvShowDogs).BeginInit();
            SuspendLayout();
            // 
            // btnAddDog
            // 
            btnAddDog.AutoSize = true;
            btnAddDog.Location = new Point(12, 12);
            btnAddDog.Name = "btnAddDog";
            btnAddDog.Size = new Size(103, 30);
            btnAddDog.TabIndex = 0;
            btnAddDog.Text = "Add New Dog";
            btnAddDog.UseVisualStyleBackColor = true;
            btnAddDog.Click += BtnAddNewDog_ClickEvent;
            // 
            // cmbSit
            // 
            cmbSit.FormattingEnabled = true;
            cmbSit.Location = new Point(111, 167);
            cmbSit.Name = "cmbSit";
            cmbSit.Size = new Size(100, 28);
            cmbSit.TabIndex = 1;
            // 
            // txtNeck
            // 
            txtNeck.Location = new Point(112, 104);
            txtNeck.Name = "txtNeck";
            txtNeck.Size = new Size(100, 26);
            txtNeck.TabIndex = 2;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(111, 217);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(100, 26);
            txtColor.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(111, 43);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 26);
            txtName.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 43);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 5;
            label1.Text = "Dog Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 104);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 6;
            label2.Text = "Neck Radius";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 170);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 7;
            label3.Text = "Sitting";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 223);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 8;
            label4.Text = "Color";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(218, 110);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 9;
            label5.Text = "inches";
            // 
            // grbAttributes
            // 
            grbAttributes.Controls.Add(txtWeight);
            grbAttributes.Controls.Add(label7);
            grbAttributes.Controls.Add(label6);
            grbAttributes.Controls.Add(txtNeck);
            grbAttributes.Controls.Add(label5);
            grbAttributes.Controls.Add(cmbSit);
            grbAttributes.Controls.Add(label4);
            grbAttributes.Controls.Add(txtColor);
            grbAttributes.Controls.Add(label3);
            grbAttributes.Controls.Add(txtName);
            grbAttributes.Controls.Add(label2);
            grbAttributes.Controls.Add(label1);
            grbAttributes.Location = new Point(12, 59);
            grbAttributes.Name = "grbAttributes";
            grbAttributes.Size = new Size(307, 322);
            grbAttributes.TabIndex = 10;
            grbAttributes.TabStop = false;
            grbAttributes.Text = "Dog Attributes";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(111, 268);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(100, 26);
            txtWeight.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(218, 274);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 11;
            label7.Text = "pounds";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 274);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 10;
            label6.Text = "Weight";
            // 
            // gvShowDogs
            // 
            gvShowDogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvShowDogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvShowDogs.Location = new Point(353, 59);
            gvShowDogs.Name = "gvShowDogs";
            gvShowDogs.Size = new Size(508, 322);
            gvShowDogs.TabIndex = 11;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(12, 396);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(317, 20);
            lblErrorMessage.TabIndex = 12;
            lblErrorMessage.Text = "Please fix the inccorect data entry...Then try again...";
            lblErrorMessage.Visible = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblErrorMessage);
            Controls.Add(gvShowDogs);
            Controls.Add(grbAttributes);
            Controls.Add(btnAddDog);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMain";
            Text = "Form1";
            Load += FrmMainLoadEventHandler;
            grbAttributes.ResumeLayout(false);
            grbAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvShowDogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddDog;
        private ComboBox cmbSit;
        private TextBox txtNeck;
        private TextBox txtColor;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox grbAttributes;
        private DataGridView gvShowDogs;
        private TextBox txtWeight;
        private Label label7;
        private Label label6;
        private Label lblErrorMessage;
    }
}
