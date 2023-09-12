// function scrolling()
// {
//     let navbar = document.getElementById('navbar').classList
//     let active_class = "navbar_scrolled"
//     window.addEventListener('scroll', e => {
//     if(pageYOffset > 100) navbar.add(active_class)
//     else navbar.remove(active_class)
//     })
// }

// scrolling();

let btnp1 = document.querySelector('#btnp-1');
let btnp2 = document.querySelector('#btnp-2');
let groupPrices = document.querySelector('#group-prices');
let personalPrices = document.querySelector('#personal-prices');;
btnp1.onclick = function(){
    if (!((' ' + btnp1.className + ' ').indexOf(' btns-active ') > -1))
    {
        btnp1.classList.add("btns-active");
        personalPrices.classList.add("prices-active");
        groupPrices.classList.remove("prices-active");
        btnp2.classList.remove("btns-active");
    }
  }

btnp2.onclick = function(){
    if (!((' ' + btnp2.className + ' ').indexOf(' btns-active ') > -1))
    {
        btnp2.classList.add("btns-active");
        personalPrices.classList.remove("prices-active");
        groupPrices.classList.add("prices-active");
        btnp1.classList.remove("btns-active");
    }
  }


