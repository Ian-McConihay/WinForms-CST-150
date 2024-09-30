using Milestone6.BusinessLayer.Models;

namespace Milestone6
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
            dataGridViewInventory = new DataGridView();
            inventoryItemBindingSource1 = new BindingSource(components);
            inventoryItemBindingSource = new BindingSource(components);
            btnAdd = new Button();
            txtDescription = new TextBox();
            txtDamage = new TextBox();
            txtQuantity = new TextBox();
            txtCost = new TextBox();
            txtWeight = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            searrchTxtBx = new TextBox();
            Id = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Damage = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryItemBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryItemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewInventory
            // 
            dataGridViewInventory.AllowUserToOrderColumns = true;
            dataGridViewInventory.AutoGenerateColumns = false;
            dataGridViewInventory.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventory.Columns.AddRange(new DataGridViewColumn[] { Id, Description, Damage, Quantity, Cost, Weight });
            dataGridViewInventory.DataSource = inventoryItemBindingSource1;
            dataGridViewInventory.Location = new Point(13, 23);
            dataGridViewInventory.Margin = new Padding(4, 6, 4, 6);
            dataGridViewInventory.Name = "dataGridViewInventory";
            dataGridViewInventory.Size = new Size(735, 284);
            dataGridViewInventory.TabIndex = 2;
            dataGridViewInventory.ColumnHeaderMouseClick += dataGridViewInventory_ColumnHeaderMouseClick;
            // 
            // inventoryItemBindingSource1
            // 
            inventoryItemBindingSource1.DataSource = typeof(InventoryItem);
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Location = new Point(177, 328);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 37);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(13, 384);
            txtDescription.Margin = new Padding(4, 6, 4, 6);
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Description";
            txtDescription.Size = new Size(113, 37);
            txtDescription.TabIndex = 4;
            // 
            // txtDamage
            // 
            txtDamage.Location = new Point(134, 384);
            txtDamage.Margin = new Padding(4, 6, 4, 6);
            txtDamage.Name = "txtDamage";
            txtDamage.PlaceholderText = "Damage";
            txtDamage.Size = new Size(113, 37);
            txtDamage.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(255, 384);
            txtQuantity.Margin = new Padding(4, 6, 4, 6);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.PlaceholderText = "Qty";
            txtQuantity.Size = new Size(113, 37);
            txtQuantity.TabIndex = 6;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(376, 384);
            txtCost.Margin = new Padding(4, 6, 4, 6);
            txtCost.Name = "txtCost";
            txtCost.PlaceholderText = "Gold";
            txtCost.Size = new Size(113, 37);
            txtCost.TabIndex = 7;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(497, 384);
            txtWeight.Margin = new Padding(4, 6, 4, 6);
            txtWeight.Name = "txtWeight";
            txtWeight.PlaceholderText = "Weight lbs";
            txtWeight.Size = new Size(113, 37);
            txtWeight.TabIndex = 8;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(269, 328);
            btnUpdate.Margin = new Padding(4, 6, 4, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 37);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(363, 328);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 37);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // searrchTxtBx
            // 
            searrchTxtBx.Location = new Point(13, 328);
            searrchTxtBx.Margin = new Padding(4, 6, 4, 6);
            searrchTxtBx.Name = "searrchTxtBx";
            searrchTxtBx.PlaceholderText = "Search by Description";
            searrchTxtBx.Size = new Size(156, 37);
            searrchTxtBx.TabIndex = 11;
            searrchTxtBx.TextChanged += SearchTextBox_TextChanged;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Description
            // 
            Description.DataPropertyName = "Description";
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // Damage
            // 
            Damage.DataPropertyName = "Damage";
            Damage.HeaderText = "Damage";
            Damage.Name = "Damage";
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // Cost
            // 
            Cost.DataPropertyName = "Cost";
            Cost.HeaderText = "Cost";
            Cost.Name = "Cost";
            // 
            // Weight
            // 
            Weight.DataPropertyName = "Weight";
            Weight.HeaderText = "Weight";
            Weight.Name = "Weight";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(915, 471);
            Controls.Add(searrchTxtBx);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtWeight);
            Controls.Add(txtCost);
            Controls.Add(txtQuantity);
            Controls.Add(txtDamage);
            Controls.Add(txtDescription);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewInventory);
            Font = new Font("Javanese Text", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 6, 4, 6);
            Name = "Form1";
            Text = "Armory Inventory";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryItemBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryItemBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewInventory;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn damageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private BindingSource inventoryItemBindingSource;
        private Button btnAdd;
        private TextBox txtDescription;
        private TextBox txtDamage;
        private TextBox txtQuantity;
        private TextBox txtCost;
        private TextBox txtWeight;
        private Button btnUpdate;
        private Button btnDelete;
        private BindingSource inventoryItemBindingSource1;
        private TextBox searrchTxtBx;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Damage;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Cost;
        private DataGridViewTextBoxColumn Weight;
    }
}
