// app.js
/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
* * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
(function() {
	
	angular
	.module('pan-list', ['ngRoute'])
	.config(function($routeProvider) {
		$routeProvider
			.when('/', {
				controller: 'itemListController as itemList',
				templateUrl: 'modules/item/views/itemList.html'
			})
			.when('/edit/:id', {
				controller:'itemEditController as itemDetail',
				templateUrl: 'modules/item/views/itemDetail.html'
			})
			.when('/add', {
			    controller: 'itemAddController as itemDetail',
				templateUrl: 'modules/item/views/itemDetail.html'
			});
	});
	
})();