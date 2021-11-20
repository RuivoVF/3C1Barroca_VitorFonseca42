-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 19-Nov-2021 às 19:25
-- Versão do servidor: 8.0.18
-- versão do PHP: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `bdrihappyvitor`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbl_login2`
--

DROP TABLE IF EXISTS `tbl_login2`;
CREATE TABLE IF NOT EXISTS `tbl_login2` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(30) DEFAULT NULL,
  `senha` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Extraindo dados da tabela `tbl_login2`
--

INSERT INTO `tbl_login2` (`id`, `email`, `senha`) VALUES
(1, 'vitor@gmail.com', 1190),
(2, 'raquel@gmail.com', 2021),
(3, 'vitor@gmail.com', 1190),
(4, 'raquel@gmail.com', 2021);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbl_produtos`
--

DROP TABLE IF EXISTS `tbl_produtos`;
CREATE TABLE IF NOT EXISTS `tbl_produtos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Produtos` varchar(40) NOT NULL,
  `Precos` varchar(200) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbl_rihappy`
--

DROP TABLE IF EXISTS `tbl_rihappy`;
CREATE TABLE IF NOT EXISTS `tbl_rihappy` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `nomecomprador` varchar(30) DEFAULT NULL,
  `idVendedores` int(11) NOT NULL,
  PRIMARY KEY (`codigo`),
  KEY `idVendedores` (`idVendedores`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
