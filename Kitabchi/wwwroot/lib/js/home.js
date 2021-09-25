function searchToggle(obj, evt){
  var container = $(obj).closest('.search-wrapper');
      if(!container.hasClass('active')){
          container.addClass('active');
          evt.preventDefault();
      }
      else if(container.hasClass('active') && $(obj).closest('.input-holder').length == 0){
          container.removeClass('active');
          // clear input
          container.find('.search-input').val('');
      }
};
$(document).ready(function(){
    $('.comments-content').slick({
      prevArrow: '.arrow-prev',
      nextArrow:'.arrow-next',
      dots:true,
      infinite:true,
      autoplay:true,
      autoplaySpeed: 2000
    });
  });

  $(document).ready(function(){
    $('.slider-content').slick({
      arrows:false,
      prevArrow: '.arrow-prev',
      nextArrow:'.arrow-next',
      autoplay:true,
      autoplaySpeed: 1000,
      slidesToShow:1
    })
  });

