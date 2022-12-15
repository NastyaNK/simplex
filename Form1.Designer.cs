namespace SimplexMethod
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
            this.dataA = new System.Windows.Forms.DataGridView();
            this.solve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataB = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rows = new System.Windows.Forms.NumericUpDown();
            this.cols = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataZ = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataR = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cols)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataR)).BeginInit();
            this.SuspendLayout();
            // 
            // dataA
            // 
            this.dataA.AllowUserToAddRows = false;
            this.dataA.AllowUserToDeleteRows = false;
            this.dataA.AllowUserToResizeRows = false;
            this.dataA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataA.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataA.Location = new System.Drawing.Point(12, 62);
            this.dataA.Name = "dataA";
            this.dataA.RowHeadersVisible = false;
            this.dataA.Size = new System.Drawing.Size(307, 143);
            this.dataA.TabIndex = 0;
            this.dataA.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataA_CellValidating);
            // 
            // solve
            // 
            this.solve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.solve.Location = new System.Drawing.Point(243, 211);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(153, 23);
            this.solve.TabIndex = 1;
            this.solve.Text = "РАССЧИТАТЬ";
            this.solve.UseVisualStyleBackColor = true;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "РАЗМЕРНОСТЬ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "х";
            // 
            // dataB
            // 
            this.dataB.AllowUserToAddRows = false;
            this.dataB.AllowUserToDeleteRows = false;
            this.dataB.AllowUserToResizeRows = false;
            this.dataB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataB.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataB.Location = new System.Drawing.Point(325, 62);
            this.dataB.Name = "dataB";
            this.dataB.RowHeadersVisible = false;
            this.dataB.Size = new System.Drawing.Size(71, 143);
            this.dataB.TabIndex = 6;
            this.dataB.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataB_CellValidating);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "B";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // rows
            // 
            this.rows.Location = new System.Drawing.Point(107, 214);
            this.rows.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.rows.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rows.Name = "rows";
            this.rows.Size = new System.Drawing.Size(37, 20);
            this.rows.TabIndex = 7;
            this.rows.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.rows.ValueChanged += new System.EventHandler(this.rows_ValueChanged);
            // 
            // cols
            // 
            this.cols.Location = new System.Drawing.Point(164, 214);
            this.cols.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.cols.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cols.Name = "cols";
            this.cols.Size = new System.Drawing.Size(36, 20);
            this.cols.TabIndex = 8;
            this.cols.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cols.ValueChanged += new System.EventHandler(this.cols_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ресурсы:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ограничения:";
            // 
            // dataZ
            // 
            this.dataZ.AllowUserToAddRows = false;
            this.dataZ.AllowUserToDeleteRows = false;
            this.dataZ.AllowUserToResizeRows = false;
            this.dataZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataZ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataZ.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataZ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataZ.ColumnHeadersVisible = false;
            this.dataZ.Location = new System.Drawing.Point(12, 20);
            this.dataZ.Name = "dataZ";
            this.dataZ.RowHeadersVisible = false;
            this.dataZ.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataZ.Size = new System.Drawing.Size(307, 21);
            this.dataZ.TabIndex = 11;
            this.dataZ.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataZ_CellValidating);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "max",
            "min"});
            this.comboBox1.Location = new System.Drawing.Point(325, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Целевая функция:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Решение:";
            // 
            // dataR
            // 
            this.dataR.AllowUserToAddRows = false;
            this.dataR.AllowUserToDeleteRows = false;
            this.dataR.AllowUserToResizeRows = false;
            this.dataR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataR.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataR.ColumnHeadersVisible = false;
            this.dataR.Location = new System.Drawing.Point(12, 279);
            this.dataR.Name = "dataR";
            this.dataR.ReadOnly = true;
            this.dataR.RowHeadersVisible = false;
            this.dataR.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataR.Size = new System.Drawing.Size(307, 21);
            this.dataR.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Максимум:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 279);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 312);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cols);
            this.Controls.Add(this.rows);
            this.Controls.Add(this.dataB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.dataA);
            this.Name = "Form1";
            this.Text = "Симлекс метод";
            ((System.ComponentModel.ISupportInitialize)(this.dataA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cols)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataA;
        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.NumericUpDown rows;
        private System.Windows.Forms.NumericUpDown cols;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataZ;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
    }
}

