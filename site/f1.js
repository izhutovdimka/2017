$('document').ready(function(){
	$('.messageForm').hide();

	$('#btnToggle').on('click', function(event){
	$('.messageForm').fadeToggle();
	});
});
