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
