use caloriecounterDB;

CREATE TABLE Breakfast (
	id INTEGER PRIMARY KEY,
    BreakFastDate Date,
    Food varchar(255),
    Calorie decimal
);

CREATE TABLE Lunch (
	id INTEGER PRIMARY KEY,
    LunchDate Date,
    Food varchar(255),
    Calorie decimal
);

CREATE TABLE Dinner (
	id INTEGER PRIMARY KEY,
    DinnerDate Date,
    Food varchar(255),
    Calorie decimal
);

CREATE TABLE Snack (
	id INTEGER PRIMARY KEY,
    SnackDate Date,
    Food varchar(255),
    Calorie decimal
);

CREATE TABLE Exercise (
	id INTEGER PRIMARY KEY,
    ExerciseDate Date,
    ExerciseType varchar(255),
    Calorie decimal
);

CREATE TABLE Water (
	id INTEGER PRIMARY KEY,
    WaterDate Date,
    WaterAmount decimal
);