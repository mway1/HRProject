CREATE PROCEDURE dbo.[EmployeeRequest_GetAllInfo]
AS
BEGIN
SELECT Pr.[Name], Po.[Name], LOP.[Name], S.[name], LOS.[Name], E.[Quantity] 
FROM EmployeeRequest as E
JOIN Project as Pr ON (Pr.id = E.ProjectId)
JOIN EmployeeRequest_Skill as ES on (E.id = ES.EmployeeRequestId)
JOIN Skill as S on (S.id = ES.SkillId)
JOIN LevelOfSkill as LOS on (LOS.id = S.LevelOfSKillId)
JOIN EmployeeRequest_Position as EP on (E.id = EP.EmployeeRequestId)
JOIN Position as Po on (Po.id = EP.PositionId)
JOIN Position_LevelOfPosition as PL on (PL.PositionId = Po.id)
JOIN LevelOfPOsition as LOP on (LOP.id = PL.LevelOfPositionId)
WHERE E.isDeleted = 0
END