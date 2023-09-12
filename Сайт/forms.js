const popForm = document.getElementById('fomnpop-up');
const formnClose = document.getElementById('formn-close');
const personal = document.getElementById('personal');

document.addEventListener('DOMContentLoaded', function() {
  const trainerTables = document.querySelectorAll('.trainer-table');

  trainerTables.forEach(trainerTable => {
    const trainerHover = trainerTable.querySelector('.trainer-hover');
    let isVisible = false;
    let isTouchDevice = false;

    if ('ontouchstart' in window || navigator.msMaxTouchPoints) {
      isTouchDevice = true;
    }

    const toggleVisibility = () => {
      isVisible = !isVisible;
      if (isVisible) {
        trainerHover.classList.remove('trainer-hidden');
      } else {
        trainerHover.classList.add('trainer-hidden');
      }
    };

    trainerTable.addEventListener('click', function() {
      if (!isTouchDevice) {
        toggleVisibility();
      }
    });

    trainerTable.addEventListener('mouseenter', function() {
      if (!isVisible && !isTouchDevice) {
        trainerHover.classList.remove('trainer-hidden');
      }
    });

    trainerTable.addEventListener('mouseleave', function() {
      if (!isVisible && !isTouchDevice) {
        trainerHover.classList.add('trainer-hidden');
      }
    });

    trainerTable.addEventListener('click', function() {
      if (isTouchDevice) {
        toggleVisibility();
      }
    });
  });
});

document.addEventListener('DOMContentLoaded', () => {

  const elements = document.querySelectorAll('[data-mask="phone"]') 
  if (!elements) return 
  const phoneOptions = {
    mask: '+{7}(000)000-00-00'
  }
  elements.forEach(el => {
    IMask(el, phoneOptions)
  })

})

function toggleHoverEffects(element) {
  if (!element.classList.contains('hover-active')) {
    element.classList.add('hover-active');
  } else {
    element.classList.remove('hover-active');
  }
}

personal.addEventListener('click', () => 
{
  let title = document.getElementById("title-span");
  title.textContent = "Персональные тренировки";
  let desc = document.getElementById("name-span");
  desc.textContent = "Персональная тренировка - это занятие, которое тренер проводит лично для Вас, с учётом ваших целей, физической формы, индивидуальных особенностей и пожеланий. Ваш персональный тренер - проводник в мир здоровья, прекрасного самочувствия и отличной формы!";
  popForm.classList.add("formn-active");
});

formnClose.addEventListener('click', () => 
{
    popForm.classList.remove('formn-active');
});

const group = document.getElementById('group');
group.addEventListener('click', () => 
{
  let title = document.getElementById("title-span");
  title.textContent = "Групповые тренировки";
  let desc = document.getElementById("name-span");
  desc.textContent = "Групповые тренировки стоит выбрать тем, кто не хочет быть под постоянным надзором тренера и любит заниматься в тёплой и приятной компании. Групповые тренинги – это очень часто не только совместные занятия, но и общение, а также обмен опытом и мнениям";
  popForm.classList.add("formn-active");
});

const aero = document.getElementById('aero');
aero.addEventListener('click', () => 
{
  let title = document.getElementById("title-span");
  title.textContent = `Аэройога`;
  let desc = document.getElementById("name-span");
  desc.textContent = `Аэройога– это практика, которая сочетает в себе принципы йоги, растяжки, пилатеса и
  калланетики. При выполнении асан в подвешенном состоянии тело человека
  вытягивается, запускается механизм самообновления и улучшается общее состояние
  здоровья. В основе аэройоги лежит взаимодействие с гамаком. Он берёт на себя часть
  веса тела. Благодаря силам гравитации работает главный принцип йоги в воздухе —
  вытяжение через расслабление.`;
  popForm.classList.add("formn-active");
});

const spin = document.getElementById('spin');
spin.addEventListener('click', () => 
{
  let title = document.getElementById("title-span");
  title.textContent = "Здоровая спина";
  let desc = document.getElementById("name-span");
  desc.textContent = `Тренировка «Здоровая спина» - фитнес-программа, созданная для
  восстановления и профилактики болезней позвоночника. Она направлена на
  проработку мышц, удерживающих позвоночник в правильном положении.
  Специально подобранный комплекс упражнений на развитие подвижности и
  гибкости спины рекомендуется и мужчинам, и женщинам. Занятия рассчитаны на
  разный уровень подготовки, поэтому подойдут всем, независимо от возраста и
  физического развития.`;
  popForm.classList.add("formn-active");
});

// const dziy = document.getElementById('dziy');
// dziy.addEventListener('click', () => 
// {
//   let title = document.getElementById("title-span");
//   title.textContent = "Джиу-джитсу";
//   let desc = document.getElementById("name-span");
//   desc.textContent = `Боевое искусство, основой которого является борьба в партере, а также болевые и удушающие приёмы.
//   Джиу-джитсу нацелено гасить агрессию, а не разжигать её.
//   Техники в джиу-джитсу позволяют слабому победить сильного противника.
//   Для детей джиу джитсу представляет огромный интерес: дети учатся защищать себя, улучшают свою физическую форму, учатся стремлению, общению со сверстниками, учатся побеждать и проигрывать, получая мотивацию. Джиу-джитсу, — один из самых безопасных видов контактной борьбы для детей с наименьшим уровнем травматизма.`;
//   popForm.classList.add("formn-active");
// });

const box = document.getElementById('box');
box.addEventListener('click', () => 
{
  let title = document.getElementById("title-span");
  title.textContent = `Офп бокс`;
  let desc = document.getElementById("name-span");
  desc.textContent = `Обще–физическая подготовка, подразумевает развитие основных физических качеств: силы, скорости, выносливости, ловкости и гибкости. Главными определяющими физическими качествами в боксе являются – сила и скорость. 
  В тренировке боксёра для наилучшего развития силы,
   желательно подбирать упражнения, включающие в работу наибольшее количество мышц.`;
  popForm.classList.add("formn-active");
});

const fbox = document.getElementById('f-box');
fbox.addEventListener('click', () => 
{
  let title = document.getElementById("title-span");
  title.textContent = "Женский бокс";
  let desc = document.getElementById("name-span");
  desc.textContent = `Бокс – это интенсивный вид спорта, который требует от спортсменов много силы, выносливости и
  координации движений. Когда-то считалось, что бокс – это мужское занятие, но сегодня все
  больше женщин увлекаются этим видом спорта. Бокс для девушек — это увлекательный способ
  избавиться от лишнего веса, повысить свою физическую форму и развить навыки самозащиты.`;
  popForm.classList.add("formn-active");
});

// const mma = document.getElementById('mma');
// mma.addEventListener('click', () => 
// {
//   let title = document.getElementById("title-span");
//   title.textContent = "ММА";
//   let desc = document.getElementById("name-span");
//   desc.textContent = `ММА – это полно контактное спортивное единоборство, включающее в себя
// ударную и борцовскую технику, применяемую как в стойке, так и партере.
// Современное ММА вобрало в себя множество техник и направлений от различных
// боевых искусств и единоборств, сделав из этого отдельное боевую школу.
// ММА является универсальным видом единоборств, и его стратегия не
// ограничивается каким-то определённым наборов техник или приёмов.`;
//   popForm.classList.add("formn-active");
// });