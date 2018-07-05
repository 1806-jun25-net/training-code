CREATE DATABASE MoviesDB;
GO -- break up commands into batches

CREATE SCHEMA Movies; -- schema is a collection of tables, separated by function
GO

CREATE TABLE Movies.Movie
(
	ID INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(128) NOT NULL,
	GenreID INT NOT NULL
);

CREATE TABLE Movies.Genre
(
	ID INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(128) NOT NULL
);

ALTER TABLE Movies.Movie
ADD CONSTRAINT FK_Movie_Genre FOREIGN KEY (GenreID) REFERENCES Movies.Genre(ID);

INSERT INTO Movies.Genre
VALUES ('Action');

SELECT * FROM Movies.Genre;

INSERT INTO Movies.Movie
VALUES ('Incredibles 2', 1);

SELECT * FROM Movies.Movie;

SELECT *
FROM Movies.Movie AS m
INNER JOIN Movies.Genre AS g ON m.GenreID = g.ID;

-- after scaffolding, let's change our data model in the db

ALTER TABLE Movies.Movie
ADD ReleaseDate Date NULL;










