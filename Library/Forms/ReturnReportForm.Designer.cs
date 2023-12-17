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
            estimatedReturnDateLable.Location = new Point(10, 153);
            estimatedReturnDateLable.Name = "estimatedReturnDateLable";
            estimatedReturnDateLable.Size = new Size(38, 15);
            estimatedReturnDateLable.TabIndex = 84;
            estimatedReturnDateLable.Text = "label7";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 109);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 81;
            label3.Text = "Конечная дата";
            // 
            // endDate
            // 
            endDate.Location = new Point(12, 127);
            endDate.Name = "endDate";
            endDate.Size = new Size(208, 23);
            endDate.TabIndex = 80;
            // 
            // startDate
            // 
            startDate.ImeMode = ImeMode.NoControl;
            startDate.Location = new Point(12, 54);
            startDate.Name = "startDate";
            startDate.Size = new Size(208, 23);
            startDate.TabIndex = 79;
            // 
            // dateOfIssuedLable
            // 
            dateOfIssuedLable.AutoSize = true;
            dateOfIssuedLable.ForeColor = Color.Red;
            dateOfIssuedLable.Location = new Point(11, 80);
            dateOfIssuedLable.Name = "dateOfIssuedLable";
            dateOfIssuedLable.Size = new Size(38, 15);
            dateOfIssuedLable.TabIndex = 78;
            dateOfIssuedLable.Text = "label7";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 37);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 77;
            label2.Text = "Начальная дата";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 13);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 76;
            label1.Text = "Создание отчёта";
            // 
            // addStaff
            // 
            addStaff.Location = new Point(193, 200);
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
            staffLabel.Location = new Point(12, 226);
            staffLabel.Name = "staffLabel";
            staffLabel.Size = new Size(38, 15);
            staffLabel.TabIndex = 74;
            staffLabel.Text = "label9";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 182);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 73;
            label7.Text = "Сотрудник";
            // 
            // staffComboBox
            // 
            staffComboBox.FormattingEnabled = true;
            staffComboBox.Location = new Point(12, 200);
            staffComboBox.Name = "staffComboBox";
            staffComboBox.Size = new Size(175, 23);
            staffComboBox.TabIndex = 72;
            // 
            // buttonReportStaff
            // 
            buttonReportStaff.Location = new Point(62, 261);
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
            ClientSize = new Size(239, 296);
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
            Text = "Выданные книг которые не вернули";
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