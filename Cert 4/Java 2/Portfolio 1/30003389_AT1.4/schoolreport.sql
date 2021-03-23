DROP DATABASE IF EXISTS schoolreport;
CREATE DATABASE schoolreport;
USE schoolreport;
CREATE TABLE grades (Subject VARCHAR(20), Score INTEGER);
INSERT INTO grades(Subject, Score) VALUES ("English", 68), ("Maths", 75), ("Science", 88), ("History", 94);