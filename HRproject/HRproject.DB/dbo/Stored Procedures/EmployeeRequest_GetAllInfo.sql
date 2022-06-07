CREATE PROCEDURE dbo.[EmployeeRequest_GetAllInfo]
AS
BEGIN
SELECT E.[id],
E.[Quantity],
Pr.[id],
Pr.[Name] as [ProjectName],
Pr.[Description],
Po.[id],
Po.[Name] as [PositionName],
LOP.[id],
LOP.[Name] as [PositionLevel],
S.[id],
S.[Name] as [SkillName],
ES.[id],
ES.[LevelOfSkill]
FROM dbo.EmployeeRequest as E
LEFT JOIN dbo.Project as Pr ON (E.ProjectId = Pr.id)
LEFT JOIN dbo.EmployeeRequest_Skill as ES on (E.id = ES.EmployeeRequestId)
LEFT JOIN dbo.Skill as S on (ES.SkillId = S.id)
LEFT JOIN dbo.EmployeeRequest_Position as EP on (E.id = EP.EmployeeRequestId)
LEFT JOIN dbo.Position as Po on (Po.id = EP.PositionId)
LEFT JOIN dbo.Position_LevelOfPosition as PL on (Po.id = PL.PositionId)
LEFT JOIN dbo.LevelOfPOsition as LOP on (LOP.id = PL.LevelOfPositionId)
WHERE E.isDeleted = 0
END