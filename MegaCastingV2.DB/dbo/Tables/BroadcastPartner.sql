CREATE TABLE [dbo].[BroadcastPartner] (
    [Identifier]     BIGINT     IDENTITY (1, 1) NOT NULL,
    [LastName]       NCHAR (50) NULL,
    [FirstName]      NCHAR (50) NULL,
    [Phone]          INT        NULL,
    [Email]          NCHAR (50) NULL,
    [Street]         NCHAR (70) NULL,
    [IdentifierCity] BIGINT     NULL,
    CONSTRAINT [PK_BroadcastPartner] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_BroadcastPartner_City] FOREIGN KEY ([IdentifierCity]) REFERENCES [dbo].[City] ([Identifier])
);





