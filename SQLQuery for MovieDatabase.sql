CREATE DATABASE MovieDatabase;
use MovieDatabase
-- Create tables
CREATE TABLE Directors (
    DirectorId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50) NOT NULL
);

CREATE TABLE Actors (
    ActorId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50) NOT NULL
);

CREATE TABLE Genres (
    GenreId INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50) NOT NULL
);

CREATE TABLE Movies (
    MovieId INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(100) NOT NULL,
    DirectorId INT FOREIGN KEY REFERENCES Directors(DirectorId),
    CONSTRAINT UC_Title UNIQUE (Title)
);

CREATE TABLE ActorMovies (
    ActorId INT,
    MovieId INT,
    PRIMARY KEY (ActorId, MovieId),
    FOREIGN KEY (ActorId) REFERENCES Actors(ActorId),
    FOREIGN KEY (MovieId) REFERENCES Movies(MovieId)
);

CREATE TABLE MovieGenres (
    MovieId INT,
    GenreId INT,
    PRIMARY KEY (MovieId, GenreId),
    FOREIGN KEY (MovieId) REFERENCES Movies(MovieId),
    FOREIGN KEY (GenreId) REFERENCES Genres(GenreId)
);

CREATE TABLE Reviews (
    ReviewId INT PRIMARY KEY IDENTITY(1,1),
    Text NVARCHAR(500) NOT NULL,
    MovieId INT FOREIGN KEY REFERENCES Movies(MovieId),
    CONSTRAINT CK_ReviewText CHECK (LEN(Text) <= 500)
);