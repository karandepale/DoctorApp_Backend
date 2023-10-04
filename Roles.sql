-- DATABASE CREATED FOR DOCTORLIST PROJECT:-
Create Database DoctorList;
use DoctorList;


-- ROLES TABLE CREATED FOR [DOCTOR,ADMIN ,PATIENTS]
create table Roles(
 RoleID int primary Key identity(1,1),
 RoleName varchar(200),
 CreateAt Date,
 UpdateAt Date
);
Select * from Roles;

insert into Roles values(
  'Admin',
  '2023-10-04',
  '2023-10-20'
);





