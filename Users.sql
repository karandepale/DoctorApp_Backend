create table Users    (
	  RoleID int,
	  FOREIGN KEY (RoleID) REFERENCES Roles(RoleID),
 
	  UserID int primary key identity(1,1),
	  FullName varchar(400),
	  Email varchar(400),
	  Password varchar(500),
	  Contact varchar(200),
	  Create_At Date,
	  Update_At Date
	);
	
create OR alter Procedure SP_Users_Registration
(
@RoleID int,
@FullName varchar(400),
@Email varchar(400),
@Password varchar(500),
@Contact varchar(200),
@Create_At datetime,
@Update_At datetime
)
as
begin 
begin try
insert into Users(RoleID ,FullName, Email, Password, Contact, Create_At, Update_At)
values(@RoleID,@FullName, @Email, @Password, @Contact, @Create_At, @Update_At)
end try
begin catch
select 
ERROR_MESSAGE() as 'User Registration Failed...'
end catch
end

exec SP_Users_Registration 'Karan Depale' , 
                           'karan@gmail.com',
						   'Karan@9131',
						   '8132425252',
						   '2023-10-29',
						   '2023-10-29'


Select * From Users;
	drop table Users;
	truncate table Users
 