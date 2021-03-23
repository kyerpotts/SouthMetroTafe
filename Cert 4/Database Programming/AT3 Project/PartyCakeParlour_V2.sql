-- phpMyAdmin SQL Dump
-- version 4.7.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Jun 28, 2019 at 02:43 AM
-- Server version: 5.6.34
-- PHP Version: 7.1.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `party_cake`
--

-- --------------------------------------------------------

--
-- Table structure for table `category`
--

CREATE TABLE `category` (
  `ID` int(11) NOT NULL,
  `Description` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `category`
--

INSERT INTO `category` (`ID`, `Description`) VALUES
(1, 'Cake'),
(2, 'Cupcake'),
(3, 'Cheesecake'),
(4, 'Mudcake'),
(5, 'Wedding Cake'),
(6, 'Muffin'),
(7, 'Cookie');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `ID` int(11) NOT NULL,
  `FName` varchar(30) DEFAULT NULL,
  `LName` varchar(40) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `Suburb` varchar(30) DEFAULT NULL,
  `State` varchar(3) DEFAULT NULL,
  `Phone` char(10) DEFAULT NULL,
  `Descr` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`ID`, `FName`, `LName`, `Address`, `Suburb`, `State`, `Phone`, `Descr`) VALUES
(1, 'Ruby', 'Finsch', '31 Sale-Heyfield Road', 'ARAWATA', 'VIC', '0353415264', 'Has young daughter'),
(2, 'Gabrielle', 'Frater', '50 Monteagle Road', 'TURNER', 'ACT', '0261438295', 'Dislikes chocolate'),
(3, 'Christian', 'Bungaree', '83 Pipeclay Road', 'BROMBIN', 'NSW', '0267657054', 'Wants a cat'),
(4, 'Mason', 'Farnell', '44 Link Road', 'LOORANA', 'TAS', '0362302975', 'Does the cha cha'),
(5, 'Kayla', 'Winter', '25 Mnimbah Road', 'ALLYNBROOK', 'NSW', '0249554034', 'Collects pet rocks'),
(6, 'Chloe', 'Levey', '82 Brown Street', 'WILLOUGHBY EAST', 'NSW', '0297754125', 'Does not do the cha cha'),
(7, 'Poppy', 'Camidge', '63 Correa Place', 'NIGHTCLIFF', 'NT', '0889670567', 'Has a bad rash or something'),
(8, 'Sara', 'Caird', '85 Cunningham Street', 'YULEBA', 'QLD', '0745224247', 'Has nice hair');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `ID` int(11) NOT NULL,
  `FName` varchar(30) DEFAULT NULL,
  `LName` varchar(40) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `Suburb` varchar(30) DEFAULT NULL,
  `Salary` decimal(9,2) DEFAULT NULL,
  `StartDate` date DEFAULT NULL,
  `TFN` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`ID`, `FName`, `LName`, `Address`, `Suburb`, `Salary`, `StartDate`, `TFN`) VALUES
(1, 'Roger', 'Moore', '23 Wilcombe Way', 'BASSENDEAN', '33000.00', '2016-05-05', '2365418975'),
(2, 'Seth', 'Littler', '5 Farrar Parade', 'EGANU', '45000.00', '2017-02-25', '1548615478'),
(3, 'Owen', 'Holdsworth', '54 Walder Crescent', 'GOGANGO', '52000.00', '2016-05-18', '2458745365');

-- --------------------------------------------------------

--
-- Table structure for table `invoice`
--

