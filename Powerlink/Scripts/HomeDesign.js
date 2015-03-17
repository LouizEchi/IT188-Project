$(document).ready(function () {

    $('#proceed_button').addClass("visibility-hidden").hide("slow", function () { });
    $('#login').addClass("visibility-hidden").hide("slow", function () { });
    $('#welcome-text').addClass("visibility-hidden").hide("slow", function () { });
    $('#to-text').addClass("visibility-hidden").hide("slow", function () { });
    $('#B-text').addClass("visibility-hidden").hide("slow", function () { });
    $('#M-text').addClass("visibility-hidden").hide("slow", function () { });
    $('#S-text').addClass("visibility-hidden").hide("slow", function () { });
    $('#phrase').addClass("visibility-hidden").hide("slow", function () { }).delay(100)
                .queue(function () {
                    $(this).removeClass("visibility-hidden");
                    $(this).fadeIn(300, function () { });

                    $('#welcome-text').delay(200)
                               .queue(function () {
                                   $(this).removeClass("visibility-hidden");
                                   $(this).fadeIn(200, function () { });
                                   $('#to-text').delay(200)
                                                     .queue(function () {
                                                         $(this).removeClass("visibility-hidden");
                                                         $(this).fadeIn(400, function () { });
                                                         $('#B-text').delay(200)
                                                                      .queue(function () {
                                                                          $(this).removeClass("visibility-hidden");
                                                                          $(this).show(400, function () { });
                                                                          $('#M-text').delay(400)
                                                                                       .queue(function () {
                                                                                           $(this).removeClass("visibility-hidden");
                                                                                           $(this).fadeIn(500, function () { });
                                                                                           $('#S-text').delay(400)
                                                                                                       .queue(function () {
                                                                                                           $(this).removeClass("visibility-hidden");
                                                                                                           $(this).fadeIn(700, function () { });
                                                                                                           $('#B-cont-text').delay(900)
                                                                                                                       .queue(function () {

                                                                                                                           $(this).fadeOut(200, function () { });
                                                                                                                           $('#M-cont-text').fadeOut(200, function () { });
                                                                                                                           $('#S-cont-text').fadeOut(200, function () { });
                                                                                                                           $('#phrase').delay(400)
                                                                                                                                       .queue(function () {

                                                                                                                                           $(this).animate({ 'marginLeft': '+=32px' });
                                                                                                                                           $(this).dequeue();
                                                                                                                                       });
                                                                                                                           $(this).dequeue();
                                                                                                                       });
                                                                                                           $(this).dequeue();
                                                                                                       });

                                                                                           $(this).dequeue();
                                                                                       });
                                                                          $(this).dequeue();
                                                                      });
                                                         $(this).dequeue();
                                                     });

                                   $(this).dequeue();
                               });


                    $('#login').delay(100)
                               .queue(function () {
                                   $(this).removeClass("visibility-hidden");
                                   $(this).fadeIn(200, function () {
                                       $('#register').hide("fast", function () { }).delay(300)
                                                  .queue(function () {
                                                      $(this).removeClass("visibility-hidden");
                                                      $(this).fadeIn(300, function () { });
                                                      $(this).dequeue();
                                                  });
                                   });
                                   $(this).dequeue();
                               });

                    $('#proceed_button').delay(100)
                               .queue(function () {
                                   $(this).removeClass("visibility-hidden");
                                   $(this).fadeIn(200, function () {
                                       $('#register').hide("slow", function () { }).delay(300)
                                                  .queue(function () {
                                                      $(this).removeClass("visibility-hidden")
                                                      $(this).fadeIn(300, function () { });
                                                      $(this).dequeue();
                                                  });
                                   });
                                   $(this).dequeue();
                               });


                    $(this).dequeue();
                });


    var form = $("#myFormId");
    var url = form.attr("action");
    var formData = form.serialize();
    $.post(url, formData, function (data) {
        $("#msg").html(data);
    });
});