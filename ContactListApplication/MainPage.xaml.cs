using System.Collections.ObjectModel;

namespace ContactListApplication;

public partial class MainPage : ContentPage
{

	public ObservableCollection<ContactGroup> ContactGroups { get; set; }
	public MainPage()
	{
		InitializeComponent();

        ContactGroups = new ObservableCollection<ContactGroup>
        {
            new ContactGroup("A", new List<Contact>
            {
                new Contact
                {
                    Name = "Arya Stark",
                    Email = "arya.stark@winterfell.com",
                    PhoneNumber = "555-101-1001",
                    Description = "Arya is independent, brave, and skilled with the sword.",
                    Photo = "pic1.png"
                },
                new Contact
                {
                    Name = "Aemon Targaryen",
                    Email = "aemon.targaryen@castleblack.com",
                    PhoneNumber = "555-101-1002",
                    Description = "Aemon is wise, calm, and respected. He also gives thoughtful advice.",
                    Photo = "pic2.png"
                },
                new Contact
                {
                    Name = "Allister Throne",
                    Email = "allister.throne@thenightwatch.com",
                    PhoneNumber = "555-101-1003",
                    Description = "Allister is strict and serious. He expects discipline and loyalty from everyone.",
                    Photo = "pic3.png"
                }
            }),

            new ContactGroup("B", new List<Contact>
            {
                new Contact
                {
                    Name = "Bran Stark",
                    Email = "bran.stark@winterfell.com",
                    PhoneNumber = "555-202-2001",
                    Description = "Bran is quiet, observant, and thoughful. He has a connection to the three eyed raven.",
                    Photo = "pic4.png"
                },
                new Contact
                {
                    Name = "Bronn Blackwater",
                    Email = "bron.blackwater@kingslanding.com",
                    PhoneNumber = "555-202-2002",
                    Description = "Bronn is clever, funny, and skilled in combat. .",
                    Photo = "pic1.png"
                },
                new Contact
                {
                    Name = "Brienne Of Tarth",
                    Email = "brienne.tarth@tarth.com",
                    PhoneNumber = "555-202-2003",
                    Description = "Brienne is loyal, honorable, and strong. She keeps her promises.",
                    Photo = "pic2.png"
                }
            }),

            new ContactGroup("C", new List<Contact>
            {
                new Contact
                {
                    Name = "Cersei Lannister",
                    Email = "cersei.lannister@kingslanding.com",
                    PhoneNumber = "555-303-3001",
                    Description = "Cersei is powerful, ambitious, and protective of her family. She is known for her sharp mind.",
                    Photo = "pic3.png"
                },
                new Contact
                {
                    Name = "Catelyn Stark",
                    Email = "catelyn.stark@winterfell.com",
                    PhoneNumber = "555-303-3002",
                    Description = "Catelyn is caring, protective, and devoted to her family. She values loyalty.",
                    Photo = "pic4.png"
                },
                new Contact
                {
                    Name = "Craster",
                    Email = "craster@beyondthewall.com",
                    PhoneNumber = "555-303-3003",
                    Description = "Craster lives beyond the wall and is harsh, isolated, and difficult to trust.",
                    Photo = "pic1.png"
                }
            }),

            new ContactGroup("D", new List<Contact>
            {
                new Contact
                {
                    Name = "Daenerys Targaryen",
                    Email = "daenerys.targaryen@dragonstone.com",
                    PhoneNumber = "555-404-4001",
                    Description = "daenerys is determind, confident, and the mother of 3 dragons.",
                    Photo = "pic2.png"
                },
                new Contact
                {
                    Name = "Davos Seawoth",
                    Email = "davos.seaworth@dragonstone.com",
                    PhoneNumber = "555-404-4002",
                    Description = "Davos is honest, loyal, and pratical. He provides straightforward advice.",
                    Photo = "pic3.png"
                },
                new Contact
                {
                    Name = "Drogo",
                    Email = "drogo@dothraki.com",
                    PhoneNumber = "555-404-4003",
                    Description = "Drogo is a powerful dothraki leader known for strength, confidence, and bravery.",
                    Photo = "pic4.png"
                }
            }),

            new ContactGroup("E", new List<Contact>
            {
                new Contact
                {
                    Name = "Eddard Stark",
                    Email = "eddard.stark@winterfell.com",
                    PhoneNumber = "555-505-5001",
                    Description = "Eddard AKA Nedd Stark is honorbale, loyal, and serious about duty and family.",
                    Photo = "pic1.png"
                },
                new Contact
                {
                    Name = "Euron Greyjoy",
                    Email = "euron.greyjoy@ironislands.com",
                    PhoneNumber = "555-505-5002",
                    Description = "Euron is bold, unpredictable, and dangerous.",
                    Photo = "pic2.png"
                },
                new Contact
                {
                    Name = "Ellaria Sand",
                    Email = "ellaria.sand@ironislands.com",
                    PhoneNumber = "555-505-5003",
                    Description = "Ellaria is passionate, bold, and connected to Dorne.",
                    Photo = "pic3.png"
                }
            })
        };

        ContactsCollectionView.ItemsSource = ContactGroups;
    }

    private async void ContactsCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Contact selectedContact = e.CurrentSelection.FirstOrDefault() as Contact;

        if (selectedContact == null)
            return;

        await Navigation.PushAsync(new ContactDetailsPage(selectedContact));

        ContactsCollectionView.SelectedItem = null;
    }

}
