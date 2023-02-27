function showCart() {
    var cartRowHTML = "";
    var grandTotal = 0;
    var shoppingCart = JSON.parse(sessionStorage.getItem('shopping-cart'));
    var price = parseFloat(shoppingCart.price);
    var quantity = parseInt(shoppingCart.quantity);
    var subPrice = price * quantity;
    cartRowHTML += "<tr>" +
				"<td>" + shoppingCart.productName + "</td>" +
				"<td class='text-right'>" + price + "</td>" +
				"<td class='text-right'>" + quantity + "</td>" +
				"<td class='text-right'>" + subPrice + "</td>" +
				"</tr>";
    grandTotal += subPrice;
    $('#cartTableBody').html(cartRowHTML);
    $('#itemCount').text(1);
	$('#totalAmount').text(grandTotal);
}

$(document).ready(function () {
    showCart();
});