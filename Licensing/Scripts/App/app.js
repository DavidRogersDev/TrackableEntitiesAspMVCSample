(function (parameters) {
    'use strict';

    var licensingApp = angular.module('licensing', ['ngRoute', 'kendo.directives']);

    var setUp = function ($http, $rootScope) {

        $http.defaults.headers.common["X-Requested-With"] = "XMLHttpRequest";

        // publish current transition direction on rootScope
        $rootScope.direction = 'ltr';
        // listen change start events

        $rootScope.$on('$routeChangeStart', function (event, next, current) {
            $rootScope.direction = 'rtl';
            // console.log(arguments);
            if (current && next && (current.depth > next.depth)) {
                $rootScope.direction = 'ltr';
            }
            // back
            $rootScope.back = function () {
                $window.history.back();
            };
        });

    };

    licensingApp.run(['$http', '$rootScope', setUp]);

})();

