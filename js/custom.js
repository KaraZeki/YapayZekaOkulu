/******************************************
    Version: 1.0
/****************************************** */
$(document).ready(function () {

	//Shy Panda
	$('.lds-facebook').hide();
	$('#TumrResimler').hide();
	$('#AyrilanResimler').hide();
	$('#contResimTestet').hide();
	$('#contButtonGrup').hide();
	$('#contTextMakEgit').hide();
	$('#contTestText').hide();

	$('#dancePanda').hide();
	$('#shamePanda').hide();


	$('#PostaciSO').hide();
	$('#PostaciOX').hide();
	$('#PostaciGU').hide();

	//Tourist İnfo
	//$('#contTextMakEgitTourist').hide();
	$('#tourisRehberTest').hide();

	$('#touristKategorileri').hide();


	//Kiwi or Stoat 

	// $('#contTextMakEgitKiwi').hide();
	// $('#TumrResimlerKiwi').hide();
	// $('#AyrilanResimlerKiwi').hide();
	// $('#contButtonGrupKiwi').hide();
	// $('#contTestTextKiwi').hide();
	//$('#contResimTestetKiwi').hide();

	$('#kiwiResimSecilmedi').show();
	$('#kalkımBilgisi').hide();
	$('#kiwiBilgisi').hide();



});

//Zeki Kiwi or stot eğitim container
$('#btnOlusturKiwi').on('click', function () {

	if (document.getElementById('projeAdiKiwi').value != "") {
		$('#contTextMakEgitKiwi').show();
		$('#TumrResimlerKiwi').show();
		$('#AyrilanResimlerKiwi').show();
		$('#contButtonGrupKiwi').show();
		

		$('#ldsProjeOlusturKiwi').show();
		$('#ldsProjeOlusturKiwi').fadeOut(2000);

		var projeadi = document.getElementById('projeAdiKiwi').value;
		document.getElementById('strongProjeAdiKiwi').innerHTML = projeadi;
	}
	else {
		alert("Proje adı boş olamaz !!")
	}

})

//zeki kiwi or stoat çalıştır butonu
$('#projeCalistirKiwi').on('click', function () {
	$('#contTestTextKiwi').show();

	$('#contResimTestetKiwi').show();
	

	$('#prjeCalistirKiwi').show();
	$('#prjeCalistirKiwi').fadeOut(2000);
})



// Fatih Postacı
// function readURLposta(input) {
// 	if (input.files && input.files[0]) {
// 		var reader = new FileReader();

// 		reader.onload = function (e) {
// 			$('#blah')
// 				.attr('src', e.target.result)
// 				.width(100)
// 				.height(100);

// 			var $a = document.getElementById("cardfotosec");
// 			var $img = $a.getElementsByTagName("img")[0];

// 			var PostaciSOp = ["PostacıSO.jpg", "avatar-01.jpg", "avatar-02.jpg", "avatar-03.jpg", "boy-717151_640.jpg", "c070e411ac.jpg", "images.jfif", "indir (1).jfif", "indir.jfif", "testi_01.png"];
// 			var PostaciOXp = ["images (1).jfif", "images (2).jfif", "images (3).jfif", "images (4).jfif", "images (5).jfif", "images (6).jfif", "indir (2).jfif", "indir (3).jfif", "indir (4).jfif", "indir (5).jfif"];
// 			var PostaciGUp = ["images (1).jfif", "images (2).jfif", "images (3).jfif", "images (4).jfif", "images (5).jfif", "images (6).jfif", "indir (2).jfif", "indir (3).jfif", "indir (4).jfif", "indir (5).jfif"];

// 			for (i = 0; i <= PostaciOXp.length; i++) {
// 				if (input.value.replace(/^.*[\\\/]/, '') == PostaciOXp[i]) {
// 					$('#Postaci').hide()
// 					$('#PostaciSO').hide();
// 					$('#PostaciOX').show();
// 					$('#PostaciGU').hide();
// 				}

// 			}

// 			//alert(input.value.replace(/^.*[\\\/]/, ''));
// 			for (y = 0; y <= PostaciGUp.length; y++) {
// 				if (input.value.replace(/^.*[\\\/]/, '') == PostaciGUp[y]) {

