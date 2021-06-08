
namespace Kurs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dob = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.yd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(561, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(12, 317);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(86, 23);
            this.dob.TabIndex = 1;
            this.dob.Text = "Добавление";
            this.dob.UseVisualStyleBackColor = true;
            this.dob.Click += new System.EventHandler(this.dob_Click);
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(104, 317);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(107, 23);
            this.red.TabIndex = 2;
            this.red.Text = "Редактирование";
            this.red.UseVisualStyleBackColor = true;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // yd
            // 
            this.yd.Location = new System.Drawing.Point(217, 317);
            this.yd.Name = "yd";
            this.yd.Size = new System.Drawing.Size(75, 23);
            this.yd.TabIndex = 3;
            this.yd.Text = "Удаление";
            this.yd.UseVisualStyleBackColor = true;
            this.yd.Click += new System.EventHandler(this.yd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yd);
            this.Controls.Add(this.red);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dob;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button yd;
    }
}

