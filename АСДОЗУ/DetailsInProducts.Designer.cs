namespace АСДОЗУ
{
    partial class DetailsInProducts
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
            this.det = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prod = new System.Windows.Forms.ComboBox();
            this.deleter = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kolichestvo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 80;
            this.label3.Text = "Деталь";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // det
            // 
            this.det.FormattingEnabled = true;
            this.det.Location = new System.Drawing.Point(67, 6);
            this.det.Name = "det";
            this.det.Size = new System.Drawing.Size(260, 21);
            this.det.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Продукт";
            // 
            // prod
            // 
            this.prod.FormattingEnabled = true;
            this.prod.Location = new System.Drawing.Point(67, 33);
            this.prod.Name = "prod";
            this.prod.Size = new System.Drawing.Size(260, 21);
            this.prod.TabIndex = 77;
            // 
            // deleter
            // 
            this.deleter.Location = new System.Drawing.Point(174, 286);
            this.deleter.Name = "deleter";
            this.deleter.Size = new System.Drawing.Size(75, 23);
            this.deleter.TabIndex = 76;
            this.deleter.Text = "Удалить";
            this.deleter.UseVisualStyleBackColor = true;
            this.deleter.Click += new System.EventHandler(this.deleter_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(12, 286);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 75;
            this.update.Text = "Загрузить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(93, 286);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 74;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(255, 286);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 73;
            this.close.Text = "Закрыть";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(318, 150);
            this.dataGridView1.TabIndex = 72;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 87);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(315, 37);
            this.add.TabIndex = 71;
            this.add.Text = "Добавить запись";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Количество";
            // 
            // kolichestvo
            // 
            this.kolichestvo.FormattingEnabled = true;
            this.kolichestvo.Location = new System.Drawing.Point(84, 60);
            this.kolichestvo.Name = "kolichestvo";
            this.kolichestvo.Size = new System.Drawing.Size(243, 21);
            this.kolichestvo.TabIndex = 81;
            // 
            // DetailsInProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kolichestvo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.det);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prod);
            this.Controls.Add(this.deleter);
            this.Controls.Add(this.update);
            this.Controls.Add(this.save);
            this.Controls.Add(this.close);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add);
            this.Name = "DetailsInProducts";
            this.Text = "DetailsInProducts";
            this.Load += new System.EventHandler(this.DetailsInProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox det;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox prod;
        private System.Windows.Forms.Button deleter;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kolichestvo;
    }
}