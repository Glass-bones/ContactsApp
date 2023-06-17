using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    internal class Project
    {
        private List<Contact> Array=new List<Contact>;

        public Contact GetElement(int index)
        {
            if (index < 0 || index >= this.GetCount()) return;
            return this.Array.ElementAt(index);
        }

        public int GetCount() 
        { 
            return this.Array.Count; 
        }

        public void SetElement(Contact contact,int index)
        {
            if (index < 0 || index >= this.GetCount()) return;
            this.Array[index]=contact;
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
            string pivot = this->GetElement(high).GetFullName();
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (string.Compare(this->GetElement(j).GetFullName(), pivot) < 0)
                {
                    i++;
                    Contact tmp = this->GetElement(i);
                    this->SetElement((this->GetElement(j),i);
                    this->SetElement(tmp, j);
                }
            }
            Contact tmp = this->GetElement(i);
            this->SetElement((this->GetElement(j), i);
            this->SetElement(tmp, j);
            return i + 1;
        }
        //FindBirthdayContact и FindSubstring начинают поиск с start чтобы было возможно найти все подходящие контакты(например в цикле)
        public int FindBirthdayContact(int start)
        {
            if (start < 0 || start >= this.GetCount()) return -1;
            for (int i=start,i<this.GetCount();i++)
            {
                if(this.GetElement(i).GetBirthDate()==DateTime.Today)
                    return i;
            }
            return -1;
        }
        
        public int FindSubstring(int start,string substring) 
        {
            if (start < 0 || start >= this.GetCount()) return -1;
            for (int i = start, i< this.GetCount(); i++)
            {
                if (this.GetElement(i).GetFullName().Contains(substring))
                    return i;
            }
            return -1;
        }
    }
}
