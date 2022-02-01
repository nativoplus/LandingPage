window.runInitScript = () => {
	/*-------------------------------------------------------------------------------
	   Detect mobile device 
	 -------------------------------------------------------------------------------*/
	var navbar = $('.js-navbar:not(.navbar-fixed)');
	$('.loader').fadeOut(1000);

	/*-------------------------------------------------------------------------------
	  Navbar 
	-------------------------------------------------------------------------------*/

	navbar.affix({
		offset: {
			top: 50
		}
	});
	navbar.on('affix.bs.affix', function () {
		if (!navbar.hasClass('affix')) {
			navbar.addClass('animated slideInDown');
		}
	});

	navbar.on('affixed-top.bs.affix', function () {
		navbar.removeClass('animated slideInDown');

	});

	$('.nav-mobile-list li a[href="#"]').on('click', function () {
		$(this).closest('li').toggleClass('current');
		$(this).closest('li').children('ul').slideToggle(200);
		return false;
	});



	/*-------------------------------------------------------------------------------
	  Menu
	-------------------------------------------------------------------------------*/



	$('.navbar-toggle').on('click', function () {
		$('body').removeClass('menu-is-closed').addClass('menu-is-opened');
	});

	$('.close-menu, .click-capture').on('click', function () {
		$('body').removeClass('menu-is-opened').addClass('menu-is-closed');
		$('.menu-list ul').slideUp(300);
	});





	/*-------------------------------------------------------------------------------
	  Full screen sections 
	-------------------------------------------------------------------------------*/



	if ($('.pagepiling').length > 0) {
		$('.pagepiling').pagepiling({
			scrollingSpeed: 280,
			loopBottom: true,
			anchors: ['page1', 'page2', 'page3', 'page4', 'page5', 'page6', 'page7'],
			afterLoad: function (anchorLink, index) {
				if ($('.pp-section.active').scrollTop() > 0) {
					$('.navbar').removeClass('navbar-white');
				}
				else {
					$('.navbar').addClass('navbar-white');
				}
			}
		});



		/*-------------------------------------------------------------------------------
		   Scroll into sections 
		/-------------------------------------------------------------------------------*/



		$('.pp-scrollable').on('scroll', function () {
			var scrollTop = $(this).scrollTop();
			if (scrollTop > 0) {
				$('.navbar-2').removeClass('navbar-white');
			}
			else {
				$('.navbar-2').addClass('navbar-white');
			}
		});



		/*-------------------------------------------------------------------------------
		   Scroller navigation
		/-------------------------------------------------------------------------------*/



		$('#pp-nav').remove().appendTo('body').addClass('white right-boxed hidden-xs');

		$('.pp-nav-up').on('click', function () {
			$.fn.pagepiling.moveSectionUp();
		});

		$('.pp-nav-down').on('click', function () {
			$.fn.pagepiling.moveSectionDown();
		});
	}



	/*-------------------------------------------------------------------------------
	  Change bacgkround on project section
	-------------------------------------------------------------------------------*/



	$('.project-box').on('mouseover', function () {
		var index = $('.project-box').index(this);
		$('.bg-changer .section-bg').removeClass('active').eq(index).addClass('active');
	});




	/*-------------------------------------------------------------------------------
	  Owl Carousel
	-------------------------------------------------------------------------------*/





	var sync1 = $("#sync1");
	var sync2 = $("#sync2");
	var slidesPerPage = 4; //globaly define number of elements per page
	var syncedSecondary = true;

	sync1.owlCarousel({
		items: 1,
		slideSpeed: 2000,
		nav: false,
		autoplay: false,
		dots: false,
		loop: false,
		responsiveRefreshRate: 200,
		navText: ['<svg width="100%" height="100%" viewBox="0 0 11 20"><path style="fill:none;stroke-width: 1px;stroke: #000;" d="M9.554,1.001l-8.607,8.607l8.607,8.606"/></svg>', '<svg width="100%" height="100%" viewBox="0 0 11 20" version="1.1"><path style="fill:none;stroke-width: 1px;stroke: #000;" d="M1.054,18.214l8.606,-8.606l-8.606,-8.607"/></svg>'],
	}).on('changed.owl.carousel', syncPosition);

	sync2
		.on('initialized.owl.carousel', function () {
			sync2.find(".owl-item").eq(0).addClass("current");
		})
		.owlCarousel({
			items: slidesPerPage,
			dots: false,
			nav: false,
			smartSpeed: 200,
			slideSpeed: 500,
			slideBy: slidesPerPage, //alternatively you can slide by 1, this way the active slide will stick to the first item in the second carousel
			responsiveRefreshRate: 100
		}).on('changed.owl.carousel', syncPosition2);

	function syncPosition(el) {
		//if you set loop to false, you have to restore this next line
		//var current = el.item.index;

		//if you disable loop you have to comment this block
		var count = el.item.count - 1;
		var current = Math.round(el.item.index - (el.item.count / 2) - .5);

		if (current < 0) {
			current = count;
		}
		if (current > count) {
			current = 0;
		}

		//end block

		sync2
			.find(".owl-item")
			.removeClass("current")
			.eq(current)
			.addClass("current");
		var onscreen = sync2.find('.owl-item.active').length - 1;
		var start = sync2.find('.owl-item.active').first().index();
		var end = sync2.find('.owl-item.active').last().index();

		if (current > end) {
			sync2.data('owl.carousel').to(current, 100, true);
		}
		if (current < start) {
			sync2.data('owl.carousel').to(current - onscreen, 100, true);
		}
	}

	function syncPosition2(el) {
		if (syncedSecondary) {
			var number = el.item.index;
			sync1.data('owl.carousel').to(number, 100, true);
		}
	}

	sync2.on("click", ".owl-item", function (e) {
		e.preventDefault();
		var number = $(this).index();
		sync1.data('owl.carousel').to(number, 300, true);
	});
};

