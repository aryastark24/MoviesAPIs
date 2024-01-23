DataBase creation is present in the solution 

Dummy Data for insertion is also available 

Please find the Proof Of Concept docs in the repo as well

DB Scafolding is used for DBcontext 

Visual Studio 2022 with .net 6.0 is used for the solution 

Please install below nuget packages 

1.) Install-Package Microsoft.EntityFrameworkCore 

2.) Install-Package Microsoft.EntityFrameworkCore.Design 

3.) Install-Package Microsoft.EntityFrameworkCore.SqlServer


AIM of the Repo:-

● Implement an API endpoint to retrieve a movie with all details of the movie - actors, director, genre, reviews. 
API to hit https://localhost:7293/movies/1 -where 1 is the MovieID

● Implement an API endpoint to retrieve an actor with a list of all movies. 
ApI to hit https://localhost:7293/actor/1 -where 1 is the ActorID

● Implement an API endpoint to list all movies by a genre. 
API to Hit https://localhost:7293/genre/1 -where 1 is the GenreID
