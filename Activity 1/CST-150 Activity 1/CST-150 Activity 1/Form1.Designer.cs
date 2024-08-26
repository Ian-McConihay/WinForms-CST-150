namespace CST_150_Activity_1
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
            lblEarth = new Label();
            txtEarthWeight = new TextBox();
            lblMars = new Label();
            lblMarsWeight = new Label();
            btnConvert = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblEarth
            // 
            lblEarth.AutoSize = true;
            lblEarth.Location = new Point(242, 128);
            lblEarth.Name = "lblEarth";
            lblEarth.Size = new Size(147, 15);
            lblEarth.TabIndex = 0;
            lblEarth.Text = "Enter your weight on Earth";
            lblEarth.Click += label1_Click;
            // 
            // txtEarthWeight
            // 
            txtEarthWeight.Location = new Point(399, 120);
            txtEarthWeight.Name = "txtEarthWeight";
            txtEarthWeight.PlaceholderText = "lbs";
            txtEarthWeight.Size = new Size(100, 23);
            txtEarthWeight.TabIndex = 1;
            txtEarthWeight.TextChanged += textBox1_TextChanged;
            // 
            // lblMars
            // 
            lblMars.AutoSize = true;
            lblMars.Location = new Point(242, 154);
            lblMars.Name = "lblMars";
            lblMars.Size = new Size(116, 15);
            lblMars.TabIndex = 2;
            lblMars.Text = "Your weight on Mars";
            lblMars.Click += label1_Click_1;
            // 
            // lblMarsWeight
            // 
            lblMarsWeight.AutoSize = true;
            lblMarsWeight.BackColor = Color.DarkOrange;
            lblMarsWeight.Location = new Point(399, 154);
            lblMarsWeight.Name = "lblMarsWeight";
            lblMarsWeight.Size = new Size(32, 15);
            lblMarsWeight.TabIndex = 3;
            lblMarsWeight.Text = "label";
            lblMarsWeight.Click += label1_Click_2;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(399, 196);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(75, 23);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += ConvertButtonClickEvent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(505, 128);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 5;
            label1.Text = "lbs";
            label1.Click += label1_Click_3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnConvert);
            Controls.Add(lblMarsWeight);
            Controls.Add(lblMars);
            Controls.Add(txtEarthWeight);
            Controls.Add(lblEarth);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEarth;
        private TextBox txtEarthWeight;
        private Label lblMars;
        private Label lblMarsWeight;
        private Button btnConvert;
        private Label label1;
    }
}
