(function (module) {
	'use strict';
	
	function itemService($http) {
		
		var fetch = function() {				
			return $http.get('/api/item/');		
		}
		
		var add = function(item) {
			return $http.post('/api/item/add', item);
		}
		
		var update = function(item) {
			return $http.post('/api/item/update', item);
		}
		
		var get = function(index) {
			return $http.get('/api/item/get/' + index);
		}
		
		return {
			fetch,
			add,
			update,
			get
		};
	}
	
	module.factory('itemService', itemService);
	
})(angular.module('pan-list'));
