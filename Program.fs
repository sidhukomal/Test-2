// Define the discriminated union for genres
type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport

// Define the "Director" record type
type Director = {
    Name: string
    Movies: int
}
// Define the "Movie" record type
type Movie = {
    Name: string
    RunLength: int
    Genre: Genre
    Director: Director
    IMDBRating: float
}
// Create movie instances
let movies = [
    { Name = "CODA"; RunLength = 111; Genre = Drama; Director = { Name = "Sian Heder"; Movies = 9 }; IMDBRating = 8.1 }
    { Name = "Belfast"; RunLength = 98; Genre = Comedy; Director = { Name = "Kenneth Branagh"; Movies = 23 }; IMDBRating = 7.3 }
    { Name = "Dune"; RunLength = 155; Genre = Fantasy; Director = { Name = "Denis Villeneuve"; Movies = 24 }; IMDBRating = 8.1 }
    { Name = "King Richard"; RunLength = 144; Genre = Sport; Director = { Name = "Reinaldo Marcus Green"; Movies = 15 }; IMDBRating = 7.5 }
    { Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = { Name = "Paul Thomas Anderson"; Movies = 49 }; IMDBRating = 7.4 }
    { Name = "Nightmare Alley"; RunLength = 150; Genre = Thriller ; Director = { Name = "Guillermo Del Toro"; Movies = 22 }; IMDBRating = 7.1 }
]

// Identify probable Oscar winners
let oscarWinners = movies |> List.filter (fun movie -> movie.IMDBRating > 7.4)

printfn "Probable Oscar Winners: %A" oscarWinners

