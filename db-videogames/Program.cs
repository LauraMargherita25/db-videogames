// See https://aka.ms/new-console-template for more information


// VIDEOGAMES
// id: int
// title: varchar
// description: text
// releseDate: date
// FK softwareHouse_id: int


// VIDEGAME CATEGORY
// id: int
// name: varchar

// PLATFORMS
// id: int
// name: varchar
// model: varchar

// VIDEGAME LABELS
// id: int
// type: varchar


// SOFTWARE HOUSES
// id: int
// name: varchar
// paritaIva: smallint
// city: varchar
// nation: varchar


//TOURNAMENTS
// id: int
// title: varchar
// year: year
// city:  varchar
// FK videogame_id: int

//PLAYERS
// id: int
// name: varchar
// surname: varchar
// nikname: varchar
// nationality: varchar

// AWARDS
// id: int
// title: varchar
//tabella pivot awards_videogames con year

//REVIEWS
// id: int
// title: varchar
// description: text
// rating: int
// FK vidogame_id: int
// FK playr_id: int