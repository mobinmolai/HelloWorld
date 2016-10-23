/// <reference path="/lib/jquery/dist/jquery.min.js" />
(function () {
    $(".sidebarToggle").on("click", function () {
        var $sidebarAndWrapper = $("#sidebar,#wrapper");
        $sidebarAndWrapper.toggleClass("hide-sidebar");
        if ($sidebarAndWrapper.hasClass("hide-sidebar"))
            $(this).text("Show Sidebar");
        else
            $(this).text("Hide Sidebar");
    });
})();