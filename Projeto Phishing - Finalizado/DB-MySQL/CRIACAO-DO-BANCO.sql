CREATE TABLE `appphishingdb`.`phsg_pergunta` (
  `COD_PERGUNTA` INT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'CHAVE PRIMARIA DA TABELA',
  `DSCTITULOPERGUNTA` VARCHAR(255) NOT NULL COMMENT 'TITULO DA PERGUNTA',
  `DSCPERGUNTA` VARCHAR(500) NOT NULL COMMENT 'DESCRIÇÃO DO ENUNCIADO DA PERGUNTA',
  `NUMPERGUNTA` INT NOT NULL COMMENT 'NUMERO DA PERGUNTA NA SEQUENCIA DE APRESENTAÇÃO NA TELA',
  `IDTRESPOSTA` VARCHAR(1) NOT NULL COMMENT 'RESPOSTA PHISHING(P) OU VERDADEIRO(V)\n',
  `DSCRESPOSTA` VARCHAR(500) NOT NULL COMMENT 'DESCRIÇÃO DA EXPLICAÇÃO DA RESPOSTA',
  `DSCCATEGORIA` VARCHAR(255) NOT NULL COMMENT 'CATEGORIZAÇÃO POR ÁREA DE ATUAÇÃO NA EMPRESA QUE A PERGUNTA É INTERESSANTE DE SER APLICADA',
  `DSCHTMLIMG` VARCHAR(500) NOT NULL COMMENT 'DESCRIÇÃO DO CONTEUDO VISUAL DO HTML',
  `DATCADASTRO` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'DATA EM QUE A PERGUNTA FOI CADASTRADA',
  `IDTSTATUS` VARCHAR(1) NOT NULL COMMENT 'PERGUNTA ATIVA(A) OU INATIVA(I)?',
  PRIMARY KEY (`COD_PERGUNTA`));
  
CREATE TABLE `appphishingdb`.`phsg_usuario` (
  `CODUSUARIO` INT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'CHAVE PRIMARIA DA TABELA',
  `NOMUSUARIO` VARCHAR(255) NOT NULL COMMENT 'NOME DO USUÁRIO',
  `DSCEMAIL` VARCHAR(255) NOT NULL COMMENT 'EMAIL DO USUARIO',
  `NUMPONTUACAO` INT NOT NULL COMMENT 'QUANTIDADE DE QUESTÕES QUE O USUÁRIO ACERTOU',
  `DATRESPOSTA` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'DATA EM QUE O QUESTIONÁRIO FOI RESPONDIDO',
  `IDTSTATUS` VARCHAR(1) NOT NULL COMMENT 'USUÁRIO JÁ RESPONDEU O QUESTIONÁRIO(V) OU (F)',
  PRIMARY KEY (`CODUSUARIO`));
