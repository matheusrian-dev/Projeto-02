CREATE DATABASE bdEscolaFuturo
GO

USE bdEscolaFuturo
GO

CREATE TABLE Funcionario(
 cpf			      VARCHAR(15) PRIMARY KEY NOT NULL,
 nomeFuncionario      VARCHAR(90) NOT NULL,
 telefoneFuncionario  VARCHAR(20) NOT NULL,
 emailFuncionario	  VARCHAR(70) NOT NULL,
 cargoFuncionario     VARCHAR(50) NOT NULL,
 senhaFuncionario     VARCHAR(20) NOT NULL,
 sexoFuncionario      VARCHAR(50)  NOT NULL
);

CREATE TABLE Curso(
 codCurso				INT PRIMARY KEY IDENTITY,
 nomeCurso				VARCHAR(70) NOT NULL,
 cargaHoraria			INT			NOT NULL
);

CREATE TABLE Turma(
 codTurma						INT	PRIMARY KEY IDENTITY,
 nomeTurma						VARCHAR(50)  NOT NULL,
 nomeInstrutor					VARCHAR(100) NOT NULL,
 Curso_codCurso					INT			 NOT NULL,
 FOREIGN KEY (Curso_codCurso)
	REFERENCES Curso(codCurso)
);

CREATE TABLE Aluno(
 codAluno			INT PRIMARY KEY IDENTITY,
 nomeAluno			VARCHAR(90)  NOT NULL,
 dataNascAluno		DATE		 NOT NULL,
 nomeResponsavel	VARCHAR(90)  NOT NULL,
 telefoneAluno		VARCHAR(20)  NOT NULL,
 sexoAluno			VARCHAR(50)  NOT NULL,
 enderecoAluno		VARCHAR(100) NOT NULL,
 serie				VARCHAR(50)  NOT NULL,
 Turma_CodTurma		INT			 NULL
 FOREIGN KEY (Turma_CodTurma)
	REFERENCES Turma (codTurma)
);

CREATE TABLE DistribuicaoPontos(
 codDistribuicaoPontos					INT PRIMARY KEY IDENTITY,
 nomeInstrutor							VARCHAR(100) NOT NULL,
 valorAtividade01						DECIMAL	     NOT NULL,
 valorAtividade02						DECIMAL	     NOT NULL,
 valorAtividade03						DECIMAL	     NOT NULL,
 valorAtividade04						DECIMAL	     NOT NULL,
 valorProvaInicial						DECIMAL	     NOT NULL,
 valorProvaFinal						DECIMAL	     NOT NULL,
 Turma_codTurma							INT			 NOT NULL
 FOREIGN KEY (Turma_codTurma)
    REFERENCES Turma(codTurma),
);

CREATE TABLE Nota(
 codNota						INT PRIMARY KEY IDENTITY,
 notaAtividade01				DECIMAL     NOT NULL,
 notaAtividade02				DECIMAL     NOT NULL,
 notaAtividade03				DECIMAL     NOT NULL,
 notaAtividade04				DECIMAL     NOT NULL,
 notaProvaInicial				DECIMAL     NOT NULL,
 notaProvaFinal 				DECIMAL     NOT NULL,
 Aluno_codAluno					INT		    NOT NULL
 FOREIGN KEY (Aluno_codAluno)
	REFERENCES Aluno(codAluno),
 DistribuicaoPontos_codDistribuicaoPontos					INT			NOT NULL
 FOREIGN KEY (DistribuicaoPontos_codDistribuicaoPontos)
	REFERENCES DistribuicaoPontos (codDistribuicaoPontos)
);

CREATE TABLE FrequenciaAluno(
 codFrequenciaAluno						INT PRIMARY KEY IDENTITY (1,1),
 Aluno_codAluno							INT			NOT NULL
  FOREIGN KEY (Aluno_codAluno)
	REFERENCES Aluno(codAluno),
 dataAula								DATE	    NOT NULL,
 statusFrequencia						VARCHAR(40) NOT NULL,
);

INSERT INTO Funcionario(cpf, nomeFuncionario, telefoneFuncionario, emailFuncionario, cargoFuncionario, senhaFuncionario, sexoFuncionario) 
	VALUES('222.222.222-22', 'Diretor', '(31) 99726-6405', 'diretor@gmail.com', 'diretor', '123', 'Masculino')
--SELECT * FROM Funcionario
--CREATE TABLE FrequenciaFuncionario(
-- codFrequenciaFuncionario			INT PRIMARY KEY IDENTITY(1,1),
-- Funcionario_cpf					INT			NOT NULL,
-- statusFrequenciaFuncionario		VARCHAR(40) NOT NULL,
-- dataReferente						DATE		NOT NULL,
-- FOREIGN KEY (Funcionario_cpf)
--	REFERENCES Funcionario(cpf)
--);

--DROP DATABASE bdEscolaFuturo;
--USE master;