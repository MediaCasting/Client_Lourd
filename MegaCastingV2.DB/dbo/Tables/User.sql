CREATE TABLE [dbo].[User] (
    [Identifier]     BIGINT        IDENTITY (1, 1) NOT NULL,
    [FirstName]      NVARCHAR (50) NULL,
    [LastName]       NVARCHAR (50) NULL,
    [Password]       NVARCHAR (50) NULL,
    [Salt]           NVARCHAR (50) NULL,
    [IsAdmin]        TINYINT       NULL,
    [IdentifierCity] BIGINT        NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_User_City] FOREIGN KEY ([IdentifierCity]) REFERENCES [dbo].[City] ([Identifier])
);

