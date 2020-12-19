namespace Alg_test_rgr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel = new System.Windows.Forms.Panel();
            this.btn_prim = new System.Windows.Forms.Button();
            this.btn_clean = new System.Windows.Forms.Button();
            this.dgv_matrix = new System.Windows.Forms.DataGridView();
            this.textbox_result = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matrix)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(12, 112);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(497, 426);
            this.panel.TabIndex = 0;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // btn_prim
            // 
            this.btn_prim.Location = new System.Drawing.Point(12, 12);
            this.btn_prim.Name = "btn_prim";
            this.btn_prim.Size = new System.Drawing.Size(75, 23);
            this.btn_prim.TabIndex = 2;
            this.btn_prim.Text = "Поиск";
            this.btn_prim.UseVisualStyleBackColor = true;
            this.btn_prim.Click += new System.EventHandler(this.btn_prim_Click);
            // 
            // btn_clean
            // 
            this.btn_clean.Location = new System.Drawing.Point(93, 12);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(75, 23);
            this.btn_clean.TabIndex = 3;
            this.btn_clean.Text = "Очистить";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // dgv_matrix
            // 
            this.dgv_matrix.AllowUserToAddRows = false;
            this.dgv_matrix.AllowUserToDeleteRows = false;
            this.dgv_matrix.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_matrix.Location = new System.Drawing.Point(515, 112);
            this.dgv_matrix.Name = "dgv_matrix";
            this.dgv_matrix.ReadOnly = true;
            this.dgv_matrix.Size = new System.Drawing.Size(521, 346);
            this.dgv_matrix.TabIndex = 4;
            // 
            // textbox_result
            // 
            this.textbox_result.Location = new System.Drawing.Point(12, 41);
            this.textbox_result.Name = "textbox_result";
            this.textbox_result.Size = new System.Drawing.Size(156, 20);
            this.textbox_result.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_prim);
            this.panel1.Controls.Add(this.textbox_result);
            this.panel1.Controls.Add(this.btn_clean);
            this.panel1.Location = new System.Drawing.Point(515, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 74);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Об авторе: Давлетбаев Рамзес Рустемович, группа ПРО-222";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1027, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_matrix);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_matrix)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_prim;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.DataGridView dgv_matrix;
        private System.Windows.Forms.TextBox textbox_result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

