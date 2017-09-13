// script.js

// create the module and name it scotchApp
// also include ngRoute for all our routing needs
var vehicleApp = angular.module('vehicleApp', ['ngRoute']);

// configure our routes
vehicleApp.config(function ($routeProvider) {
    $routeProvider

        // route for the home page
        .when('/', {
            templateUrl: 'pages/home.html',
            controller: 'mainController'
        })

         // route for the new bike
         .when('/newbike', {
             templateUrl: 'pages/NewBike.html',
             controller: 'vehicleController'
         })

        // route for the new car
         .when('/newcar', {
             templateUrl: 'pages/NewCar.html',
             controller: 'vehicleController'
         })

        //route for the student form
        

});

// create the controller and inject Angular's $scope
vehicleApp.controller('mainController', function ($scope, $http, $location) {
    // create a message to display in our view
    $scope.message = 'Everyone come and see how good I look!';

    $scope.AddNewCar = function () //submit post event
    {
        $location.url('newcar');
    };

    $scope.AddNewBike = function () //submit post event
    {
        $location.url('newbike');
    };

    $scope.VehiclesData = [];

    $scope.PopulateVehicleData = function () {
        $http({
            method: 'POST',
            url: '/Home/PopulateVehiclesData',
            data: {}
        }).success(function (result) {
            $scope.VehiclesData = result;
        });
    };
    //Calling the function to load the data on pageload
    $scope.PopulateVehicleData();

    
});



vehicleApp.controller('vehicleController', function ($scope, $http, $location) {

   // var arrBooks = new Array();
    //$http.get("/Application/Get/").success(function (data) {

    //    $.map(data, function (item) {
    //        arrBooks.push(item.BookName);
    //    });

    //    $scope.list = arrBooks;
    //}).error(function (status) {
    //    alert(status);
    //});

    //$scope.selectedGenderList = null;
    $scope.carType = [];

    $scope.fillCarTypes = function () {
        $http({
            method: 'POST',
            url: '/Home/GetCarTypes',
            data: {}
        }).success(function (result) {
            $scope.carTypes = result;
        });
    };
    //Calling the function to load the data on pageload
    $scope.fillCarTypes();
    $scope.message = 'Add new car.';

    $scope.PostData = function () //submit post event
    {
        // use $.param jQuery function to serialize data from JSON 
        var data = $.param({
            fName: $scope.firstName,
            lName: $scope.lastName
        });

        var config = {
            headers: {
                'Content-Type': 'application/x-www-form-urlencoded;charset=utf-8;'
            }
        }

        $http.post('/Home/PostDataResponse', data, config)
            .success(function (data, status, headers, config) {
                $scope.PostDataResponse = data;
            })
            .error(function (data, status, header, config) {
                $scope.ResponseDetails = "Data: " + data +
                    "<hr />status: " + status +
                    "<hr />headers: " + header +
                    "<hr />config: " + config;
            });
    };

    $scope.Cancel = function () //submit post event
    {
        $location.url('/');
    };
    
});