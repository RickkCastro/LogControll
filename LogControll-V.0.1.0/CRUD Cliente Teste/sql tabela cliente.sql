CREATE SCHEMA `crud_cliente_c#` ;

CREATE TABLE `crud_cliente_c#`.`tb_cliente` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `numero` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`));
  
ALTER TABLE `crud_cliente_c#`.`tb_cliente` 
CHANGE COLUMN `nome` `nome` VARCHAR(45) NOT NULL DEFAULT 'No name' ,
CHANGE COLUMN `numero` `numero` VARCHAR(45) NOT NULL DEFAULT 0 ;

SELECT AUTO_INCREMENT FROM information_schema.tables
WHERE table_name = 'tb_cliente';