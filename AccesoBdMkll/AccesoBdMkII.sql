

-- Script SQL Sugerido para la Base de Datos ControlAccesosDB en MySQL

-- MySQL Workbench Forward Engineering
 
SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema ControlAccesosDB
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema ControlAccesosDB
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `ControlAccesosDB` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci ;
USE `ControlAccesosDB` ;

-- -----------------------------------------------------
-- Table `ControlAccesosDB`.`Usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ControlAccesosDB`.`Usuarios` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Usuario` VARCHAR(50) NOT NULL,
  `ContraHash` VARCHAR(256) NOT NULL,
  `Rol` ENUM('Residente', 'Guardia') NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Username` (`Usuario` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_unicode_ci;


-- -----------------------------------------------------
-- Table `ControlAccesosDB`.`Guardias`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ControlAccesosDB`.`Guardias` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(100) NOT NULL,
  `Apellidos` VARCHAR(100) NOT NULL,
  `PlacasVehiculo` VARCHAR(20) NULL DEFAULT NULL,
  `UserId` INT NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `UserId` (`UserId` ASC) VISIBLE,
  CONSTRAINT `Guardias_ibfk_1`
    FOREIGN KEY (`UserId`)
    REFERENCES `ControlAccesosDB`.`Usuarios` (`Id`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_unicode_ci;


-- -----------------------------------------------------
-- Table `ControlAccesosDB`.`Residentes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ControlAccesosDB`.`Residentes` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(100) NOT NULL,
  `Apellidos` VARCHAR(100) NOT NULL,
  `Domicilio` VARCHAR(200) NULL DEFAULT NULL,
  `Telefono` VARCHAR(20) NULL DEFAULT NULL,
  `Vehiculo` VARCHAR(100) NULL DEFAULT NULL,
  `Placas` VARCHAR(20) NULL DEFAULT NULL,
  `UserId` INT NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `UserId` (`UserId` ASC) VISIBLE,
  CONSTRAINT `Residentes_ibfk_1`
    FOREIGN KEY (`UserId`)
    REFERENCES `ControlAccesosDB`.`Usuarios` (`Id`))
ENGINE = InnoDB
AUTO_INCREMENT = 1
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_unicode_ci;


-- -----------------------------------------------------
-- Table `ControlAccesosDB`.`Invitados`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ControlAccesosDB`.`Invitados` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Nombre` VARCHAR(100) NOT NULL,
  `Apellidos` VARCHAR(100) NOT NULL,
  `TipoInvitacion` ENUM('Unica', 'Recurrente', 'PorFecha') NOT NULL,
  `FechaValidez` DATETIME NULL DEFAULT NULL,
  `QrCode` VARCHAR(15) NOT NULL UNIQUE,
  `ResidenteId` INT NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `QrCode_UNIQUE` (`QrCode` ASC) VISIBLE, 
  INDEX `ResidenteId` (`ResidenteId` ASC) VISIBLE,
  CONSTRAINT `Invitados_ibfk_1`
    FOREIGN KEY (`ResidenteId`)
    REFERENCES `ControlAccesosDB`.`Residentes` (`Id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_unicode_ci;


-- -----------------------------------------------------
-- Table `ControlAccesosDB`.`RegistrosAcceso`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ControlAccesosDB`.`RegistrosAcceso` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `FechaHora` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `TipoAcceso` ENUM('Entrada', 'Salida') NOT NULL,
  `ResidenteId` INT NULL DEFAULT NULL,
  `InvitadoId` INT NULL DEFAULT NULL,
  `GuardiaId` INT NOT NULL,
  `PlacasVehiculo` VARCHAR(20) NULL DEFAULT NULL,
  `Notas` VARCHAR(500) NULL DEFAULT NULL,
  PRIMARY KEY (`Id`),
  INDEX `ResidenteId` (`ResidenteId` ASC) VISIBLE,
  INDEX `InvitadoId` (`InvitadoId` ASC) VISIBLE,
  INDEX `GuardiaId` (`GuardiaId` ASC) VISIBLE,
  CONSTRAINT `RegistrosAcceso_ibfk_1`
    FOREIGN KEY (`ResidenteId`)
    REFERENCES `ControlAccesosDB`.`Residentes` (`Id`),
  CONSTRAINT `RegistrosAcceso_ibfk_2`
    FOREIGN KEY (`InvitadoId`)
    REFERENCES `ControlAccesosDB`.`Invitados` (`Id`),
  CONSTRAINT `RegistrosAcceso_ibfk_3`
    FOREIGN KEY (`GuardiaId`)
    REFERENCES `ControlAccesosDB`.`Guardias` (`Id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_unicode_ci;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;


USE ControlAccesosDB;

INSERT INTO Usuarios VALUES
 (null, 'ROOT', '$2a$12$jboXaxQfvLAaB0XkLlNqdu23nkxpazfCInVQX3l3Bye2xfVQmMlem', 'Guardia');

INSERT INTO Guardias (Nombre, Apellidos, PlacasVehiculo, UserId) VALUES
('Primer', 'Guardia', 'GUA-001', (SELECT Id FROM Usuarios WHERE Usuario = 'ROOT'));




