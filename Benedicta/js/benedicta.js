$(window).scroll(function() {
    if ($(this).scrollTop() >= 50) {        // If page is scrolled more than 50px
        $("#return-to-top").fadeIn(200);    // Fade in the arrow
    } else {
        $('#return-to-top').fadeOut(200);   // Else fade out the arrow
    }
});
$("#return-to-top").click(function() {      // When arrow is clicked
    $("body,html").animate({
        scrollTop : 0                       // Scroll to top of body
    }, 1000);
});

$(window).scroll(function() {
    if ($(document).scrollTop() > 600) {
      $('#navbar-custom').addClass('color-change');
      document.querySelector("#navbar-custom").removeAttribute("style")
    } else {
      $('#navbar-custom').removeClass('color-change');
      document.querySelector("#navbar-custom").setAttribute("style","background:transparent !important");
    }
  });