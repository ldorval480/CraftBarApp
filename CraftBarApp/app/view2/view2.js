'use strict';

angular.module('craftBar.view2', [])


.controller('View2Ctrl', ['$scope', 'styleService', 'beerService', function($scope, styleService, beerService) {

    $scope.currentStyleCategory = null;

    styleService.getStyles().then(function(response){
      console.log(response.data)
      $scope.styles = response.data;
    });

    beerService.getBeers().then(function(response){
      //console.log(response.data)
      $scope.beers = response.data;
    });

    $scope.setCurrentStyleCategory =  function(style){
      $scope.currentStyleCategory = style;
      console.log($scope.currentStyleCategory)
    }

    $scope.isSelectedStyle = function(style){
      if($scope.currentStyleCategory == style)
        return true;
      else
        return false;
    };

    //console.log($scope.style)

}]);