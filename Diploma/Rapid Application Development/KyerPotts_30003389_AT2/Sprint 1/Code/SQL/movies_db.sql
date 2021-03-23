/*
	Date: 30/07/2019
  Name: Luke Gough
  Student ID: 30003918
*/

-- create a fresh database
CREATE DATABASE movies_db;

-- select the database just created
USE movies_db;

-- create a table
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

-- insert records from CSV file
LOAD DATA INFILE "C:/Temp/Movies _With_SearchedCount_Column.csv" INTO TABLE movies_table
FIELDS TERMINATED BY ','
ENCLOSED BY '"'
LINES TERMINATED by '\n'
IGNORE 1 LINES
(id, title, studio, status, sound, versions, recretprice, rating, year, genre, aspect, searchedcount);