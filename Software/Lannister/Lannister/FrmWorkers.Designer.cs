﻿namespace Lannister {
    partial class FrmWorkers {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgcWorkers = new System.Windows.Forms.DataGridView();
            this.BtnChangeWorker = new System.Windows.Forms.Button();
            this.BtnBackToHomeScreen = new System.Windows.Forms.Button();
            this.BtnAddWorker = new System.Windows.Forms.Button();
            this.BtnDeleteWorker = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgcWorkers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgcWorkers
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcWorkers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgcWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgcWorkers.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgcWorkers.Location = new System.Drawing.Point(16, 16);
            this.dgcWorkers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgcWorkers.Name = "dgcWorkers";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcWorkers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgcWorkers.RowHeadersWidth = 100;
            this.dgcWorkers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dgcWorkers.Size = new System.Drawing.Size(978, 526);
            this.dgcWorkers.TabIndex = 5;
            // 
            // BtnChangeWorker
            // 
            this.BtnChangeWorker.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnChangeWorker.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Bold);
            this.BtnChangeWorker.Location = new System.Drawing.Point(508, 550);
            this.BtnChangeWorker.Name = "BtnChangeWorker";
            this.BtnChangeWorker.Size = new System.Drawing.Size(240, 52);
            this.BtnChangeWorker.TabIndex = 9;
            this.BtnChangeWorker.Text = "Izmjeni zaposlenika";
            this.BtnChangeWorker.UseVisualStyleBackColor = false;
            // 
            // BtnBackToHomeScreen
            // 
            this.BtnBackToHomeScreen.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnBackToHomeScreen.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Bold);
            this.BtnBackToHomeScreen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnBackToHomeScreen.Location = new System.Drawing.Point(754, 550);
            this.BtnBackToHomeScreen.Name = "BtnBackToHomeScreen";
            this.BtnBackToHomeScreen.Size = new System.Drawing.Size(240, 52);
            this.BtnBackToHomeScreen.TabIndex = 8;
            this.BtnBackToHomeScreen.Text = "Početni zaslon";
            this.BtnBackToHomeScreen.UseVisualStyleBackColor = false;
            this.BtnBackToHomeScreen.Click += new System.EventHandler(this.BtnBackToHomeScreen_Click);
            // 
            // BtnAddWorker
            // 
            this.BtnAddWorker.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnAddWorker.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAddWorker.Location = new System.Drawing.Point(16, 550);
            this.BtnAddWorker.Name = "BtnAddWorker";
            this.BtnAddWorker.Size = new System.Drawing.Size(240, 52);
            this.BtnAddWorker.TabIndex = 7;
            this.BtnAddWorker.Text = "Dodaj zaposlenika";
            this.BtnAddWorker.UseVisualStyleBackColor = false;
            this.BtnAddWorker.Click += new System.EventHandler(this.BtnAddWorker_Click);
            // 
            // BtnDeleteWorker
            // 
            this.BtnDeleteWorker.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BtnDeleteWorker.Font = new System.Drawing.Font("Arial Nova", 12F, System.Drawing.FontStyle.Bold);
            this.BtnDeleteWorker.Location = new System.Drawing.Point(262, 550);
            this.BtnDeleteWorker.Name = "BtnDeleteWorker";
            this.BtnDeleteWorker.Size = new System.Drawing.Size(240, 52);
            this.BtnDeleteWorker.TabIndex = 6;
            this.BtnDeleteWorker.Text = "Obriši zaposlenika";
            this.BtnDeleteWorker.UseVisualStyleBackColor = false;
            this.BtnDeleteWorker.Click += new System.EventHandler(this.BtnDeleteWorker_Click);
            // 
            // FrmWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 623);
            this.Controls.Add(this.BtnChangeWorker);
            this.Controls.Add(this.BtnBackToHomeScreen);
            this.Controls.Add(this.BtnAddWorker);
            this.Controls.Add(this.BtnDeleteWorker);
            this.Controls.Add(this.dgcWorkers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmWorkers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmWorkers";
            this.Load += new System.EventHandler(this.FrmWorkers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgcWorkers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgcWorkers;
        private System.Windows.Forms.Button BtnChangeWorker;
        private System.Windows.Forms.Button BtnBackToHomeScreen;
        private System.Windows.Forms.Button BtnAddWorker;
        private System.Windows.Forms.Button BtnDeleteWorker;
    }
}