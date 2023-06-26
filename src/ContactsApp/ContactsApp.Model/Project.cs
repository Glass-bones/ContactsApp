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
        private List<Contact> Array;

        public Contact GetElement(int index)
        {
            if (index < 0 || index >= this.GetCount()) return null;
            return this.Array.ElementAt(index);
        }

        public int GetCount() 
        { 
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

        public void Sort(int low,int high)
        {
            if (low < 0 || high >= this.GetCount()) return;
            if (low < high)
            {
                int pivot = Partition(low, high);
                Sort(low, pivot - 1);
                Sort(pivot + 1, high);
            }
        }

        public int Partition(int low, int high)
        {
            string pivot = this.GetElement(high).GetFullName();
            int i = low - 1;
            Contact tmp;
            for (int j = low; j < high; j++)
            {
                if (string.Compare(this.GetElement(j).GetFullName(), pivot) < 0)
                {
                    i++;
                    tmp = this.GetElement(i);
                    this.SetElement(this.GetElement(j),i);
                    this.SetElement(tmp, j);
                }
            }
            tmp = this.GetElement(i + 1);
            this.SetElement(this.GetElement(high), i + 1);
            this.SetElement(tmp, high);
            return i + 1;
        }
        //FindBirthdayContact и FindSubstring начинают поиск с start чтобы было возможно найти все подходящие контакты(например в цикле)
        public int FindBirthdayContact(int start)
        {
            if (start < 0 || start >= this.GetCount()) return -1;
            for (int i=start; i<this.GetCount();i++)
            {
                if(this.GetElement(i).GetBirthDate()==DateTime.Today)
                    return i;
            }
            return -1;
        }
        
        public int FindSubstring(int start,string substring) 
        {
            if (start < 0 || start >= this.GetCount()) return -1;
            for (int i = start; i< this.GetCount(); i++)
            {
                if (this.GetElement(i).GetFullName().Contains(substring))
                    return i;
            }
            return -1;
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
