using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void CopyrightTextBox_TextChanged(object sender, EventArgs e)
        {
            CopyrightTextBox.Text = "Copyright (c) 2023 Ilya Buldakov\r\n\r\nPermission is hereby granted, free of charge, to any person obtaining a copy of this\r\nsoftware and associated documentation files (the \"Software\"), to deal in the\r\nSoftware without restriction, including without limitation the rights to use, copy,\r\nmodify, merge, publish, distribute, sublicense, and/or sell copies of the Software,\r\nand to permit persons to whom the Software is furnished to do so, subject to the\r\nfollowing conditions:\r\n\r\nThe above copyright notice and this permission notice shall be included in all copies\r\nor substantial portions of the Software.\r\n\r\nTHE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND,\r\nEXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF\r\nMERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND\r\nNONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS\r\nBE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN\r\nACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN\r\nCONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE\r\nSOFTWARE.\r\n";
        }

        private void OkAddButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
