CREATE TABLE [dbo].[Job] (
    [Identifier]                 BIGINT     IDENTITY (1, 1) NOT NULL,
    [Name]                       NCHAR (50) NULL,
    [IdentifierJobLevelRequired] BIGINT     NOT NULL,
    CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_Job_IdentifierJobLevelRequired] FOREIGN KEY ([IdentifierJobLevelRequired]) REFERENCES [dbo].[JobLevelRequired] ([Identifier])
);



