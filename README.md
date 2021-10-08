# HobbyRadarAPI
C#/.NET Webapi for HobbyRadar project.
Notes: 
-This backend application is intended to be paired with the React frontend found here: https://github.com/rnandon/HobbyRadar
-This application will not function without a Private class. See further details below.

## Decription
This backend application provides the connection to the HobbyRadar database as well as curating the recommendations for the HobbyRadar platform. The application is built in ASP.NET Core, using Identity Framework, Entity Framework Core, Twilio API, and MailKit API. 

## Installation
To install this application, download the code and open the .csproj file. Once this is opened, additionally open the .sln file on the top level directory.
In Visual Studio, open a nuget package manager terminal, and run the command 'nuget install' to retrieve the necessary packages to the directory. 
After the packages are installed, the database will need to be initialized. Run the command 'update-database' to create and populate the database with the seed data. Note that the seed data contains no intentional references to any persons, real or fictitious. Any correlations are accidental and unintended. The seed data will populate the database with 40 users: 20 each in Minneapolis and Milwaukee. This is for demonstration and exploration purposes. A series of starter hobbies, tags, events, and user connections will be established as well to properly demonstrate the functionality of the platform.

After the database has been initialized, associated packages have been installed, and the Private class has been included in the Models directory, the application is ready to start! Enjoy, and feel free to provide feedback!

### Private class info
The private class is essential to the functioning of this application, and needs the following fields: Email, host, Port, Password, AccountSid, and AuthToken. These fields should be initialized in the constructor for the application to work properly. Email, Port, Host, and Password all refer to an email account used to send email notifications through the MailKit API. AccountSID and AuthToken refer to the same values of a valid Twilio API application. These values are not critical, but failure to provide legitimate values will result in the application not functioning as intended regarding user notifications.
