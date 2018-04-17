CREATE TABLE [dbo].[TBAlternativa] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [Letra]     CHAR (1)     NOT NULL,
    [Resposta]  VARCHAR (50) NOT NULL,
    [Correta]   BIT          NOT NULL,
    [QuestaoId] INT          NOT NULL,
    CONSTRAINT [PK_TBAlternativa] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBAlternativa_TBQuestao] FOREIGN KEY ([QuestaoId]) REFERENCES [dbo].[TBQuestao] ([Id])
);



