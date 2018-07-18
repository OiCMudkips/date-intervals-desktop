namespace date_intervals_desktop
{
    partial class DateIntervalsForm
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
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.numPickerIntervalLength = new System.Windows.Forms.NumericUpDown();
            this.numPickerDates = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.radioButtonAfter = new System.Windows.Forms.RadioButton();
            this.radioButtonBefore = new System.Windows.Forms.RadioButton();
            this.groupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPickerIntervalLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPickerDates)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.AutoSize = true;
            this.groupBoxOptions.Controls.Add(this.radioButtonBefore);
            this.groupBoxOptions.Controls.Add(this.radioButtonAfter);
            this.groupBoxOptions.Controls.Add(this.btnGenerate);
            this.groupBoxOptions.Controls.Add(this.numPickerIntervalLength);
            this.groupBoxOptions.Controls.Add(this.numPickerDates);
            this.groupBoxOptions.Controls.Add(this.label2);
            this.groupBoxOptions.Controls.Add(this.label1);
            this.groupBoxOptions.Controls.Add(this.lblStartDate);
            this.groupBoxOptions.Controls.Add(this.dateTimePicker);
            this.groupBoxOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOptions.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(364, 194);
            this.groupBoxOptions.TabIndex = 0;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerate.Location = new System.Drawing.Point(141, 159);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // numPickerIntervalLength
            // 
            this.numPickerIntervalLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numPickerIntervalLength.Location = new System.Drawing.Point(232, 88);
            this.numPickerIntervalLength.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numPickerIntervalLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPickerIntervalLength.Name = "numPickerIntervalLength";
            this.numPickerIntervalLength.Size = new System.Drawing.Size(120, 20);
            this.numPickerIntervalLength.TabIndex = 5;
            this.numPickerIntervalLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numPickerDates
            // 
            this.numPickerDates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numPickerDates.Location = new System.Drawing.Point(232, 56);
            this.numPickerDates.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPickerDates.Name = "numPickerDates";
            this.numPickerDates.Size = new System.Drawing.Size(120, 20);
            this.numPickerDates.TabIndex = 4;
            this.numPickerDates.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interval Length (Days)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Dates";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(12, 25);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 1;
            this.lblStartDate.Text = "Start Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(152, 19);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // radioButtonAfter
            // 
            this.radioButtonAfter.AutoSize = true;
            this.radioButtonAfter.Location = new System.Drawing.Point(15, 125);
            this.radioButtonAfter.Name = "radioButtonAfter";
            this.radioButtonAfter.Size = new System.Drawing.Size(118, 17);
            this.radioButtonAfter.TabIndex = 7;
            this.radioButtonAfter.TabStop = true;
            this.radioButtonAfter.Text = "After Selected Date";
            this.radioButtonAfter.UseVisualStyleBackColor = true;
            // 
            // radioButtonBefore
            // 
            this.radioButtonBefore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonBefore.AutoSize = true;
            this.radioButtonBefore.Location = new System.Drawing.Point(225, 125);
            this.radioButtonBefore.Name = "radioButtonBefore";
            this.radioButtonBefore.Size = new System.Drawing.Size(127, 17);
            this.radioButtonBefore.TabIndex = 8;
            this.radioButtonBefore.TabStop = true;
            this.radioButtonBefore.Text = "Before Selected Date";
            this.radioButtonBefore.UseVisualStyleBackColor = true;
            // 
            // DateIntervalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 194);
            this.Controls.Add(this.groupBoxOptions);
            this.Name = "DateIntervalsForm";
            this.Text = "Date Intervals";
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPickerIntervalLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPickerDates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.NumericUpDown numPickerDates;
        private System.Windows.Forms.NumericUpDown numPickerIntervalLength;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RadioButton radioButtonAfter;
        private System.Windows.Forms.RadioButton radioButtonBefore;
    }
}

