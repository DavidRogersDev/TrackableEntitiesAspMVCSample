(function() {
    'use strict';

    angular.module('licensing').controller('editLicencesCtrl', function($scope, $http, $httpParamSerializer) {


        $http.post('/Edit/GetLicenceById/1')
            .success(function(data) {
                $scope.data = data;

                $scope.peopleDataSource = {
                    data: $scope.data.people,
                    change: function(e) {
                        
                    }
                };

                $scope.customOptions = {
                    dataSource: $scope.peopleDataSource,
                    dataTextField: 'firstName',
                    dataValueField: 'id',
                    placeholder: 'Select a person...',
                    optionLabel: 'Select a person...',
                    template: 'person : #= firstName # #=lastName #',
                    headerTemplate: '<div style="background-color: grey;">' +'<span>First Name</span>' +'<span> Last Name</span>' + '</div>'
                };

            });
        
        $scope.postLicenceFormSubmit = function() {

            //var encoder = formEncode();
            //var data = encoder(JSON.stringify($('form')));

            //$http.post('/Edit/EditLicence')
            //    .success(function (data) {
            //        $scope.data = data;
            //    });

            $http({
                method: 'POST',
                url: '/Edit/EditLicence',
                //headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
                //data: JSON.parse()
                data: $scope.data
                //data: $httpParamSerializer($scope.data)
            }).success(function(data) {
                $scope.data = data;
            });
        };

        $scope.flagModelAsChanged = function(model) {
            model.TrackingState = 2;
        };

        $scope.flagModelAsChangedKendo = function (allocation, kendoEvent) {
            
            allocation.trackingState = 2;
            allocation.personId = allocation.person.id;
            //$scope.$apply();
        };
    });
})();