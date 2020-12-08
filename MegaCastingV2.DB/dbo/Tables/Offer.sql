CREATE TABLE [dbo].[Offer] (
    [Identifier]             BIGINT          IDENTITY (1, 1) NOT NULL,
    [Name]                   NVARCHAR (50)   NOT NULL,
    [Reference]              NVARCHAR (50)   NULL,
    [PublishDateTime]        DATETIME        NULL,
    [Duration]               INT             NOT NULL,
    [StartContractDate]      DATETIME        NULL,
    [PostCount]              INT             NULL,
    [JobDescription]         NVARCHAR (2000) NULL,
    [ProfilDescription]      NVARCHAR (2000) NULL,
    [Street]                 NVARCHAR (70)   NULL,
    [IdentifierCity]         BIGINT          NULL,
    [IdentifierProducer]     BIGINT          NULL,
    [IdentifierJob]          BIGINT          NULL,
    [IdentifierContractType] BIGINT          NULL,
    CONSTRAINT [PK_Offer] PRIMARY KEY CLUSTERED ([Identifier] ASC),
    CONSTRAINT [FK_Offer_City] FOREIGN KEY ([IdentifierCity]) REFERENCES [dbo].[City] ([Identifier]),
    CONSTRAINT [FK_Offer_ContractType] FOREIGN KEY ([IdentifierContractType]) REFERENCES [dbo].[ContractType] ([Identifier]),
    CONSTRAINT [FK_Offer_Job] FOREIGN KEY ([IdentifierJob]) REFERENCES [dbo].[Job] ([Identifier]),
    CONSTRAINT [FK_Offer_Producer] FOREIGN KEY ([IdentifierProducer]) REFERENCES [dbo].[Producer] ([Identifier])
);





