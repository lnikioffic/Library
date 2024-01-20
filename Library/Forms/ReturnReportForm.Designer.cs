namespace Library.Forms
{
    partial class ReturnReportForm
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
            estimatedReturnDateLable = new Label();
            label3 = new Label();
            endDate = new DateTimePicker();
            startDate = new DateTimePicker();
            dateOfIssuedLable = new Label();
            label2 = new Label();
            label1 = new Label();
            addStaff = new Button();
            staffLabel = new Label();
            label7 = new Label();
            staffComboBox = new ComboBox();
            buttonReportStaff = new Button();
            SuspendLayout();
            // 
            // estimatedReturnDateLable
            // 
            estimatedReturnDateLable.AutoSize = true;
            estimatedReturnDateLable.ForeColor = Color.Red;
            estimatedReturnDateLable.Location = new Point(9, 78);
            estimatedReturnDateLable.Name = "estimatedReturnDateLable";
            estimatedReturnDateLable.Size = new Size(38, 15);
            estimatedReturnDateLable.TabIndex = 84;
            estimatedReturnDateLable.Text = "label7";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 34);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 81;
            label3.Text = "Текущая дата";
            // 
            // endDate
            // 
            endDate.Enabled = false;
            endDate.Location = new Point(11, 52);
            endDate.Name = "endDate";
            endDate.Size = new Size(208, 23);
            endDate.TabIndex = 80;
            // 
            // startDate
            // 
            startDate.ImeMode = ImeMode.NoControl;
            startDate.Location = new Point(250, 52);
            startDate.Name = "startDate";
            startDate.Size = new Size(208, 23);
            startDate.TabIndex = 79;
            startDate.Visible = false;
            // 
            // dateOfIssuedLable
            // 
            dateOfIssuedLable.AutoSize = true;
            dateOfIssuedLable.ForeColor = Color.Red;
            dateOfIssuedLable.Location = new Point(249, 78);
            dateOfIssuedLable.Name = "dateOfIssuedLable";
            dateOfIssuedLable.Size = new Size(38, 15);
            dateOfIssuedLable.TabIndex = 78;
            dateOfIssuedLable.Text = "label7";
            dateOfIssuedLable.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 35);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 77;
            label2.Text = "Начальная дата";
            label2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 76;
            label1.Text = "Создание отчёта";
            // 
            // addStaff
            // 
            addStaff.Location = new Point(192, 125);
            addStaff.Name = "addStaff";
            addStaff.Size = new Size(27, 23);
            addStaff.TabIndex = 75;
            addStaff.Text = "...";
            addStaff.UseVisualStyleBackColor = true;
            addStaff.Click += addStaff_Click;
            // 
            // staffLabel
            // 
            staffLabel.AutoSize = true;
            staffLabel.ForeColor = Color.Red;
            staffLabel.Location = new Point(11, 151);
            staffLabel.Name = "staffLabel";
            staffLabel.Size = new Size(38, 15);
            staffLabel.TabIndex = 74;
            staffLabel.Text = "label9";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 107);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 73;
            label7.Text = "Сотрудник";
            // 
            // staffComboBox
            // 
            staffComboBox.FormattingEnabled = true;
            staffComboBox.Location = new Point(11, 125);
            staffComboBox.Name = "staffComboBox";
            staffComboBox.Size = new Size(175, 23);
            staffComboBox.TabIndex = 72;
            // 
            // buttonReportStaff
            // 
            buttonReportStaff.Location = new Point(61, 186);
            buttonReportStaff.Name = "buttonReportStaff";
            buttonReportStaff.Size = new Size(101, 23);
            buttonReportStaff.TabIndex = 86;
            buttonReportStaff.Text = "Создать";
            buttonReportStaff.UseVisualStyleBackColor = true;
            buttonReportStaff.Click += buttonReportStaff_Click;
            // 
            // ReturnReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 238);
            Controls.Add(buttonReportStaff);
            Controls.Add(estimatedReturnDateLable);
            Controls.Add(label3);
            Controls.Add(endDate);
            Controls.Add(startDate);
            Controls.Add(dateOfIssuedLable);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addStaff);
            Controls.Add(staffLabel);
            Controls.Add(label7);
            Controls.Add(staffComboBox);
            Name = "ReturnReportForm";
            Text = "Не возвращённые книги";
            Load += SataffReportForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label estimatedReturnDateLable;
        private Label label3;
        private DateTimePicker endDate;
        private DateTimePicker startDate;
        private Label dateOfIssuedLable;
        private Label label2;
        private Label label1;
        private Button addStaff;
        private Label staffLabel;
        private Label label7;
        private ComboBox staffComboBox;
        private Button buttonReportStaff;
    }
}