// 					$('#Postaci').hide()
// 					$('#PostaciSO').hide();
// 					$('#PostaciOX').hide();
// 					$('#PostaciGU').show();
// 				}
// 			}

// 			for (z = 0; y <= PostaciSOp.length; z++) {
// 				if (input.value.replace(/^.*[\\\/]/, '') == PostaciSOp[z]) {

// 					$('#Postaci').hide()
// 					$('#PostaciSO').show();
// 					$('#PostaciOX').hide();
// 					$('#PostaciGU').hide();
// 				}
// 			}

// 		};


// 		reader.readAsDataURL(input.files[0]);


// 	}
// }




//zeki turist eğtim container
$('#btnOlusturTurist').on('click', function () {

	if (document.getElementById('projeAdiTurist').value != "") {
		$('#touristKategorileri').show();

		$('#ldsProjeOlusturTurist').show();

		$('#ldsProjeOlusturTurist').fadeOut(2000);

		var projeadi = document.getElementById('projeAdiTurist').value;
		document.getElementById('strongProjeAdi').innerHTML = projeadi;
	}
	else {
		alert("Proje adı boş olamaz !!")
	}

})


//zeki turist rehberi çalıştır butonu
$('#projeCalistirTurist').on('click', function () {
	$('#tourisRehberTest').show();
})

//zeki metin ekleme******************************

var dizibitkiText=[];
$('#btnEkle8').on('click', function () {

	var bitkiText=document.getElementById('inputBitki').value;

	if(bitkiText=="")
	{
		alert("Boş Değer Girilemez");
	}
	else{
		document.getElementById('textBitki').innerHTML+=`</br>`+ bitkiText;
		dizibitkiText.push(bitkiText);
		document.getElementById('inputBitki').value="";

	}
	
	
});


//Ulkeler container
var diziulkelerText=[];
$('#btnEkle9').on('click', function () {

	var ulkelerText=document.getElementById('inputUlkeler').value;
	
	if(ulkelerText=="")
	{
		alert("Boş Değer Girilemez");
	}
	else{
		document.getElementById('txtUlkeler').innerHTML+=`</br>`+ ulkelerText;
		diziulkelerText.push(ulkelerText);
		document.getElementById('inputUlkeler').value="";
	}
	
});



//Gezi container
var dizigeziText=[];
$('#btnEkle11').on('click', function () {

	var geziText=document.getElementById('inputGezi').value;
	

	if(geziText=="")
	{
		alert("boş değer girilemez");
	}
	else{
		document.getElementById('txtGezi').innerHTML+=`</br>`+ geziText;
		dizigeziText.push(geziText);
		document.getElementById('inputGezi').value="";
	}

});


//Muhhabbet container
var dizimuhabbetText=[];
$('#btnEkle12').on('click', function () {

	var muhabbetText=document.getElementById('inputMuhabbet').value;

	if(muhabbetText=="")
	{
		alert("boş değer girilemez");
	}
	else{
		document.getElementById('txtMuhabbet').innerHTML+=`</br>`+ muhabbetText;
		dizimuhabbetText.push(muhabbetText)
		document.getElementById('inputMuhabbet').value="";
	}

});


/////////////////////////////////////////

//Meyve container
var dizimeyveText=[];
$('#btnEkle10').on('click', function () {

	var meyveText=document.getElementById('inputMeyve').value;
	
	if(meyveText=="")
	{
		alert("boş değer girilemez");
	}
	else{
		document.getElementById('txtMeyve').innerHTML+=`</br>`+ meyveText;
		dizimeyveText.push(meyveText);
		document.getElementById('inputMeyve').value="";
	}

});


//Hayvan counter
var dizihayvanText=[];
$('#btnEkle7').on('click', function () {

	var hayvanText=document.getElementById('inputHayvan').value;
	
	if(hayvanText=="")
	{
		alert("Boş Değer Girilemez");
	}
	else
	{
		document.getElementById('textHayvan').innerHTML+=`</br>`+ hayvanText;
		dizihayvanText.push(hayvanText);
		document.getElementById('inputHayvan').value="";
	}
	
	
});

