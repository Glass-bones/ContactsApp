using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Model;

namespace ContactsApp.View
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }
        private Contact _contact;
        private string _phoneNumberError;

        private void UpdateForm()
        {
            FullNameTextBox.Text = _contact.GetFullName();
            EmailTextBox.Text = _contact.GetEmail();
            PhoneTextBox.Text = _contact.GetPhoneNumber();
            BirthDateTimePicker.Value = _contact.GetBirthDate();
            VKTextBox.Text = _contact.GetVK();
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            if(_contact==null)
                _contact = new Contact("john Doe", "@no.mail", "+7 (000) 000-00-00", "", DateTime.Today);
            BirthDateTimePicker.MaxDate = DateTime.Today;
            _phoneNumberError = "";
            UpdateForm();
        }

        private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
        }

        private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
        }

        private void CancelAddButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text.Length <= 0) return;
            else
            {
                if (char.IsLower(Convert.ToChar(FullNameTextBox.Text.Substring(0, 1))))
                {
                    FullNameTextBox.Text = FullNameTextBox.Text.Substring(0, 1).Replace(FullNameTextBox.Text.Substring(0, 1), FullNameTextBox.Text.Substring(0, 1).ToUpper()) + FullNameTextBox.Text.Substring(1, FullNameTextBox.Text.Length - 1);
                    FullNameTextBox.SelectionStart = 1;
                }
                _contact.SetFullName(FullNameTextBox.Text);
            }
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.SetPhoneNumber(PhoneTextBox.Text);
                PhoneTextBox.BackColor = Color.White;
                _phoneNumberError = "";
            }
            catch
            {
                PhoneTextBox.BackColor = Color.LightPink;
                _phoneNumberError = "Invalid phone number.";
            }
        }

        private void BirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            _contact.SetBirthDate(BirthDateTimePicker.Value);
        }

        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            _contact.SetVK(VKTextBox.Text);
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            _contact.SetEmail(EmailTextBox.Text);
        }
        private bool CheckFormOnErrors()
        {
            if (_phoneNumberError.Length > 0)
            {
                MessageBox.Show(_phoneNumberError, "Error!", MessageBoxButtons.OK);
                return false;
            }
            else return true;
        }

        public Contact GetContact() 
        { 
            return _contact;
        }

        public void SetContact(Contact contact)
        {
            _contact = new Contact(contact.GetFullName(), contact.GetEmail(), contact.GetPhoneNumber(), contact.GetVK(), contact.GetBirthDate());
        }

        //тк эта форма - диалог, проверка на ошибки происходит только перед выходом,
        //а не при нажатии кнопки ok
        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK && !CheckFormOnErrors())
                e.Cancel = true;
        }
    }
}
