namespace АСДОЗУ
{
    partial class DetailComing
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
            this.deleter = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sklad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.detal = new System.Windows.Forms.ComboBox();
            this.kolich = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleter
            // 
            this.deleter.Location = new System.Drawing.Point(174, 286);
            this.deleter.Name = "deleter";
            this.deleter.Size = new System.Drawing.Size(75, 23);
            this.deleter.TabIndex = 54;
            this.deleter.Text = "Удалить";
            this.deleter.UseVisualStyleBackColor = true;
            this.deleter.Click += new System.EventHandler(this.deleter_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(12, 286);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 53;
            this.update.Text = "Загрузить";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(93, 286);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 52;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(255, 286);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 51;
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
            this.dataGridView1.TabIndex = 50;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(12, 87);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(318, 37);
            this.add.TabIndex = 49;
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
            this.label2.TabIndex = 48;
            this.label2.Text = "Количество";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Склад";
            // 
            // sklad
            // 
            this.sklad.FormattingEnabled = true;
            this.sklad.Location = new System.Drawing.Point(114, 33);
            this.sklad.Name = "sklad";
            this.sklad.Size = new System.Drawing.Size(216, 21);
            this.sklad.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Деталь";
            // 
            // detal
            // 
            this.detal.FormattingEnabled = true;
            this.detal.Location = new System.Drawing.Point(114, 6);
            this.detal.Name = "detal";
            this.detal.Size = new System.Drawing.Size(216, 21);
            this.detal.TabIndex = 57;
            // 
            // kolich
            // 
            this.kolich.FormattingEnabled = true;
            this.kolich.Location = new System.Drawing.Point(114, 60);
            this.kolich.Name = "kolich";
            this.kolich.Size = new System.Drawing.Size(81, 21);
            this.kolich.TabIndex = 59;
            // 
            // DetailComing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 317);
            this.Controls.Add(this.kolich);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.detal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sklad);
            this.Controls.Add(this.deleter);
            this.Controls.Add(this.update);
            this.Controls.Add(this.save);
            this.Controls.Add(this.close);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label2);
            this.Name = "DetailComing";
            this.Text = "DetailComing";
            this.Load += new System.EventHandler(this.DetailComing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleter;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sklad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox detal;
        private System.Windows.Forms.ComboBox kolich;
    }
}