CREATE TABLE `invoice` (
  `InvoiceNo` int(11) NOT NULL,
  `InvoiceDate` date DEFAULT NULL,
  `CustID` int(11) DEFAULT NULL,
  `EmpID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `invoice`
--

INSERT INTO `invoice` (`InvoiceNo`, `InvoiceDate`, `CustID`, `EmpID`) VALUES
(1, '2018-06-11', 2, 2),
(2, '2018-10-18', 4, 3),
(3, '2015-05-09', 5, 1),
(4, '2019-06-19', 6, 2);

-- --------------------------------------------------------

--
-- Table structure for table `invoice_line`
--

CREATE TABLE `invoice_line` (
  `InvoiceNo` int(11) NOT NULL DEFAULT '0',
  `ProdID` int(11) NOT NULL DEFAULT '0',
  `Qty` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `invoice_line`
--

INSERT INTO `invoice_line` (`InvoiceNo`, `ProdID`, `Qty`) VALUES
(1, 2, 2),
(2, 4, 1),
(3, 3, 1),
(4, 4, 3);

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `ID` int(11) NOT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `CategoryID` int(11) DEFAULT NULL,
  `CostPrice` decimal(5,2) DEFAULT NULL,
  `SuppID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`ID`, `Description`, `CategoryID`, `CostPrice`, `SuppID`) VALUES
(1, 'Chocolate Cake', 1, '25.15', 2),
(2, 'Chocolate Muffin', 6, '3.95', 1),
(3, 'Raspberry Cheesecake', 3, '28.95', 3),
(4, 'Dense Ganache Mudcake', 4, '26.75', 2);

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `ID` int(11) NOT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `Phone` char(10) DEFAULT NULL,
  `Address` varchar(50) DEFAULT NULL,
  `Suburb` varchar(30) DEFAULT NULL,
  `State` varchar(3) DEFAULT NULL,
  `Postcode` char(4) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`ID`, `Name`, `Phone`, `Address`, `Suburb`, `State`, `Postcode`) VALUES
(1, 'Chittering Bakery', '0415265147', '79 Point Walter Road', 'CHITTERING', 'WA', '6014'),
(2, 'Dog Kiss Desserts', '0895147841', '60 Barker Street', 'WOOGENELLUP', 'WA', '6324'),
(3, 'Seashell Sweetery', '0240002382', '70 Bathurst Road', 'NAPOLEON REEF', 'NSW', '2795'),
(4, 'Cabbagetown Bakery', '0730316083', '22 Martens Place', 'WYNNUM', 'QLD', '4178');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `category`
--
ALTER TABLE `category`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `invoice`
--
ALTER TABLE `invoice`
  ADD PRIMARY KEY (`InvoiceNo`),
  ADD KEY `CustID` (`CustID`),
  ADD KEY `EmpID` (`EmpID`);

--
-- Indexes for table `invoice_line`
--
ALTER TABLE `invoice_line`
  ADD PRIMARY KEY (`InvoiceNo`,`ProdID`),
  ADD KEY `ProdID` (`ProdID`);

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `CategoryID` (`CategoryID`),
  ADD KEY `SuppID` (`SuppID`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `category`
--
ALTER TABLE `category`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `invoice`
--
ALTER TABLE `invoice`
  MODIFY `InvoiceNo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `invoice`
--
ALTER TABLE `invoice`
  ADD CONSTRAINT `invoice_ibfk_1` FOREIGN KEY (`CustID`) REFERENCES `customer` (`ID`),
  ADD CONSTRAINT `invoice_ibfk_2` FOREIGN KEY (`EmpID`) REFERENCES `employee` (`ID`);

--
-- Constraints for table `invoice_line`
--
ALTER TABLE `invoice_line`
  ADD CONSTRAINT `invoice_line_ibfk_1` FOREIGN KEY (`InvoiceNo`) REFERENCES `invoice` (`InvoiceNo`),
  ADD CONSTRAINT `invoice_line_ibfk_2` FOREIGN KEY (`ProdID`) REFERENCES `product` (`ID`);

--
-- Constraints for table `product`
--
ALTER TABLE `product`
  ADD CONSTRAINT `product_ibfk_1` FOREIGN KEY (`CategoryID`) REFERENCES `category` (`ID`),
  ADD CONSTRAINT `product_ibfk_2` FOREIGN KEY (`SuppID`) REFERENCES `supplier` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
