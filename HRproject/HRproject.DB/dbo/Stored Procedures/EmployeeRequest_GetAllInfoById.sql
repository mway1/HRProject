CREATE PROCEDURE dbo.[EmployeeRequest_GetAllInfoById]
@Id int
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
FROM EmployeeRequest as E
LEFT JOIN Project as Pr ON (E.ProjectId = Pr.id)
LEFT JOIN EmployeeRequest_Skill as ES on (E.id = ES.EmployeeRequestId)
LEFT JOIN Skill as S on (ES.SkillId = S.id)
LEFT JOIN EmployeeRequest_Position as EP on (E.id = EP.EmployeeRequestId)
LEFT JOIN Position as Po on (Po.id = EP.PositionId)
LEFT JOIN Position_LevelOfPosition as PL on (Po.id = PL.PositionId)
LEFT JOIN LevelOfPOsition as LOP on (LOP.id = PL.LevelOfPositionId)
WHERE E.id = @Id
END