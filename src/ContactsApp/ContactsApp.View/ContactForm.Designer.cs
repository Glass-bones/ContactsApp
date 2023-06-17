namespace ContactsApp.View
{
    partial class ContactForm
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
            VKTextBox = new TextBox();
            VKLabel = new Label();
            DateOfBirthLabel = new Label();
            PhoneTextBox = new TextBox();
            PhoneLabel = new Label();
            EmailTextBox = new TextBox();
            EmailLabel = new Label();
            FullNameTextBox = new TextBox();
            NameLabel = new Label();
            PhotoPictureBox = new PictureBox();
            AddPhotoButton = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            OkAddButton = new Button();
            CancelAddButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddPhotoButton).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // VKTextBox
            // 
            VKTextBox.Location = new Point(118, 257);
            VKTextBox.MaxLength = 50;
            VKTextBox.Name = "VKTextBox";
            VKTextBox.Size = new Size(180, 23);
            VKTextBox.TabIndex = 21;
            // 
            // VKLabel
            // 
            VKLabel.AutoSize = true;
            VKLabel.Location = new Point(118, 239);
            VKLabel.Margin = new Padding(3, 10, 3, 0);
            VKLabel.Name = "VKLabel";
            VKLabel.Size = new Size(26, 15);
            VKLabel.TabIndex = 20;
            VKLabel.Text = "VK:";
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Location = new Point(118, 185);
            DateOfBirthLabel.Margin = new Padding(3, 10, 3, 0);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(83, 15);
            DateOfBirthLabel.TabIndex = 18;
            DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(118, 149);
            PhoneTextBox.MaxLength = 30;
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(180, 23);
            PhoneTextBox.TabIndex = 17;
            PhoneTextBox.Text = "7 (000) 000-00-00";
            PhoneTextBox.TextChanged += PhoneTextBox_TextChanged;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(118, 131);
            PhoneLabel.Margin = new Padding(3, 10, 3, 0);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(94, 15);
            PhoneLabel.TabIndex = 16;
            PhoneLabel.Text = "Phone Number:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmailTextBox.Location = new Point(118, 95);
            EmailTextBox.MaxLength = 100;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(394, 23);
            EmailTextBox.TabIndex = 15;
            EmailTextBox.Text = "chain.lightning@no.mail";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(118, 77);
            EmailLabel.Margin = new Padding(3, 10, 3, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(44, 15);
            EmailLabel.TabIndex = 14;
            EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Location = new Point(118, 41);
            FullNameTextBox.MaxLength = 100;
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(394, 23);
            FullNameTextBox.TabIndex = 13;
            FullNameTextBox.Text = "Солмир Джафарович";
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(118, 15);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(65, 15);
            NameLabel.TabIndex = 12;
            NameLabel.Text = "Full Name:";
            // 
            // PhotoPictureBox
            // 
            PhotoPictureBox.Image = Properties.Resources.photo_placeholder_100x100;
            PhotoPictureBox.Location = new Point(12, 12);
            PhotoPictureBox.Name = "PhotoPictureBox";
            PhotoPictureBox.Size = new Size(100, 100);
            PhotoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            PhotoPictureBox.TabIndex = 11;
            PhotoPictureBox.TabStop = false;
            // 
            // AddPhotoButton
            // 
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
            AddPhotoButton.Location = new Point(12, 112);
            AddPhotoButton.Margin = new Padding(0);
            AddPhotoButton.Name = "AddPhotoButton";
            AddPhotoButton.Size = new Size(100, 32);
            AddPhotoButton.SizeMode = PictureBoxSizeMode.CenterImage;
            AddPhotoButton.TabIndex = 22;
            AddPhotoButton.TabStop = false;
            AddPhotoButton.MouseEnter += AddPhotoButton_MouseEnter;
            AddPhotoButton.MouseLeave += AddPhotoButton_MouseLeave;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(118, 203);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(180, 23);
            dateTimePicker1.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(OkAddButton);
            panel1.Controls.Add(CancelAddButton);
            panel1.Location = new Point(0, 305);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 46);
            panel1.TabIndex = 24;
            // 
            // OkAddButton
            // 
            OkAddButton.Location = new Point(356, 11);
            OkAddButton.Name = "OkAddButton";
            OkAddButton.Size = new Size(75, 23);
            OkAddButton.TabIndex = 1;
            OkAddButton.Text = "OK";
            OkAddButton.UseVisualStyleBackColor = true;
            OkAddButton.Click += OkAddButton_Click;
            // 
            // CancelAddButton
            // 
            CancelAddButton.Location = new Point(437, 11);
            CancelAddButton.Name = "CancelAddButton";
            CancelAddButton.Size = new Size(75, 23);
            CancelAddButton.TabIndex = 0;
            CancelAddButton.Text = "Cancel";
            CancelAddButton.UseVisualStyleBackColor = true;
            CancelAddButton.Click += CancelAddButton_Click;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(524, 351);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(AddPhotoButton);
            Controls.Add(VKTextBox);
            Controls.Add(VKLabel);
            Controls.Add(DateOfBirthLabel);
            Controls.Add(PhoneTextBox);
            Controls.Add(PhoneLabel);
            Controls.Add(EmailTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(FullNameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(PhotoPictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ContactForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += ContactForm_Load;
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddPhotoButton).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox VKTextBox;
        private Label VKLabel;
        private Label DateOfBirthLabel;
        private TextBox PhoneTextBox;
        private Label PhoneLabel;
        private TextBox EmailTextBox;
        private Label EmailLabel;
        private TextBox FullNameTextBox;
        private Label NameLabel;
        private PictureBox PhotoPictureBox;
        private PictureBox AddPhotoButton;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private Button CancelAddButton;
        private Button OkAddButton;
    }
}