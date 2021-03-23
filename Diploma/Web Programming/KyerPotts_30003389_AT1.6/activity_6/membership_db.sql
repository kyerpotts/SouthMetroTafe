CREATE database names_emails;
USE names_emails;
CREATE TABLE `data` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `firstname` varchar(20) NOT NULL,
  `surname` varchar(20) NOT NULL,
  `email` varchar(50) NOT NULL,
  PRIMARY KEY (id)
  );


INSERT INTO data(`firstname`,`surname`,`email`) VALUES
("John", "Kennedy", "jfk@headshot.com"),
("Donald", "Trump", "buildthewall@racist.com"),
("Bill", "Clinton", "cigarsarecool@lewisnki.com"),
("Hillary", "Clinton", "brokenmarriage@unsecuredemailserver.com"),
("George", "Bush", "illiteratechimp@teachmetoread.com")


