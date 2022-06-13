use AddressbookForADO

select * from AddressBook

insert into AddressBook values ('shravanthi','Pabboji','Alwal','Hyderabad','Telangana','520008','9876543210','Shravanthi@gmail.com')
insert into AddressBook values ('Sai','Teja','Poranki','Guntur','Karnataka','520008','4567898768','Sai@gmail.com')
update AddressBook set FirstName = 'krishna' where id = 2
update AddressBook set FirstName = 'Raju', LastName = 'ABC' where id = 3

--------------------uc_9_Adding AdressBook Name and Type-----------------------------
update AddressBook set AddressBookName ='Self',AddressBookType='Self' where ID=1;
update AddressBook set AddressBookName ='Relative',AddressBookType='Cousin' where ID=2; 
update AddressBook set AddressBookName ='Profession',AddressBookType='Colleague' where ID=4; 
update AddressBook set AddressBookName ='School',AddressBookType='Friend' where ID=5; 

DELETE FROM AddressBook WHERE id=7;
DELETE FROM AddressBook WHERE id=8;

select * from AddressBook
------------------------------------------------------------------------------------------



go
create procedure SpAddressBook(@FirstName varchar(50),
							   @LastName varchar(50),
 @Address varchar(50),
 @City varchar(50),
 @State varchar(50),
 @Zip varchar(50),
 @PhoneNumber varchar(50),
 @Email varchar(50)
 )
 as
 begin
 Insert into AddressBook(FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email)
 values(
@FirstName,
 @LastName,
 @Address,
 @City,
 @State,
 @Zip,
 @PhoneNumber,
 @Email
)
SET NOCOUNT ON;
select * from AddressBook
 End


 /*Update store procedure*/
go
create procedure SpAddressBookEditUpdate
(
	@FirstName varchar(50),
	@LastName varchar(50),
	@Address varchar(50),
	@City varchar(50),
	@State varchar(50),
	@Zip varchar(50),
	@PhoneNumber varchar(50),
	@Email varchar(50)
)
as
begin
update  AddressBook set FirstName=@FirstName,LastName=@LastName,Address=@Address,City=@City,State=@State,Zip=@Zip,
PhoneNumber=@PhoneNumber,Email=@Email where FirstName=@FirstName;
SET NOCOUNT ON;
SELECT FirstName,LastName,Address,City,State,Zip,PhoneNumber,Email from AddressBook
END
GO

--Delete record

create procedure SpAddressBook_Delete
(
	@FirstName varchar(50)
)
as
begin
delete from AddressBook where FirstName=@FirstName;
End