var app = angular.module('app', []);
app.controller('clientController', ['$scope', '$http', clientController]);

function clientController($scope, $http) {
    $http.get('https://localhost:44315/api/Item/getAllItems').success(function (data) {
        $scope.listagemItems = data;
    }).error(function () {
        $scope.erro = "Erro ao exibir a listagem de itens.";
    });
}