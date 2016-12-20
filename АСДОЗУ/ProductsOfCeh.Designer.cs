namespace АСДОЗУ
{
    partial class ProductsOfCeh
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
            this.label3 = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ceh = new System.Windows.Forms.ComboBox();
            this.deleter = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Продукт";
            // 
            // product
            // 
            this.product.FormattingEnabled = true;
            this.product.Location = new System.Drawing.Point(67, 6);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(263, 21);
            this.product.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Цех";
            // 
            // ceh
            // 
            this.ceh.FormattingEnabled = true;
            this.ceh.Location = new System.Drawing.Point(67, 33);
            this.ceh.Name = "ceh";
            this.ceh.Size = new System.Drawing.Size(263, 21);
            this.ceh.TabIndex = 67;
            // 
            // deleter
            // 
            this.deleter.Location = new System.Drawing.Point(174, 259);
            this.deleter.Name = "deleter";
            this.deleter.Size = new System.Drawing.Size(75, 23);
            this.deleter.TabIndex = 66;
            this.deleter.Text = "Удалить";
            this.deleter.UseVisualStyleBackColor = true;
            this.deleter.Click += new System.EventHandler(this.deleter_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(12, 259);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 65;
            this.update.Text = "Загрузить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(93, 259);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 64;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(255, 259);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 63;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(318, 150);
            this.dataGridView1.TabIndex = 62;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 60);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(318, 37);
            this.add.TabIndex = 61;
            this.add.Text = "Добавить запись";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // ProductsOfCeh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 290);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ceh);
            this.Controls.Add(this.deleter);
            this.Controls.Add(this.update);
            this.Controls.Add(this.save);
            this.Controls.Add(this.close);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add);
            this.Name = "ProductsOfCeh";
            this.Text = "ProductsOfCeh";
            this.Load += new System.EventHandler(this.ProductsOfCeh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ceh;
        private System.Windows.Forms.Button deleter;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add;
    }
}