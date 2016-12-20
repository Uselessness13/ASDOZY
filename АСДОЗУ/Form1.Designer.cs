namespace АСДОЗУ
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.prods = new System.Windows.Forms.Button();
            this.stuff = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.sklad = new System.Windows.Forms.Button();
            this.comes = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.detinprods = new System.Windows.Forms.Button();
            this.dispthirovanie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Просмотреть детали";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prods
            // 
            this.prods.Location = new System.Drawing.Point(12, 58);
            this.prods.Name = "prods";
            this.prods.Size = new System.Drawing.Size(129, 40);
            this.prods.TabIndex = 1;
            this.prods.Text = "Посмотреть продукты";
            this.prods.UseVisualStyleBackColor = true;
            this.prods.Click += new System.EventHandler(this.prods_Click);
            // 
            // stuff
            // 
            this.stuff.Location = new System.Drawing.Point(12, 104);
            this.stuff.Name = "stuff";
            this.stuff.Size = new System.Drawing.Size(129, 40);
            this.stuff.TabIndex = 3;
            this.stuff.Text = "Просмотреть сотрудников";
            this.stuff.UseVisualStyleBackColor = true;
            this.stuff.Click += new System.EventHandler(this.stuff_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 40);
            this.button4.TabIndex = 2;
            this.button4.Text = "Просмотреть цеха";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // sklad
            // 
            this.sklad.Location = new System.Drawing.Point(12, 196);
            this.sklad.Name = "sklad";
            this.sklad.Size = new System.Drawing.Size(129, 40);
            this.sklad.TabIndex = 4;
            this.sklad.Text = "Просмотреть склады";
            this.sklad.UseVisualStyleBackColor = true;
            this.sklad.Click += new System.EventHandler(this.sklad_Click);
            // 
            // comes
            // 
            this.comes.Location = new System.Drawing.Point(147, 12);
            this.comes.Name = "comes";
            this.comes.Size = new System.Drawing.Size(129, 40);
            this.comes.TabIndex = 5;
            this.comes.Text = "Приходы деталей";
            this.comes.UseVisualStyleBackColor = true;
            this.comes.Click += new System.EventHandler(this.comes_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Продукты цехов";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // detinprods
            // 
            this.detinprods.Location = new System.Drawing.Point(147, 150);
            this.detinprods.Name = "detinprods";
            this.detinprods.Size = new System.Drawing.Size(129, 40);
            this.detinprods.TabIndex = 7;
            this.detinprods.Text = "Детали в продуктах";
            this.detinprods.UseVisualStyleBackColor = true;
            this.detinprods.Click += new System.EventHandler(this.detinprods_Click);
            // 
            // dispthirovanie
            // 
            this.dispthirovanie.Location = new System.Drawing.Point(147, 58);
            this.dispthirovanie.Name = "dispthirovanie";
            this.dispthirovanie.Size = new System.Drawing.Size(129, 40);
            this.dispthirovanie.TabIndex = 8;
            this.dispthirovanie.Text = "Диспетчирование";
            this.dispthirovanie.UseVisualStyleBackColor = true;
            this.dispthirovanie.Click += new System.EventHandler(this.dispthirovanie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 245);
            this.Controls.Add(this.dispthirovanie);
            this.Controls.Add(this.detinprods);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comes);
            this.Controls.Add(this.sklad);
            this.Controls.Add(this.stuff);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.prods);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "АСДОЗУ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button prods;
        private System.Windows.Forms.Button stuff;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button sklad;
        private System.Windows.Forms.Button comes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button detinprods;
        private System.Windows.Forms.Button dispthirovanie;
    }
}

