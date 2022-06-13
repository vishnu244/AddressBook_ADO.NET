use AddressbookForADO

select * from AddressBook

insert into AddressBook values ('shravanthi','Pabboji','Alwal','Hyderabad','Telangana','520008','9876543210','Shravanthi@gmail.com')
insert into AddressBook values ('Sai','Teja','Poranki','Guntur','Karnataka','520008','4567898768','Sai@gmail.com')

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