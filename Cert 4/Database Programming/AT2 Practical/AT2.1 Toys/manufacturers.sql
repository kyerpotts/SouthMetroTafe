-- phpMyAdmin SQL Dump
-- version 4.0.4
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 17, 2016 at 06:37 AM
-- Server version: 5.5.32
-- PHP Version: 5.4.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `toyshop`
--

-- --------------------------------------------------------

--
-- Table structure for table `manufacturers`
--

CREATE TABLE IF NOT EXISTS `manufacturers` (
  `manufacturerID` char(4) NOT NULL,
  `company_name` char(50) NOT NULL,
  `address` char(50) NOT NULL,
  `city` char(20) NOT NULL,
  `state` char(2) NOT NULL,
  `post_code` char(5) NOT NULL,
  `area_code` char(3) NOT NULL,
  `phone_number` char(8) NOT NULL,
  PRIMARY KEY (`manufacturerID`),
  UNIQUE KEY `PhoneNumber` (`phone_number`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `manufacturers`
--

INSERT INTO `manufacturers` (`manufacturerID`, `company_name`, `address`, `city`, `state`, `post_code`, `area_code`, `phone_number`) VALUES
('AA01', 'Matel', '2892 23rd Ave S', 'St. Petersburg', 'FL', '33710', '727', '324-5421'),
('AA02', 'Jurnes', '1231 Lindsay Ave N', 'Tampa', 'FL', '33618', '813', '234-3982'),
('AA03', 'Radae', '1872 3rd Ave N', 'Baltimore', 'MD', '21210', '240', '713-0011'),
('AA04', 'Winnies', '6000 16th Ave N', 'San Diego', 'CA', '92101', '213', '981-8745'),
('AA05', 'Lenar', '1230 9th Ave N', 'Baltimore', 'MD', '21202', '301', '321-0987');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
