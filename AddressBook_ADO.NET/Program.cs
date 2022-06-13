// See https://aka.ms/new-console-template for more information
using AddressBook_ADO.NET;

Console.WriteLine("Welcomw to AddressBook ADO.NET!");


AddressBookData addressBookData = new AddressBookData();


Console.WriteLine("Select option\n1)Create AddrssBookServiceDatabase\n2)Create AddressBookTable\n3)Inserting Details to DataBase\n4)retreiv Details From dataBase");
int op = Convert.ToInt16(Console.ReadLine());
switch (op)
{
    case 1:
        addressBookData.Create_Database();
        break;
    case 2:
        addressBookData.CreateTables();
        break;
    case 3:
        AddressBookModel addressbook = new AddressBookModel();
        addressbook.FirstName = "Vishnu";
        addressbook.LastName = "Vardhan";
        addressbook.Address = "Kanuru";
        addressbook.City = "vijayawada";
        addressbook.State = "Andhra Pradesh";
        addressbook.Zip = "520007";
        addressbook.PhoneNumber = "1234567890";
        addressbook.Email = "Vishnu@gmail.com";
        addressBookData.AddContact(addressbook);
        Console.WriteLine("Record Inserted successfully");
        break;
    case 4:
        addressBookData.GetAllContact();
        break;
    default:
        Console.WriteLine("Please choose the correct option!");
        break;
}