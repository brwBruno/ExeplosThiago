CREATE TABLE [dbo].[TBQuestao] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Enunciado] VARCHAR (MAX) NOT NULL,
    [MateriaId] INT           NOT NULL,
    [Bimestre]  INT           NOT NULL,
    CONSTRAINT [PK_TBQuestao] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBQuestao_TBMateria] FOREIGN KEY ([MateriaId]) REFERENCES [dbo].[TBMateria] ([Id])
);



