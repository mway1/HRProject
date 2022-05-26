CREATE PROCEDURE dbo.[EmployeeRequest_GetAllInfo]
AS
BEGIN
SELECT Pr.[Name], Po.[Name], LOP.[Name], S.[name], ES.[LevelOfSkill], E.[Quantity] 
FROM EmployeeRequest as E
LEFT JOIN Project as Pr ON (E.ProjectId = Pr.id)
LEFT JOIN EmployeeRequest_Skill as ES on (E.id = ES.EmployeeRequestId)
LEFT JOIN Skill as S on (ES.SkillId = S.id)
LEFT JOIN EmployeeRequest_Position as EP on (E.id = EP.EmployeeRequestId)
LEFT JOIN Position as Po on (Po.id = EP.PositionId)
LEFT JOIN Position_LevelOfPosition as PL on (Po.id = PL.PositionId)
LEFT JOIN LevelOfPOsition as LOP on (LOP.id = PL.LevelOfPositionId)
WHERE E.isDeleted = 0
END