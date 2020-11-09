CREATE TABLE [dbo].[UserOffer] (
    [Identifier]      BIGINT IDENTITY (1, 1) NOT NULL,
    [IdentifierUser]  BIGINT NOT NULL,
    [IdentifierOffer] BIGINT NOT NULL,
    CONSTRAINT [PK_UserOffer] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_UserOffer_Offer] FOREIGN KEY ([IdentifierOffer]) REFERENCES [dbo].[Offer] ([Identifier]),
    CONSTRAINT [FK_UserOffer_User] FOREIGN KEY ([IdentifierUser]) REFERENCES [dbo].[User] ([Identifier])
);

