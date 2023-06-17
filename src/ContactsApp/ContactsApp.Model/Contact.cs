using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    public class Contact
    {
        private string FullName;
        private string Email;
        private string PhoneNumber;
        private string VK;
        private DateTime BirthDate;
        public void SetFullName(string fullName)
        {
            if (fullName.Length > 100) throw new ArgumentException();
            else this.FullName = fullName;
        }
        public void SetEmail(string email) 
        {
            if (email.Length > 100) throw new ArgumentException();
            else this.Email = email;
        }
        public void SetPhoneNumber(string phoneNumber) 
        {
            if (!Regex.IsMatch(phoneNumber, "^((8|\\+7)[\\- ]?)?(\\(?\\d{3}\\)?[\\- ]?)?[\\d\\- ]{7,10}$"))
                throw new ArgumentException();
            else this.PhoneNumber = phoneNumber;
        }
        public void SetVK(string vk)
        {
            if (vk.Length > 50) throw new ArgumentException();
            else this.VK = vk;
        }
        public void SetBirthDate(DateTime birthDate)
        {
            DateTime Min = new DateTime(1900,1,1);
            if (birthDate > DateTime.Today || birthDate < Min) throw new ArgumentException();
            else this.BirthDate = birthDate;
        }
        public Contact(string fullName, string email, string phoneNumber, string vk,DateTime birthDate)
        {
            this.SetFullName(fullName);
            this.SetEmail(email);
            this.SetPhoneNumber(phoneNumber);
            this.SetVK(vk);
            this.SetBirthDate(birthDate);
        }
        public string GetFullName()
        { 
            return this.FullName; 
        }
        public string  GetEmail()
        {
            return this.Email;
        }
        public string GetPhoneNumber()
        {
            return this.PhoneNumber;
        }
        public string GetVK()
        {
            return this.VK;
        }
        public DateTime GetBirthDate() 
        {
            return this.BirthDate;
        }
    }
}
