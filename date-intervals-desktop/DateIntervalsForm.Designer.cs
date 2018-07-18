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
            this.radioButtonBefore = new System.Windows.Forms.RadioButton();
            this.radioButtonAfter = new System.Windows.Forms.RadioButton();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.numPickerIntervalLength = new System.Windows.Forms.NumericUpDown();
            this.numPickerDates = new System.Windows.Forms.NumericUpDown();
            this.labelMultipleDatesIntervalLength = new System.Windows.Forms.Label();
            this.labelNumDates = new System.Windows.Forms.Label();
            this.lblStartDateMultipleDates = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageMultDates = new System.Windows.Forms.TabPage();
            this.tabPageSingleDate = new System.Windows.Forms.TabPage();
            this.groupBoxSingleDate = new System.Windows.Forms.GroupBox();
            this.groupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPickerIntervalLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPickerDates)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageMultDates.SuspendLayout();
            this.tabPageSingleDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.radioButtonBefore);
            this.groupBoxOptions.Controls.Add(this.radioButtonAfter);
            this.groupBoxOptions.Controls.Add(this.btnGenerate);
            this.groupBoxOptions.Controls.Add(this.numPickerIntervalLength);
            this.groupBoxOptions.Controls.Add(this.numPickerDates);
            this.groupBoxOptions.Controls.Add(this.labelMultipleDatesIntervalLength);
            this.groupBoxOptions.Controls.Add(this.labelNumDates);
            this.groupBoxOptions.Controls.Add(this.lblStartDateMultipleDates);
            this.groupBoxOptions.Controls.Add(this.dateTimePicker);
            this.groupBoxOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOptions.Location = new System.Drawing.Point(3, 3);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(342, 180);
            this.groupBoxOptions.TabIndex = 0;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // radioButtonBefore
            // 
            this.radioButtonBefore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonBefore.AutoSize = true;
            this.radioButtonBefore.Location = new System.Drawing.Point(203, 125);
            this.radioButtonBefore.Name = "radioButtonBefore";
            this.radioButtonBefore.Size = new System.Drawing.Size(127, 17);
            this.radioButtonBefore.TabIndex = 8;
            this.radioButtonBefore.TabStop = true;
            this.radioButtonBefore.Text = "Before Selected Date";
            this.radioButtonBefore.UseVisualStyleBackColor = true;
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
            // btnGenerate
            // 
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGenerate.Location = new System.Drawing.Point(112, 151);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // numPickerIntervalLength
            // 
            this.numPickerIntervalLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numPickerIntervalLength.Location = new System.Drawing.Point(210, 88);
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
            this.numPickerDates.Location = new System.Drawing.Point(210, 56);
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
            // labelMultipleDatesIntervalLength
            // 
            this.labelMultipleDatesIntervalLength.AutoSize = true;
            this.labelMultipleDatesIntervalLength.Location = new System.Drawing.Point(12, 90);
            this.labelMultipleDatesIntervalLength.Name = "labelMultipleDatesIntervalLength";
            this.labelMultipleDatesIntervalLength.Size = new System.Drawing.Size(111, 13);
            this.labelMultipleDatesIntervalLength.TabIndex = 3;
            this.labelMultipleDatesIntervalLength.Text = "Interval Length (Days)";
            // 
            // labelNumDates
            // 
            this.labelNumDates.AutoSize = true;
            this.labelNumDates.Location = new System.Drawing.Point(12, 58);
            this.labelNumDates.Name = "labelNumDates";
            this.labelNumDates.Size = new System.Drawing.Size(87, 13);
            this.labelNumDates.TabIndex = 2;
            this.labelNumDates.Text = "Number of Dates";
            // 
            // lblStartDateMultipleDates
            // 
            this.lblStartDateMultipleDates.AutoSize = true;
            this.lblStartDateMultipleDates.Location = new System.Drawing.Point(12, 25);
            this.lblStartDateMultipleDates.Name = "lblStartDateMultipleDates";
            this.lblStartDateMultipleDates.Size = new System.Drawing.Size(55, 13);
            this.lblStartDateMultipleDates.TabIndex = 1;
            this.lblStartDateMultipleDates.Text = "Start Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(130, 19);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageMultDates);
            this.tabControlMain.Controls.Add(this.tabPageSingleDate);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(356, 212);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageMultDates
            // 
            this.tabPageMultDates.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMultDates.Controls.Add(this.groupBoxOptions);
            this.tabPageMultDates.Location = new System.Drawing.Point(4, 22);
            this.tabPageMultDates.Name = "tabPageMultDates";
            this.tabPageMultDates.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMultDates.Size = new System.Drawing.Size(348, 186);
            this.tabPageMultDates.TabIndex = 0;
            this.tabPageMultDates.Text = "Multiples Dates in Fixed Intervals";
            // 
            // tabPageSingleDate
            // 
            this.tabPageSingleDate.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSingleDate.Controls.Add(this.groupBoxSingleDate);
            this.tabPageSingleDate.Location = new System.Drawing.Point(4, 22);
            this.tabPageSingleDate.Name = "tabPageSingleDate";
            this.tabPageSingleDate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSingleDate.Size = new System.Drawing.Size(348, 186);
            this.tabPageSingleDate.TabIndex = 1;
            this.tabPageSingleDate.Text = "Single Date";
            // 
            // groupBoxSingleDate
            // 
            this.groupBoxSingleDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSingleDate.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSingleDate.Name = "groupBoxSingleDate";
            this.groupBoxSingleDate.Size = new System.Drawing.Size(342, 180);
            this.groupBoxSingleDate.TabIndex = 0;
            this.groupBoxSingleDate.TabStop = false;
            this.groupBoxSingleDate.Text = "Options";
            // 
            // DateIntervalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 212);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DateIntervalsForm";
            this.Text = "Date Intervals";
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPickerIntervalLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPickerDates)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageMultDates.ResumeLayout(false);
            this.tabPageSingleDate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelMultipleDatesIntervalLength;
        private System.Windows.Forms.Label labelNumDates;
        private System.Windows.Forms.Label lblStartDateMultipleDates;
        private System.Windows.Forms.NumericUpDown numPickerDates;
        private System.Windows.Forms.NumericUpDown numPickerIntervalLength;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RadioButton radioButtonAfter;
        private System.Windows.Forms.RadioButton radioButtonBefore;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageMultDates;
        private System.Windows.Forms.TabPage tabPageSingleDate;
        private System.Windows.Forms.GroupBox groupBoxSingleDate;
    }
}

