using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    public class Contact:ICloneable
    {
        [JsonProperty("FullName")]
        private string FullName { get; set; }
        [JsonProperty("Email")]
        private string Email { get; set; }
        [JsonProperty("PhoneNumber")]
        private string PhoneNumber { get; set; }
        [JsonProperty("VK")]
        private string VK { get; set; }
        [JsonProperty("BirthDate")]
        private DateTime BirthDate { get; set; }
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
            if (!Regex.IsMatch(phoneNumber, @"^[0-9()+\- ]+$"))
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
        public Contact()
        {
            this.SetFullName("");
            this.SetEmail("");
            this.SetPhoneNumber("+");
            this.SetVK("");
            this.SetBirthDate(DateTime.Today);
        }
        public object Clone()
        {
            return new Contact(this.GetFullName(),this.GetEmail(), this.GetPhoneNumber(), this.GetVK(), this.GetBirthDate());
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
