namespace Barcode
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
            this.components = new System.ComponentModel.Container();
            this.label_ItemName = new System.Windows.Forms.Label();
            this.label_Barcode = new System.Windows.Forms.Label();
            this.txtBox_Barcode = new System.Windows.Forms.TextBox();
            this.label_ItemDetail = new System.Windows.Forms.Label();
            this.label_ItemCode = new System.Windows.Forms.Label();
            this.label_ItemWeight = new System.Windows.Forms.Label();
            this.txtBox_ItemName = new System.Windows.Forms.TextBox();
            this.tableItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barcodeDataSet = new Barcode.barcodeDataSet();
            this.txtBox_ItemCode = new System.Windows.Forms.TextBox();
            this.txtBox_ItemWeight = new System.Windows.Forms.TextBox();
            this.table_ItemTableAdapter = new Barcode.barcodeDataSetTableAdapters.Table_ItemTableAdapter();
            this.label_AddItem = new System.Windows.Forms.Label();
            this.txtBox_NewItemWeight = new System.Windows.Forms.TextBox();
            this.txtBox_NewItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ItemName
            // 
            this.label_ItemName.AutoSize = true;
            this.label_ItemName.Location = new System.Drawing.Point(346, 89);
            this.label_ItemName.Name = "label_ItemName";
            this.label_ItemName.Size = new System.Drawing.Size(61, 13);
            this.label_ItemName.TabIndex = 15;
            this.label_ItemName.Text = "Item Name:";
            // 
            // label_Barcode
            // 
            this.label_Barcode.AutoSize = true;
            this.label_Barcode.Location = new System.Drawing.Point(340, 9);
            this.label_Barcode.Name = "label_Barcode";
            this.label_Barcode.Size = new System.Drawing.Size(75, 13);
            this.label_Barcode.TabIndex = 13;
            this.label_Barcode.Text = "Scan Barcode";
            // 
            // txtBox_Barcode
            // 
            this.txtBox_Barcode.Location = new System.Drawing.Point(337, 25);
            this.txtBox_Barcode.Name = "txtBox_Barcode";
            this.txtBox_Barcode.Size = new System.Drawing.Size(237, 20);
            this.txtBox_Barcode.TabIndex = 5;
            this.txtBox_Barcode.TextChanged += new System.EventHandler(this.btn_Search1_Click);
            // 
            // label_ItemDetail
            // 
            this.label_ItemDetail.AutoSize = true;
            this.label_ItemDetail.Location = new System.Drawing.Point(337, 66);
            this.label_ItemDetail.Name = "label_ItemDetail";
            this.label_ItemDetail.Size = new System.Drawing.Size(62, 13);
            this.label_ItemDetail.TabIndex = 14;
            this.label_ItemDetail.Text = "Item Details";
            // 
            // label_ItemCode
            // 
            this.label_ItemCode.AutoSize = true;
            this.label_ItemCode.Location = new System.Drawing.Point(349, 116);
            this.label_ItemCode.Name = "label_ItemCode";
            this.label_ItemCode.Size = new System.Drawing.Size(58, 13);
            this.label_ItemCode.TabIndex = 16;
            this.label_ItemCode.Text = "Item Code:";
            // 
            // label_ItemWeight
            // 
            this.label_ItemWeight.AutoSize = true;
            this.label_ItemWeight.Location = new System.Drawing.Point(328, 141);
            this.label_ItemWeight.Name = "label_ItemWeight";
            this.label_ItemWeight.Size = new System.Drawing.Size(82, 13);
            this.label_ItemWeight.TabIndex = 17;
            this.label_ItemWeight.Text = "Item Weight (g):";
            // 
            // txtBox_ItemName
            // 
            this.txtBox_ItemName.Location = new System.Drawing.Point(413, 86);
            this.txtBox_ItemName.Name = "txtBox_ItemName";
            this.txtBox_ItemName.ReadOnly = true;
            this.txtBox_ItemName.Size = new System.Drawing.Size(161, 20);
            this.txtBox_ItemName.TabIndex = 18;
            // 
            // tableItemBindingSource
            // 
            this.tableItemBindingSource.DataMember = "Table_Item";
            this.tableItemBindingSource.DataSource = this.barcodeDataSet;
            // 
            // barcodeDataSet
            // 
            this.barcodeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtBox_ItemCode
            // 
            this.txtBox_ItemCode.Location = new System.Drawing.Point(413, 112);
            this.txtBox_ItemCode.Name = "txtBox_ItemCode";
            this.txtBox_ItemCode.ReadOnly = true;
            this.txtBox_ItemCode.Size = new System.Drawing.Size(161, 20);
            this.txtBox_ItemCode.TabIndex = 19;
            // 
            // txtBox_ItemWeight
            // 
            this.txtBox_ItemWeight.Location = new System.Drawing.Point(413, 138);
            this.txtBox_ItemWeight.Name = "txtBox_ItemWeight";
            this.txtBox_ItemWeight.ReadOnly = true;
            this.txtBox_ItemWeight.Size = new System.Drawing.Size(161, 20);
            this.txtBox_ItemWeight.TabIndex = 20;
            // 
            // table_ItemTableAdapter
            // 
            this.table_ItemTableAdapter.ClearBeforeFill = true;
            // 
            // label_AddItem
            // 
            this.label_AddItem.AutoSize = true;
            this.label_AddItem.Location = new System.Drawing.Point(12, 9);
            this.label_AddItem.Name = "label_AddItem";
            this.label_AddItem.Size = new System.Drawing.Size(74, 13);
            this.label_AddItem.TabIndex = 8;
            this.label_AddItem.Text = "Add New Item";
            // 
            // txtBox_NewItemWeight
            // 
            this.txtBox_NewItemWeight.Location = new System.Drawing.Point(91, 86);
            this.txtBox_NewItemWeight.Name = "txtBox_NewItemWeight";
            this.txtBox_NewItemWeight.Size = new System.Drawing.Size(220, 20);
            this.txtBox_NewItemWeight.TabIndex = 1;
            // 
            // txtBox_NewItemName
            // 
            this.txtBox_NewItemName.Location = new System.Drawing.Point(91, 58);
            this.txtBox_NewItemName.Name = "txtBox_NewItemName";
            this.txtBox_NewItemName.Size = new System.Drawing.Size(220, 20);
            this.txtBox_NewItemName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Item Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Item Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Item Name:";
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Location = new System.Drawing.Point(240, 116);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(71, 27);
            this.btn_AddItem.TabIndex = 3;
            this.btn_AddItem.Text = "Add Item";
            this.btn_AddItem.UseVisualStyleBackColor = true;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(506, 51);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(68, 21);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 205);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_AddItem);
            this.Controls.Add(this.txtBox_NewItemWeight);
            this.Controls.Add(this.txtBox_NewItemName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_AddItem);
            this.Controls.Add(this.txtBox_ItemWeight);
            this.Controls.Add(this.txtBox_ItemCode);
            this.Controls.Add(this.txtBox_ItemName);
            this.Controls.Add(this.label_ItemWeight);
            this.Controls.Add(this.label_ItemCode);
            this.Controls.Add(this.label_ItemDetail);
            this.Controls.Add(this.txtBox_Barcode);
            this.Controls.Add(this.label_Barcode);
            this.Controls.Add(this.label_ItemName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ItemName;
        private System.Windows.Forms.Label label_Barcode;
        private System.Windows.Forms.TextBox txtBox_Barcode;
        private System.Windows.Forms.Label label_ItemDetail;
        private System.Windows.Forms.Label label_ItemCode;
        private System.Windows.Forms.Label label_ItemWeight;
        private System.Windows.Forms.TextBox txtBox_ItemName;
        private System.Windows.Forms.TextBox txtBox_ItemCode;
        private System.Windows.Forms.TextBox txtBox_ItemWeight;
        private barcodeDataSet barcodeDataSet;
        private System.Windows.Forms.BindingSource tableItemBindingSource;
        private barcodeDataSetTableAdapters.Table_ItemTableAdapter table_ItemTableAdapter;
        private System.Windows.Forms.Label label_AddItem;
        private System.Windows.Forms.TextBox txtBox_NewItemWeight;
        private System.Windows.Forms.TextBox txtBox_NewItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.Button btn_Clear;
    }
}

