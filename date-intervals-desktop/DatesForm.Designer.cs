﻿namespace date_intervals_desktop
{
    partial class DatesForm
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
            this.listBoxDates = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxDates
            // 
            this.listBoxDates.FormatString = "d";
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.Location = new System.Drawing.Point(12, 12);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.Size = new System.Drawing.Size(279, 199);
            this.listBoxDates.TabIndex = 0;
            // 
            // DatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 224);
            this.Controls.Add(this.listBoxDates);
            this.Name = "DatesForm";
            this.Text = "Dates";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDates;

    }
}