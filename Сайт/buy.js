// const openPop = document.getElementById('buy-btn');
const openPop = document.querySelectorAll('#buy-btn');
const closePop = document.getElementById('buy-close');
const pop = document.getElementById('buypop-up');

openPop.forEach(function(btn) {
    btn.addEventListener('click', () => {
        pop.classList.add('buy-active');
    });
  });

closePop.addEventListener('click', () => 
{
    pop.classList.remove('buy-active');
});

document.addEventListener('submit', (e) => { 
        e.prevent.Default(); 
        e.target.reset(); 
        pop.classList.remove('buy-active');
    });