//müze Container
var dizimuzeText = [];
$('#btnEkle7').on('click', function () {

	var muzeText = document.getElementById('inputMuze').value;

	if (muzeText == "") {
		alert("Boş Değer Girilemez");
	}
	else {
		document.getElementById('textMuze').innerHTML += `</br>` + muzeText;
		dizimuzeText.push(muzeText);
		document.getElementById('inputMuze').value = "";
	}


});

//balık container
var dizibalıkText = [];
$('#btnEkle2').on('click', function () {

	var balıkText = document.getElementById('inputBalık').value;

	if (balıkText == "") {
		alert("Boş Değer Girilemez");
	}
	else {
		document.getElementById('textBalık').innerHTML += `</br>` + balıkText;
		dizibalıkText.push(balıkText);
		document.getElementById('inputBalık').value = "";

	}


});

//deniz container
var dizidenizText = [];
$('#btnEkle3').on('click', function () {

	var denizText = document.getElementById('inputDeniz').value;

	if (denizText == "") {
		alert("Boş Değer Girilemez");
	}
	else {
		document.getElementById('txtDeniz').innerHTML += `</br>` + denizText;
		dizidenizText.push(denizText);
		document.getElementById('inputDeniz').value = "";
	}

});

//Yemek container
var diziyemekText = [];
$('#btnEkle4').on('click', function () {

	var yemekText = document.getElementById('inputYemek').value;

	if (yemekText == "") {
		alert("boş değer girilemez");
	}
	else {
		document.getElementById('txtYemek').innerHTML += `</br>` + yemekText;
		diziyemekText.push(yemekText);
		document.getElementById('inputYemek').value = "";
	}

});


//Otel container
var diziotelText = [];
$('#btnEkle5').on('click', function () {

	var otelText = document.getElementById('inputOtel').value;


	if (otelText == "") {
		alert("boş değer girilemez");
	}
	else {
		document.getElementById('txtOtel').innerHTML += `</br>` + otelText;
		diziotelText.push(otelText);
		document.getElementById('inputOtel').value = "";
	}

});


//Doğa container
var dizidogaText = [];
$('#btnEkle6').on('click', function () {

	var dogaText = document.getElementById('inputDoga').value;

	if (dogaText == "") {
		alert("boş değer girilemez");
	}
	else {
		document.getElementById('txtDoga').innerHTML += `</br>` + dogaText;
		dizidogaText.push(dogaText)
		document.getElementById('inputDoga').value = "";
	}

});






//Zeki chatbot
//links
//http://eloquentjavascript.net/09_regexp.html
//https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Regular_Expressions


var messages = [], //array that hold the record of each string in chat
	lastUserMessage = "", //keeps track of the most recent input string from the user
	botMessage = "", //var keeps track of what the chatbot is going to say
	botName = 'Murtaza', //name of the chatbot
	talking = true; //when false the speach function doesn't work
//

