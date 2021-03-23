-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Nov 07, 2017 at 04:50 AM
-- Server version: 5.6.21
-- PHP Version: 5.5.19

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `art_collection`
--

-- --------------------------------------------------------

--
-- Table structure for table `artist`
--

CREATE TABLE IF NOT EXISTS `artist` (
  `Artist_Name` varchar(35) NOT NULL,
  `LifeSpan` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `painting`
--

CREATE TABLE IF NOT EXISTS `painting` (
  `Title` varchar(35) NOT NULL,
  `Year` int(4) NOT NULL,
  `Media` varchar(20) NOT NULL,
  `ArtistNameFK` varchar(35) NOT NULL,
  `StyleFK` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `style`
--

CREATE TABLE IF NOT EXISTS `style` (
  `Style` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `style`
--

INSERT INTO `style` (`Style`) VALUES
('Cubism'),
('Impressionism'),
('Mannerism'),
('Portrait'),
('Realism'),
('Renaissance'),
('Still-life'),
('Surrealism');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `artist`
--
ALTER TABLE `artist`
 ADD PRIMARY KEY (`Artist_Name`);

--
-- Indexes for table `painting`
--
ALTER TABLE `painting`
 ADD PRIMARY KEY (`Title`), ADD KEY `ArtistNameFK` (`ArtistNameFK`,`StyleFK`), ADD KEY `StyleFK` (`StyleFK`), ADD KEY `ArtistNameFK_2` (`ArtistNameFK`);

--
-- Indexes for table `style`
--
ALTER TABLE `style`
 ADD PRIMARY KEY (`Style`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `painting`
--
ALTER TABLE `painting`
ADD CONSTRAINT `painting_ibfk_1` FOREIGN KEY (`ArtistNameFK`) REFERENCES `artist` (`Artist_Name`) ON DELETE CASCADE ON UPDATE CASCADE,
ADD CONSTRAINT `painting_ibfk_2` FOREIGN KEY (`StyleFK`) REFERENCES `style` (`Style`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
