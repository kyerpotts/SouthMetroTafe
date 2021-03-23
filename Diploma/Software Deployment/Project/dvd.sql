CREATE DATABASE dvd_search;

-- select the database just created
USE dvd_search;

-- create a table
CREATE TABLE movies_table (
	`id` INTEGER NOT NULL AUTO_INCREMENT,
	`title` VARCHAR(255),
	PRIMARY KEY (id)
);

-- insert records from CSV file
LOAD DATA INFILE "ENTER THE DIRECTORY OF THE CSV FILE HERE\TITLES.csv" INTO TABLE movies_table
FIELDS TERMINATED BY ','
ENCLOSED BY '"'
LINES TERMINATED by '\n'