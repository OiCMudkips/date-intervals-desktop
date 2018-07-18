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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateIntervalsForm));
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
            this.labelSingleDateResult = new System.Windows.Forms.Label();
            this.radioButtonSingleDateBefore = new System.Windows.Forms.RadioButton();
            this.radioButtonSingleDateAfter = new System.Windows.Forms.RadioButton();
            this.numericUpDownSingleDateIntervalLength = new System.Windows.Forms.NumericUpDown();
            this.labelSingleDateIntervalLength = new System.Windows.Forms.Label();
            this.dateTimePickerSingleDate = new System.Windows.Forms.DateTimePicker();
            this.labelSingleDateStartDate = new System.Windows.Forms.Label();
            this.groupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPickerIntervalLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPickerDates)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageMultDates.SuspendLayout();
            this.tabPageSingleDate.SuspendLayout();
            this.groupBoxSingleDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSingleDateIntervalLength)).BeginInit();
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
            this.groupBoxOptions.Size = new System.Drawing.Size(342, 172);
            this.groupBoxOptions.TabIndex = 0;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // radioButtonBefore
            // 
            this.radioButtonBefore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonBefore.AutoSize = true;
            this.radioButtonBefore.Location = new System.Drawing.Point(209, 115);
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
            this.radioButtonAfter.Location = new System.Drawing.Point(15, 115);
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
            this.btnGenerate.Location = new System.Drawing.Point(114, 145);
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
            this.numPickerIntervalLength.Location = new System.Drawing.Point(210, 85);
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
            this.numPickerDates.Location = new System.Drawing.Point(210, 52);
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
            this.labelMultipleDatesIntervalLength.Location = new System.Drawing.Point(12, 85);
            this.labelMultipleDatesIntervalLength.Name = "labelMultipleDatesIntervalLength";
            this.labelMultipleDatesIntervalLength.Size = new System.Drawing.Size(111, 13);
            this.labelMultipleDatesIntervalLength.TabIndex = 3;
            this.labelMultipleDatesIntervalLength.Text = "Interval Length (Days)";
            // 
            // labelNumDates
            // 
            this.labelNumDates.AutoSize = true;
            this.labelNumDates.Location = new System.Drawing.Point(12, 55);
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
            this.tabControlMain.Size = new System.Drawing.Size(356, 204);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageMultDates
            // 
            this.tabPageMultDates.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMultDates.Controls.Add(this.groupBoxOptions);
            this.tabPageMultDates.Location = new System.Drawing.Point(4, 22);
            this.tabPageMultDates.Name = "tabPageMultDates";
            this.tabPageMultDates.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMultDates.Size = new System.Drawing.Size(348, 178);
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
            this.tabPageSingleDate.Size = new System.Drawing.Size(348, 178);
            this.tabPageSingleDate.TabIndex = 1;
            this.tabPageSingleDate.Text = "Single Date";
            // 
            // groupBoxSingleDate
            // 
            this.groupBoxSingleDate.Controls.Add(this.labelSingleDateResult);
            this.groupBoxSingleDate.Controls.Add(this.radioButtonSingleDateBefore);
            this.groupBoxSingleDate.Controls.Add(this.radioButtonSingleDateAfter);
            this.groupBoxSingleDate.Controls.Add(this.numericUpDownSingleDateIntervalLength);
            this.groupBoxSingleDate.Controls.Add(this.labelSingleDateIntervalLength);
            this.groupBoxSingleDate.Controls.Add(this.dateTimePickerSingleDate);
            this.groupBoxSingleDate.Controls.Add(this.labelSingleDateStartDate);
            this.groupBoxSingleDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSingleDate.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSingleDate.Name = "groupBoxSingleDate";
            this.groupBoxSingleDate.Size = new System.Drawing.Size(342, 172);
            this.groupBoxSingleDate.TabIndex = 0;
            this.groupBoxSingleDate.TabStop = false;
            this.groupBoxSingleDate.Text = "Options";
            // 
            // labelSingleDateResult
            // 
            this.labelSingleDateResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSingleDateResult.AutoSize = true;
            this.labelSingleDateResult.Location = new System.Drawing.Point(111, 140);
            this.labelSingleDateResult.Name = "labelSingleDateResult";
            this.labelSingleDateResult.Size = new System.Drawing.Size(111, 13);
            this.labelSingleDateResult.TabIndex = 11;
            this.labelSingleDateResult.Text = "labelSingleDateResult";
            // 
            // radioButtonSingleDateBefore
            // 
            this.radioButtonSingleDateBefore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonSingleDateBefore.AutoSize = true;
            this.radioButtonSingleDateBefore.Location = new System.Drawing.Point(209, 85);
            this.radioButtonSingleDateBefore.Name = "radioButtonSingleDateBefore";
            this.radioButtonSingleDateBefore.Size = new System.Drawing.Size(127, 17);
            this.radioButtonSingleDateBefore.TabIndex = 10;
            this.radioButtonSingleDateBefore.TabStop = true;
            this.radioButtonSingleDateBefore.Text = "Before Selected Date";
            this.radioButtonSingleDateBefore.UseVisualStyleBackColor = true;
            this.radioButtonSingleDateBefore.CheckedChanged += new System.EventHandler(this.radioButtonSingleDateBefore_CheckedChanged);
            // 
            // radioButtonSingleDateAfter
            // 
            this.radioButtonSingleDateAfter.AutoSize = true;
            this.radioButtonSingleDateAfter.Location = new System.Drawing.Point(15, 85);
            this.radioButtonSingleDateAfter.Name = "radioButtonSingleDateAfter";
            this.radioButtonSingleDateAfter.Size = new System.Drawing.Size(118, 17);
            this.radioButtonSingleDateAfter.TabIndex = 9;
            this.radioButtonSingleDateAfter.TabStop = true;
            this.radioButtonSingleDateAfter.Text = "After Selected Date";
            this.radioButtonSingleDateAfter.UseVisualStyleBackColor = true;
            this.radioButtonSingleDateAfter.CheckedChanged += new System.EventHandler(this.radioButtonSingleDateAfter_CheckedChanged);
            // 
            // numericUpDownSingleDateIntervalLength
            // 
            this.numericUpDownSingleDateIntervalLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSingleDateIntervalLength.Location = new System.Drawing.Point(210, 52);
            this.numericUpDownSingleDateIntervalLength.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownSingleDateIntervalLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSingleDateIntervalLength.Name = "numericUpDownSingleDateIntervalLength";
            this.numericUpDownSingleDateIntervalLength.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSingleDateIntervalLength.TabIndex = 6;
            this.numericUpDownSingleDateIntervalLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSingleDateIntervalLength.ValueChanged += new System.EventHandler(this.numericUpDownSingleDateIntervalLength_ValueChanged);
            // 
            // labelSingleDateIntervalLength
            // 
            this.labelSingleDateIntervalLength.AutoSize = true;
            this.labelSingleDateIntervalLength.Location = new System.Drawing.Point(12, 55);
            this.labelSingleDateIntervalLength.Name = "labelSingleDateIntervalLength";
            this.labelSingleDateIntervalLength.Size = new System.Drawing.Size(111, 13);
            this.labelSingleDateIntervalLength.TabIndex = 4;
            this.labelSingleDateIntervalLength.Text = "Interval Length (Days)";
            // 
            // dateTimePickerSingleDate
            // 
            this.dateTimePickerSingleDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerSingleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSingleDate.Location = new System.Drawing.Point(130, 19);
            this.dateTimePickerSingleDate.Name = "dateTimePickerSingleDate";
            this.dateTimePickerSingleDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerSingleDate.TabIndex = 1;
            this.dateTimePickerSingleDate.ValueChanged += new System.EventHandler(this.dateTimePickerSingleDate_ValueChanged);
            // 
            // labelSingleDateStartDate
            // 
            this.labelSingleDateStartDate.AutoSize = true;
            this.labelSingleDateStartDate.Location = new System.Drawing.Point(12, 25);
            this.labelSingleDateStartDate.Name = "labelSingleDateStartDate";
            this.labelSingleDateStartDate.Size = new System.Drawing.Size(55, 13);
            this.labelSingleDateStartDate.TabIndex = 0;
            this.labelSingleDateStartDate.Text = "Start Date";
            // 
            // DateIntervalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 204);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
            this.groupBoxSingleDate.ResumeLayout(false);
            this.groupBoxSingleDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSingleDateIntervalLength)).EndInit();
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
        private System.Windows.Forms.Label labelSingleDateStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerSingleDate;
        private System.Windows.Forms.Label labelSingleDateIntervalLength;
        private System.Windows.Forms.NumericUpDown numericUpDownSingleDateIntervalLength;
        private System.Windows.Forms.RadioButton radioButtonSingleDateBefore;
        private System.Windows.Forms.RadioButton radioButtonSingleDateAfter;
        private System.Windows.Forms.Label labelSingleDateResult;
    }
}

