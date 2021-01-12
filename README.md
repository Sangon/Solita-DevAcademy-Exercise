The application is made with ASP.NET on .NET core version 3.1
The end point of the API is at http://localhost:5000/Names

To run the already compiled project just run the Solita-DevAcademy-Exercise.exe located in the Build folder.

The project source can be found in the Solita-DevAcademy-Exercise folder.

The project has 4 different endpoints to pull data from.

 ## /Names/ByPopularity - Get list of names by their popularity

Example Query:
```
curl -X GET http://localhost:5000/Names/ByPopularity
```
Response: 
```
[
  {
    "name": "Ville",
    "amount": 24
  },
  {
    "name": "Antti",
    "amount": 22
  },
  {
    "name": "Mikko",
    "amount": 19
  }
  ...
]
 ```
 
 ## /Names/AlphabeticalOrder - Get a list of names in alphabetical order

Example Query:
```
curl -X GET http://localhost:5000/Names/AlphabeticalOrder
```
Response: 
```
[
  "Anna",
  "Antti",
  "Henna",
  "Janne",
  "Kati",
  "Liisa",
  "Mika",
  ...
]
```

 ## /Names/TotalAmount - Returns a sum of all the names in the list

Example Query:
```
curl -X GET http://localhost:5000/Names/TotalAmount
```
Response: 
```
211
```
 ## /Names/NameAmount/{nameParameter} - Returns the amount of {nameParameter}

Example Query:
```
curl -X GET http://localhost:5000/Names/NameAmount/Kati
```
Response: 
```
5
```