//edit this function to change what the chatbot says
function chatbotResponse() {
	talking = true;
	botMessage = "I'm confused"; //the default message


	for (i = 0; i <= dizimuzeText.length; i++) {
		if (lastUserMessage == dizimuzeText[i]) {
			botMessage = "Selam Bebek Mıgo Ben Kelebek";
		}

		if (lastUserMessage === 'name') {
			botMessage = 'My name is ' + botName;
		}
	}

	for (i = 0; i <= dizibalıkText.length; i++) {
		if (lastUserMessage == dizibalıkText[i]) {
			botMessage = "Hamsi Kafalu Ne Yabucaun";
		}

		if (lastUserMessage === 'name') {
			botMessage = 'My name is ' + botName;
		}
	}

	for (i = 0; i <= dizidenizText.length; i++) {
		if (lastUserMessage == dizidenizText[i]) {
			botMessage = "Yüzmen Lazım";
		}

		if (lastUserMessage === 'name') {
			botMessage = 'My name is ' + botName;
		}
	}

	for (i = 0; i <= diziyemekText.length; i++) {
		if (lastUserMessage == diziyemekText[i]) {
			botMessage = "AÇ Mısın";
		}

		if (lastUserMessage === 'name') {
			botMessage = 'My name is ' + botName;
		}
	}

	for (i = 0; i <= diziotelText.length; i++) {
		if (lastUserMessage == diziotelText[i]) {
			botMessage = "Otel Mi TRIVAGO";
		}

		if (lastUserMessage === 'name') {
			botMessage = 'My name is ' + botName;
		}
	}
	for (i = 0; i <= dizidogaText.length; i++) {
		if (lastUserMessage == dizidogaText[i]) {
			botMessage = "Ağrı DağınE	Eteğinde ";
		}

		if (lastUserMessage === 'name') {
			botMessage = 'My name is ' + botName;
		}
	
	
	}
	//Fatih Arıcılık
	for(i=0;i<=dizihayvanText.length;i++){
		if(lastUserMessage==dizihayvanText[i]){
			botMessage="Heyvanmı sormak istedin";
		}
		
	 if (lastUserMessage === 'name') {
	   botMessage = 'My name is ' + botName;
	 }

	}


	
	for(i=0;i<=dizibitkiText.length;i++){
		if(lastUserMessage==dizibitkiText[i]){
			botMessage="Bitkiler hakkında konuşalım";
		}
		
	 if (lastUserMessage === 'name') {
	   botMessage = 'My name is ' + botName;
	 }
	}
	
	
	for(i=0;i<=diziulkelerText.length;i++){
		if(lastUserMessage==diziulkelerText[i]){
			botMessage="Bu bir ülke";
		}
		
	 if (lastUserMessage === 'name') {
	   botMessage = 'My name is ' + botName;
	 }
	}
	
	for(i=0;i<=dizimeyveText.length;i++){
		if(lastUserMessage==dizimeyveText[i]){
			botMessage="AÇ Mısın";
		}
		
	 if (lastUserMessage === 'name') {
	   botMessage = 'My name is ' + botName;
	 }
	}
	
	for(i=0;i<=dizigeziText.length;i++){
		if(lastUserMessage==dizigeziText[i]){
			botMessage="Gezmeyide iyi biliyon";
		}
		
	 if (lastUserMessage === 'name') {
	   botMessage = 'My name is ' + botName;
	 }
	}
	
	
	for(i=0;i<=dizimuhabbetText.length;i++){
		if(lastUserMessage==dizimuhabbetText[i]){
			botMessage="Senle Muhabbet etmek güzel";
		}
		
	 if (lastUserMessage === 'name') {
	   botMessage = 'My name is ' + botName;
	 }
	 
	}
	
	//   if (lastUserMessage === 'hi' || lastUserMessage =='hello') {
	//     const hi = ['hi','howdy','hello']
	//     botMessage = hi[Math.floor(Math.random()*(hi.length))];;
	//   }

	//   if (lastUserMessage === 'name') {
	//     botMessage = 'My name is ' + botName;
	//   }

}

//
//this runs each time enter is pressed.
//It controls the overall input and output
function newEntry() {
	//if the message from the user isn't empty then run 
	if (document.getElementById("chatbox").value != "") {
		//pulls the value from the chatbox ands sets it to lastUserMessage
		lastUserMessage = document.getElementById("chatbox").value;
		//sets the chat box to be clear
		document.getElementById("chatbox").value = "";
		//adds the value of the chatbox to the array messages
		messages.push(lastUserMessage);
		//Speech(lastUserMessage);  //says what the user typed outloud
		//sets the variable botMessage in response to lastUserMessage
		chatbotResponse();
		//add the chatbot's name and message to the array messages
		messages.push("<b>" + botName + ":</b> " + botMessage);
		// says the message using the text to speech function written below
		Speech(botMessage);
		//outputs the last few array elements of messages to html
		for (var i = 1; i < 8; i++) {
			if (messages[messages.length - i])
				document.getElementById("chatlog" + i).innerHTML = messages[messages.length - i];
		}
	}
}

//text to Speech
//https://developers.google.com/web/updates/2014/01/Web-apps-that-talk-Introduction-to-the-Speech-Synthesis-API
function Speech(say) {
	if ('speechSynthesis' in window && talking) {
		var utterance = new SpeechSynthesisUtterance(say);
		//msg.voice = voices[10]; // Note: some voices don't support altering params
		//msg.voiceURI = 'native';
		//utterance.volume = 1; // 0 to 1
		//utterance.rate = 0.1; // 0.1 to 10
		//utterance.pitch = 1; //0 to 2
		//utterance.text = 'Hello World';
		//utterance.lang = 'en-US';
		speechSynthesis.speak(utterance);
	}
}

