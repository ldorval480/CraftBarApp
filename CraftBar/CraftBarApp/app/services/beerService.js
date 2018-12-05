/**
 * Created by ldorval on 11/30/2018.
 */
angular.module('craftBar.services.beerService', [])
  .service('beerService', function($http){

    var beerService = {};

    beerService.getBeers = function() {
//      var url = {FETCH: 'data/beer.json'};
//      return $http.get(url.FETCH);
      return $http({
        method : 'GET',
        cache  : true,
        url    : 'http://craftbarapi.local:8000/api/beer'
      });
    };

    return beerService;
  });