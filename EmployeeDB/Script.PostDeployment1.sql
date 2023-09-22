/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
if not exists (select * from dbo.Employee)
begin
	insert into dbo.Employee (FirstName, LastName, Title)
	values
		('John', 'Doe', 'Manager'),
		('Jane', 'Doe', 'Assistant Manager'),
		('Bob', 'Smith', 'Clerk'),
		('Sue', 'Smith', 'Clerk'),
		('Mark', 'Jones', 'Clerk'),
		('Sally', 'Jones', 'Clerk')
end