# Training Website

## Purpose

This website was created by me to track my workout progress across days and weeks. Application allows for quick edits
and changes to each exercise I'm doing on the fly, so I don't have to worry about taking my mind off the training
while I'm doing it. Also, I've used Google Spreadsheets before for this purpose but there was just too much clicking 
for my liking.

## Demo

NOTE: I will add demo section when application is more complete.

## Building the application

To build the application, only thing you need is `dotnet`. Run following command to build it `dotnet build`.

## Running and debugging

If you would like to debug the application you must have running MySql server. Once database is running edit the
_Shared/AppDbContext.cs_ so that it points to your database.

```
// Change this line
var connectionString = "Server=192.168.18.5;Port=32768;Database=TrainingAppDb_DEV;User=root;Password=pass;";
```

Once this is set, you can apply all migrations to your database to make sure schema is correct. 
Make sure you have Entity Framework Tools installed.

```
dotnet tool install --global dotnet-ef
```

Then execute following command to apply migrations:

```
dotnet ef database update --project Shared/Shared.csproj
```

From now on, your database schema should be complete, and you can debug the application.

## TODO

[] Workout creator - right now, I need to add each workout day into database manually. It is fast to make one, but 
less intuitive and error-prone

[] Summary graph progress