CREATE TABLE [dbo].[Messagerie] (
    [Identifier]         BIGINT         IDENTITY (1, 1) NOT NULL,
    [Texte]              NVARCHAR (500) NULL,
    [Date]               DATE           NULL,
    [QuiEcrit]           BIT            NULL,
    [IdentifierUser]     BIGINT         NOT NULL,
    [IdentifierProducer] BIGINT         NOT NULL,
    CONSTRAINT [PK_Messagerie] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_Messagerie_Producer] FOREIGN KEY ([IdentifierProducer]) REFERENCES [dbo].[Producer] ([Identifier]),
    CONSTRAINT [FK_Messagerie_User] FOREIGN KEY ([IdentifierUser]) REFERENCES [dbo].[User] ([Identifier])
);

