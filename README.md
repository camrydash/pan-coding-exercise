# pan-coding-exercise

The exercise consists of 4 different sub projects: data layer, service layer, web api back-end & presentation layer. This app structure allows for separation of concerns. Each sub project is responsible for its own implementation. This allows us to create scalable applications since we can create multile front-end (mobile, desktop, web) applications using same project structure.

1. `PANCodingExercise.Data` contains entitity classes & mapping, migrations & database context. Change to the database is done using code-first methodology which allowed me to alter database from code.
1. `PANCodingExercise.Services` contains our service logic. 
1. `PANCodingExercise.Api` is the web api back-end. Services are injected injected into the controller & resolved on each http request. http requests are further delegated to service for processing requests. Contracts expose service methods.
1. `PANCodingExercise.FrontEnd` is the presentation layer where angularJS project is hosted.

pan-coding-exercise is hosted here: http://pancodingexercise.azurewebsites.net
