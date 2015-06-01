(function(){
	var app = angular.module('store',[]);

	app.controller('StoreController',function(){
		this.products = gems;
	});
	
	var gems = [
		{
			name: 'Dodecahedron',
			price: 2.95,
			description:'Lorem Ipsum is simply dummy text of the printing and typesetting industry. ',
			canPurchase:true,
			souldOut:false
		},
		{
		name: 'Pentagonal gem',
		price: 5.95,
		description:'Lorem Ipsum is simply dummy text of the printing',
		canPurchase:false,
		souldOut:false
	}
	]
})();