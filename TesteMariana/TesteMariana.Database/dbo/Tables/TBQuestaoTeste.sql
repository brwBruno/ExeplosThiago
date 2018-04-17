CREATE TABLE [dbo].[TBQuestaoTeste] (
    [QuestaoId] INT NOT NULL,
    [TesteId]   INT NOT NULL,
    CONSTRAINT [FK_TBQuestaoTeste_TBQuestao] FOREIGN KEY ([TesteId]) REFERENCES [dbo].[TBQuestao] ([Id]),
    CONSTRAINT [FK_TBQuestaoTeste_TBTeste] FOREIGN KEY ([TesteId]) REFERENCES [dbo].[TBTeste] ([Id])
);

