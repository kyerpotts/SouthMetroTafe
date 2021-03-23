CREATE DATABASE `quote_db`;

CREATE TABLE `quote_table` (
`id` INTEGER NOT NULL AUTO_INCREMENT,
`quote` VARCHAR(255),
PRIMARY KEY (`id`)
);

INSERT INTO `quote_table` (`quote`)
VALUES
("You know youre in love when you cant fall asleep because reality is finally better than your dreams. - Dr. Seuss"),
("Get busy living or get busy dying. Stephen King"),
("The first step toward success is taken when you refuse to be a captive of the environment in which you first find yourself. - Mark Caine"),
("When one door of happiness closes, another opens, but often we look so long at the closed door that we do not see the one which has been opened for us. - Helen Keller"),
("Twenty years from now you will be more disappointed by the things that you didnt do than by the ones you did do. - Mark Twain"),
("When I dare to be powerful - to use my strength in the service of my vision, then it becomes less and less important whether I am afraid. - Audre Lorde"),
("Great minds discuss ideas, average minds discuss events, small minds discuss people. - Eleanor Roosevelt"),
("A successful man is one who can lay a firm foundation with the bricks others have thrown at him. - David Brinkley"),
("Those who dare to fail miserably can achieve greatly. - John F. Kennedy"),
("I cant give you a sure-fire formula for success, but I can give you a formula for failure, try to please everybody all the time. - Herbert Bayard Swope");