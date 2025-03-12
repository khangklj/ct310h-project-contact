Create Database CONTACT;
Use CONTACT;

Drop Table Contact;

Create Login mylogin with password='mylogin', CHECK_POLICY = OFF;
Execute sp_changedbowner mylogin;

Create Table Account (
	Account_ID int primary key,
	Account_UserName nvarchar(100) unique not null,
	Account_Password nvarchar(100) not null,
	Account_Name nvarchar(100) not null,
	Account_Avatar varbinary(max), 
);

Create Table ContactGroup (
	ContactGroup_ID int primary key,
	ContactGroup_Name nvarchar(100) not null,
	ContactGroup_Description nvarchar(200),
	Account_ID int references Account(Account_ID),
);

Create Table Contact (
	Contact_ID int primary key,
	Contact_Name nvarchar(100) not null,
	Contact_Email nvarchar(100) not null,
	Contact_PhoneNumber char(10),
	Contact_Favorite bit not null,
	Contact_Description nvarchar(200),
	Account_ID int references Account(Account_ID),
	ContactGroup_ID int references ContactGroup(ContactGroup_ID),
);


Alter Table Contact
Add Constraint chk_contact_email
Check (Contact_Email Like '%_@_%._%');

Alter Table Contact
Add Constraint chk_contact_phonenumber
Check (Contact_PhoneNumber Like '%[0-9]%');

-- Insert Accounts
INSERT INTO Account (Account_ID, Account_UserName, Account_Password, Account_Name) VALUES
(1, 'user1', 'password1', 'John Doe'),
(2, 'user2', 'password2', 'Jane Smith'),
(3, 'user3', 'password3', 'Alice Johnson');

-- Insert Contact Groups
INSERT INTO ContactGroup (ContactGroup_ID, ContactGroup_Name, ContactGroup_Description, Account_ID) VALUES
(1, 'Family', 'Contacts related to family members', 1),
(2, 'Friends', 'Contacts related to friends', 2);

-- Insert Contacts
-- Insert Contacts with Email

ALTER TABLE Contact DROP CONSTRAINT chk_contact_phonenumber;

ALTER TABLE Contact ADD CONSTRAINT chk_contact_phonenumber
CHECK (Contact_PhoneNumber IS NULL OR Contact_PhoneNumber = '' OR Contact_PhoneNumber LIKE '%[0-9]%');

INSERT INTO Contact (Contact_ID, Contact_Name, Contact_Email, Contact_PhoneNumber, Contact_Favorite, Contact_Description, Account_ID, ContactGroup_ID) VALUES
(1, 'Mike Doe', 'mike.doe@example.com', '1234567890', 1, 'Brother', 1, 1),
(2, 'Sara Doe', 'sara.doe@example.com', '1234567891', 0, 'Sister', 1, 1),
(3, 'Kevin Smith', 'kevin.smith@example.com', '1234567892', 1, 'Best friend', 2, 2),
(4, 'Emma Brown', 'emma.brown@example.com', '1234567893', 0, 'Colleague', 2, NULL),
(5, 'Olivia Johnson', 'olivia.johnson@example.com', '1234567894', 1, 'Cousin', 1, 1),
(6, 'Liam Davis', 'liam.davis@example.com', '1234567895', 0, 'Gym buddy', 2, 2),
(7, 'Noah Wilson', 'noah.wilson@example.com', '1234567896', 1, 'Childhood friend', 3, 2),
(8, 'Sophia Martinez', 'sophia.martinez@example.com', '1234567897', 0, 'Neighbor', 3, NULL),
(9, 'Mia Garcia', 'mia.garcia@example.com', '1234567898', 1, 'Close friend', 1, 2),
(10, 'James Taylor', 'james.taylor@example.com', '1234567899', 0, 'Family friend', 3, 1);


