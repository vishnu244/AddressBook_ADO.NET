using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_ADO.NET
{
    public class AddressBookRepo
    {
        AddressBook addressmodel = new();
        PersonDetail1 personDetail1 = new PersonDetail1();
        Address_Book1 address_Book1 = new Address_Book1();
        PersonTypes1 personTypes1 = new PersonTypes1();
        PersonsDetail_Type1 personsDetail_Type1 = new();
        Employee_Department1 employee_Department1 = new();
        private SqlConnection Connection;

        //Method to retreive data
        public void GetAllContactOf_AddressBook()
        {
            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-7SFIPVKT; Initial Catalog =addressbook_practice; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"Select * from AddressBook";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            addressmodel.ID = datareader.GetInt32(0);
                            addressmodel.FirstName = datareader.GetString(1);
                            addressmodel.LastName = datareader.GetString(2);
                            addressmodel.Address = datareader.GetString(3);
                            addressmodel.City = datareader.GetString(4);
                            addressmodel.State = datareader.GetString(5);
                            addressmodel.Zip = datareader.GetInt32(6);
                            addressmodel.PhoneNumber = datareader.GetString(7);
                            addressmodel.Email_ID = datareader.GetString(8);

                            Console.WriteLine(addressmodel.FirstName + " " +
                                addressmodel.LastName + " " +
                                addressmodel.Address + " " +
                                addressmodel.City + " " +
                                addressmodel.State + " " +
                                addressmodel.Zip + " " +
                                addressmodel.PhoneNumber + " " +
                                addressmodel.Email_ID + " "
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Retrieve PersonDetail1
        public void GetAllContactOf_PersonDetail()
        {
            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-7SFIPVKT; Initial Catalog =addressbook_practice; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"Select * from PersonDetail";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            personDetail1.PersonId = datareader.GetInt32(0);
                            personDetail1.AddressBookId = datareader.GetInt32(1);
                            personDetail1.FirstName = datareader.GetString(2);
                            personDetail1.LastName = datareader.GetString(3);
                            personDetail1.Address = datareader.GetString(4);
                            personDetail1.City = datareader.GetString(5);
                            personDetail1.State = datareader.GetString(6);
                            personDetail1.Zip = datareader.GetInt32(7);
                            personDetail1.PhoneNumber = datareader.GetInt64(8);
                            personDetail1.Email_ID = datareader.GetString(9);

                            Console.WriteLine(personDetail1.FirstName + " " +
                                personDetail1.LastName + " " +
                                personDetail1.Address + " " +
                                personDetail1.City + " " +
                                personDetail1.State + " " +
                                personDetail1.Zip + " " +
                                personDetail1.PhoneNumber + " " +
                                personDetail1.Email_ID + " "
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        // Display of address_Book1
        public void GetAllContactOf_Address_Book()
        {
            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-7SFIPVKT; Initial Catalog =addressbook_practice; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"Select * from Address_Book";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            address_Book1.AddressBookId = datareader.GetInt32(0);
                            address_Book1.AddressBookName = datareader.GetString(1);

                            Console.WriteLine(address_Book1.AddressBookId + " " +
                                address_Book1.AddressBookName + " "
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        // Display of PersonTypes1
        public void GetAllContactOf_PersonTypes()
        {
            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-7SFIPVKT; Initial Catalog =addressbook_practice; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"Select * from PersonTypes";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            personTypes1.PersonTypeId = datareader.GetInt32(0);
                            personTypes1.PersonType = datareader.GetString(1);

                            Console.WriteLine(personTypes1.PersonTypeId + " " +
                                personTypes1.PersonType + " "
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Display of PersonsDetail_Type1
        public void GetAllContactOf_PersonsDetail_Type()
        {
            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-7SFIPVKT; Initial Catalog =addressbook_practice; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"Select * from PersonsDetail_Type";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            personsDetail_Type1.PersonId = datareader.GetInt32(0);
                            personsDetail_Type1.PersonTypeId = datareader.GetInt32(1);

                            Console.WriteLine(personsDetail_Type1.PersonId + " " +
                                personsDetail_Type1.PersonTypeId + " "
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //Display of Employee_Department1
        public void GetAllContactOf_Employee_Department()
        {
            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-7SFIPVKT; Initial Catalog =addressbook_practice; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"Select * from Employee_Department";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            employee_Department1.PersonId = datareader.GetInt32(0);
                            employee_Department1.EmployeeID = datareader.GetInt32(1);
                            employee_Department1.DepartmentID = datareader.GetInt32(2);


                            Console.WriteLine(employee_Department1.PersonId + " " +
                                employee_Department1.EmployeeID + " " +
                                employee_Department1.DepartmentID + " "
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        //uc13
        public void GetContactsBasedOnCityStateByJoins()
        {

            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-7SFIPVKT; Initial Catalog =addressbook_practice; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"SELECT addressbook.AddressBookId,addressbook.AddressBookName,persondetail.PersonId,persondetail.FirstName,persondetail.LastName,persondetail.Address,persondetail.City,persondetail.State,persondetail.Zip,
                                    persondetail.PhoneNumber,persondetail.Email_ID,persontype.PersonType,persontype.PersonTypeId FROM
                                    Address_Book AS addressbook 
                                    INNER JOIN PersonDetail AS persondetail ON addressbook.AddressBookId = persondetail.AddressBookId AND (persondetail.City='Kanuru' OR persondetail.State='Andhra Pradesh')
                                    INNER JOIN PersonsDetail_Type as persontypedetail On persontypedetail.PersonId = persondetail.PersonId
                                    INNER JOIN PersonTypes AS persontype ON persontype.PersonTypeId = persontypedetail.PersonTypeId";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            address_Book1.AddressBookId = datareader.GetInt32(0);
                            address_Book1.AddressBookName = datareader.GetString(1);
                            personDetail1.PersonId = datareader.GetInt32(2);
                            personDetail1.FirstName = datareader.GetString(3);
                            personDetail1.LastName = datareader.GetString(4);
                            personDetail1.Address = datareader.GetString(5);
                            personDetail1.City = datareader.GetString(6);
                            personDetail1.State = datareader.GetString(7);
                            personDetail1.Zip = datareader.GetInt32(8);
                            personDetail1.PhoneNumber = datareader.GetInt64(9);
                            personDetail1.Email_ID = datareader.GetString(10);
                            personTypes1.PersonType = datareader.GetString(11);
                            personTypes1.PersonTypeId = datareader.GetInt32(12);

                            Console.WriteLine(personTypes1.PersonTypeId + " " +
                                personTypes1.PersonType + " " + personDetail1.FirstName + " " +
                                personDetail1.LastName + " " +
                                personDetail1.Address + " " +
                                personDetail1.City + " " +
                                personDetail1.State + " " +
                                personDetail1.Zip + " " +
                                personDetail1.PhoneNumber + " " +
                                personDetail1.Email_ID + " " + address_Book1.AddressBookId + " " +
                                address_Book1.AddressBookName + " "
                                );

                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void GetCountOfContactsByCity_PersonDetail()
        {
            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-7SFIPVKT; Initial Catalog =addressbook_practice; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"Select Count(*) As count,City from PersonDetail Group By City;";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            personDetail1.count = datareader.GetInt32(0);
                            personDetail1.City = datareader.GetString(1);

                            Console.WriteLine(
                                personDetail1.count + " " +
                                personDetail1.City
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void GetContactsInAlphabeticalOrderOfFirstNameByJoins()
        {

            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-7SFIPVKT; Initial Catalog =addressbook_practice; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query = @"SELECT addressbook.AddressBookId,addressbook.AddressBookName,persondetail.PersonId,persondetail.FirstName,persondetail.LastName,persondetail.Address,persondetail.City,persondetail.State,persondetail.Zip,
                                    persondetail.PhoneNumber,persondetail.Email_ID,persontype.PersonType,persontype.PersonTypeId FROM
                                    Address_Book AS addressbook 
                                    INNER JOIN PersonDetail AS persondetail ON addressbook.AddressBookId = persondetail.AddressBookId 
                                    INNER JOIN PersonsDetail_Type as persontypedetail On persontypedetail.PersonId = persondetail.PersonId
                                    INNER JOIN PersonTypes AS persontype ON persontype.PersonTypeId = persontypedetail.PersonTypeId Order By FirstName";
                    SqlCommand cmd = new SqlCommand(Query, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            address_Book1.AddressBookId = datareader.GetInt32(0);
                            address_Book1.AddressBookName = datareader.GetString(1);
                            personDetail1.PersonId = datareader.GetInt32(2);
                            personDetail1.FirstName = datareader.GetString(3);
                            personDetail1.LastName = datareader.GetString(4);
                            personDetail1.Address = datareader.GetString(5);
                            personDetail1.City = datareader.GetString(6);
                            personDetail1.State = datareader.GetString(7);
                            personDetail1.Zip = datareader.GetInt32(8);
                            personDetail1.PhoneNumber = datareader.GetInt64(9);
                            personDetail1.Email_ID = datareader.GetString(10);
                            personTypes1.PersonType = datareader.GetString(11);
                            personTypes1.PersonTypeId = datareader.GetInt32(12);

                            Console.WriteLine(personTypes1.PersonTypeId + " " + personDetail1.FirstName + " " +
                                personTypes1.PersonType + " " +
                                personDetail1.LastName + " " +
                                personDetail1.Address + " " +
                                personDetail1.City + " " +
                                personDetail1.State + " " +
                                personDetail1.Zip + " " +
                                personDetail1.PhoneNumber + " " +
                                personDetail1.Email_ID + " " + address_Book1.AddressBookId + " " +
                                address_Book1.AddressBookName + " "
                                );

                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void GetCountOfContactsByTypeByJoins()
        {
            try
            {
                Connection = new SqlConnection(@"Data Source=LAPTOP-7SFIPVKT; Initial Catalog =addressbook_practice; Integrated Security = True;");
                using (this.Connection)
                {
                    string Query2 = @"Select Count(a.PersonTypeId) As PersonCount,b.PersonType From 
                                        PersonsDetail_Type As a 
                                        INNER JOIN PersonTypes AS b ON b.PersonTypeId = a.PersonTypeId
                                        INNER JOIN PersonDetail AS c ON c.PersonId = a.PersonId Group By a.PersonTypeId,b.PersonType;";
                    SqlCommand cmd = new SqlCommand(Query2, this.Connection);
                    this.Connection.Open();
                    SqlDataReader datareader = cmd.ExecuteReader();
                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            personTypes1.PersonCount = datareader.GetInt32(0);
                            personTypes1.PersonType = datareader.GetString(1);

                            Console.WriteLine(personTypes1.PersonCount + " " + personTypes1.PersonType
                                );
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
