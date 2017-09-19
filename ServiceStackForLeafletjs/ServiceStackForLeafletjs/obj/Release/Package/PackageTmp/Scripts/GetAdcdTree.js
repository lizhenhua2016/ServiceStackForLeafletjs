function GetAdcdTreeprovince(doucmentname, adcd) {
    $.ajax({
        type: "post",
        url: "http://localhost/ZZTX/GetZZTX",
        dataType: "json",
        data: { "UserAdcd": adcd },
        success: function (data) {
            $(doucmentname).empty();
            var sb = new StringBuilder();
            var haha = eval(data);
            sb.append("<ul>");
            $.each(haha, function (i, item) {
                sb.append("<li dataid='" + item.id + "' datalat='" + item.lat + "' datalng='" + item.lng + "' adcd='" + item.adcd + "'>" + item.adnm + "</li>");
            });
            sb.append("</ul>");
            $(doucmentname).html(sb.toString()).show();

            $(doucmentname).children("ul").children("li").on("click", function () {
                GetMapPoint($(this).attr("lat"),$(this).attr("lng"))
                GetAdcdTreeprovince(doucmentname, $(this).attr("adcd"));
            });
        }
    });
}

function GetMapPoint(lat,lng) {
    var cun = L.marker(L.latLng(lat, lng), { icon: L.icon({ iconUrl: "http://ovsqnadmr.bkt.clouddn.com/p1.png", iconAnchor: new L.Point(9, 9) }) });
    map.addLayer(cun);//map是在load里面创建好的
    map.setView([lng, lng], 10);//这里是设置视野
}