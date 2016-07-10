var trackingState = {
    Unchanged: 0,
    Added: 1,
    Modified: 2,
    Deleted: 3
};

(function () {
    'use strict';

    angular.module('licensing').controller('editLicencesCtrl', function($scope, $http) {


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

            $http({
                method: 'POST',
                url: '/Edit/EditLicence',
                data: $scope.data
            }).success(function(data) {
                $scope.data = data;
            });
        };

        $scope.flagModelAsChanged = function(model) {
            model.trackingState = trackingState.Modified;
        };

        $scope.flagModelAsChangedKendo = function (allocation, kendoEvent) {
            
            allocation.trackingState = trackingState.Modified;
            allocation.personId = allocation.person.id;
        };
    });
})();