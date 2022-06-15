// See https://aka.ms/new-console-template for more information
using AddressBook_ADO.NET;

Console.WriteLine("Welcomw to AddressBook ADO.NET!");


AddressBookData addressBookData = new AddressBookData();
AddressBookModel addressbook = new AddressBookModel();
AddressBookRepo repo = new AddressBookRepo();


Console.WriteLine("Select option\n1)Create AddrssBookServiceDatabase\n2)Create AddressBookTable\n3)Inserting Details to DataBase\n4)retreiv Details From dataBase\n6)Update Contacts\n7)" +
    "Delete Contacts from DataBase\n8)Count By City/State\n9)Retreive Details By State\n10)Retreive Details By City\n11)Sort Details By FirstName for given City\n12)Added columns AddressBook Name and Type to " +
    "AddressBook Table\n13)Display AddressBook Details By AddressBookType\n14)Count Number of Contacts by AddressBoookType\n15)Add a Person to Both Friend and family\n16)Retreiving Details From AddressBook \n17)Display of" +
    " PersonDetail\n18)Display of Address_Book\n19)Display of PersonTypes\n20)Display of PersonsDetail_Type\n21)Display of Employee_Department\n22)Display Of Contacts by City using Inner Join" +
        "\n23)Display Of count of  Contacts by City\n24)Display Of Contacts alphabetically order by Firstname\n25)Display count of Contacts by type");
        
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
    case 12:
        Console.WriteLine("Adding Columns AddressBookName and AddressBookType to AddressBook Table");
        addressBookData.AddAddressBookNameAndType();
        break;
    case 13:
        addressBookData.GetContactsBYAddressBookType();
        break;
    case 14:
        int countByType = addressBookData.CountOfEmployeeDetailsByType();
        Console.WriteLine("Count of Records by Type Colleague :" + countByType);
        break;
    case 15:
        addressBookData.AddContactAsFriendAndFamily();
        Console.WriteLine("Added Contact to both Family and Friend");
        break;
    case 16:
        Console.WriteLine("Display of AddressBook");
        repo.GetAllContactOf_AddressBook();
        Console.WriteLine("*********************************************************");
        break;
    case 17:
        Console.WriteLine("Display of PersonDetail");
        repo.GetAllContactOf_PersonDetail();
        Console.WriteLine("*********************************************************");
        break;
    case 18:
        Console.WriteLine("Display of Address_Book");
        repo.GetAllContactOf_Address_Book();
        Console.WriteLine("*********************************************************");
        break;
    case 19:
        Console.WriteLine("Display of PersonTypes");
        repo.GetAllContactOf_PersonTypes();
        Console.WriteLine("*********************************************************");
        break;
    case 20:
        Console.WriteLine("Display of PersonsDetail_Type");
        repo.GetAllContactOf_PersonsDetail_Type();
        Console.WriteLine("*********************************************************");
        break;
    case 21:
        Console.WriteLine("Display of Employee_Department");
        repo.GetAllContactOf_Employee_Department();
        Console.WriteLine("*********************************************************");
        break;
    case 22:
        Console.WriteLine("Display Of Contacts by City using Inner Join");
        repo.GetContactsBasedOnCityStateByJoins();
        Console.WriteLine("*********************************************************");
        break;
    case 23:
        Console.WriteLine("Display Of count of  Contacts by City");
        repo.GetCountOfContactsByCity_PersonDetail();
        Console.WriteLine("*********************************************************");
        break;
    case 24:
        Console.WriteLine("Display Of Contacts alphabetically order by Firstname");
        repo.GetContactsInAlphabeticalOrderOfFirstNameByJoins();
        Console.WriteLine("*********************************************************");
        break;
    case 25:
        Console.WriteLine("Display count of Contacts by type");
        repo.GetCountOfContactsByTypeByJoins();
        Console.WriteLine("*********************************************************");
        break;

    default:
        Console.WriteLine("Please choose the correct option!");
        break;
}