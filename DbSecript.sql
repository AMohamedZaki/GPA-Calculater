--
CREATE TABLE [dbo].[Gpas] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]     NVARCHAR (MAX) NULL,
    [DateTime] DATETIME       NOT NULL,
    CONSTRAINT [PK_dbo.Gpas] PRIMARY KEY CLUSTERED ([Id] ASC)
);
--
CREATE TABLE [dbo].[Grades] (
    [Id]    INT             IDENTITY (1, 1) NOT NULL,
    [Name]  NVARCHAR (MAX)  NULL,
    [Value] DECIMAL (18, 2) NOT NULL,
    [GpaId] INT             NOT NULL,
    CONSTRAINT [PK_dbo.Grades] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_dbo.Grades_dbo.Gpas_GpaId] FOREIGN KEY ([GpaId]) REFERENCES [dbo].[Gpas] ([Id]) 
);