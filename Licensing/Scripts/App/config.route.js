(function () {
    'use strict';

    var licensingApp = angular.module('licensing');

    // Collect the routes
    licensingApp.constant('routes', getRoutes());

    // Configure the routes and route resolvers
    licensingApp.config(['$routeProvider', 'routes', '$locationProvider', routeConfigurator]);

    function routeConfigurator($routeProvider, routes, $locationProvider) {

        routes.forEach(function (r) {
            $routeProvider.when(r.url, r.config);
        });

        $locationProvider.html5Mode(true);
        $routeProvider.otherwise({ redirectTo: '/home' });
    }

    // Define the routes 
    function getRoutes() {
        return [
            {
                url: '/home',
                config: {
                    templateUrl: '/Scripts/App/Templates/EditLicence.html',
                    controller: 'editLicencesCtrl'
                }
            }
        ];
    }
})();

