db = db.getSiblingDB("movies_db");

db.createUser({
    user: "svc_movie_catalog",
    pwd: "svc_movie_catalog",
    roles: [
      {
        role: 'readWrite', 
        db: 'movies_db'
      },
    ],
  });

db.createCollection("movies_collection");

db.movies_collection.insertMany([
  { 
    
  },
]);