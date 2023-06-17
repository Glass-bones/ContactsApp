namespace ContactsApp.View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainTableLayoutPanel = new TableLayoutPanel();
            LeftPanel = new Panel();
            ButtonsTableLayoutPanel = new TableLayoutPanel();
            EditButton = new PictureBox();
            RemoveButton = new PictureBox();
            AddButton = new PictureBox();
            FindLabel = new Label();
            FindTextBox = new TextBox();
            ContactsListBox = new ListBox();
            RightPanel = new Panel();
            NotePanel = new Panel();
            CloseBDNoteButton = new PictureBox();
            NotedNamesLabel = new Label();
            TodayIsBirthdayOfLabel = new Label();
            NotePictureBox = new PictureBox();
            VKTextBox = new TextBox();
            VKLabel = new Label();
            DateOfBirthTextBox = new TextBox();
            DateOfBirthLabel = new Label();
            PhoneTextBox = new TextBox();
            PhoneLabel = new Label();
            EmailTextBox = new TextBox();
            EmailLabel = new Label();
            FullNameTextBox = new TextBox();
            NameLabel = new Label();
            PhotoPictureBox = new PictureBox();
            MainTableLayoutPanel.SuspendLayout();
            LeftPanel.SuspendLayout();
            ButtonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EditButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RemoveButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddButton).BeginInit();
            RightPanel.SuspendLayout();
            NotePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseBDNoteButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NotePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            MainTableLayoutPanel.ColumnCount = 2;
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainTableLayoutPanel.Controls.Add(LeftPanel, 0, 0);
            MainTableLayoutPanel.Controls.Add(RightPanel, 1, 0);
            MainTableLayoutPanel.Dock = DockStyle.Fill;
            MainTableLayoutPanel.Location = new Point(0, 0);
            MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            MainTableLayoutPanel.RowCount = 1;
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainTableLayoutPanel.Size = new Size(800, 450);
            MainTableLayoutPanel.TabIndex = 0;
            // 
            // LeftPanel
            // 
            LeftPanel.Controls.Add(ButtonsTableLayoutPanel);
            LeftPanel.Controls.Add(FindLabel);
            LeftPanel.Controls.Add(FindTextBox);
            LeftPanel.Controls.Add(ContactsListBox);
            LeftPanel.Dock = DockStyle.Fill;
            LeftPanel.Location = new Point(3, 3);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.Size = new Size(244, 444);
            LeftPanel.TabIndex = 0;
            // 
            // ButtonsTableLayoutPanel
            // 
            ButtonsTableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonsTableLayoutPanel.ColumnCount = 3;
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonsTableLayoutPanel.Controls.Add(EditButton, 1, 0);
            ButtonsTableLayoutPanel.Controls.Add(RemoveButton, 2, 0);
            ButtonsTableLayoutPanel.Controls.Add(AddButton, 0, 0);
            ButtonsTableLayoutPanel.Location = new Point(3, 409);
            ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            ButtonsTableLayoutPanel.RowCount = 1;
            ButtonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ButtonsTableLayoutPanel.Size = new Size(238, 32);
            ButtonsTableLayoutPanel.TabIndex = 3;
            // 
            // EditButton
            // 
            EditButton.Dock = DockStyle.Fill;
            EditButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditButton.Location = new Point(79, 0);
            EditButton.Margin = new Padding(0);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(79, 32);
            EditButton.SizeMode = PictureBoxSizeMode.CenterImage;
            EditButton.TabIndex = 4;
            EditButton.TabStop = false;
            EditButton.MouseEnter += EditButton_MouseEnter;
            EditButton.MouseLeave += EditButton_MouseLeave;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveButton.Location = new Point(158, 0);
            RemoveButton.Margin = new Padding(0);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(80, 32);
            RemoveButton.SizeMode = PictureBoxSizeMode.CenterImage;
            RemoveButton.TabIndex = 2;
            RemoveButton.TabStop = false;
            RemoveButton.Click += RemoveButton_Click;
            RemoveButton.MouseEnter += RemoveButton_MouseEnter;
            RemoveButton.MouseLeave += RemoveButton_MouseLeave;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddButton.Location = new Point(0, 0);
            AddButton.Margin = new Padding(0);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(79, 32);
            AddButton.SizeMode = PictureBoxSizeMode.CenterImage;
            AddButton.TabIndex = 3;
            AddButton.TabStop = false;
            AddButton.Click += AddButton_Click;
            AddButton.MouseEnter += AddButton_MouseEnter;
            AddButton.MouseLeave += AddButton_MouseLeave;
            // 
            // FindLabel
            // 
            FindLabel.AutoSize = true;
            FindLabel.Location = new Point(3, 6);
            FindLabel.Name = "FindLabel";
            FindLabel.Size = new Size(33, 15);
            FindLabel.TabIndex = 2;
            FindLabel.Text = "Find:";
            // 
            // FindTextBox
            // 
            FindTextBox.Location = new Point(42, 3);
            FindTextBox.Name = "FindTextBox";
            FindTextBox.Size = new Size(199, 23);
            FindTextBox.TabIndex = 0;
            // 
            // ContactsListBox
            // 
            ContactsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContactsListBox.FormattingEnabled = true;
            ContactsListBox.IntegralHeight = false;
            ContactsListBox.ItemHeight = 15;
            ContactsListBox.Items.AddRange(new object[] { "Астрал", "Дейрмиф", "Жозефина", "Нила", "Ризза", "Серена", "Теодор", "Торосар", "Фафнер", "Халон" });
            ContactsListBox.Location = new Point(3, 32);
            ContactsListBox.Name = "ContactsListBox";
            ContactsListBox.SelectionMode = SelectionMode.MultiSimple;
            ContactsListBox.Size = new Size(238, 377);
            ContactsListBox.TabIndex = 0;
            ContactsListBox.MouseDown += ContactsListBox_MouseDown;
            // 
            // RightPanel
            // 
            RightPanel.Controls.Add(NotePanel);
            RightPanel.Controls.Add(VKTextBox);
            RightPanel.Controls.Add(VKLabel);
            RightPanel.Controls.Add(DateOfBirthTextBox);
            RightPanel.Controls.Add(DateOfBirthLabel);
            RightPanel.Controls.Add(PhoneTextBox);
            RightPanel.Controls.Add(PhoneLabel);
            RightPanel.Controls.Add(EmailTextBox);
            RightPanel.Controls.Add(EmailLabel);
            RightPanel.Controls.Add(FullNameTextBox);
            RightPanel.Controls.Add(NameLabel);
            RightPanel.Controls.Add(PhotoPictureBox);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Location = new Point(253, 3);
            RightPanel.Name = "RightPanel";
            RightPanel.Size = new Size(544, 444);
            RightPanel.TabIndex = 1;
            // 
            // NotePanel
            // 
            NotePanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NotePanel.BackColor = Color.FromArgb(245, 245, 255);
            NotePanel.Controls.Add(CloseBDNoteButton);
            NotePanel.Controls.Add(NotedNamesLabel);
            NotePanel.Controls.Add(TodayIsBirthdayOfLabel);
            NotePanel.Controls.Add(NotePictureBox);
            NotePanel.Location = new Point(3, 369);
            NotePanel.Name = "NotePanel";
            NotePanel.Size = new Size(538, 75);
            NotePanel.TabIndex = 11;
            // 
            // CloseBDNoteButton
            // 
            CloseBDNoteButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseBDNoteButton.Image = Properties.Resources.close_32x32;
            CloseBDNoteButton.Location = new Point(503, 3);
            CloseBDNoteButton.Name = "CloseBDNoteButton";
            CloseBDNoteButton.Size = new Size(32, 32);
            CloseBDNoteButton.TabIndex = 3;
            CloseBDNoteButton.TabStop = false;
            CloseBDNoteButton.Click += CloseBDNoteButton_Click;
            // 
            // NotedNamesLabel
            // 
            NotedNamesLabel.AutoSize = true;
            NotedNamesLabel.ForeColor = Color.FromArgb(0, 144, 255);
            NotedNamesLabel.Location = new Point(78, 22);
            NotedNamesLabel.Name = "NotedNamesLabel";
            NotedNamesLabel.Size = new Size(216, 15);
            NotedNamesLabel.TabIndex = 2;
            NotedNamesLabel.Text = "Комаров, Комарова, Комарово и др.";
            // 
            // TodayIsBirthdayOfLabel
            // 
            TodayIsBirthdayOfLabel.AutoSize = true;
            TodayIsBirthdayOfLabel.ForeColor = Color.FromArgb(0, 144, 255);
            TodayIsBirthdayOfLabel.Location = new Point(78, 3);
            TodayIsBirthdayOfLabel.Name = "TodayIsBirthdayOfLabel";
            TodayIsBirthdayOfLabel.Size = new Size(118, 15);
            TodayIsBirthdayOfLabel.TabIndex = 1;
            TodayIsBirthdayOfLabel.Text = "Today is Birthday of:";
            // 
            // NotePictureBox
            // 
            NotePictureBox.Image = Properties.Resources.info_48x48;
            NotePictureBox.Location = new Point(3, 3);
            NotePictureBox.Name = "NotePictureBox";
            NotePictureBox.Size = new Size(69, 69);
            NotePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            NotePictureBox.TabIndex = 0;
            NotePictureBox.TabStop = false;
            // 
            // VKTextBox
            // 
            VKTextBox.Location = new Point(109, 248);
            VKTextBox.Name = "VKTextBox";
            VKTextBox.Size = new Size(180, 23);
            VKTextBox.TabIndex = 10;
            VKTextBox.KeyPress += VKTextBox_KeyPress;
            // 
            // VKLabel
            // 
            VKLabel.AutoSize = true;
            VKLabel.Location = new Point(109, 230);
            VKLabel.Margin = new Padding(3, 10, 3, 0);
            VKLabel.Name = "VKLabel";
            VKLabel.Size = new Size(26, 15);
            VKLabel.TabIndex = 9;
            VKLabel.Text = "VK:";
            // 
            // DateOfBirthTextBox
            // 
            DateOfBirthTextBox.Location = new Point(109, 194);
            DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            DateOfBirthTextBox.Size = new Size(180, 23);
            DateOfBirthTextBox.TabIndex = 8;
            DateOfBirthTextBox.KeyPress += DateOfBirthTextBox_KeyPress;
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Location = new Point(109, 176);
            DateOfBirthLabel.Margin = new Padding(3, 10, 3, 0);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(83, 15);
            DateOfBirthLabel.TabIndex = 7;
            DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(109, 140);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(180, 23);
            PhoneTextBox.TabIndex = 6;
            PhoneTextBox.Text = "+7 (000) 000-00-00";
            PhoneTextBox.KeyPress += PhoneTextBox_KeyPress;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(109, 122);
            PhoneLabel.Margin = new Padding(3, 10, 3, 0);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(94, 15);
            PhoneLabel.TabIndex = 5;
            PhoneLabel.Text = "Phone Number:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmailTextBox.Location = new Point(109, 86);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(432, 23);
            EmailTextBox.TabIndex = 4;
            EmailTextBox.Text = "chain.lightning@no.mail";
            EmailTextBox.KeyPress += EmailTextBox_KeyPress;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(109, 68);
            EmailLabel.Margin = new Padding(3, 10, 3, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(44, 15);
            EmailLabel.TabIndex = 3;
            EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Location = new Point(109, 32);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(432, 23);
            FullNameTextBox.TabIndex = 2;
            FullNameTextBox.Text = "Солмир Джафарович";
            FullNameTextBox.KeyPress += FullNameTextBox_KeyPress;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(109, 6);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(65, 15);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Full Name:";
            // 
            // PhotoPictureBox
            // 
            PhotoPictureBox.Image = Properties.Resources.photo_placeholder_100x100;
            PhotoPictureBox.Location = new Point(3, 3);
            PhotoPictureBox.Name = "PhotoPictureBox";
            PhotoPictureBox.Size = new Size(100, 100);
            PhotoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            PhotoPictureBox.TabIndex = 0;
            PhotoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(MainTableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "ContactsApp";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            HelpRequested += MainForm_HelpRequested;
            MainTableLayoutPanel.ResumeLayout(false);
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ButtonsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EditButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)RemoveButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddButton).EndInit();
            RightPanel.ResumeLayout(false);
            RightPanel.PerformLayout();
            NotePanel.ResumeLayout(false);
            NotePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseBDNoteButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)NotePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainTableLayoutPanel;
        private Panel LeftPanel;
        private ListBox ContactsListBox;
        private Panel RightPanel;
        private Label FindLabel;
        private TextBox FindTextBox;
        private TableLayoutPanel ButtonsTableLayoutPanel;
        private TextBox PhoneTextBox;
        private Label PhoneLabel;
        private TextBox EmailTextBox;
        private Label EmailLabel;
        private TextBox FullNameTextBox;
        private Label NameLabel;
        private PictureBox PhotoPictureBox;
        private TextBox VKTextBox;
        private Label VKLabel;
        private TextBox DateOfBirthTextBox;
        private Label DateOfBirthLabel;
        private Panel NotePanel;
        private Label NotedNamesLabel;
        private Label TodayIsBirthdayOfLabel;
        private PictureBox NotePictureBox;
        private PictureBox RemoveButton;
        private PictureBox EditButton;
        private PictureBox AddButton;
        private PictureBox CloseBDNoteButton;
    }
}