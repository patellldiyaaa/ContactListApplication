using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ContactListApplication
{
    public class ContactGroup : ObservableCollection<Contact>
    {

        public string GroupName { get; set; }

        public ContactGroup(string groupName, IEnumerable<Contact> contacts) : base(contacts)
        {
            GroupName = groupName;
        }
    }
}
