namespace SQLFirstConnection
{
    partial class Form1
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
            this.txtBarCodeToUpdate = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNameToUpdate = new System.Windows.Forms.TextBox();
            this.txtDescToUpdate = new System.Windows.Forms.TextBox();
            this.TxtPriceToUpdate = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBarCodeD = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.OrderBy = new System.Windows.Forms.GroupBox();
            this.rdbBarcode = new System.Windows.Forms.RadioButton();
            this.rdbPrice = new System.Windows.Forms.RadioButton();
            this.rdbName = new System.Windows.Forms.RadioButton();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.OrderBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarCodeToUpdate
            // 
            this.txtBarCodeToUpdate.Location = new System.Drawing.Point(337, 70);
            this.txtBarCodeToUpdate.Name = "txtBarCodeToUpdate";
            this.txtBarCodeToUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtBarCodeToUpdate.TabIndex = 0;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(90, 164);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 1;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(90, 119);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "BarCode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Desc";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(90, 202);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Add";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(337, 243);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Desc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(284, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Name";
            // 
            // txtNameToUpdate
            // 
            this.txtNameToUpdate.Location = new System.Drawing.Point(337, 115);
            this.txtNameToUpdate.Name = "txtNameToUpdate";
            this.txtNameToUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtNameToUpdate.TabIndex = 13;
            // 
            // txtDescToUpdate
            // 
            this.txtDescToUpdate.Location = new System.Drawing.Point(337, 203);
            this.txtDescToUpdate.Name = "txtDescToUpdate";
            this.txtDescToUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtDescToUpdate.TabIndex = 14;
            // 
            // TxtPriceToUpdate
            // 
            this.TxtPriceToUpdate.Location = new System.Drawing.Point(337, 161);
            this.TxtPriceToUpdate.Name = "TxtPriceToUpdate";
            this.TxtPriceToUpdate.Size = new System.Drawing.Size(100, 20);
            this.TxtPriceToUpdate.TabIndex = 15;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(108, 327);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(74, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "BarCode";
            // 
            // txtBarCodeD
            // 
            this.txtBarCodeD.Location = new System.Drawing.Point(128, 279);
            this.txtBarCodeD.Name = "txtBarCodeD";
            this.txtBarCodeD.Size = new System.Drawing.Size(100, 20);
            this.txtBarCodeD.TabIndex = 16;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(490, 206);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(19, 13);
            this.lblResult.TabIndex = 19;
            this.lblResult.Text = "....";
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(515, 162);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 20;
            this.btnSelect.Text = "Check Items";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // OrderBy
            // 
            this.OrderBy.Controls.Add(this.rdbName);
            this.OrderBy.Controls.Add(this.rdbPrice);
            this.OrderBy.Controls.Add(this.rdbBarcode);
            this.OrderBy.Location = new System.Drawing.Point(515, 60);
            this.OrderBy.Name = "OrderBy";
            this.OrderBy.Size = new System.Drawing.Size(84, 96);
            this.OrderBy.TabIndex = 21;
            this.OrderBy.TabStop = false;
            this.OrderBy.Text = "Order By";
            // 
            // rdbBarcode
            // 
            this.rdbBarcode.AutoSize = true;
            this.rdbBarcode.Checked = true;
            this.rdbBarcode.Location = new System.Drawing.Point(7, 20);
            this.rdbBarcode.Name = "rdbBarcode";
            this.rdbBarcode.Size = new System.Drawing.Size(66, 17);
            this.rdbBarcode.TabIndex = 0;
            this.rdbBarcode.TabStop = true;
            this.rdbBarcode.Text = "BarCode";
            this.rdbBarcode.UseVisualStyleBackColor = true;
            this.rdbBarcode.CheckedChanged += new System.EventHandler(this.rdbBarcode_CheckedChanged);
            // 
            // rdbPrice
            // 
            this.rdbPrice.AutoSize = true;
            this.rdbPrice.Location = new System.Drawing.Point(7, 40);
            this.rdbPrice.Name = "rdbPrice";
            this.rdbPrice.Size = new System.Drawing.Size(49, 17);
            this.rdbPrice.TabIndex = 1;
            this.rdbPrice.Text = "Price";
            this.rdbPrice.UseVisualStyleBackColor = true;
            this.rdbPrice.Click += new System.EventHandler(this.rdbBarcode_CheckedChanged);
            // 
            // rdbName
            // 
            this.rdbName.AutoSize = true;
            this.rdbName.Location = new System.Drawing.Point(7, 63);
            this.rdbName.Name = "rdbName";
            this.rdbName.Size = new System.Drawing.Size(53, 17);
            this.rdbName.TabIndex = 2;
            this.rdbName.Text = "Name";
            this.rdbName.UseVisualStyleBackColor = true;
            this.rdbName.Click += new System.EventHandler(this.rdbBarcode_CheckedChanged);
            // 
            // dgvItems
            // 
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(657, 66);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(240, 312);
            this.dgvItems.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 491);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.OrderBy);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBarCodeD);
            this.Controls.Add(this.TxtPriceToUpdate);
            this.Controls.Add(this.txtDescToUpdate);
            this.Controls.Add(this.txtNameToUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtBarCodeToUpdate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.OrderBy.ResumeLayout(false);
            this.OrderBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBarCodeToUpdate;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNameToUpdate;
        private System.Windows.Forms.TextBox txtDescToUpdate;
        private System.Windows.Forms.TextBox TxtPriceToUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBarCodeD;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox OrderBy;
        private System.Windows.Forms.RadioButton rdbName;
        private System.Windows.Forms.RadioButton rdbPrice;
        private System.Windows.Forms.RadioButton rdbBarcode;
        private System.Windows.Forms.DataGridView dgvItems;
    }
}

