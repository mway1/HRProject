CREATE TABLE [dbo].[Specialist] (
    [id]         INT NOT NULL,
    [PositionId] INT NOT NULL,
    [LevelId]    INT NOT NULL,
    CONSTRAINT [PK_SPECIALIST] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [Specialist_fk0] FOREIGN KEY ([PositionId]) REFERENCES [dbo].[Position] ([id]) ON UPDATE CASCADE,
    CONSTRAINT [Specialist_fk1] FOREIGN KEY ([LevelId]) REFERENCES [dbo].[Level] ([id]) ON UPDATE CASCADE
);

