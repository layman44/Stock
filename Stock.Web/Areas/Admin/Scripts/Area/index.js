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
            }).done(function (res) {
                if (res.success) {
                    var html = "";
                    if (res.result[0].id.toString().lastIndexOf('00') == 4) {
                        for (var i = 0; i < res.result.length; i++) {
                            html += "<tr data-tt-id='" + res.result[i].id + "' data-tt-parent-id='" + node.id + "' data-tt-branch='true' class='branch'><td>" + res.result[i].id + "</td><td>" + res.result[i].name + "</td></tr>";
                        }
                    }
                    else {
                        for (var i = 0; i < res.result.length; i++) {
                            html += "<tr data-tt-id='" + res.result[i].id + "' data-tt-parent-id='" + node.id + "'><td>" + res.result[i].id + "</td><td>" + res.result[i].name + "</td></tr>";
                        }
                    }
                }
                areatable.treetable("loadBranch",node, html);
            }).fail(function (data) {
                alert(data);
            });
        }
    });
})(jQuery);