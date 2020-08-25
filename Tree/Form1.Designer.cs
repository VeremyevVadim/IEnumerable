namespace Tree
{
    partial class MainForm
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
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Srch_Btn = new System.Windows.Forms.Button();
            this.edit_add = new System.Windows.Forms.TextBox();
            this.Output_Btn = new System.Windows.Forms.Button();
            this.Log_TxBx = new System.Windows.Forms.TextBox();
            this.edit_search = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add_Btn
            // 
            this.Add_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Add_Btn.Location = new System.Drawing.Point(12, 326);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(127, 33);
            this.Add_Btn.TabIndex = 0;
            this.Add_Btn.Text = "Добавить";
            this.Add_Btn.UseVisualStyleBackColor = true;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Srch_Btn
            // 
            this.Srch_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Srch_Btn.Location = new System.Drawing.Point(168, 326);
            this.Srch_Btn.Name = "Srch_Btn";
            this.Srch_Btn.Size = new System.Drawing.Size(127, 33);
            this.Srch_Btn.TabIndex = 2;
            this.Srch_Btn.Text = "Поиск";
            this.Srch_Btn.UseVisualStyleBackColor = true;
            this.Srch_Btn.Click += new System.EventHandler(this.Srch_Btn_Click);
            // 
            // edit_add
            // 
            this.edit_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.edit_add.Location = new System.Drawing.Point(12, 283);
            this.edit_add.Name = "edit_add";
            this.edit_add.Size = new System.Drawing.Size(127, 27);
            this.edit_add.TabIndex = 3;
            // 
            // Output_Btn
            // 
            this.Output_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Output_Btn.Location = new System.Drawing.Point(12, 379);
            this.Output_Btn.Name = "Output_Btn";
            this.Output_Btn.Size = new System.Drawing.Size(283, 34);
            this.Output_Btn.TabIndex = 4;
            this.Output_Btn.Text = "Обход дерева";
            this.Output_Btn.UseVisualStyleBackColor = true;
            this.Output_Btn.Click += new System.EventHandler(this.Output_Btn_Click);
            // 
            // Log_TxBx
            // 
            this.Log_TxBx.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Log_TxBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Log_TxBx.Location = new System.Drawing.Point(12, 12);
            this.Log_TxBx.Multiline = true;
            this.Log_TxBx.Name = "Log_TxBx";
            this.Log_TxBx.ReadOnly = true;
            this.Log_TxBx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Log_TxBx.Size = new System.Drawing.Size(283, 265);
            this.Log_TxBx.TabIndex = 5;
            // 
            // edit_search
            // 
            this.edit_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.edit_search.Location = new System.Drawing.Point(168, 283);
            this.edit_search.Name = "edit_search";
            this.edit_search.Size = new System.Drawing.Size(127, 27);
            this.edit_search.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 425);
            this.Controls.Add(this.edit_search);
            this.Controls.Add(this.Log_TxBx);
            this.Controls.Add(this.Output_Btn);
            this.Controls.Add(this.edit_add);
            this.Controls.Add(this.Srch_Btn);
            this.Controls.Add(this.Add_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button Srch_Btn;
        private System.Windows.Forms.TextBox edit_add;
        private System.Windows.Forms.Button Output_Btn;
        private System.Windows.Forms.TextBox Log_TxBx;
        private System.Windows.Forms.TextBox edit_search;
    }
}

