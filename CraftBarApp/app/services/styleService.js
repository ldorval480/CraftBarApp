/**
 * Created by ldorval on 11/30/2018.
 */
angular.module('craftBar.services.styleService', [])
.service('styleService', function($http){

    var styleService = {};

    styleService.getStyles = function() {
      var url = {FETCH: 'data/style.json'};
      return $http.get(url.FETCH);
    };

    return styleService;
  });