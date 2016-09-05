(function ($) {
    var $treeTable = null;
    $(function () {
        $treeTable = $('#areatree').treeTable({
            expandLevel: 1,
            url: '@Url.Action("GetAreaListByParentID、“Area”,new { id = " 123 " })',

        });

    });
})(jQuery);