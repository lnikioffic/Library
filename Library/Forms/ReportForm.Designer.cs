namespace Library.Forms
{
    partial class ReportForm
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
            addStaff = new Button();
            staffLabel = new Label();
            label7 = new Label();
            staffComboBox = new ComboBox();
            label1 = new Label();
            estimatedReturnDateLable = new Label();
            dataLable = new Label();
            dateCreate = new DateTimePicker();
            label3 = new Label();
            endDate = new DateTimePicker();
            startDate = new DateTimePicker();
            dateOfIssuedLable = new Label();
            label2 = new Label();
            buttonReportGenre = new Button();
            buttonReportStaff = new Button();
            buttonReportAuthor = new Button();
            createLable = new Label();
            SuspendLayout();
            // 
            // addStaff
            // 
            addStaff.Location = new Point(291, 117);
            addStaff.Name = "addStaff";
            addStaff.Size = new Size(27, 23);
            addStaff.TabIndex = 41;
            addStaff.Text = "...";
            addStaff.UseVisualStyleBackColor = true;
            addStaff.Click += addStaff_Click;
            // 
            // staffLabel
            // 
            staffLabel.AutoSize = true;
            staffLabel.ForeColor = Color.Red;
            staffLabel.Location = new Point(85, 143);
            staffLabel.Name = "staffLabel";
            staffLabel.Size = new Size(38, 15);
            staffLabel.TabIndex = 40;
            staffLabel.Text = "label9";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 99);
            label7.Name = "label7";
            label7.Size = new Size(163, 15);
            label7.TabIndex = 39;
            label7.Text = "Сотрудник создавший отчёт";
            // 
            // staffComboBox
            // 
            staffComboBox.FormattingEnabled = true;
            staffComboBox.Location = new Point(85, 117);
            staffComboBox.Name = "staffComboBox";
            staffComboBox.Size = new Size(200, 23);
            staffComboBox.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 42;
            label1.Text = "Создание отчётов";
            // 
            // estimatedReturnDateLable
            // 
            estimatedReturnDateLable.AutoSize = true;
            estimatedReturnDateLable.ForeColor = Color.Red;
            estimatedReturnDateLable.Location = new Point(270, 231);
            estimatedReturnDateLable.Name = "estimatedReturnDateLable";
            estimatedReturnDateLable.Size = new Size(38, 15);
            estimatedReturnDateLable.TabIndex = 50;
            estimatedReturnDateLable.Text = "label7";
            // 
            // dataLable
            // 
            dataLable.AutoSize = true;
            dataLable.Location = new Point(335, 100);
            dataLable.Name = "dataLable";
            dataLable.Size = new Size(130, 15);
            dataLable.TabIndex = 49;
            dataLable.Text = "Дата создания отячёта";
            // 
            // dateCreate
            // 
            dateCreate.CustomFormat = " ";
            dateCreate.Location = new Point(335, 117);
            dateCreate.Name = "dateCreate";
            dateCreate.Size = new Size(178, 23);
            dateCreate.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(289, 187);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 47;
            label3.Text = "Конечная дата";
            // 
            // endDate
            // 
            endDate.Location = new Point(291, 205);
            endDate.Name = "endDate";
            endDate.Size = new Size(178, 23);
            endDate.TabIndex = 46;
            // 
            // startDate
            // 
            startDate.ImeMode = ImeMode.NoControl;
            startDate.Location = new Point(107, 204);
            startDate.Name = "startDate";
            startDate.Size = new Size(178, 23);
            startDate.TabIndex = 45;
            // 
            // dateOfIssuedLable
            // 
            dateOfIssuedLable.AutoSize = true;
            dateOfIssuedLable.ForeColor = Color.Red;
            dateOfIssuedLable.Location = new Point(106, 230);
            dateOfIssuedLable.Name = "dateOfIssuedLable";
            dateOfIssuedLable.Size = new Size(38, 15);
            dateOfIssuedLable.TabIndex = 44;
            dateOfIssuedLable.Text = "label7";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 187);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 43;
            label2.Text = "Начальная дата";
            // 
            // buttonReportGenre
            // 
            buttonReportGenre.Location = new Point(18, 297);
            buttonReportGenre.Name = "buttonReportGenre";
            buttonReportGenre.Size = new Size(159, 23);
            buttonReportGenre.TabIndex = 51;
            buttonReportGenre.Text = "Отчёт по жанрам";
            buttonReportGenre.UseVisualStyleBackColor = true;
            buttonReportGenre.Click += buttonReportGenre_Click;
            // 
            // buttonReportStaff
            // 
            buttonReportStaff.Location = new Point(212, 297);
            buttonReportStaff.Name = "buttonReportStaff";
            buttonReportStaff.Size = new Size(159, 23);
            buttonReportStaff.TabIndex = 52;
            buttonReportStaff.Text = "Отчёт по сотрудникам";
            buttonReportStaff.UseVisualStyleBackColor = true;
            buttonReportStaff.Click += buttonReportStaff_Click;
            // 
            // buttonReportAuthor
            // 
            buttonReportAuthor.Location = new Point(395, 297);
            buttonReportAuthor.Name = "buttonReportAuthor";
            buttonReportAuthor.Size = new Size(159, 23);
            buttonReportAuthor.TabIndex = 53;
            buttonReportAuthor.Text = "Отчёт по авторам";
            buttonReportAuthor.UseVisualStyleBackColor = true;
            buttonReportAuthor.Click += buttonReportAuthor_Click;
            // 
            // createLable
            // 
            createLable.AutoSize = true;
            createLable.ForeColor = Color.Red;
            createLable.Location = new Point(335, 143);
            createLable.Name = "createLable";
            createLable.Size = new Size(38, 15);
            createLable.TabIndex = 54;
            createLable.Text = "label7";
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 360);
            Controls.Add(createLable);
            Controls.Add(buttonReportAuthor);
            Controls.Add(buttonReportStaff);
            Controls.Add(buttonReportGenre);
            Controls.Add(estimatedReturnDateLable);
            Controls.Add(dataLable);
            Controls.Add(dateCreate);
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
            Name = "ReportForm";
            Text = "Отчёты";
            Load += ReportForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addStaff;
        private Label staffLabel;
        private Label label7;
        private ComboBox staffComboBox;
        private Label label1;
        private Label estimatedReturnDateLable;
        private Label dataLable;
        private DateTimePicker dateCreate;
        private Label label3;
        private DateTimePicker endDate;
        private DateTimePicker startDate;
        private Label dateOfIssuedLable;
        private Label label2;
        private Button buttonReportGenre;
        private Button buttonReportStaff;
        private Button buttonReportAuthor;
        private Label createLable;
    }
}