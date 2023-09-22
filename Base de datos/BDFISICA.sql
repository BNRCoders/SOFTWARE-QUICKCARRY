-- MySQL Workbench Forward Engineering
drop database mydb;
SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`Vehiculo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Vehiculo` (
  `Matricula` VARCHAR(255) NOT NULL,
  `Capacidad_M3` INT NULL,
  `Capacidad_KG` INT NULL,
  PRIMARY KEY (`Matricula`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Almacen`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Almacen` (
  `ID_Almacen` INT NOT NULL,
  `Capacidad_M3` INT NULL,
  `Capacidad_KG` INT NULL,
  `Direccion` VARCHAR(255) NULL,
  PRIMARY KEY (`ID_Almacen`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Paquete`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Paquete` (
  `ID_Paquete` INT NOT NULL,
  PRIMARY KEY (`ID_Paquete`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Carga`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Carga` (
  `ID_Carga` INT NOT NULL,
  `Paquete_ID_Paquete` INT NOT NULL,
  PRIMARY KEY (`ID_Carga`, `Paquete_ID_Paquete`),
  INDEX `fk_Carga_Paquete1_idx` (`Paquete_ID_Paquete` ASC)  ,
  CONSTRAINT `fk_Carga_Paquete1`
    FOREIGN KEY (`Paquete_ID_Paquete`)
    REFERENCES `mydb`.`Paquete` (`ID_Paquete`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Almacenes_CRECOM`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Almacenes_CRECOM` (
  `Paquete_ID_Paquete` INT NOT NULL,
  `Carga_ID_Carga` INT NOT NULL,
  `Almacen_ID_Almacen` INT NOT NULL,
  PRIMARY KEY (`Carga_ID_Carga`, `Paquete_ID_Paquete`, `Almacen_ID_Almacen`),
  INDEX `fk_Almacenes_CRECOM_Carga1_idx` (`Carga_ID_Carga` ASC)  ,
  INDEX `fk_Almacenes_CRECOM_Almacen1_idx` (`Almacen_ID_Almacen` ASC)  ,
  CONSTRAINT `fk_Almacenes_CRECOM_Paquete`
    FOREIGN KEY (`Paquete_ID_Paquete`)
    REFERENCES `mydb`.`Paquete` (`ID_Paquete`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Almacenes_CRECOM_Carga1`
    FOREIGN KEY (`Carga_ID_Carga`)
    REFERENCES `mydb`.`Carga` (`ID_Carga`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Almacenes_CRECOM_Almacen1`
    FOREIGN KEY (`Almacen_ID_Almacen`)
    REFERENCES `mydb`.`Almacen` (`ID_Almacen`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Lote`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Lote` (
  `ID_Lote` INT NOT NULL,
  `Paquete_ID_Paquete` INT NOT NULL,
  PRIMARY KEY (`ID_Lote`, `Paquete_ID_Paquete`),
  INDEX `fk_Lote_Paquete1_idx` (`Paquete_ID_Paquete` ASC)  ,
  CONSTRAINT `fk_Lote_Paquete1`
    FOREIGN KEY (`Paquete_ID_Paquete`)
    REFERENCES `mydb`.`Paquete` (`ID_Paquete`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Almacenes_QUICKCARRY`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Almacenes_QUICKCARRY` (
  `ID_Almacen` INT NOT NULL,
  `Carga_ID_Carga` INT NOT NULL,
  `Lote_ID_Lote` INT NOT NULL,
  `Paquete_ID_Paquete` INT NOT NULL,
  `Almacen_ID_Almacen` INT NOT NULL,
  PRIMARY KEY (`Carga_ID_Carga`, `Lote_ID_Lote`, `Paquete_ID_Paquete`, `Almacen_ID_Almacen`),
  INDEX `fk_Almacenes_QUICKCARRY_Lote1_idx` (`Lote_ID_Lote` ASC)  ,
  INDEX `fk_Almacenes_QUICKCARRY_Paquete1_idx` (`Paquete_ID_Paquete` ASC)  ,
  INDEX `fk_Almacenes_QUICKCARRY_Almacen1_idx` (`Almacen_ID_Almacen` ASC)  ,
  CONSTRAINT `fk_Almacenes_QUICKCARRY_Carga1`
    FOREIGN KEY (`Carga_ID_Carga`)
    REFERENCES `mydb`.`Carga` (`ID_Carga`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Almacenes_QUICKCARRY_Lote1`
    FOREIGN KEY (`Lote_ID_Lote`)
    REFERENCES `mydb`.`Lote` (`ID_Lote`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Almacenes_QUICKCARRY_Paquete1`
    FOREIGN KEY (`Paquete_ID_Paquete`)
    REFERENCES `mydb`.`Paquete` (`ID_Paquete`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Almacenes_QUICKCARRY_Almacen1`
    FOREIGN KEY (`Almacen_ID_Almacen`)
    REFERENCES `mydb`.`Almacen` (`ID_Almacen`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Camion`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Camion` (
  `Carga_ID_Carga` INT NOT NULL,
  `Lote_ID_Lote` INT NOT NULL,
  `Vehiculo_Matricula` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`Carga_ID_Carga`, `Lote_ID_Lote`, `Vehiculo_Matricula`),
  INDEX `fk_Camion_Lote1_idx` (`Lote_ID_Lote` ASC)  ,
  INDEX `fk_Camion_Vehiculo1_idx` (`Vehiculo_Matricula` ASC)  ,
  CONSTRAINT `fk_Camion_Carga1`
    FOREIGN KEY (`Carga_ID_Carga`)
    REFERENCES `mydb`.`Carga` (`ID_Carga`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Camion_Lote1`
    FOREIGN KEY (`Lote_ID_Lote`)
    REFERENCES `mydb`.`Lote` (`ID_Lote`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Camion_Vehiculo1`
    FOREIGN KEY (`Vehiculo_Matricula`)
    REFERENCES `mydb`.`Vehiculo` (`Matricula`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Camioneta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Camioneta` (
  `Paquete_ID_Paquete` INT NOT NULL,
  `Vehiculo_Matricula` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`Paquete_ID_Paquete`, `Vehiculo_Matricula`),
  INDEX `fk_Camioneta_Vehiculo1_idx` (`Vehiculo_Matricula` ASC)  ,
  CONSTRAINT `fk_Camioneta_Paquete1`
    FOREIGN KEY (`Paquete_ID_Paquete`)
    REFERENCES `mydb`.`Paquete` (`ID_Paquete`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Camioneta_Vehiculo1`
    FOREIGN KEY (`Vehiculo_Matricula`)
    REFERENCES `mydb`.`Vehiculo` (`Matricula`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Destino Final`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Destino Final` (
  `Direccion` VARCHAR(255) NOT NULL,
  `Paquete_ID_Paquete` INT NOT NULL,
  PRIMARY KEY (`Direccion`, `Paquete_ID_Paquete`),
  INDEX `fk_Destino Final_Paquete1_idx` (`Paquete_ID_Paquete` ASC)  ,
  CONSTRAINT `fk_Destino Final_Paquete1`
    FOREIGN KEY (`Paquete_ID_Paquete`)
    REFERENCES `mydb`.`Paquete` (`ID_Paquete`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Agencias_QUICKCARRY`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Agencias_QUICKCARRY` (
  `ID_Agencia` INT NOT NULL,
  `Direccion` VARCHAR(255) NULL,
  `Lote_ID_Lote` INT NOT NULL,
  `Paquete_ID_Paquete` INT NOT NULL,
  PRIMARY KEY (`ID_Agencia`, `Lote_ID_Lote`, `Paquete_ID_Paquete`),
  INDEX `fk_Agencias_QUICKCARRY_Lote1_idx` (`Lote_ID_Lote` ASC)  ,
  INDEX `fk_Agencias_QUICKCARRY_Paquete1_idx` (`Paquete_ID_Paquete` ASC)  ,
  CONSTRAINT `fk_Agencias_QUICKCARRY_Lote1`
    FOREIGN KEY (`Lote_ID_Lote`)
    REFERENCES `mydb`.`Lote` (`ID_Lote`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Agencias_QUICKCARRY_Paquete1`
    FOREIGN KEY (`Paquete_ID_Paquete`)
    REFERENCES `mydb`.`Paquete` (`ID_Paquete`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;


