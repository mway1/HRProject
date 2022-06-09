CREATE PROCEDURE [dbo].[EmployeeHistory_GetAll]
	@employeeId int
AS
BEGIN 
	SELECT  EH.[id], EMP.[FirstName], EH.[Date], St.[Name] as StatusName, EH.[isDeleted]
	FROM dbo.EmployeeHistory as EH
	LEFT JOIN [Status] as St ON (EH.StatusId = St.id)
	LEFT JOIN Employee as EMP ON (EH.EmployeeId=EMP.id)
	where EMP.[id] = @employeeId
	END
	