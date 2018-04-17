CREATE TABLE [dbo].[TBTeste] (
    [Id]           INT           NOT NULL,
    [DataGeracao]  VARCHAR (500) NOT NULL,
    [Recuperacao]  BIT           NOT NULL,
    [MateriaId]    INT           NOT NULL,
    [DisciplinaId] INT           NOT NULL,
    CONSTRAINT [PK_TBTeste] PRIMARY KEY CLUSTERED ([Id] ASC)
);