//runs the keypress() function when a key is pressed
document.onkeypress = keyPress;
//if the key pressed is 'enter' runs the function newEntry()
function keyPress(e) {
	var x = e || window.event;
	var key = (x.keyCode || x.which);
	if (key == 13 || key == 3) {
		//runs this function when enter is pressed
		newEntry();
	}
	if (key == 38) {
		console.log('hi')
		//document.getElementById("chatbox").value = lastUserMessage;
	}
}

//clears the placeholder text ion the chatbox
//this function is set to run when the users brings focus to the chatbox, by clicking on it
function placeHolder() {
	document.getElementById("chatbox").placeholder = "";
}



// Zeki Fotoğraf yükleme
var gulenSuratlar = ["author.jpg", "avatar-01.jpg", "avatar-02.jpg", "avatar-03.jpg", "boy-717151_640.jpg", "c070e411ac.jpg", "images.jfif", "indir (1).jfif", "indir.jfif", "testi_01.png"];
var utananSuratlar = ["images (1).jfif", "images (2).jfif", "images (3).jfif", "images (4).jfif", "images (5).jfif", "images (6).jfif", "indir (2).jfif", "indir (3).jfif", "indir (4).jfif", "indir (5).jfif"];

var Kalkim = ["kalkım1.jfif", "kalkım2.jfif", "kalkım3.jfif", "kalkım4.jfif", "kalkım5.jfif", "kalkım6.jfif", "kalkım7.jfif", "kalkım8.jfif","kalkım9.jfif", "kalkım10.jfif","kalkım11.jfif", "kalkım12.jfif","kalkım13.jfif", "kalkım14.jfif"];
var Kiwi = ["kiwi.jfif","kiwi1.jfif","kiwi2.jfif","kiwi3.jfif", "kiwi4.jfif", "kiwi5.jfif", "kiwi6.jfif", "kiwi7.jfif","kiwi8.jfif","kiwi9.jfif","kiwi10.jfif"];

function readURL(input) {
	if (input.files && input.files[0]) {
		var reader = new FileReader();

		reader.onload = function (e) {
			$('#blah')
				.attr('src', e.target.result)
				.width(100)
				.height(100);

			var $a = document.getElementById("cardfotosec");
			var $img = $a.getElementsByTagName("img")[0];

			
			for (i = 0; i <= gulenSuratlar.length; i++) {
				if (input.value.replace(/^.*[\\\/]/, '') == gulenSuratlar[i]) {
					$('#firsPanda').hide()
					$('#shamePanda').hide();
					$('#dancePanda').show();
				}

			}

			
			for (y = 0; y <= utananSuratlar.length; y++) {
				if (input.value.replace(/^.*[\\\/]/, '') == utananSuratlar[y]) {

					$('#firsPanda').hide();
					$('#shamePanda').show();
					$('#dancePanda').hide();
				}
			}

			for (x = 0; x <= Kalkim.length; x++) {
				if (input.value.replace(/^.*[\\\/]/, '') == Kalkim[x]) {

					$('#kiwiResimSecilmedi').hide();
					$('#kalkımBilgisi').show();
					$('#kiwiBilgisi').hide();
				
				}
			}

			
			for (z = 0; z <= Kiwi.length; z++) {
				if (input.value.replace(/^.*[\\\/]/, '') == Kiwi[z]) {

					$('#kiwiResimSecilmedi').hide();
					$('#kiwiBilgisi').show();
					$('#kalkımBilgisi').hide();
					
				
				}
			}

		};


		reader.readAsDataURL(input.files[0]);


	}
}




$('#btnOlustur').on('click', function () {

	var projeadi = document.getElementById('projeAdi').value;

	document.getElementById('strongProjeAdi').innerHTML = projeadi;
	$('#ldsProjeOlustur').show();

	$('#ldsProjeOlustur').fadeOut(2000);

	$('#TumrResimler').show();
	$('#AyrilanResimler').show();
	$('#contTextMakEgit').show();
	$('#contButtonGrup').show();


});


$('#projeCalistir').on('click', function () {

	$('.lds-facebook').show();

	$('.lds-facebook').fadeOut(2000);

	$('#contResimTestet').show();
	$('#contTestText').show();

});

