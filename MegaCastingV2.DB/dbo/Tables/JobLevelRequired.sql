CREATE TABLE [dbo].[JobLevelRequired] (
    [Identifier] BIGINT     IDENTITY (1, 1) NOT NULL,
    [Name]       NCHAR (50) NULL,
    CONSTRAINT [PK_JobLevelRequired] PRIMARY KEY CLUSTERED ([Identifier] ASC)
);

