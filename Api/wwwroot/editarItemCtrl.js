(function () {
    'use strict';

    angular
        .module('Api', [])
        .controller('editarItemCtrl', editarItemCtrl);

    editarItemCtrl.$inject = ['$http'];

    function editarItemCtrl($http) {
        var listarItemPorId = function (idItem) {
            return $http.get("https://localhost:44315/api/Item/getById?id=" + idItem).then(function (data) {
                $scope.item = data;
                console.log(idItem);
            });
            return listarItemPorId();
        }
    }
})();
