Installation

1) Open appsettings.json and update "ConnectionStrings" with your MSSQL connection.

2) open PS in folder 

3) dotnet ef database update --project ../CarAdverts.Repository/CarAdverts.Repository.csproj

4) dotnet run

Using:

        To add a new advertisement, send a POST request to /api/caradverts with the JSON body of the advertisement.

        To get a list of all advertisements, send a GET request to /api/caradverts.

        To get a specific advertisement, send a GET request to /api/caradverts/{id}.

        To update an advertisement, send a PUT request to /api/caradverts with the JSON body of the advertisement.

        To delete an advertisement, send a DELETE request to /api/caradverts/{id}.

Note:
The service supports handling CORS requests from any domain.
