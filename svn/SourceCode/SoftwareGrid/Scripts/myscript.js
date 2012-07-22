/// <reference path="jquery-1.6.2-vsdoc.js" />
/// <reference path="jquery-ui-1.8.11.js" />
$(document).ready(function () {


    //    $("a.toggle").each(function () {
    //        $(this).addClass("toggle_closed");
    //        $("div.block").hide();
    //        $(this).siblings(".box_head").removeClass("round_top").toggleClass("round_all");
    //    });

    $(".alert.dismissible").click(function () {
        $(this).animate({ opacity: 0 }, 'slow', function () {
            $(this).slideUp();
        });
    });

    $("#sidebaricon").click(function () {
        $("#sidebar").toggle("slow");
        $(this).toggleClass("active");
        $("#overview_body").animate({ width: $("#overview_body").width() - 180 }, 400);
        return false;
    });
    $('#hideh1').click(function () {
        $("#sidebar").hide("slow");
        $("#overview_body").animate({ width: $("#overview_body").width() + 180 }, 400);
    });

    $('*[data-action]').live("change", function () {
        var actionName = $(this).attr("data-action");
        var actualUrl = $(location).attr('href').replace("http://", "").replace("https://", "");
        var urlContents = actualUrl.split('/');
        var url = "http:/";
        if (urlContents.length >= 1) {
            if (url == "") {
                url = url + urlContents[0];
            }
            else {
                url = url + "/" + urlContents[0];
            }
        }
        if (urlContents.length >= 2) {
            if (url == "") {
                url = url + urlContents[1];
            }
            else {
                url = url + "/" + urlContents[1];
            }
        }
        if (urlContents.length >= 3) {
            if (url == "") {
                url = url + urlContents[2];
            }
            else {
                url = url + "/" + urlContents[2];
            }
        }
        url = url + "/" + actionName;
        var dropDownListName = $(this).attr("name");
        var data = dropDownListName + "=" + $(this).val();
        $.ajax({
            type: "POST",
            url: url,
            data: data,
            success: function (r) {
                var refreshControlId = "div" + dropDownListName;
                $("#" + refreshControlId).html(r.data);
            },
            complete: function () {
            },
            error: function (req, status, error) {
            }
        });
    });
});