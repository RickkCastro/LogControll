CREATE database `crud_LogControll`;
use crud_LogControll;

CREATE TABLE `crud_LogControll`.`tb_cliente` (
  `id` INT auto_increment,
  `nome` VARCHAR(45) NOT NULL DEFAULT 'No name',
  `numero` VARCHAR(45) NOT NULL DEFAULT 0,
  PRIMARY KEY (`id`));

SELECT AUTO_INCREMENT FROM information_schema.tables
WHERE table_name = 'tb_cliente';

select * from tb_cliente;

select auto_increment from information_schema.tables where table_name = 'tb_cliente' and table_schema = 'crud_LogControll';

SHOW TABLE STATUS LIKE 'tb_cliente';

INSERT INTO tb_cliente (`nome`, `numero`) VALUES ('rickkk', 5);