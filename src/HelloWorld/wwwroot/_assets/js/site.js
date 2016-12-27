/// <reference path="/lib/jquery/dist/jquery.min.js" />
(function () {
    $(".sidebarToggle").on("click", function () {
        var $sidebarAndWrapper = $("#sidebar,#wrapper");
        $sidebarAndWrapper.toggleClass("hide-sidebar");
        if ($sidebarAndWrapper.hasClass("hide-sidebar"))
            //$(this).text("Show Sidebar");
            $(".sidebarToggle i.fa").removeClass("fa-angle-left").addClass("fa-angle-right");
        else
            //$(this).text("Hide Sidebar");
            $(".sidebarToggle i.fa").removeClass("fa-angle-right").addClass("fa-angle-left");
    });
})();