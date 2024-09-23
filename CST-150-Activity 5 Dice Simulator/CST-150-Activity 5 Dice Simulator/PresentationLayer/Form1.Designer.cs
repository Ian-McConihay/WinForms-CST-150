namespace CST_150_Activity_5_Dice_Simulator
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
            btnRollDice = new Button();
            picBoxDiceOne = new PictureBox();
            picBoxDiceTwo = new PictureBox();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)picBoxDiceOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxDiceTwo).BeginInit();
            SuspendLayout();
            // 
            // btnRollDice
            // 
            btnRollDice.BackColor = Color.SandyBrown;
            btnRollDice.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRollDice.Location = new Point(178, 106);
            btnRollDice.Name = "btnRollDice";
            btnRollDice.Size = new Size(181, 85);
            btnRollDice.TabIndex = 0;
            btnRollDice.Text = "Roll Dice";
            btnRollDice.UseVisualStyleBackColor = false;
            btnRollDice.Click += btnRollDice_Click;
            // 
            // picBoxDiceOne
            // 
            picBoxDiceOne.BackgroundImageLayout = ImageLayout.Center;
            picBoxDiceOne.Location = new Point(178, 266);
            picBoxDiceOne.Name = "picBoxDiceOne";
            picBoxDiceOne.Size = new Size(151, 152);
            picBoxDiceOne.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxDiceOne.TabIndex = 1;
            picBoxDiceOne.TabStop = false;
            // 
            // picBoxDiceTwo
            // 
            picBoxDiceTwo.Location = new Point(383, 266);
            picBoxDiceTwo.Name = "picBoxDiceTwo";
            picBoxDiceTwo.Size = new Size(155, 152);
            picBoxDiceTwo.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxDiceTwo.TabIndex = 2;
            picBoxDiceTwo.TabStop = false;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 18F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblResult.ForeColor = SystemColors.Control;
            lblResult.Location = new Point(178, 209);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(77, 32);
            lblResult.TabIndex = 3;
            lblResult.Text = "label1";
            lblResult.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(869, 517);
            Controls.Add(lblResult);
            Controls.Add(picBoxDiceTwo);
            Controls.Add(picBoxDiceOne);
            Controls.Add(btnRollDice);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picBoxDiceOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxDiceTwo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRollDice;
        private PictureBox picBoxDiceOne;
        private PictureBox picBoxDiceTwo;
        private Label lblResult;
    }
}
