function GetAdcdTree(ducmentname, adcd) {   
    var sb = new StringBuilder();
    $.ajax({
        type: "post",
        url: "http://localhost/ZZTX/GetZZTX",
        dataType: "json",
        data: { "UserAdcd": adcd },
        success: function (data) {
            $(ducmentname).empty();
            var haha = eval(data);            
            $.each(haha, function (i, item) {               
                sb.append("<li dataid='" + item.id + "' adcd='" + item.adcd + "'>" + item.adnm + "<li>");
                alert(sb.toString());
                $(".province").append(sb.toString());
            });            
        }
    });
    
}