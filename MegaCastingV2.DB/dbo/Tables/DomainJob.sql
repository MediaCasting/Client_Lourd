CREATE TABLE [dbo].[DomainJob] (
    [Identifier] BIGINT     IDENTITY (1, 1) NOT NULL,
    [Name]       NCHAR (50) NULL,
    CONSTRAINT [PK_DomainJob] PRIMARY KEY CLUSTERED ([Identifier] ASC)
);

