CREATE TABLE [dbo].[TBMateria] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [Nome]         VARCHAR (50) NOT NULL,
    [SerieId]      INT          NOT NULL,
    [DisciplinaId] INT          NOT NULL,
    CONSTRAINT [PK_TBMateria] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBMateria_TBDisciplina] FOREIGN KEY ([DisciplinaId]) REFERENCES [dbo].[TBDisciplina] ([Id]),
    CONSTRAINT [FK_TBMateria_TBSerie] FOREIGN KEY ([SerieId]) REFERENCES [dbo].[TBSerie] ([Id])
);

