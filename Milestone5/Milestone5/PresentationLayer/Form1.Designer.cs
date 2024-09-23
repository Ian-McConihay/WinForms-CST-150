using Milestone5.BusinessLayer.Models;

namespace Milestone5
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
            components = new System.ComponentModel.Container();
            btnShowInventory = new Button();
            dataGridViewInventory = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            damageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            costDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            weightDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inventoryItemBindingSource = new BindingSource(components);
            btnIncrement = new Button();
            txtBoxIncQty = new TextBox();
            txtBoxQty = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryItemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnShowInventory
            // 
            btnShowInventory.BackColor = Color.DarkSeaGreen;
            btnShowInventory.Cursor = Cursors.Hand;
            btnShowInventory.Location = new Point(12, 12);
            btnShowInventory.Name = "btnShowInventory";
            btnShowInventory.Size = new Size(128, 23);
            btnShowInventory.TabIndex = 1;
            btnShowInventory.Text = "Show Inventory";
            btnShowInventory.UseVisualStyleBackColor = false;
            btnShowInventory.Click += btnShowInventory_Click;
            // 
            // dataGridViewInventory
            // 
            dataGridViewInventory.AutoGenerateColumns = false;
            dataGridViewInventory.BackgroundColor = Color.DarkSeaGreen;
            dataGridViewInventory.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventory.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, damageDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, costDataGridViewTextBoxColumn, weightDataGridViewTextBoxColumn });
            dataGridViewInventory.DataSource = inventoryItemBindingSource;
            dataGridViewInventory.Location = new Point(12, 41);
            dataGridViewInventory.Name = "dataGridViewInventory";
            dataGridViewInventory.Size = new Size(643, 150);
            dataGridViewInventory.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // damageDataGridViewTextBoxColumn
            // 
            damageDataGridViewTextBoxColumn.DataPropertyName = "Damage";
            damageDataGridViewTextBoxColumn.HeaderText = "Damage";
            damageDataGridViewTextBoxColumn.Name = "damageDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            costDataGridViewTextBoxColumn.HeaderText = "Cost";
            costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // inventoryItemBindingSource
            // 
            inventoryItemBindingSource.DataSource = typeof(InventoryItem);
            // 
            // btnIncrement
            // 
            btnIncrement.BackColor = Color.DarkSeaGreen;
            btnIncrement.Location = new Point(146, 12);
            btnIncrement.Name = "btnIncrement";
            btnIncrement.Size = new Size(75, 23);
            btnIncrement.TabIndex = 3;
            btnIncrement.Text = "Add Qty";
            btnIncrement.UseVisualStyleBackColor = false;
            btnIncrement.Click += btnIncrement_Click;
            // 
            // txtBoxIncQty
            // 
            txtBoxIncQty.Location = new Point(227, 12);
            txtBoxIncQty.Name = "txtBoxIncQty";
            txtBoxIncQty.PlaceholderText = "Enter Id";
            txtBoxIncQty.Size = new Size(100, 23);
            txtBoxIncQty.TabIndex = 4;
            // 
            // txtBoxQty
            // 
            txtBoxQty.Location = new Point(333, 12);
            txtBoxQty.Name = "txtBoxQty";
            txtBoxQty.PlaceholderText = "Enter Qty Amount";
            txtBoxQty.Size = new Size(104, 23);
            txtBoxQty.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxQty);
            Controls.Add(txtBoxIncQty);
            Controls.Add(btnIncrement);
            Controls.Add(dataGridViewInventory);
            Controls.Add(btnShowInventory);
            Name = "Form1";
            Text = "Armory Inventory";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryItemBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnShowInventory;
        private DataGridView dataGridViewInventory;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn damageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private BindingSource inventoryItemBindingSource;
        private Button btnIncrement;
        private TextBox txtBoxIncQty;
        private TextBox txtBoxQty;
    }
}
