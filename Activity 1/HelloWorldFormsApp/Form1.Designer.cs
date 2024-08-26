namespace HelloWorldFormsApp
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
            button1 = new Button();
            lblHelloWoldLabel = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Arial", 12F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(306, 114);
            button1.Name = "button1";
            button1.Size = new Size(83, 32);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ButtonOnClick;
            // 
            // lblHelloWoldLabel
            // 
            lblHelloWoldLabel.AutoSize = true;
            lblHelloWoldLabel.BackColor = SystemColors.ButtonHighlight;
            lblHelloWoldLabel.Font = new Font("Arial", 24F);
            lblHelloWoldLabel.Location = new Point(296, 55);
            lblHelloWoldLabel.Name = "lblHelloWoldLabel";
            lblHelloWoldLabel.Size = new Size(0, 36);
            lblHelloWoldLabel.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHelloWoldLabel);
            Controls.Add(button1);
            Name = "Form1";
            Text = "HelloWorldWork";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblHelloWoldLabel;
    }
}
