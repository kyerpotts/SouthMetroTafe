CREATE TABLE IF NOT EXISTS `country` (
  `country` char(20) NOT NULL,
  PRIMARY KEY (`country`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


CREATE TABLE IF NOT EXISTS `manufacturer` (
  `name` char(18) NOT NULL,
  `country` char(20) NOT NULL,
  `rating` char(2) NOT NULL,
  PRIMARY KEY (`name`),
  KEY `country` (`country`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;


ALTER TABLE `manufacturer`
  ADD CONSTRAINT `manufacturer_ibfk_1` FOREIGN KEY (`country`) REFERENCES `country` (`country`) ON DELETE CASCADE ON UPDATE CASCADE;