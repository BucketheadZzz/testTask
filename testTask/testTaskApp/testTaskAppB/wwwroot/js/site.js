
// Задачу можно было бы просто через CSS сделать
$(function () {
    $(".hover-grid tbody tr").hover(function (e) {
          $(this).toggleClass("hover");
    });
});