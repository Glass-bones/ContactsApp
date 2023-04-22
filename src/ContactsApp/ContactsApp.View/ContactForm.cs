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

namespace ContactsApp.View
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {

        }

        private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
        }

        private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
        }

        private void OkAddButton_Click(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text.Length <= 0) return;
            else if (PhoneTextBox.Text == "")
                Close();
            else if (!Regex.IsMatch(PhoneTextBox.Text, "^((8|\\+7)[\\- ]?)?(\\(?\\d{3}\\)?[\\- ]?)?[\\d\\- ]{7,10}$"))
                return;
            else Close(); 
        }

        private void CancelAddButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text.Length <= 0) return;
            else if (char.IsLower(Convert.ToChar(FullNameTextBox.Text.Substring(0, 1))))
            {
                FullNameTextBox.Text = FullNameTextBox.Text.Substring(0, 1).Replace(FullNameTextBox.Text.Substring(0, 1), FullNameTextBox.Text.Substring(0, 1).ToUpper()) + FullNameTextBox.Text.Substring(1, FullNameTextBox.Text.Length - 1);
                FullNameTextBox.SelectionStart = 1;
            }
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {

            //if(PhoneTextBox.Text.)
        }
    }
}