$('#projeGerial').on('click', function () {

	location.reload();
});

//Drop-Drag İmage Mehmet Zeki KARA
function allowDrop(ev) {
	ev.preventDefault();
}

function drag(ev) {
	ev.dataTransfer.setData("text", ev.target.id);
}

function drop(ev) {
	ev.preventDefault();
	var data = ev.dataTransfer.getData("text");
	ev.target.appendChild(document.getElementById(data));
}




// image gallery
// init the state from the input
$(".image-checkbox").each(function () {
	if ($(this).find('input[type="checkbox"]').first().attr("checked")) {
		$(this).addClass('image-checkbox-checked');
	}
	else {
		$(this).removeClass('image-checkbox-checked');
	}
});

// sync the state to the input
$(".image-checkbox").on("click", function (e) {
	$(this).toggleClass('image-checkbox-checked');
	var $checkbox = $(this).find('input[type="checkbox"]');
	$checkbox.prop("checked", !$checkbox.prop("checked"))

	e.preventDefault();
});

(function ($) {
	"use strict";

    /* ==============================================
    Fixed menu
    =============================================== */

	$(window).on('scroll', function () {
		if ($(window).scrollTop() > 50) {
			//$('.top-navbar').addClass('fixed-menu');
		} else {
			//$('.top-navbar').removeClass('fixed-menu');
		}
	});

    /* ==============================================
    Back top
    =============================================== */
	jQuery(window).scroll(function () {
		if (jQuery(this).scrollTop() > 1) {
			jQuery('.dmtop').css({
				bottom: "10px"
			});
		} else {
			jQuery('.dmtop').css({
				bottom: "-100px"
			});
		}
	});

    /* ==============================================
	Loader -->
	=============================================== */

	$(window).load(function () {
		$("#preloader").on(500).fadeOut();
		$(".preloader").on(600).fadeOut("slow");
		$('.loader-container').addClass('done');
		$('.progress-br').addClass('done');
	});

	/* ==============================================
		Scroll to top  
	============================================== */

	if ($('#scroll-to-top').length) {
		var scrollTrigger = 100, // px
			backToTop = function () {
				var scrollTop = $(window).scrollTop();
				if (scrollTop > scrollTrigger) {
					$('#scroll-to-top').addClass('show');
				} else {
					$('#scroll-to-top').removeClass('show');
				}
			};
		backToTop();
		$(window).on('scroll', function () {
			backToTop();
		});
		$('#scroll-to-top').on('click', function (e) {
			e.preventDefault();
			$('html,body').animate({
				scrollTop: 0
			}, 700);
		});
	}

    /* ==============================================
     Fun Facts -->
     =============================================== */

	function count($this) {
		var current = parseInt($this.html(), 10);
		current = current + 50; /* Where 50 is increment */
		$this.html(++current);
		if (current > $this.data('count')) {
			$this.html($this.data('count'));
		} else {
			setTimeout(function () {
				count($this)
			}, 30);
		}
	}
	$(".stat_count, .stat_count_download").each(function () {
		$(this).data('count', parseInt($(this).html(), 10));
		$(this).html('0');
		count($(this));
	});

	/* ==============================================
     Bootstrap Touch Slider -->
     =============================================== */

	$('#carouselExampleControls').bsTouchSlider();

    /* ==============================================
     Tooltip -->
     =============================================== */
	$('[data-toggle="tooltip"]').tooltip()
	$('[data-toggle="popover"]').popover()

    /* ==============================================
     Contact -->
     =============================================== */
	jQuery(document).ready(function () {
		$('#contactform').submit(function () {
			var action = $(this).attr('action');
			$("#message").slideUp(750, function () {
				$('#message').hide();
				$('#submit')
					.after('<img src="images/ajax-loader.gif" class="loader" />')
					.attr('disabled', 'disabled');
				$.post(action, {
					first_name: $('#first_name').val(),
					last_name: $('#last_name').val(),
					email: $('#email').val(),
					phone: $('#phone').val(),
					select_service: $('#select_service').val(),
					select_price: $('#select_price').val(),
					comments: $('#comments').val(),
					verify: $('#verify').val()
				},
					function (data) {
						document.getElementById('message').innerHTML = data;
						$('#message').slideDown('slow');
						$('#contactform img.loader').fadeOut('slow', function () {
							$(this).remove()
						});
						$('#submit').removeAttr('disabled');
						if (data.match('success') != null) $('#contactform').slideUp('slow');
					}
				);
			});
			return false;
		});
	});

})(jQuery);


