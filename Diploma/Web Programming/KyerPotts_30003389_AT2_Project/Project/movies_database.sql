/*
	22/09/2019
	Kyer Potts
	30003389
*/


CREATE DATABASE movies_db;

USE movies_db;

CREATE TABLE movies_table (
	`id` INTEGER NOT NULL AUTO_INCREMENT,
	`title` VARCHAR(255),
	`studio` VARCHAR(255),
	`status` VARCHAR(255),
	`sound` VARCHAR(255),
	`versions` VARCHAR(255),
	`recretprice` VARCHAR(255),
	`rating` VARCHAR(255),
	`year` VARCHAR(255),
	`genre` VARCHAR(255),
	`aspect` VARCHAR(255),
	`searchedcount` INT(5),
	PRIMARY KEY (id)
);

LOAD DATA INFILE "C:/xampp/htdocs/Project/movies_with_searchcount.csv" INTO TABLE movies_table
FIELDS TERMINATED BY ','
ENCLOSED BY '"'
LINES TERMINATED by '\n'
IGNORE 1 LINES
(id, title, studio, status, sound, versions, recretprice, rating, year, genre, aspect, searchedcount);