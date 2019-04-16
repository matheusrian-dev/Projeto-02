CREATE DATABASE bdEscolaFuturo
GO

USE bdEscolaFuturo
GO

CREATE TABLE Funcionario(
 cpf			      INT PRIMARY KEY NOT NULL,
 nomeFuncionario      VARCHAR(90) NOT NULL,
 telefoneFuncionario  VARCHAR(14) NOT NULL,
 emailFuncionario	  VARCHAR(30) NOT NULL,
 cargoFuncionario     VARCHAR(20) NOT NULL,
 senhaFuncionario     VARCHAR(16) NOT NULL,
 sexoFuncionario      VARCHAR(9)  NOT NULL
);


CREATE TABLE Aluno(
 codAluno			INT PRIMARY KEY IDENTITY,
 nomeAluno			VARCHAR(90) NOT NULL,
 dataNascAluno		VARCHAR(10) NOT NULL,
 nomeResponsavel	VARCHAR(90) NOT NULL,
 telefoneAluno		VARCHAR(14) NOT NULL,
 sexoAluno			VARCHAR(9)  NOT NULL,
 enderecoAluno		VARCHAR(40) NOT NULL,
 serie				VARCHAR(10) NOT NULL
);


CREATE TABLE Curso(
 codCurso				INT PRIMARY KEY IDENTITY,
 nomeCurso				VARCHAR(30) NOT NULL,
 diciplina				VARCHAR(20) NOT NULL,
 intrutorResponsavel	VARCHAR(90) NOT NULL,
 dataInicio				DATE        NOT NULL,
 dataFim				DATE        NOT NULL
);


CREATE TABLE Nota(
 codNota						INT PRIMARY KEY IDENTITY,
 nomeAtividade					VARCHAR(30) NOT NULL,
 pontos							INT         NOT NULL,
 Aluno_codAluno					INT			NOT NULL
 FOREIGN KEY (Aluno_codAluno)
	REFERENCES Aluno(codAluno)
);


CREATE TABLE Boletim(
 codBoletim							INT PRIMARY KEY IDENTITY,
 Aluno_codAluno						INT NOT NULL
 FOREIGN KEY (Aluno_codAluno)
	REFERENCES Aluno(codAluno)
);


CREATE TABLE DistribuicaoPontos(
 codDistribuicaoPontos					INT PRIMARY KEY IDENTITY,
 nomeAtividade							VARCHAR(30) NOT NULL,
 valor									INT			NOT NULL,
 Curso_codCurso							INT			NOT NULL
 FOREIGN KEY (Curso_codCurso)
    REFERENCES Curso(codCurso),
 dataInicio								DATE		NOT NULL,
 dataEntrega							DATE		NOT NULL
);


CREATE TABLE Certificado(
 codCertificado						INT PRIMARY KEY IDENTITY,
 tipoCertificado 					VARCHAR(20) NOT NULL,
 dataEmissaoCertificado				DATE		NOT NULL,
 Aluno_codAluno						INT			NOT NULL
 FOREIGN KEY (Aluno_codAluno)
	REFERENCES Aluno(codAluno),
 Curso_codCurso						INT			NOT NULL
 FOREIGN KEY (Curso_codCurso)
    REFERENCES Curso(codCurso),
);


CREATE TABLE Turma(
 codTurma						INT	PRIMARY KEY IDENTITY,
 nomeTurma						VARCHAR(15) NOT NULL,
 quantAlunos					INT			NOT NULL,
 Curso_codCurso					INT			NOT NULL,
 FOREIGN KEY (Curso_codCurso)
	REFERENCES Curso(codCurso)
);

CREATE TABLE Diploma(
 codDiploma						INT PRIMARY KEY IDENTITY,
 Aluno_codAluno					INT NOT NULL
 FOREIGN KEY (Aluno_codAluno)
	REFERENCES Aluno(codAluno)
);


CREATE TABLE FrequenciaAluno(
 codFrequenciaAluno						INT PRIMARY KEY IDENTITY (1,1),
 Aluno_codAluno							INT			NOT NULL
  FOREIGN KEY (Aluno_codAluno)
	REFERENCES Aluno(codAluno),
 dataAula								DATE	    NOT NULL,
 statusFrequencia						VARCHAR(40) NOT NULL,
);


CREATE TABLE Historico(
 codHistorico										INT PRIMARY KEY IDENTITY,
 Aluno_codAluno										INT NOT NULL
  FOREIGN KEY (Aluno_codAluno)
	REFERENCES Aluno(codAluno),					
 FrequenciaAluno_codFrequenciaAluno					INT NOT NULL
 FOREIGN KEY (FrequenciaAluno_codFrequenciaAluno)
	REFERENCES FrequenciaAluno(codFrequenciaAluno),

);


CREATE TABLE FrequenciaFuncionario(
 codFrequenciaFuncionario			INT PRIMARY KEY IDENTITY(1,1),
 Funcionario_cpf					INT			NOT NULL,
 statusFrequenciaFuncionario		VARCHAR(40) NOT NULL,
 dataReferente						DATE		NOT NULL,
 FOREIGN KEY (Funcionario_cpf)
	REFERENCES Funcionario(cpf)
);

--DROP DATABASE bdEscolaFuturo;
--USE master;