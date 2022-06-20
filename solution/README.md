# powerplant-coding-challenge


## How to build !

The implementation is done in C# with ASP.NET Core Web API & Swagger for testing the application easily.
1) Open the solution in Visual Studio
2) Build the solution
3) Run the application on IIE Express via keyboard-shortcut F5 



#### Launch the API

1) The default browser will be launched, if not navigate to http://localhost:8888/swagger/index.html this is the swagger endpoint
2) Click on the "POST /ProductionPlan" button
3) Click on the "Try it out" button
4) Copy the content of the JSON file "payload1.json" from the "Data" directory of the project into the Request body using application/json mimetype
5) Click on the "Execute" button
6) The Server Response Body give you the result JSON data

#### response

The response should be a json that specify for each powerplant how much power each powerplant should deliver.

