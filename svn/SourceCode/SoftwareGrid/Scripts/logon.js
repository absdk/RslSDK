/// <reference path="jquery-1.6.2-vsdoc.js" />
/// <reference path="jquery-ui-1.8.11.js" />
$(document).ready(function () {
    // Unlock Slider	
    $(".slider_unlock").slider({
        value: "0",
        range: "min",
        animate: true,
        stop: unlocked,
        slide: fixBounds,
        change: fixBounds,
        create: unlockMsg
    });

    function unlockMsg() {
        var unlockMessage = $(this).attr("title");
        $(this).append('<div class="unlock_message">' + unlockMessage + '</div>');
    }
    function fixBounds() {
        var value = $(this).slider("value");
        var fixMargin = (value / 100 * -30);
        $(this).find(".ui-slider-handle").css("margin-left", fixMargin + "px");
    }
    function unlocked(e, ui) {
        if ($(this).slider("value") > 95) {
            $(this).siblings("button, input").trigger("click");
            $(this).find(".ui-slider-handle").delay(500).animate({
                left: 0,
                "margin-left": 0
            }, 350);
            $(this).find(".ui-slider-range").delay(500).animate({ width: 0 });
        }
        else {
            $(this).find(".ui-slider-handle").animate({
                left: 0,
                "margin-left": 0
            }, 350);
            $(this).find(".ui-slider-range").animate({ width: 0 });
        }
    }
});