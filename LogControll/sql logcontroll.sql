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



select * from logcontroll.tb_cursos;
select id, nome, tipo, data_Inicio, data_Termino from  logcontroll.tb_cursos WHERE ativo_curso = '1';

select coalesce( max( id), 0) + 1 from tb_cursos;
  
INSERT INTO `logcontroll`.`tb_cursos` (`nome_curso`, `tipo_curso`, `dataInicio_curso`, `dataTermino_curso`)
VALUES ('Programacao', 'TI', '19/06/22', '19/06/23');