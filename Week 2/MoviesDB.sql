CREATE DATABASE MoviesDB;
GO -- break up commands into batches

CREATE SCHEMA Movies;
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
FROM Movies.Movie as m
INNER JOIN Movies.Genre as g ON m.GenreID = g.ID;

-- after scaffolding, let's change our data model in the db.
ALTER TABLE Movies.Movie
ADD ReleaseDate Date NULL;

-- computed columns
ALTER TABLE Movies.Movie
ADD ComputedName AS (Name + ' (' + CONVERT(VARCHAR, YEAR(ReleaseDate)) + ')');
-- can add PERSISTED so it's not recomputed every single time

--ALTER TABLE Movies.Movie
--DROP COLUMN ComputedName

UPDATE Movies.Movie
SET ReleaseDate = '2010-01-01';

SELECT * FROM Movies.Movie;
GO

-- views
-- readonly interface to our tables based on some select statement
CREATE VIEW Movies.NewReleases
AS
	SELECT * FROM Movies.Movie
	WHERE YEAR(ReleaseDate) > 2016;
GO

SELECT * FROM Movies.NewReleases;

-- variables
-- doesn't work but you can do something like this
DECLARE @table;
SELECT * INTO @table FROM Movies.Movie;
GO

-- functions
CREATE FUNCTION Movies.NumberOfYearMovies(@year INT)
RETURNS INT
AS
BEGIN
	DECLARE @result INT

	SELECT @result = COUNT(*) FROM Movies.Movie
	WHERE YEAR(ReleaseDate) = @year;

	RETURN @result
END
-- functions do not allow modifying data (side effects)
-- only reading data (select statement).

SELECT Movies.NumberOfYearMovies(2010); -- returns 1
SELECT Movies.NumberOfYearMovies(2011); -- returns 0

ALTER TABLE Movies.Movie
ADD DateModified DATETIME2;

SELECT * FROM Movies.Movie
GO

CREATE TRIGGER Movies.TR_Movie_DateModified
ON Movies.Movie
AFTER UPDATE
AS
	-- in here, we can see pseudo-tables "Inserted" and "Deleted"
	UPDATE Movies.Movie
	SET DateModified = GETDATE()
	WHERE ID IN (SELECT ID FROM Inserted)
	PRINT 'Updated'

-- fills in datemodified because of my trigger
UPDATE Movies.Movie
SET ReleaseDate = '1999-01-01'

SELECT * FROM Movies.Movie

-- we can trigger on INSERT, UPDATE, or DELETE
-- we'll be able to use Inserted, Deleted, or both

CREATE TRIGGER Movies.TR_Movie_ReplaceDeleting
ON Movies.Movie
INSTEAD OF DELETE
AS
	PRINT 'Replacing/preventing all deletes'

DELETE FROM Movies.Movie

SELECT * FROM Movies.Movie