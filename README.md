# Building Application using the Web API Template

## Project Architecture

* Connected Services : Basically used to publish or host the Web APIs
* Dependencies : All the References, sdk, dll, nuget files are placed
* wwwroot : For Static files. e.g, html, css and JS files
* controllers : CRUD Data
* appsettings.json : connection string
* program.cs : Main method builds the Webhost and run the application.
* startup : Used by the Program.cs to run the Application
* ConfigureServices : This method gets called by the runtime. Use this method to add services to the container.

* Configure : Use the service added in "ConfigureServices"

## Rest and DB Operation

* Post <-> CREATE
* GET <-> READ
* PUT <-> UPDATE
* DELETE <-> DELETE
