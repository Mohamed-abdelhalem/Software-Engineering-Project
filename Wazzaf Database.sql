Drop table Users cascade constraints;
Drop table Jobs cascade constraints;
Drop table Responds cascade constraints;
Drop table ApplyRequest cascade constraints;
Drop table addToFavorate cascade constraints;
Drop table Feedback cascade constraints;

Create Table Users
(MemberID number (10) primary key , MemberName varchar2(20), Pass number (10) , MemberEmail varchar2(20) , birthday date , 
  MemberPhone number(12) , MemberType varchar2(20) , MemberAddress varchar2(20));
  
Create Table Jobs
(JobID number (10) primary key, jobName varchar2(20),  jobDescription varchar2(200),
  companyId number (10) references Users (MemberID) , jobStatus varchar2(10));
  
Create Table Responds
(UserID number (10) references Users (MemberID), JobID number (10) references Jobs (JobID) ,  Message varchar2(20) ,
   InterViewDate DATE);


Create Table ApplyRequest
(UserID number (10) references Users (MemberID), JobID number (10) references Jobs (JobID) , CV varchar2(50) );

Create Table addToFavorate
(UserID number (10) references Users (MemberID), JobID number (10) references Jobs (JobID));
   

Create Table Feedback
(UserID number (10) references Users (MemberID), JobID number (10) references Jobs (JobID) , MessageFeedBack varchar2(20));


insert into Users values
(1, 'Mohamed' , 123456789 , 'mohamed@yahoo.com' , '15-Jul-2001', 01123456 , 'applicant' , 'cairo' );
insert into Users  values
(2, 'Ahmed' , 1011121314 , 'ahmed@yahoo.com' , '14-Jul-2002' , 0127891011 , 'applicant' , 'cairo');
insert into Users  values
(3, 'Omar', 1516171819 , 'omar@yahoo.com' , '13-Jul-2000' , 01012131415 , 'applicant' , 'alex');
insert into Users  values
(4, 'Nosa' , 2021222324 , 'nosa@yahoo.com' , '1-Jul-1998' , 011768948 , 'applicant' , 'luxor');
insert into Users  values
(5, 'Eman' , 2526272829 , 'eman@yahoo.com' , '17-Jul-1999' , 0111235448 , 'admin_System' , 'sheraton');
insert into Users  values
(6, 'FCIS_Company' , 3031323334 , 'fcis_comp@yahoo.com' , '29-Jul-2011' , 0228701456 , 'company', 'newCapital');
insert into Users  values
(7, 'valeo' , 1239521 , 'valeo@yahoo.com' , '19-Jul-2007' , 5664532 , 'company', 'Alex');
insert into Users  values
(8, 'intercom' , 9875236 , 'intercom@yahoo.com' , '21-Jul-2001' , 12456562 , 'company', 'Giza');
insert into Users  values
(9, 'Huawei' , 1477777 , 'huawei@yahoo.com' , '05-Dec-2001' , 010546556 , 'company', 'Cairo/Alex');


insert into jobs values
(1, 'flutter Developer' , 'repons for bulid app' , 6 , 'accept'  );
insert into jobs  values
(2, 'Full Stack Developer' , 'repons for make site', 6  , 'postpend');
insert into jobs  values
(3, 'Database Admin', ' access database', 7   , 'accept' );
insert into jobs  values
(4, 'Casher' , 'takes money ' , 8  , 'accept' );
insert into jobs  values
(5, 'Accountant' , 'calculate money ' , 8  , 'accept' );
insert into jobs  values
(6, 'lawyr' , ' help people'  , 7  , 'accept');
insert into jobs  values
(7, 'Ai' , 'Artificial Intelligent'  , 9  , 'accept');
insert into jobs  values
(8, 'Networks' , 'need applicant cant treat with networks'  , 9  , 'postpend');
insert into jobs  values
(9, 'Help Desk' , ' IT'  , 9  , 'accept');
insert into jobs  values
(10, 'Android Developer' , 'repons for bulid app' , 6 , 'accept');


insert into Responds values
(1, 1 , 'accepted' ,  '20-Jul-22' );
insert into Responds  values
(2 , 2  , 'accepted' , '10-May-22');
insert into Responds  values
(3, 3   , 'accepted' , '15-Jan-23');
insert into Responds  values
(4, 4 ,'accepted' , '28-Apr-22' );
insert into Responds  values
(1, 5  , 'accepted' , '25-Jul-22');
insert into Responds  values
(2, 5 , 'accepted' , '17-Jul-22');
insert into Responds  values
(2, 4  , 'accepted' , '11-Dec-22');
insert into Responds  values
(3, 5 , 'rejected' , '');
insert into Responds  values
(3, 6  , 'accepted' , '20-Aug-22');
insert into Responds  values
(4, 7  , 'accepted' , '20-Aug-22');
insert into Responds  values
(3, 8  , 'rejected' , '');
insert into Responds  values
(4, 9  , 'accepted' , '20-Aug-22');
insert into Responds  values
(1, 10  , 'rejected' , '');

insert into ApplyRequest values
(1, 1 , 'mohamed.pdf'  );
insert into ApplyRequest  values
(2 , 2  , 'ahmed.pdf' );
insert into ApplyRequest  values
(3, 3   , 'omar.pdf' );
insert into ApplyRequest  values
(4, 4 ,'nosa.docx' );
insert into ApplyRequest  values
(3, 5  , 'eman.docx' );
insert into ApplyRequest  values
(2, 6  , 'ibrahim.pptx' );
insert into ApplyRequest  values
(5, 7  , 'ibrahim.pptx' );
insert into ApplyRequest  values
(3, 8  , 'ibrahim.pptx' );
insert into ApplyRequest  values
(2, 10  , 'ibrahim.pptx' );


insert into Feedback values
(1, 1 , 'nice interview'  );
insert into Feedback  values
(2 , 2  , 'great job' );
insert into Feedback  values
(3, 3   , ' great applicant ' );
insert into Feedback  values
(4, 4 ,'bad job' );
insert into Feedback  values
(1, 5  , ' not recommend job ' );
insert into Feedback  values
(2, 6  , 'recommend' );
insert into Feedback  values
(3, 7 , 'Loved it' );
insert into Feedback  values
(4, 8 , 'Goood' );
insert into Feedback  values
(1, 9 , 'interested' );
insert into Feedback  values
(1, 10 , 'bad job' );
insert into Feedback  values
(2, 1 , 'very nice ' );
insert into Feedback  values
(4, 10 , 'Gameeed!' );
insert into Feedback  values
(6, 5 , 'loved ' );
insert into Feedback  values
(6, 4, 'baaaaad' );


insert into addToFavorate values
(1, 3  );
insert into addToFavorate values
(1 , 2 );
insert into addToFavorate  values
(2, 1  );
insert into addToFavorate  values
( 3, 5  );
insert into addToFavorate  values
(4, 6 );
insert into addToFavorate  values
(4, 10 );


commit;