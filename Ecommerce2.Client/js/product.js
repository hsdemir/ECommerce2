var productZone = angular.module("products", []);

productZone.controller('productListController', function ($scope, $http) {

    $http.get("http://localhost:2917/api/Product/List")
        .then(function (response) {
            $scope.products = response.data;
        }), function (error) {
            alert('Ürün listelenirken bir hata oluştu');
        }

});

productZone.controller("productAddController", function ($scope, $http) {

    $http.get("http://localhost:2917/api/Category/List")
    .then(function (response) {
        $scope.categories = response.data; console.log(response.data);
    }), function (error) {
        alert('Kategori listelenirken bir hata oluştu');
    }

    $scope.submit = function () {

        var p = {
            'Id': 0,
            'Name': $scope.Name,
            'Category.Id': $scope.categorySelect,
            'UnitinStock': $scope.UnitinStock,
            'Price': $scope.Price,
            'Vat': $scope.Vat,
        };

        $http({
            method: 'POST',
            url: 'http://localhost:2917/api/Product/Insert',
            data: JSON.stringify(p),
            headers: { 'Content-Type': 'application/json' },
        }).then(function () { });

    }

});