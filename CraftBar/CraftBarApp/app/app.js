'use strict';

// Declare app level module which depends on views, and core components
angular.module('craftBar', [
  'ngRoute',
  'craftBar.home',
  'craftBar.view2',
  'craftBar.services.styleService',
  'craftBar.services.beerService'
]).
config(['$locationProvider', '$routeProvider', function($locationProvider, $routeProvider) {
  $locationProvider.hashPrefix('!');


  $routeProvider
    .when('/home', {
      templateUrl: 'view1/view1.html',
      controller: 'homeCtrl'
    })
    .when('/view2', {
      templateUrl: 'view2/view2.html',
      controller: 'View2Ctrl'
    })
    .otherwise({redirectTo: '/home'});
}]);

