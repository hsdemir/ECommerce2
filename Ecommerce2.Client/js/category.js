var categoryZone = angular.module("categories", []);

categoryZone.controller('categoryListController', function ($scope, $http) {

    $http.get("http://localhost:2917/api/Category/List")
        .then(function (response) {
            $scope.categories = response.data;
        }), function (error) {
            alert('Kategori listelenirken bir hata oluştu');
        }

});

categoryZone.controller("categoryAddController", function ($scope, $http) {

    $scope.submit = function () {

        var c = {
            'Id': 0,
            'Name': $scope.Name,
            'IsActive': $scope.IsActive,
            'Sort': $scope.Sort
        };

        $http({
            method: 'POST',
            url: 'http://localhost:2917/api/Category/Insert',
            data: JSON.stringify(c),
            headers: { 'Content-Type': 'application/json' },
        }).then(function () { });

    }


});