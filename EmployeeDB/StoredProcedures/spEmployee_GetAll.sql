CREATE PROCEDURE [dbo].[spEmployee_GetAll]
AS
begin
	
	Select [Id], [FirstName], [LastName], [Title]
	from Employee

end
