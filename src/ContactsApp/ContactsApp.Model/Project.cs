using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    public class Project
    {
        [JsonProperty("id")]
        private List<Contact> Array { get; set; }

        public Contact GetElement(int index)
        {
            if (index < 0 || index >= this.GetCount()) return null;
            return this.Array.ElementAt(index);
        }

        public int GetCount() 
        { 
            if(this.Array==null) return 0;
            return this.Array.Count;
        }

        public void SetElement(Contact contact,int index)
        {
            if (index < 0 || index >= this.GetCount()) return;
            this.Array[index]=new Contact(contact.GetFullName(), contact.GetEmail(), contact.GetPhoneNumber(), contact.GetVK(), contact.GetBirthDate()); ;
        }

        public void AddElement(Contact contact) 
        { 
            if (contact == null) return;
            if (this.Array==null) this.Array = new List<Contact>();
            this.Array.Add(contact); 
        }

        public void Sort()
        {
            this.Array=this.Array.OrderBy(contact=>contact.GetFullName()).ToList();
        }

        public List<Contact> FindBirthdayContacts()
        {
            return this.Array.Where(contact=>contact.GetBirthDate()==DateTime.Today).ToList();
        }

        public List<Contact> FindSubstring(string substring)
        {
            return this.Array.Where(contact => contact.GetFullName().Contains(substring)).ToList();
        }

        public void RemoveElement(int index)
        {
            if (this.Array != null && this.Array.Count > 0)
                this.Array.RemoveAt(index);
        }
        public void RemoveElement()
        {
            if (this.Array != null && this.Array.Count > 0)
                this.Array.RemoveAt(this.GetCount() - 1);
        }
    }
}
