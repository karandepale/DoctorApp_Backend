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
insert into Roles values(
  'Admin',
  '2021-01-10',
  '2021-04-20'
),
(
     'Doctor',
  '2022-03-25',
  '2022-05-20'
),
(
     'patients',
  '2023-10-04',
  '2023-10-20'
);
Select * from Roles;



