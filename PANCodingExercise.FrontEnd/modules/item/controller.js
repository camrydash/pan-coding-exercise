(function (module) {
    'use strict';

    function itemAddController($location, itemService) {
        var self = this;
        self.model = {
            Name: '',
            DisplayName: '',
            Description: '',
            CreatedOn: new Date(Date.now())
        };
		
        self.save = function () {
            console.log('u');
		    return itemService.add(self.model).then(
			    function (response) {
			        if (!response.data.error && response.data.key > 0) {
			            $location.path('/');
			        }
			    });
		}

    }
	
	function itemEditController($location, $routeParams, itemService) {

		var self = this;
		
		self.itemIndex = $routeParams.id;
		
		console.log('index: ' + self.itemIndex);
		
		self.model = {};
		
		function get(id) {
		    return itemService.get(id).then(function (response) {
		        console.log(response.data);
			    if (response.data.item != undefined) {
			        self.model = response.data.item;
			    }
			});
		}
		
		self.save = function () {
			return itemService.update(self.model).then(
			function(response) {
			    if (!response.data.error && response.data.key > 0) {
			        $location.path('/');
			    }
			});
		}

		get(self.itemIndex);

    }
	
    function itemListController(itemService) {

		var self = this;
	
		function fetchAll() {
			return itemService.fetch().then(function(response) {
			    if (response.data.items != undefined) {
			        self.list = response.data.items;
			    }
				console.log(self.list);
			});
		}
		
		fetchAll();

    }	

    module
	.controller('itemAddController', itemAddController)
	.controller('itemEditController', itemEditController)
	.controller('itemListController', itemListController);

})(angular.module('pan-list'));
