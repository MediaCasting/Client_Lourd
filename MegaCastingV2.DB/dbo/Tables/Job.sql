CREATE TABLE [dbo].[Job] (
    [Identifier]          BIGINT     IDENTITY (1, 1) NOT NULL,
    [Name]                NCHAR (50) NULL,
    [IdentifierDomainJob] BIGINT     NULL,
    CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_Job_DomainJob] FOREIGN KEY ([IdentifierDomainJob]) REFERENCES [dbo].[DomainJob] ([Identifier])
);





