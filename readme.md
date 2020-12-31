# [Dating App](https://datingapplaurie.herokuapp.com/)
[demo](https://datingapplaurie.herokuapp.com/)
## This application allows users to create a profile, add photos, do simple searches and message other users. It was built on ASP.NET core and Angular 10. Created following tutorial from Neil Cummings, TryCatchLearn.  
I originally started this using .NET core 3.1/Angular 8, but found I did not have enough Angular knowledge, so put it on pause, and learned Angular in more depth. When I came back to this project, it had been updated to .NET core, so I started it over. 

This app is best viewed on a full-sized screen.

### Created a walking skeleton using roll-your-own identity
* create the API
* create the Users entity, db, controller
* Add Angular as front-end

### Add nav bar, registration forms
* Note: The base of this project was done as a tutorial. Gender is listed as binary to make use of the ternary  operator. The most common use case will be men looking for women, hence the default looking for women.

### Use toastr for errors
* Add global exception handling

### Authentication is done using JWT tokens
* Initially hashing and salting the password, refactor to ASP.NET identity later

### Use Repository pattern

### Photo Upload using cloudinary API

### Messaging Feature

### Pagination was added to help with memory useage

### Users may like other users. These users then show up on a Likes page
* TODO: clicking again unlikes member

### Policy-based authorization 
* features used: ASP.NET Identity, route guards, modals

### SignalR for detection of if user is online, live messaging
* Refactor authenticaton using a query string, update CORS
* Refactored Messaging Feature to Use SignalR,
* Presence Tracker uses a Dictionary (in memory) of connection IDs, so rely on single server. Plan to update
* Use a thread lock on OnlineUsers
* User indicator color changes from black to green when user is online
* Track group members with a database, Add Group and List of connections entities

### Use Unit of work pattern

### Add modal for confirm window
* Create a service for the confirm window, add to route guard, delete message

### commit 98c2c75d0d1807a685d010ad2ab4db6fc8fec1e1 is the end of the tutorial.
Later commits are my additions to the project

### TODO:
* Refactor presence tracker to use Redis
* Like / unlike functionality
* Add in testing
* Make more responsive
* Add about page on how to use
* Add photo admin functinality - approve photos, message user status-awaiting approval, only uploader,admins can see photos until approved

NOTE: This app was made in .net5 on windows 10, and was tested in chrome, edge and firefox.
