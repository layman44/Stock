(function ($) {
    var areatable = $("#areatree");
    areatable.treetable({
        expandable: true,
        onNodeCollapse: function () {
            var node = this;
            areatable.treetable("unloadBranch", node);
        },
        onNodeExpand: function () {
            var node = this;
            $.ajax({
                async: false,
                type: 'GET',
                url: "GetAreaListByParentID?id=" + this.id
            }).done(function (data) {
                for (item in data) {
                    var html = "<tr data-tt-id='" + item.id + "' data-tt-parent-id='" + this.id + "'><td>" + item.id + "</td><td>" + item.name + "</td></tr>";
                    areatable.addChilds(html);
                }
            }).fail(function (data) {
                alert(data);
            });
        }
    });
})(jQuery);