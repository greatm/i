

$(function () {
    var accordionMenuIndex = parseInt(sessionStorage.getItem("accordionMenuIndex"));
    $("#accordionMenu").accordion({
        active: accordionMenuIndex,
        activate: function (event, ui) {
            var accordionMenuIndex = $("#accordionMenu").accordion("option", "active");
            sessionStorage.setItem("accordionMenuIndex", accordionMenuIndex);
        }
    });

});