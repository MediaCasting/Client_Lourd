CREATE TABLE [dbo].[Artist] (
    [Identifier]      BIGINT         IDENTITY (1, 1) NOT NULL,
    [Login]           NVARCHAR (50)  NULL,
    [FirstName]       NVARCHAR (50)  NULL,
    [LastName]        NVARCHAR (50)  NULL,
    [Password]        NVARCHAR (50)  NULL,
    [Phone]           INT            NULL,
    [Email]           NVARCHAR (50)  NULL,
    [Age]             INT            NULL,
    [Descritpion]     NVARCHAR (100) NULL,
    [IdentifierCity]  BIGINT         NULL,
    [IdentifierImage] BIGINT         NULL,
    CONSTRAINT [PK_Artist] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_Artist_City] FOREIGN KEY ([IdentifierCity]) REFERENCES [dbo].[City] ([Identifier]),
    CONSTRAINT [FK_Artist_Image] FOREIGN KEY ([IdentifierImage]) REFERENCES [dbo].[Image] ([Identifier])
);

