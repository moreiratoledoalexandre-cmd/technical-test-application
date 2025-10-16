db = db.getSiblingDB("movies_db");

db.createUser({
  user: "svc_movie_catalog",
  pwd: "svc_movie_catalog",
  roles: [
    {
      role: "readWrite",
      db: "movies_db",
    },
  ],
});

db.createCollection("movies_collection");

db.movies_collection.insertMany([
  {
    title: "Inception",
    year: 2010,
    genre: ["Action", "Sci-Fi", "Thriller"],
    director: {
      name: "Christopher Nolan",
      birth_year: 1970,
      nationality: "British-American",
    },
    cast: [
      { name: "Leonardo DiCaprio", role: "Dom Cobb" },
      { name: "Joseph Gordon-Levitt", role: "Arthur" },
      { name: "Elliot Page", role: "Ariadne" },
    ],
    duration_minutes: 148,
    language: ["English", "Japanese", "French"],
    country: ["USA", "UK"],
    imdb_rating: 8.8,
    box_office: {
      budget: 160000000,
      gross_worldwide: 829895144,
      currency: "USD",
    },
    release_date: { $date: "2010-07-16T00:00:00Z" },
    created_at: { $date: "2025-10-16T12:00:00Z" },
  },
  {
    title: "The Matrix",
    year: 1999,
    genre: ["Action", "Sci-Fi"],
    director: {
      name: "Lana Wachowski & Lilly Wachowski",
      birth_year: 1965,
      nationality: "American",
    },
    cast: [
      { name: "Keanu Reeves", role: "Neo" },
      { name: "Laurence Fishburne", role: "Morpheus" },
      { name: "Carrie-Anne Moss", role: "Trinity" },
    ],
    duration_minutes: 136,
    language: ["English"],
    country: ["USA"],
    imdb_rating: 8.7,
    box_office: {
      budget: 63000000,
      gross_worldwide: 466364845,
      currency: "USD",
    },
    release_date: { $date: "1999-03-31T00:00:00Z" },
    created_at: { $date: "2025-10-16T12:00:00Z" },
  },
  {
    title: "Interstellar",
    year: 2014,
    genre: ["Adventure", "Drama", "Sci-Fi"],
    director: {
      name: "Christopher Nolan",
      birth_year: 1970,
      nationality: "British-American",
    },
    cast: [
      { name: "Matthew McConaughey", role: "Cooper" },
      { name: "Anne Hathaway", role: "Brand" },
      { name: "Jessica Chastain", role: "Murph" },
    ],
    duration_minutes: 169,
    language: ["English"],
    country: ["USA", "UK", "Canada"],
    imdb_rating: 8.6,
    box_office: {
      budget: 165000000,
      gross_worldwide: 701729206,
      currency: "USD",
    },
    release_date: { $date: "2014-11-07T00:00:00Z" },
    created_at: { $date: "2025-10-16T12:00:00Z" },
  },
  {
    title: "Parasite",
    year: 2019,
    genre: ["Drama", "Thriller"],
    director: {
      name: "Bong Joon-ho",
      birth_year: 1969,
      nationality: "South Korean",
    },
    cast: [
      { name: "Song Kang-ho", role: "Kim Ki-taek" },
      { name: "Lee Sun-kyun", role: "Park Dong-ik" },
      { name: "Cho Yeo-jeong", role: "Choi Yeon-gyo" },
    ],
    duration_minutes: 132,
    language: ["Korean", "English"],
    country: ["South Korea"],
    imdb_rating: 8.5,
    box_office: {
      budget: 11400000,
      gross_worldwide: 263100000,
      currency: "USD",
    },
    release_date: { $date: "2019-05-30T00:00:00Z" },
    created_at: { $date: "2025-10-16T12:00:00Z" },
  },
  {
    title: "The Godfather",
    year: 1972,
    genre: ["Crime", "Drama"],
    director: {
      name: "Francis Ford Coppola",
      birth_year: 1939,
      nationality: "American",
    },
    cast: [
      { name: "Marlon Brando", role: "Don Vito Corleone" },
      { name: "Al Pacino", role: "Michael Corleone" },
      { name: "James Caan", role: "Sonny Corleone" },
    ],
    duration_minutes: 175,
    language: ["English", "Italian"],
    country: ["USA"],
    imdb_rating: 9.2,
    box_office: {
      budget: 6000000,
      gross_worldwide: 250000000,
      currency: "USD",
    },
    release_date: { $date: "1972-03-24T00:00:00Z" },
    created_at: { $date: "2025-10-16T12:00:00Z" },
  },
]);
