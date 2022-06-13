// See https://aka.ms/new-console-template for more information
using AddressBook_ADO.NET;

Console.WriteLine("Welcomw to AddressBook ADO.NET!");


AddressBookData addressBookData = new AddressBookData();
AddressBookModel addressbook = new AddressBookModel();


Console.WriteLine("Select option\n1)Create AddrssBookServiceDatabase\n2)Create AddressBookTable\n3)Inserting Details to DataBase\n4)retreiv Details From dataBase\n6)Update Contacts\n7)" +
    "Delete Contacts from DataBase\n8)Count By City/State\n9)Retreive Details By State\n10)Retreive Details By City\n11)Sort Details By FirstName for given City");
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
    case 5:
        AddressBookModel addressbook1 = new AddressBookModel();
        addressbook1.FirstName = "Vishnu";
        addressbook1.LastName = "Nali";
        addressbook1.Address = "Kanuru";
        addressbook1.City = "vijayawada";
        addressbook1.State = "Andhra Pradesh";
        addressbook1.Zip = "520007";
        addressbook1.PhoneNumber = "1234567890";
        addressbook1.Email = "Vishnu@gmail.com";

        addressBookData.UpdateContact(addressbook1);
        break;
    case 6:       
        string UpdatedAddress = addressBookData.updateEmployeeDetails();
        Console.WriteLine(UpdatedAddress);
        Console.WriteLine("Record Updated successfully");
        break;
    case 7:
        addressbook.FirstName = "Raju";
        addressBookData.DeleteContact(addressbook);
        Console.WriteLine("Record deleated successfully");
        break;
    case 8:
        int countCity = addressBookData.CountOfEmployeeDetailsByCity();
        Console.WriteLine("Count of Records for given City :" + countCity);
        int CountState = addressBookData.CountOfEmployeeDetailsByState();
        Console.WriteLine("Count of Records for given State :" + CountState);
        break;
    case 9:
        //Get Data by State
        Console.WriteLine("Get Contacts by State name");
        addressBookData.GetAllContactByState();
        break;
    case 10:
        Console.WriteLine("Get Contacts by City name");
        addressBookData.GetAllContactByCity();
        break;
    case 11:
        Console.WriteLine("Get Contacts for given City sorted by FirstName");
        addressBookData.GetAllContacsSortByName();
        break;
    default:
        Console.WriteLine("Please choose the correct option!");
        break;
}