// Mehmet Zeki KARA

var // where files are dropped + file selector is opened
	dropRegion = document.getElementById("drop-region"),
	// where images are previewed
	imagePreviewRegion = document.getElementById("image-preview");


// open file selector when clicked on the drop region
var fakeInput = document.createElement("input");
fakeInput.type = "file";
fakeInput.accept = "image/*";
fakeInput.multiple = true;
dropRegion.addEventListener('click', function () {
	fakeInput.click();
});

fakeInput.addEventListener("change", function () {
	var files = fakeInput.files;
	handleFiles(files);
});


function preventDefault(e) {
	e.preventDefault();
	e.stopPropagation();
}

dropRegion.addEventListener('dragenter', preventDefault, false)
dropRegion.addEventListener('dragleave', preventDefault, false)
dropRegion.addEventListener('dragover', preventDefault, false)
dropRegion.addEventListener('drop', preventDefault, false)


function handleDrop(e) {
	var dt = e.dataTransfer,
		files = dt.files;

	if (files.length) {

		handleFiles(files);

	} else {

		// check for img
		var html = dt.getData('text/html'),
			match = html && /\bsrc="?([^"\s]+)"?\s*/.exec(html),
			url = match && match[1];



		if (url) {
			uploadImageFromURL(url);
			return;
		}

	}


	function uploadImageFromURL(url) {
		var img = new Image;
		var c = document.createElement("canvas");
		var ctx = c.getContext("2d");

		img.onload = function () {
			c.width = this.naturalWidth;     // update canvas size to match image
			c.height = this.naturalHeight;
			ctx.drawImage(this, 0, 0);       // draw in image
			c.toBlob(function (blob) {        // get content as PNG blob

				// call our main function
				handleFiles([blob]);

			}, "image/png");
		};
		img.onerror = function () {
			alert("Error in uploading");
		}
		img.crossOrigin = "";              // if from different origin
		img.src = url;
	}

}

dropRegion.addEventListener('drop', handleDrop, false);



function handleFiles(files) {
	for (var i = 0, len = files.length; i < len; i++) {
		if (validateImage(files[i]))
			previewAnduploadImage(files[i]);
	}
}

function validateImage(image) {
	// check the type
	var validTypes = ['image/jpeg', 'image/png', 'image/gif'];
	if (validTypes.indexOf(image.type) === -1) {
		alert("Invalid File Type");
		return false;
	}

	// check the size
	var maxSizeInBytes = 10e6; // 10MB
	if (image.size > maxSizeInBytes) {
		alert("File too large");
		return false;
	}

	return true;

}

function previewAnduploadImage(image) {

	// container
	var imgView = document.createElement("div");
	imgView.className = "image-view";
	imagePreviewRegion.appendChild(imgView);

	// previewing image
	var img = document.createElement("img");
	imgView.appendChild(img);

	// progress overlay
	var overlay = document.createElement("div");
	overlay.className = "overlay";
	imgView.appendChild(overlay);


	// read the image...
	var reader = new FileReader();
	reader.onload = function (e) {
		img.src = e.target.result;
	}
	reader.readAsDataURL(image);

	// create FormData
	var formData = new FormData();
	formData.append('image', image);

	// upload the image
	var uploadLocation = 'https://api.imgbb.com/1/upload';
	formData.append('key', 'bb63bee9d9846c8d5b7947bcdb4b3573');

	var ajax = new XMLHttpRequest();
	ajax.open("POST", uploadLocation, true);

	ajax.onreadystatechange = function (e) {
		if (ajax.readyState === 4) {
			if (ajax.status === 200) {
				// done!
			} else {
				// error!
			}
		}
	}

	ajax.upload.onprogress = function (e) {

		// change progress
		// (reduce the width of overlay)

		var perc = (e.loaded / e.total * 100) || 100,
			width = 100 - perc;

		overlay.style.width = width;
	}

	ajax.send(formData);

}