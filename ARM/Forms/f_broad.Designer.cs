﻿namespace ARM.Forms
{
    partial class F_board
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
            this.pG_BoardProperty = new System.Windows.Forms.PropertyGrid();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pG_BoardProperty
            // 
            this.pG_BoardProperty.Location = new System.Drawing.Point(12, 12);
            this.pG_BoardProperty.Name = "pG_BoardProperty";
            this.pG_BoardProperty.Size = new System.Drawing.Size(360, 292);
            this.pG_BoardProperty.TabIndex = 0;
            // 
            // b_cancel
            // 
            this.b_cancel.BackColor = System.Drawing.SystemColors.Control;
            this.b_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_cancel.Location = new System.Drawing.Point(297, 310);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 1;
            this.b_cancel.Text = "Отмена";
            this.b_cancel.UseVisualStyleBackColor = false;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // b_save
            // 
            this.b_save.BackColor = System.Drawing.SystemColors.Control;
            this.b_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_save.Location = new System.Drawing.Point(216, 310);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(75, 23);
            this.b_save.TabIndex = 2;
            this.b_save.Text = "Сохранить";
            this.b_save.UseVisualStyleBackColor = false;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // F_board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(384, 340);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.pG_BoardProperty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "F_board";
            this.Text = "Параметры платы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_board_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid pG_BoardProperty;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_save;
    }
}