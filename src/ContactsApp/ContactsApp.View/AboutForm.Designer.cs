namespace ContactsApp.View
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            CopyrightTextBox = new TextBox();
            GitHubPresentLabel = new Label();
            EMailPresentLabel = new Label();
            AuthorPresentLabel = new Label();
            AuthorLabel = new Label();
            EMailLabel = new Label();
            GitHubLinkLabel = new LinkLabel();
            AppVersionLabel = new Label();
            AppLabel = new Label();
            SourceLabel = new Label();
            SourceLinkLabel = new LinkLabel();
            panel1 = new Panel();
            OkAddButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CopyrightTextBox
            // 
            CopyrightTextBox.Location = new Point(17, 174);
            CopyrightTextBox.Margin = new Padding(4);
            CopyrightTextBox.Multiline = true;
            CopyrightTextBox.Name = "CopyrightTextBox";
            CopyrightTextBox.ScrollBars = ScrollBars.Vertical;
            CopyrightTextBox.Size = new Size(489, 157);
            CopyrightTextBox.TabIndex = 0;
            CopyrightTextBox.TabStop = false;
            CopyrightTextBox.Text = resources.GetString("CopyrightTextBox.Text");
            CopyrightTextBox.TextChanged += CopyrightTextBox_TextChanged;
            // 
            // GitHubPresentLabel
            // 
            GitHubPresentLabel.AutoSize = true;
            GitHubPresentLabel.Location = new Point(16, 144);
            GitHubPresentLabel.Margin = new Padding(3, 0, 3, 11);
            GitHubPresentLabel.Name = "GitHubPresentLabel";
            GitHubPresentLabel.Size = new Size(50, 15);
            GitHubPresentLabel.TabIndex = 1;
            GitHubPresentLabel.Text = "GitHub:";
            // 
            // EMailPresentLabel
            // 
            EMailPresentLabel.AutoSize = true;
            EMailPresentLabel.Location = new Point(16, 119);
            EMailPresentLabel.Margin = new Padding(3, 0, 3, 10);
            EMailPresentLabel.Name = "EMailPresentLabel";
            EMailPresentLabel.Size = new Size(44, 15);
            EMailPresentLabel.TabIndex = 2;
            EMailPresentLabel.Text = "E-Mail:";
            // 
            // AuthorPresentLabel
            // 
            AuthorPresentLabel.AutoSize = true;
            AuthorPresentLabel.Location = new Point(16, 94);
            AuthorPresentLabel.Margin = new Padding(3, 0, 3, 10);
            AuthorPresentLabel.Name = "AuthorPresentLabel";
            AuthorPresentLabel.Size = new Size(49, 15);
            AuthorPresentLabel.TabIndex = 3;
            AuthorPresentLabel.Text = "Author:";
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(108, 94);
            AuthorLabel.Margin = new Padding(40, 0, 3, 0);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(81, 15);
            AuthorLabel.TabIndex = 4;
            AuthorLabel.Text = "Ilya Buldakov";
            // 
            // EMailLabel
            // 
            EMailLabel.AutoSize = true;
            EMailLabel.Location = new Point(108, 119);
            EMailLabel.Name = "EMailLabel";
            EMailLabel.Size = new Size(130, 15);
            EMailLabel.TabIndex = 5;
            EMailLabel.Text = "ilya.buldakov@no.mail";
            // 
            // GitHubLinkLabel
            // 
            GitHubLinkLabel.AutoSize = true;
            GitHubLinkLabel.Location = new Point(108, 144);
            GitHubLinkLabel.Name = "GitHubLinkLabel";
            GitHubLinkLabel.Size = new Size(258, 15);
            GitHubLinkLabel.TabIndex = 6;
            GitHubLinkLabel.TabStop = true;
            GitHubLinkLabel.Text = "https://github.com/Glass-bones/ContactsApp";
            // 
            // AppVersionLabel
            // 
            AppVersionLabel.AutoSize = true;
            AppVersionLabel.Location = new Point(16, 59);
            AppVersionLabel.Name = "AppVersionLabel";
            AppVersionLabel.Size = new Size(34, 15);
            AppVersionLabel.TabIndex = 7;
            AppVersionLabel.Text = "v 1.0";
            // 
            // AppLabel
            // 
            AppLabel.AutoSize = true;
            AppLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            AppLabel.Location = new Point(11, 26);
            AppLabel.Name = "AppLabel";
            AppLabel.Size = new Size(160, 32);
            AppLabel.TabIndex = 8;
            AppLabel.Text = "ContactsApp";
            // 
            // SourceLabel
            // 
            SourceLabel.AutoSize = true;
            SourceLabel.Location = new Point(16, 334);
            SourceLabel.Name = "SourceLabel";
            SourceLabel.Size = new Size(215, 15);
            SourceLabel.TabIndex = 9;
            SourceLabel.Text = "All used images are downloaded from";
            // 
            // SourceLinkLabel
            // 
            SourceLinkLabel.AutoSize = true;
            SourceLinkLabel.Location = new Point(219, 334);
            SourceLinkLabel.Name = "SourceLinkLabel";
            SourceLinkLabel.Size = new Size(69, 15);
            SourceLinkLabel.TabIndex = 10;
            SourceLinkLabel.TabStop = true;
            SourceLinkLabel.Text = "icons8.com";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(OkAddButton);
            panel1.Location = new Point(-1, 361);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 46);
            panel1.TabIndex = 25;
            // 
            // OkAddButton
            // 
            OkAddButton.Location = new Point(439, 11);
            OkAddButton.Name = "OkAddButton";
            OkAddButton.Size = new Size(75, 23);
            OkAddButton.TabIndex = 1;
            OkAddButton.Text = "OK";
            OkAddButton.UseVisualStyleBackColor = true;
            OkAddButton.Click += OkAddButton_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(525, 407);
            Controls.Add(panel1);
            Controls.Add(SourceLinkLabel);
            Controls.Add(SourceLabel);
            Controls.Add(AppLabel);
            Controls.Add(AppVersionLabel);
            Controls.Add(GitHubLinkLabel);
            Controls.Add(EMailLabel);
            Controls.Add(AuthorLabel);
            Controls.Add(AuthorPresentLabel);
            Controls.Add(EMailPresentLabel);
            Controls.Add(GitHubPresentLabel);
            Controls.Add(CopyrightTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AboutForm";
            ShowIcon = false;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CopyrightTextBox;
        private Label GitHubPresentLabel;
        private Label EMailPresentLabel;
        private Label AuthorPresentLabel;
        private Label AuthorLabel;
        private Label EMailLabel;
        private LinkLabel GitHubLinkLabel;
        private Label AppVersionLabel;
        private Label AppLabel;
        private Label SourceLabel;
        private LinkLabel SourceLinkLabel;
        private Panel panel1;
        private Button OkAddButton;
    }
}