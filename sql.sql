CREATE DATABASE Sistema_Controle_Livros

use Sistema_Controle_Livros

CREATE TABLE [dbo].[Login] (
    [Id]      INT          IDENTITY (1, 1) NOT NULL,
    [Usuario] VARCHAR (50) NULL,
    [Senha]   VARCHAR (10) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


CREATE TABLE [dbo].[Usuario] (
    [Cod_Usuario]  INT         IDENTITY (1, 1) NOT NULL,
    [Nome_Usuario] VARCHAR (100) NOT NULL,
    [Ano]          VARCHAR (25) NULL,
    [Turma]        VARCHAR (14) NULL,
    [Endereco]     VARCHAR (30) NULL,
    [Numero]       VARCHAR (MAX)NULL,
    [Telefone]     VARCHAR (14) NULL,
    [Ocupacao]     VARCHAR (11) NOT NULL,
    PRIMARY KEY CLUSTERED ([Cod_Usuario] ASC)
);

CREATE TABLE [dbo].[Livro_Literario] (
    [N_Registro] INT           NOT NULL,
    [Titulo]     VARCHAR (MAX) NOT NULL,
    [Autor]      VARCHAR (MAX) NULL,
    [Genero]     VARCHAR (MAX) NULL,
    [Estante]    VARCHAR (3) NULL,
    PRIMARY KEY CLUSTERED ([N_Registro] ASC)
);

CREATE TABLE [dbo].[Livro_Didatico] (
    [N_Registro] INT           NOT NULL,
    [Disciplina] VARCHAR (300) NULL,
    [Autor]      VARCHAR (100) NULL,
    [Ensino]      VARCHAR (30)  NULL,
    [Volume]     VARCHAR (30)  NULL,   
    PRIMARY KEY CLUSTERED ([N_Registro] ASC)
);

CREATE TABLE [dbo].[Emprestimo_Livro_Literario] (
    [Cod_Empretimo_Livro_Literario] INT          IDENTITY (1, 1) NOT NULL,
    [Data_Solicitacao]              VARCHAR (11) NULL,
    [Data_Entrega]                  VARCHAR (11) NULL,
    [Cod_Usuario]                   INT          NULL,
    [N_Registro]                    INT          NULL,
    PRIMARY KEY CLUSTERED ([Cod_Empretimo_Livro_Literario] ASC),
    FOREIGN KEY ([Cod_Usuario]) REFERENCES [dbo].[Usuario] ([Cod_Usuario]),
    FOREIGN KEY ([N_Registro]) REFERENCES [dbo].[Livro_Literario] ([N_Registro])
);



CREATE TABLE [dbo].[Emprestimo_Livro_Didatico] (
    [Cod_Emprestimo_Didatico] INT          IDENTITY (1,1) NOT NULL,
    [Data_Entrega]            VARCHAR (11) NOT NULL,
    [Data_Solicitacao]        VARCHAR (11) NULL,
    [N_Registro]              INT          NULL,
    [Cod_Usuario]             INT          NULL,
    PRIMARY KEY CLUSTERED ([Cod_Emprestimo_Didatico] ASC),
    FOREIGN KEY ([N_Registro]) REFERENCES [dbo].[Livro_Didatico] ([N_Registro]),
    FOREIGN KEY ([Cod_Usuario]) REFERENCES [dbo].[Usuario] ([Cod_Usuario])
);
CREATE TABLE [dbo].[EmprestimoTemporario] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [Livro] VARCHAR (300) NOT NULL,
    [Turma]      VARCHAR (14) NULL,
    [Professora] VARCHAR (50) NULL,
    [Quantidade] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

INSERT INTO Login VALUES ('Biblioteca','Educação')
