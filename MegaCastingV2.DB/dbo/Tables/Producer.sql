CREATE TABLE [dbo].[Producer] (
    [Identifier]      BIGINT        IDENTITY (1, 1) NOT NULL,
    [CompanyName]     NVARCHAR (50) NULL,
    [FirstName]       NVARCHAR (50) NULL,
    [LastName]        NVARCHAR (50) NULL,
    [Password]        NVARCHAR (50) NULL,
    [Salt]            NVARCHAR (50) NULL,
    [Email]           NVARCHAR (50) NULL,
    [IdentifierPack]  BIGINT        NULL,
    [IdentifierImage] BIGINT        NULL,
    CONSTRAINT [PK_Producer] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_Producer_Image] FOREIGN KEY ([IdentifierImage]) REFERENCES [dbo].[Image] ([Identifier]),
    CONSTRAINT [FK_Producer_Pack] FOREIGN KEY ([IdentifierPack]) REFERENCES [dbo].[Pack] ([Identifier])
);





