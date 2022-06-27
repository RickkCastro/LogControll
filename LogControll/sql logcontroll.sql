CREATE DATABASE `logcontroll`;
USE `logcontroll`;

CREATE TABLE `logcontroll`.`tb_cursos` (
  `id` INT UNIQUE NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(100) NOT NULL,
  `tipo` VARCHAR(45) DEFAULT NULL,
  `data_inicio` VARCHAR(20) DEFAULT NULL,
  `data_termino` VARCHAR(20) DEFAULT NULL,
  `ativo_curso` ENUM('1','0') DEFAULT '1',
  PRIMARY KEY (`id`));

CREATE TABLE `logcontroll`.`tb_alunos` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `idade` INT NULL,
  `email` VARCHAR(85) NULL,
  `sexo` ENUM('M', 'F') NULL,
  `ativo_aluno` ENUM('1','0') DEFAULT '1',
  PRIMARY KEY (`id`));
  
CREATE TABLE `logcontroll`.`tb_matriculas` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome_aluno` VARCHAR(45) NULL,
  `nome_curso` VARCHAR(45) NULL,
  `ativo_matricula` ENUM('1','0') DEFAULT '1',
  PRIMARY KEY (`id`));
