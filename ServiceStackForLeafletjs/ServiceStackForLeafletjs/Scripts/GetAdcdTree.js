$(function () {
    $(".province").show();
    $(".province").html("<ul><li dataname='浙江省'><b>浙江省</b></li></ul>");
    $(".province ul li").click(function () {
        window.GetAdcdTreeprovince(".province", "330000000000000", 0, "浙江省", 1);
    });
});

function GetAdcdTreeprovince(doucmentname, adcd, level, dataname, type) {
    
    if (level > 4) {
        return false;
    }

    switch (level) {
        case 1:
            break;
        case 2:
            break;
        case 3:
            $.ajax({
                type:"post",
                url:"",
                dataType:"json",
                data:{},
                success:function (data) {
                    
                }
            });
            
            break;
        default:

    }
    $.ajax({
        type: "post",
        url: "http://localhost/ZZTX/GetAdcdByUseradcd",
        dataType: "json",
        data: {"UserAdcd": adcd,"actiontype":type},
        success: function (data) {
            $(doucmentname).empty();
            var sb = new StringBuilder();
            sb.append("<p>当前位置:<span class='currentpostion'  data-level='" + level + "' data-name='" + dataname + "' data-adcd='" + adcd + "'>" + dataname + "</span><span class='pull-right returnback'>返回</span></p>");
            var haha = eval(data);
            sb.append("<ul>");
            $.each(haha, function (i, item) {
                sb.append("<li dataid='" + item.id + "' dataname='" + item.adnm + "' datalat='" + item.lat + "' datalng='" + item.lng + "' adcd='" + item.adcd + "'>" + item.adnm + "</li>");
            });
            sb.append("</ul>");
            $(doucmentname).html(sb.toString()).show();

            $(doucmentname).children("ul").children("li").on("click", function () {
                GetMapPoint($(this).attr("datalat"), $(this).attr("datalng"), level);
                GetAdcdTreeprovince(doucmentname, $(this).attr("adcd"), level, $(this).attr("dataname"), 1);
            });
            $(".returnback").on("click", function () {
                GetAdcdTreeprovince(doucmentname, $(".currentpostion").attr("data-adcd"), $(".currentpostion").attr("data-level"), $(".currentpostion").attr("data-name"), 2);
            });
        }
    });
    switch (type) {
        case 1:
            level = Number(level) + 1;
            break;
        case 2:
            level = Number(level) - 1;
            break;
        default:
            level = Number(level);
    }


}

/**
 * 这里是获取地图展示
 * @param {any} lat
 * @param {any} lng
 * @param {any} level
 */
function GetMapPoint(lat, lng, level) {
    var zoom;
    switch (level) {
        case 1:
            zoom = 10;
            break;
        case 2:
            zoom = 12;
            break;
        case 3:
            zoom = 14;
            break;
        case 4:
            zoom = 16;
            break;
        default:
            zoom = 10;
    }
    var mappoint = L.marker(L.latLng(lat, lng), {
        icon: L.icon({
            iconUrl: "http://ovsqnadmr.bkt.clouddn.com/p1.png",
            iconAnchor: new L.Point(9, 9)
        })
    });
    map.addLayer(mappoint);//map是在load里面创建好的
    map.setView([lat, lng], zoom);//这里是设置视野
    //layer.alert(zoom);
}

function GetWarnList(adcd) {
    $.ajax({
        type: "post",
        url: "http://localhost/ZZTX/GetAdcdByUseradcd",
        dataType: "json",
        data: {"UserAdcd": adcd},
        success: function (data) {
            var haha = eval(data);
            $.each(haha, function (i, item) {

            });
        }
    });
}