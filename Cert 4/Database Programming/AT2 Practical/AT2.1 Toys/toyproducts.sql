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
-- Table structure for table `toyproducts`
--

CREATE TABLE IF NOT EXISTS `toyproducts` (
  `productID` char(5) NOT NULL,
  `product_name` char(50) NOT NULL,
  `price` double NOT NULL,
  `sale_price` double NOT NULL,
  `in_stock` int(11) NOT NULL,
  `on_order` int(11) NOT NULL,
  `categoryID` int(11) NOT NULL,
  `manufacturerID` char(4) DEFAULT NULL,
  PRIMARY KEY (`productID`),
  KEY `categoryID` (`categoryID`),
  KEY `ManufacturerID` (`manufacturerID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `toyproducts`
--

INSERT INTO `toyproducts` (`productID`, `product_name`, `price`, `sale_price`, `in_stock`, `on_order`, `categoryID`, `manufacturerID`) VALUES
('BN200', 'Animated Rainbow', 21, 18, 10, 20, 1, 'AA01'),
('BN201', 'ElectricTrain', 49, 39, 5, 5, 3, 'AA02'),
('BN202', 'Rubiks Cube', 18, 16, 10, 10, 1, 'AA03'),
('BX001', 'Vampire Doll', 19.5, 18.5, 10, 1, 2, 'AA03'),
('BX002', 'Dracula Doll', 19.5, 18, 12, 2, 2, 'AA03'),
('BX003', 'Painter Doll', 21.5, 19, 12, 4, 2, 'AA03'),
('BX004', 'Gym Trainer Doll', 22.5, 21, 12, 4, 2, 'AA03'),
('CE300', 'Miniature Train Set', 60, 54, 1, 30, 3, 'AA03'),
('CE301', 'Tonka Truck', 42, 32, 2, 7, 5, 'AA05'),
('CE302', 'Robot Kit', 65, 44, 4, 30, 3, 'AA02'),
('CT200', 'China Puppy', 15, 13.5, 20, 40, 4, 'AA04'),
('CT201', 'Wooden Puppy', 18, 14.5, 15, 25, 4, 'AA04'),
('CT202', 'Tanjore Doll', 17, 13.5, 20, 40, 2, 'AA01'),
('ET100', 'Wooden Clock', 14, 8.5, 25, 0, 3, 'AA02'),
('ET101', 'Wooden Horse', 110, 90.9, 10, 0, 4, 'AA04'),
('ET102', 'Apple Doll', 11, 9.9, 85, 0, 2, 'AA01'),
('LF300', 'Friendly Lion', 24, 22, 2, 30, 4, 'AA04'),
('LF302', 'Marbles', 14, 12.6, 0, 30, 5, 'AA05'),
('OT100', 'Dancing Bird', 11, 10, 10, 5, 4, 'AA04'),
('OT101', 'Puppy in my Pocket', 10, 9, 10, 20, 4, 'AA04'),
('OT102', 'Digital Pet', 8, 7, 20, 20, 3, 'AA02'),
('PO200', 'Glass Rabbit', 50, 45, 50, 20, 4, 'AA04'),
('PO201', 'Fur Rabbit', 10, 8, 30, 20, 4, 'AA04'),
('PO202', 'Parian Doll', 12, 11, 50, 20, 2, 'AA01'),
('RX300', 'My Little Pony', 22, 21.5, 3, 5, 4, 'AA04'),
('RX301', 'Star Wars Lego', 35, 29, 10, 10, 5, 'AA05'),
('RX302', 'Ant Farm', 25, 22.5, 3, 40, 5, 'AA05'),
('TH100', 'Crystal Cat', 75, 67.5, 60, 20, 4, 'AA04'),
('TH101', 'Dolls House', 70, 67.5, 10, 5, 2, 'AA01'),
('TH102', 'Crystal Dog', 75, 67.5, 60, 20, 4, 'AA04'),
('VR300', 'China Doll', 20, 13, 80, 0, 2, 'AA01'),
('VR301', 'GI Joe', 19, 15, 80, 0, 6, 'AA01'),
('VR302', 'Rag Doll', 20, 13, 100, 0, 2, 'AA01'),
('VR303', 'Power Ranger', 17, 13, 20, 0, 6, 'AA01'),
('VR304', 'B-Daman', 11, 10, 20, 0, 6, 'AA01'),
('VR305', 'Transformer', 24, 21, 50, 10, 6, 'AA01'),
('XN001', 'Meccano Light', 66, 59, 4, 2, 5, 'AA05'),
('XN002', 'Meccano Crane', 72, 68, 2, 4, 5, 'AA05'),
('ZN003', 'Meccano City', 76, 66, 2, 1, 5, 'AA05'),
('ZN004', 'Meccano Ultimate', 99, 89, 1, 1, 5, 'AA05'),
('ZN005', 'Stickle Bricks', 25, 19, 10, 10, 5, 'AA05'),
('ZN006', 'Zome', 19, 18, 5, 2, 5, 'AA05');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `toyproducts`
--
ALTER TABLE `toyproducts`
  ADD CONSTRAINT `toyproducts_ibfk_2` FOREIGN KEY (`manufacturerID`) REFERENCES `manufacturers` (`manufacturerID`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `toyproducts_ibfk_1` FOREIGN KEY (`categoryID`) REFERENCES `categories` (`categoryID`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
