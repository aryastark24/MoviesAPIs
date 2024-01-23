use MovieDatabase
-- Insert dummy values into Directors table
INSERT INTO Directors (Name) VALUES ('Christopher Nolan');
INSERT INTO Directors (Name) VALUES ('Quentin Tarantino');

-- Insert dummy values into Actors table
INSERT INTO Actors (Name) VALUES ('Leonardo DiCaprio');
INSERT INTO Actors (Name) VALUES ('Brad Pitt');
INSERT INTO Actors (Name) VALUES ('Scarlett Johansson');

-- Insert dummy values into Genres table
INSERT INTO Genres (Name) VALUES ('Action');
INSERT INTO Genres (Name) VALUES ('Drama');
INSERT INTO Genres (Name) VALUES ('Science Fiction');

-- Insert dummy values into Movies table
INSERT INTO Movies (Title, DirectorId) VALUES ('Inception', 1);
INSERT INTO Movies (Title, DirectorId) VALUES ('Pulp Fiction', 2);
INSERT INTO Movies (Title, DirectorId) VALUES ('Batman begins', 1);

-- Insert dummy values into ActorMovies table
INSERT INTO ActorMovies (ActorId, MovieId) VALUES (1, 1);
INSERT INTO ActorMovies (ActorId, MovieId) VALUES (2, 2);
INSERT INTO ActorMovies (ActorId, MovieId) VALUES (3, 1);
INSERT INTO ActorMovies (ActorId, MovieId) VALUES (1, 3);

-- Insert dummy values into MovieGenres table
INSERT INTO MovieGenres (MovieId, GenreId) VALUES (1, 1);
INSERT INTO MovieGenres (MovieId, GenreId) VALUES (1, 3);
INSERT INTO MovieGenres (MovieId, GenreId) VALUES (2, 2);
INSERT INTO MovieGenres (MovieId, GenreId) VALUES (1, 1);

-- Insert dummy values into Reviews table
INSERT INTO Reviews (Text, MovieId) VALUES ('Awesome movie!', 1);
INSERT INTO Reviews (Text, MovieId) VALUES ('Classic!', 2);