(function(){
	var app = angular.module('store',[]);

	app.controller('StoreController',function(){
		this.products = gems;
	});
	
	app.controller('GalleryController', function(){
		this.current = 0;
		this.setCurrent = function(newGallery){
		  this.current = newGallery || 0;
		};
	});
	
	app.controller('PanelController',function(){
		this.tab = 1;
		this.selectTab = function(setTab){
			this.tab = setTab;
		};
		this.isSelected = function(checkTab){
			return this.tab === checkTab;
		};		
	});
	
	var gems = [
		{
			name: 'Dodecahedron',
			price: 2,
			description:'Lorem Ipsum is simply dummy text of the printing and typesetting industry. ',
			canPurchase:true,
			souldOut:false,
			images:[
				{
					full:'blue-gem - Copy.png',
					thumb:'blue-gem-thumb - Copy.png'
				},
				{
					full:'blue-gem.png',
					thumb:'blue-gem-thumb.png'
				}
			]
		},
		{
			name: 'Pentagonal gem',
			price: 5.95,
			description:'Lorem Ipsum is simply dummy text of the printing',
			canPurchase:false,
			souldOut:false,
			images:[
				{
					full:'green-gem - Copy.png',
					thumb:'green-gem-thumb - Copy.png'
				},
				{
					full:'green-gem.png',
					thumb:'green-gem-thumb.png'
				}
			]
		}
	]
})();