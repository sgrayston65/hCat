(function () {
    $(document).ready(function () {
        //$('#loading').hide();

        $('#btnSearch').click(function () {
            var url = "./api/people/" + $('#txtFrag').val();
            $('#people').empty();
            $('#loading').show()

            $.getJSON(url, function (data) {
                console.log(data);
            $('#loading').hide()

                var html = "";
                for (var i = 0; i < data.length; i++) {
                    html = "<div class='well'>" + data[i].firstname + " " + data[i].lastname + "<br />";
                    html += data[i].address + "<br />";
                    html += "<span>Age:</span> " + data[i].age + "<br />";

                    html += "<span>Interests:</span> "
                    for (var j = 0; j < data[i].interests.length; j++) {
                        if (j === 0)
                            html += data[i].interests[j].description;
                        else
                            html += ", " + data[i].interests[j].description;
                    }
                    html += "<br /></div>"
                    $('#people').append(html);
                }
            });
        });
    });
})();