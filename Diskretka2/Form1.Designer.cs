namespace Diskretka2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRazmer = new System.Windows.Forms.Button();
            this.textBoxRazmer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.matrixSelector = new System.Windows.Forms.ComboBox();
            this.buttonRezultat = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRazmer);
            this.groupBox1.Controls.Add(this.textBoxRazmer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(184)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // buttonRazmer
            // 
            this.buttonRazmer.Location = new System.Drawing.Point(257, 34);
            this.buttonRazmer.Name = "buttonRazmer";
            this.buttonRazmer.Size = new System.Drawing.Size(112, 28);
            this.buttonRazmer.TabIndex = 2;
            this.buttonRazmer.Text = "Применить";
            this.buttonRazmer.UseVisualStyleBackColor = true;
            this.buttonRazmer.Click += new System.EventHandler(this.buttonRazmer_Click);
            // 
            // textBoxRazmer
            // 
            this.textBoxRazmer.Location = new System.Drawing.Point(181, 36);
            this.textBoxRazmer.MaxLength = 2;
            this.textBoxRazmer.Name = "textBoxRazmer";
            this.textBoxRazmer.Size = new System.Drawing.Size(30, 27);
            this.textBoxRazmer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер матрицы =";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(184)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 400);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.matrixSelector);
            this.groupBox3.Controls.Add(this.buttonRezultat);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(184)))));
            this.groupBox3.Location = new System.Drawing.Point(427, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(400, 96);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат";
            // 
            // matrixSelector
            // 
            this.matrixSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.matrixSelector.FormattingEnabled = true;
            this.matrixSelector.Location = new System.Drawing.Point(176, 39);
            this.matrixSelector.Name = "matrixSelector";
            this.matrixSelector.Size = new System.Drawing.Size(121, 27);
            this.matrixSelector.TabIndex = 1;
            this.matrixSelector.SelectedIndexChanged += new System.EventHandler(this.matrixSelector_SelectedIndexChanged);
            // 
            // buttonRezultat
            // 
            this.buttonRezultat.Location = new System.Drawing.Point(34, 39);
            this.buttonRezultat.Name = "buttonRezultat";
            this.buttonRezultat.Size = new System.Drawing.Size(108, 27);
            this.buttonRezultat.TabIndex = 0;
            this.buttonRezultat.Text = "Рассчитать";
            this.buttonRezultat.UseVisualStyleBackColor = true;
            this.buttonRezultat.Click += new System.EventHandler(this.buttonRezultat_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(184)))));
            this.groupBox4.Location = new System.Drawing.Point(427, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 400);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 523);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(118)))), ((int)(((byte)(184)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ДМ Практическое занятие #2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxRazmer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRazmer;
        private System.Windows.Forms.Button buttonRezultat;
        private System.Windows.Forms.ComboBox matrixSelector;
    }
}

