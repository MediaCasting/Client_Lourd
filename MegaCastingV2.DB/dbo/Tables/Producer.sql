CREATE TABLE [dbo].[Producer] (
    [Identifier]     BIGINT        IDENTITY (1, 1) NOT NULL,
    [FirstName]      NVARCHAR (50) NULL,
    [LastName]       NVARCHAR (50) NULL,
    [Password]       NVARCHAR (50) NULL,
    [Salt]           NVARCHAR (50) NULL,
    [IdentifierPack] BIGINT        NOT NULL,
    CONSTRAINT [PK_Producer] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_Producer_Pack] FOREIGN KEY ([IdentifierPack]) REFERENCES [dbo].[Pack] ([Identifier])
);



