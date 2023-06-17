using ContactsApp.Model;
namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private Project _project;

        private void AddButton_Click(object sender, EventArgs e)
        {
            var form = new ContactForm();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                AddRandomContact();
                UpdateListBox();
            }

        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.Image = Properties.Resources.add_contact_32x32;
            AddButton.BackColor = Color.FromArgb(245, 245, 255);
        }

        private void RemoveButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveButton.Image = Properties.Resources.remove_contact_32x32;
            RemoveButton.BackColor = Color.FromArgb(250, 245, 245);
        }

        private void RemoveButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveButton.BackColor = Color.White;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddButton.BackColor = Color.White;
        }

        private void EditButton_MouseEnter(object sender, EventArgs e)
        {
            EditButton.Image = Properties.Resources.add_contact_32x32;
            EditButton.BackColor = Color.FromArgb(245, 245, 255);
        }

        private void EditButton_MouseLeave(object sender, EventArgs e)
        {
            EditButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditButton.BackColor = Color.White;
        }

        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void DateOfBirthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void VKTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void RightPanel_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            var form = new AboutForm();
            form.ShowDialog();
        }

        private void CloseBDNoteButton_Click(object sender, EventArgs e)
        {
            NotePanel.Visible = false;
        }
        private void MainForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            if (!Application.OpenForms.OfType<AboutForm>().Any())
            {
                var form = new AboutForm();
                form.ShowDialog();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _project = new Project();
            for (int i = 0; i < 5; i++)
                AddRandomContact();
            UpdateListBox();
        }
        private void UpdateListBox()
        {
            _project.Sort(0, _project.GetCount() - 1);
            ContactsListBox.Items.Clear();
            for (int i = 0; i < _project.GetCount(); i++)
            {
                ContactsListBox.Items.Add(_project.GetElement(i).GetFullName());
            }
        }
        private void AddRandomContact()
        {
            Random random = new Random();
            string upChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string cons = "bbcccdddfffgghhhjklllmmmnnnnppqrrrrssssttttvvwwxz";
            string vows = "aaeeioouy";
            int consCount = 1;
            int vowCount = 1;
            string chars = "abcdefghijklmnopqrstyvwxyz";
            string fullName = "";
            for (int i = 0; i < 2; i++)
            {
                fullName += upChars.ElementAt(random.Next(upChars.Length));
                int nameLenght = random.Next(4, 11);
                for (int j = 0; j < nameLenght; j++)
                    if (consCount > 1 || random.Next(4 - consCount) == 0 && vowCount < 2)
                    {
                        fullName += vows.ElementAt(random.Next(vows.Length));
                        consCount = 0;
                        vowCount++;
                    }
                    else
                    {
                        fullName += cons.ElementAt(random.Next(cons.Length));
                        consCount++;
                        vowCount = 0;
                    }
                fullName += " ";
                consCount = 1;
                vowCount = 1;
            }
            string email = "";
            int emailLenght = random.Next(4, 11);
            for (int i = 0; i < emailLenght; i++)
                email += chars.ElementAt(random.Next(chars.Length));
            email += "@no.mail";
            string nums = "1234567890";
            string phoneNumber;
            if (random.Next(2) == 0) phoneNumber = "+7";
            else phoneNumber = "8";
            int phoneNumberLength = random.Next(9, 12);
            for (int i = 0; i < phoneNumberLength; i++)
                phoneNumber += nums.ElementAt(random.Next(nums.Length));
            string allSymb = upChars + chars + nums;
            string vk = "";
            int vkLenght = random.Next(8, 21);
            for (int i = 0; i < vkLenght; i++)
                vk += allSymb.ElementAt(random.Next(allSymb.Length));
            int year = random.Next(1900, DateTime.Today.Year);
            int month = random.Next(1, 13);
            DateTime birthDate = new DateTime(year, month, random.Next(1, DateTime.DaysInMonth(year, month) + 1));
            Contact tmp = new Contact(fullName, email, phoneNumber, vk, birthDate);
            _project.AddElement(tmp);
        }
        private void RemoveContact()
        {
            _project.RemoveElement();
        }
        private void RemoveContact(int index)
        {
            _project.RemoveElement(index);
        }
        private void UpdateSelectedContact(int index)
        {
            FullNameTextBox.Text = _project.GetElement(index).GetFullName();
            EmailTextBox.Text = _project.GetElement(index).GetEmail();
            PhoneTextBox.Text = _project.GetElement(index).GetPhoneNumber();
            DateOfBirthTextBox.Text = _project.GetElement(index).GetBirthDate().Day + "." + _project.GetElement(index).GetBirthDate().Month + "." + _project.GetElement(index).GetBirthDate().Year;
            VKTextBox.Text = _project.GetElement(index).GetVK();
        }
        private void ClearSelectedContact()
        {
            FullNameTextBox.Text = "";
            EmailTextBox.Text = "";
            PhoneTextBox.Text = "";
            DateOfBirthTextBox.Text = "";
            VKTextBox.Text = "";
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (ContactsListBox.SelectedItems.Count == 0)
            {
                result = MessageBox.Show("Do you really want to remove last element?", "Delete", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK) RemoveContact();
                if (ContactsListBox.SelectedItems.Count == 0) ClearSelectedContact();
            }
            else
            {
                string line = "Do you really want to remove";
                for (int i = 0; i < ContactsListBox.SelectedIndices.Count; i++)
                    line += " " + (ContactsListBox.SelectedIndices[i] + 1).ToString();
                line += " element(s)?";
                result = MessageBox.Show(line, "Delete", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    if (ContactsListBox.SelectedItems.Contains(FullNameTextBox.Text))
                        ClearSelectedContact();
                    for (int i = ContactsListBox.SelectedIndices.Count - 1; i > -1; i--)
                        RemoveContact(ContactsListBox.SelectedIndices[i]);
                }
            }
            UpdateListBox();
        }

        private void ContactsListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (ContactsListBox.IndexFromPoint(e.Location) > ContactsListBox.Items.Count - 1 || ContactsListBox.IndexFromPoint(e.Location) < 0) return;
            UpdateSelectedContact(ContactsListBox.IndexFromPoint(e.Location));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}