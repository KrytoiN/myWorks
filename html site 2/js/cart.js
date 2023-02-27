function cartAdd(el)
{
    var idProduct = el.id;
    var parent = $(el).parent();
    var father = parent.parent();
    var count = parent.find('.text-val input').val();
    var price = father.find('.product-bottom small').text().split("руб")[0];
    $.ajax({
        url: "cart.php",
        method: "get",
        data: {id: idProduct, cnt: count, prc: price},
        dataType: "xml",
        success: function (data) {
            alert("A");
        },
        error: function (jqXHR, exception) {
            if (jqXHR.status === 0) {
                alert('Not connect. Verify Network.');
            } else if (jqXHR.status == 404) {
                alert('Requested page not found (404).');
            } else if (jqXHR.status == 500) {
                alert('Internal Server Error (500).');
            } else if (exception === 'parsererror') {
                alert('Requested JSON parse failed.');
            } else if (exception === 'timeout') {
                alert('Time out error.');
            } else if (exception === 'abort') {
                alert('Ajax request aborted.');
            } else {
                alert('Uncaught Error. ' + jqXHR.responseText);
            }
            }
    });
}