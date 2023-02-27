function plus()
{
    let count = $('#val-add').val();
    $("#val-add").val(++count);
}

function minus()
{
    let count = $('#val-add').val();
    if (count > 1)
    $("#val-add").val(--count);
}

// function createBindings(quantityContainer)
// {
//     var quantityAmount = quantityContainer.getElementsByClassName('ab')[0];
//     var increase = quantityContainer.getElementsByClassName('pb')[0];
//     var decrease = quantityContainer.getElementsByClassName('mb')[0];
//     increase.addEventListener('click', function () { increaseValue(quantityAmount); });
//     decrease.addEventListener('click', function () { decreaseValue(quantityAmount); });
// }

// function inVal()
// {
//     var main = document.getElementsByClassName('text-val');
//     for (var i = 0; i < main.length; i++ ) {
//         createBindings(main[i]);
//     }
// }

// function increaseValue(quantityAmount) {
//     var value = parseInt(quantityAmount.value, 10);
//     value = isNaN(value) ? 0 : value;
//     value++;
//     quantityAmount.value = value;
// }

// $.('.add-cart').click(function())

function addCart(el)
{
    console.log("aaa");
    var product = $(el).closest('div.product-card');
    var productName = $(product).find('.product-title a').text();
    var price = $(product).find('.product-price small').text();
	var quantity = $(product).find('.text-val input').val();
    var cartItem = {
		productName: productName,
		price: price,
		quantity: quantity,
        rows: {
            productName: productName,
            price: price,
            quantity: quantity 
        }
	};
    var cartItemJSON = JSON.stringify(cartItem);
    cartSet = new Array();
    cartSet.push(cartItemJSON);
    sessionStorage.setItem('shopping-cart', cartSet);
    console.log(sessionStorage.getItem('shopping-cart'));
    // sessionStorage.clear();
}

function addCartView(el)
{
    var product = $(el).closest('div.show-block');
    var productName = $(product).find('.topic h1').text();
    var price = $(product).find('div.dpc-view div.price-view h2').text();
	var quantity = $(product).find('div.cart-view #val-add').val();
    var cartItem = {
		productName: productName,
		price: price,
		quantity: quantity
	};
    var cartItemJSON = JSON.stringify(cartItem);
    cartSet = new Array();
    // if (sessionStorage.getItem('shopping-cart')) {
    //      cartSet.add(sessionStorage.getItem('shopping-cart'));
    // }
    cartSet.push(cartItemJSON);
    sessionStorage.setItem('shopping-cart', cartSet);
    // sessionStorage.clear();
}

// $('.drop-card').on('click', '.btn-plus', function(){
//     plus();
//   });

// $('.drop-card').on('click', '.btn-minus', function() {
//     minus();
// });

$('.cart-view').on('click', '.btn-plus', function(){
    plus('#val-add');
  });

$('.cart-view').on('click', '.btn-minus', function(){
    minus('#val-add');
});