<!DOCTYPE html>
<html lang="ru">

<head>
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="description" content="Лучшая фитнес-студия в Подольске и Климовске, а закрытой формат нашей студии обеспечивает Вам максимальный комфорт и уют для проведение групповых и персональных тренировок, что поможет вам достигнуть отличных результатов. Адреса: Мкр.Климовск, Красная 10А +7 (926) 037-76-36">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <link rel="shortcut icon" href="img/ikonka.ico" type="image/x-icon">
  <link href="styles/itc-slider.css" rel="stylesheet">
  <link href="styles/slider-res.css" rel="stylesheet">
  <link href="styles/prices-style.css" rel="stylesheet">
  <link href="styles/prom-style.css" rel="stylesheet">
  <link href="styles/style.css" rel="stylesheet">
  <link href="styles/trainer-style.css" rel="stylesheet">
  <link href="styles/map-style.css" rel="stylesheet">
  <link href="styles/formn-style.css" rel="stylesheet">
  <link href="styles/buy-formstyle.css" rel="stylesheet">
  <link href="styles/gallery-style.css" rel="stylesheet">
  <link href="styles/reviews-style.css" rel="stylesheet">
  <link href="styles/contact-style.css" rel="stylesheet">
  <link rel="stylesheet" href="styles/newheader-style.css">
  <script src="itc-slider.js" defer></script>
  <title>Фитнес-студия «Emotion_Fit» - Единственная Студия группового и персонального тренинга Закрытого формата. </title>
</head>

<body>
  <?php
  include_once "new-header.php";
  ?>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.0/jquery.min.js"></script>
  <div class="whyme">
    <div id="why" class="desc_services">
      <h1 class="header_h"> Почему мы? </h1>
    </div>
    <div class="cards">
      <div class="cardd">
        <div class="cardw-img" style="background-image: url('img/ico9.png');">
        </div>
        <div class="cardw-text">
          <div class="cardw-header">
            <span> Закрытый формат </span>
          </div>
          <div class="cardw-desc">
            <span>
              Студия закрытого формата только для групповых и персональных тренировок с тренером, для максимального
              комфорта клиента
            </span>
          </div>
        </div>
      </div>
      <div class="cardd">
        <div class="cardw-img" style="background-image: url('img/ico2.png');">
        </div>
        <div class="cardw-text">
          <div class="cardw-header">
            <span> Лучшие условия </span>
          </div>
          <div class="cardw-desc">
            <span>
              Лучшие условия по персональным тренировкам. Уникальная программа лояльности: Если вы занимаетесь с персональным тренером,
              дополнительно клубную карту приобретать не нужно. Вы платите только за тренировки
            </span>
          </div>
        </div>
      </div>
      <div class="cardd">
        <div class="cardw-img" style="background-image: url('img/ico3.png');">
        </div>
        <div class="cardw-text">
          <div class="cardw-header">
            <span> Высокий стандарт </span>
          </div>
          <div class="cardw-desc">
            <span>
              Соответствие высоким стандартам. Уровень комфорта, обстановки, частоты, уюта и обслуживания на высшем уровне
            </span>
          </div>
        </div>
      </div>
      <div class="cardd">
        <div class="cardw-img" style="background-image: url('img/ico1.png');">
        </div>
        <div class="cardw-text">
          <div class="cardw-header">
            <span> Индивидуальный подход </span>
          </div>
          <div class="cardw-desc">
            <span>
              Наши профессиональные тренеры подберут индивидуальные программы тренировок, исходя из ваших целей и с учётом
              вашей текущей физической формы и вашего состояния здоровья
            </span>
          </div>
        </div>
      </div>
    </div>
  </div>

  <div class="services">
    <div id="sevices" class="desc_services">
      <h1 class="header_h"> Направления </h1>
    </div>
    <div class="containers">
      <div class="itc-slider" data-slider="itc-slider" data-loop="false" data-autoplay="false">
        <div class="itc-slider-wrapper">
          <div class="itc-slider-items">
            <div id="personal" class="itc-slider-item">
              <a href="##" class="card_text">Персональные тренировки</a>
              <a href="##"><img src="img/prom2.JPG" class="card_img" alt="н"></a>
            </div>
            <div id="group" class="itc-slider-item">
              <a href="##" class="card_text">Групповые тренировки</a>
              <a href="##" class="card_small">( Силовой и функциональный треннинг )</a>
              <a href="##"><img src="img/group1.JPG" class="card_img" alt="н"></a>
            </div>
            <div id="aero" class="itc-slider-item">
              <a href="##" class="card_text">Аэройога</a>
              <a href="##"><img src="img/aero3.JPG" class="card_img" alt="н"></a>
            </div>
            <div id="spin" class="itc-slider-item">
              <a href="##" class="card_text">Здоровая спина</a>
              <a href="##"><img src="img/spin2.JPG" class="card_img" alt="н"></a>
            </div>
            <div id="box" class="itc-slider-item">
              <a href="##" class="card_text">ОФП Бокс</a>
              <a href="##" class="card_small">( дети 9-14 лет )</a>
              <a href="##"><img src="img/myz1.JPG" class="card_img" alt="н"></a>
            </div>
            <div id="f-box" class="itc-slider-item">
              <a href="##" class="card_text">Женский бокс</a>
              <a href="##"><img src="img/zen1.JPG" class="card_img" alt="н"></a>
            </div>
          </div>
        </div>
        <button class="itc-slider-btn itc-slider-btn-prev"></button>
        <button class="itc-slider-btn itc-slider-btn-next"></button>
      </div>
    </div>
  </div>

  <div class="price-b">
    <div id="prices" class="desc_services">
      <h1 class="header_h"> Цены </h1>
    </div>
    <div class="choice_prices">
      <button id="btnp-1" class="btns btns-active">Персональные тренировки</button>
      <button id="btnp-2" class="btns">Групповые занятия</button>
    </div>
    <div id="personal-prices" class="prices prices-active">
      <div class="item">
        <div class="border-active">
          <div class="border-cutter">
            <div class="price-area btp">
              <div class="bbtp">
                <h4>
                  1 тренировка
                </h4>
                <p>
                  1 600
                  <span class="rouble">i</span>
                </p>
                <a href="##" id="buy-btn" class="btn-style btn">Купить</a>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="item">
        <div class="border-active">
          <div class="border-cutter">
            <div class="price-area btp">
              <div class="bbtp">
                <h4>
                  Блок 4 тренировки
                </h4>
                <p>
                  5 900
                  <span class="rouble">i</span>
                </p>
                <a href="##" id="buy-btn" class="btn-style btn">Купить</a>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="item">
        <div class="border-active">
          <div class="border-cutter">
            <div class="price-area btp">
              <div class="bbtp">
                <h4>
                  Блок 8 тренировок
                </h4>
                <p>
                  11 900
                  <span class="rouble">i</span>
                </p>
                <a href="##" id="buy-btn" class="btn-style btn">Купить</a>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="item">
        <div class="border-active">
          <div class="border-cutter">
            <div class="price-area btp">
              <div class="bbtp">
                <h4>
                  Блок 10 тренировок
                </h4>
                <p>
                  14 900
                  <span class="rouble">i</span>
                </p>
                <a href="##" id="buy-btn" class="btn-style btn">Купить</a>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

    <div id="group-prices" class="prices prices-none">
      <div class="item">
        <div class="border-active">
          <div class="border-cutter">
            <div class="price-area btp">
              <div class="bbtp">
                <h4>
                  Пробная тренировка
                </h4>
                <p>
                  500
                  <span class="rouble">i</span>
                </p>
                <a href="##" id="buy-btn" class="btn-style btn">Купить</a>
              </div>
            </div>
          </div>
        </div>
      </div>

      <div class="item">
        <div class="border-active">
          <div class="border-cutter">
            <div class="price-area btp">
              <div class="bbtp">
                <h4>
                  Разовая групповая
                </h4>
                <p>
                  800
                  <span class="rouble">i</span>
                </p>
                <a href="##" id="buy-btn" class="btn-style btn">Купить</a>
              </div>
            </div>
          </div>
        </div>
      </div>

      <div class="item">
        <div class="border-active">
          <div class="border-cutter">
            <div class="price-area btp">
              <div class="bbtp">
                <h4>
                  Абонемент на 4 тренировки
                </h4>
                <p>
                  3000
                  <span class="rouble">i</span>
                </p>
                <a href="##" id="buy-btn" class="btn-style btn">Купить</a>
              </div>
            </div>
          </div>
        </div>
      </div>

      <div class="item">
        <div class="border-active">
          <div class="border-cutter">
            <div class="price-area btp">
              <div class="bbtp">
                <h4>
                  Абонемент на 8 тренировок
                </h4>
                <p>
                  5000
                  <span class="rouble">i</span>
                </p>
                <a href="##" id="buy-btn" class="btn-style btn">Купить</a>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
    <script src="scripts.js"></script>
  </div>

  <div class="prom-b">
    <div id="promos" class="desc_services">
      <h1 class="header_h"> Акции </h1>
    </div>

    <div class="desc_small">
      <span> Занимайтесь на самых выгодных условиях </span>
    </div>

    <div class="prom">
      <div class="prom-card hover-active" onclick="toggleHoverEffects(this);">
        <div id="prom1" class="prom-table">
          <div class="prom-cell">
            <div class="prom-back" style="background-image: url(img/promt.JPG);"> </div>
            <div class="prom-overlay" style="background-image: -webkit-linear-gradient(top, rgba(0,0,0,0.70), rgba(0,0,0,0.80));"></div>
            <div class="prom-textwrapper">
              <div class="prom-textcontent">
                <div class="prom-inner">
                  <img src="img/ico8.png" alt="" class="prom-img">
                  <div class="prom-title">
                    Тест драйв
                  </div>
                  <div class="prom-desc">
                    4 групповые тренировки за
                  </div>
                  <div class="prom-price">
                    990 <span class="rouble">i</span>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="prom-card hover-active" onclick="toggleHoverEffects(this);"" >
        <div id="prom2" class="prom-table">
          <div class="prom-cell">
            <div class="prom-back" style="background-image: url(img/IMG_2515.JPG);"> </div>
            <div class="prom-overlay" style="background-image: -webkit-linear-gradient(top, rgba(0,0,0,0.70), rgba(0,0,0,0.80));"></div>
            <div class="prom-textwrapper">
              <div class="prom-textcontent">
                <div class="prom-inner">
                  <img src="img/ico8.png" alt="" class="prom-img">
                  <div class="prom-title">
                    Начни сегодня
                  </div>
                  <div class="prom-desc">
                    4 персональные тренировки за
                  </div>
                  <div class="prom-price">
                    5900 <span class="rouble">i</span>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <div class="prom-card hover-active" onclick="toggleHoverEffects(this);"">
        <div id="prom3" class="prom-table">
          <div class="prom-cell">
            <div class="prom-back" style="background-image: url(img/promf.JPG);"> </div>
            <div class="prom-overlay" style="background-image: -webkit-linear-gradient(top, rgba(0,0,0,0.70), rgba(0,0,0,0.80));"></div>
            <div class="prom-textwrapper">
              <div class="prom-textcontent">
                <div class="prom-inner">
                  <img src="img/ico8.png" alt="" class="prom-img">
                  <div class="prom-title">
                    Приведи друга
                  </div>
                  <div class="prom-desc">
                    И получи 10% скидку к абонементу
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>

    </div>
  </div>

  <div class="trainers-b">
    <div id="trainerss" class="desc_services">
      <h1 class="header_h"> Тренера </h1>
    </div>

    <div class="trainers">
      <div class="trainer-table" style="background-image: url(img/train12.png);">
        <div class="trainer-hover">
          <div class="trainer-head">
            <h1> Юрий Ермаков </h1>
          </div>
          <p id="osn">Основатель фитнес студии Emotion_fit</p>
          <p>Сертифицированный персональный тренер *FPA*</p>
          <p>Сертифицированный Фитнес - Нутрициолог *FPA*</p>
          <p>Участник различных Семинаров и Курсов по фитнесу.</p>
          <p id="spec">Специализация:</p>
          <p>Работа с нарушениями Опорно – Двигательного аппарата.</p>
          <p>Коррекция Осанки и коррекция Фигуры</p>
          <p>Работа с болями поясницы и коленного сустава</p>
          <p>Тренировки через умный фитнес в 3D движениях</p>
        </div>
      </div>
      <div class="trainer-table" style="background-image: url(img/train1.png);">
        <div class="trainer-hover">
          <div class="trainer-head">
            <h1> Ирина Маланчева </h1>
          </div>
          <p>Дипломированный Мастер-тренер по фитнесу Лицей "Учёный фитнес"</p>
          <p>КМС по спортивной гимнастике</p>
          <p id="prob"></p>
          <p id="spec">Специализация</p>
          <p>Силовой тренинг</p>
          <p>Мастер функционального тренинга</p>
          <p>Коррекция фигуры</p>
          <p>Набор мышечной массы и похудение</p>
          <p>Мастер тренировок женщин</p>
          <p>Диагностика и растяжка</p>
        </div>
      </div>
      <div class="trainer-table" style="background-image: url(img/train5.png);">
        <div class="trainer-hover">
          <div class="trainer-head">
            <h1> Анна Классен </h1>
          </div>
          <p>Сертифицированный тренер по направлениям АЭРОЙГА, АЭРОСТРЕТЧИНГ и АЭРОФИТНЕС</p>
          <p>Сертифицированный тренер по направлениям « Фундамент Аэройоги» и «Детская аэройога» первой онлайн
            школы AEROYOGA. RF Екатерины Черепановой</p>
          <p id="spec">Специализация:</p>
          <p>Принцип йогив гамаках вытяжение через расслабление</p>
          <p>Декомпрессия позвоночника</p>
          <p>Работа с вестибулярным аппаратом</p>
          <p>Улучшение подвижности в тазобедренных суставах</p>
          <p>Снижение психоэмоционального напряжения и повышение уровня стрессоустойчивости</p>
          <p>Дыхательные практики</p>
        </div>
      </div>
      <div class="trainer-table" style="background-image: url(img/train8.jpeg);">
        <div class="trainer-hover">
          <div class="trainer-head">
            <h1> Дмитрий Васильев </h1>
          </div>
          <p>Сертифицированный Универсальный тренер по фитнесу и бодибилдингу</p>
          <p>Учитель физической культуры и спорта.</p>
          <p>Мастер Спорта по Боксу</p>
          <p>МС по жиму лежа</p>
          <p>КМС по становой тяге</p>
          <p>КМС по многоповторному жиму</p>
          <p id="spec">Специализация:</p>
          <p>ОФП Бокс для детей</p>
          <p>Набор мышечной массы, похудение.</p>
          <p>Силовой и функциональный тренинг.</p>
          <p>Коррекция фигуры, снижение жирового процента в организме</p>
        </div>
      </div>
      <div class="trainer-table" style="background-image: url(img/train4.png);">
        <div class="trainer-hover">
          <div class="trainer-head">
            <h1> Елена Кудряшова </h1>
          </div>
          <p>Сертифицированный Персональный Тренер *FPA*</p>
          <p>Опыт работы в проекте «Physical Transformation» по питанию и тренировкам</p>
          <p>Курсы по основам здорового питания и коррекции рациона</p>
          <p>Курсы по стретчингу и занятия во время беременности и восстановление после родов</p>
          <p id="spec">Специализация:</p>
          <p>Коррекция фигуры, снижения жира в организме</p>
          <p>Силовой и функциональный тренинг</p>
          <p>Ведение питания и работа с улучшение здоровья</p>
          <p>Работа с беременными</p>
        </div>
      </div>
    </div>
  </div>

  <div class="gallery-b">
    <div class="desc_services">
      <h1 class="header_h"> Галерея </h1>
    </div>

    <div id="gal" class="containers">
      <div id="gal" class="itc-slider" data-slider="itc-slider" data-loop="false" data-autoplay="false">
        <div id="gal" class="itc-slider-wrapper">
          <div id="gal" class="itc-slider-items">
            <div id="gal" class="itc-slider-item">
              <a href="##"><img src="img/zal1.JPG" id="beaf" class="card_img" alt="н"></a>
            </div>
            <div id="gal" class="itc-slider-item">
              <a href="##"><img src="img/zal2.JPG" id="beaf" class="card_img" alt="н"></a>
            </div>
            <div id="gal" class="itc-slider-item">
              <a href="##"><img src="img/zal3.JPG" id="beaf" class="card_img" alt="н"></a>
            </div>
            <div id="gal" class="itc-slider-item">
              <a href="##"><img src="img/zal8.JPG" id="beaf" class="card_img" alt="н"></a>
            </div>
            <div id="gal" class="itc-slider-item">
              <a href="##"><img src="img/zal9.JPG" id="beaf" class="card_img" alt="н"></a>
            </div>
            <div id="gal" class="itc-slider-item">
              <a href="##"><img src="img/zal10.JPG" id="beaf" class="card_img" alt="н"></a>
            </div>
            <div id="gal" class="itc-slider-item">
              <a href="##"><img src="img/zal13.JPG" id="beaf" class="card_img" alt="н"></a>
            </div>
          </div>
        </div>
        <button class="itc-slider-btn itc-slider-btn-prev"></button>
        <button class="itc-slider-btn itc-slider-btn-next"></button>
      </div>
    </div>
  </div>

  <div class="contacts-b">
    <div id="contactss" class="container">
      <div class="row">
        <div class="col-md-12">
          <div class="main-heading">
            <h1>
              Контактная информация
            </h1>
          </div>
        </div>
        <div class="row">
          <div class="col-md-3 col-sm-6 contact-box">
            <div class="contact_icon">
              <img src="img/con3.png" alt="">
            </div>
            <div class="contact_ttl"><a href="tel:+79260377636">8 (926) 037-76-36</a></div>
          </div>
          <div class="col-md-3 col-sm-6 contact-box">
            <div class="contact_icon">
              <img src="img/con2.png" alt="">
            </div>
            <div class="contact_ttl">info@emotion-fit.ru</div>
          </div>
          <div class="col-md-3 col-sm-6 contact-box">
            <div class="contact_icon">
              <img src="img/con4.png" alt="">
            </div>
            <div class="contact_ttl"><a href="https://yandex.ru/maps/org/emotion_fit/240991564994/?ll=37.506307%2C55.364865&z=17.02">Красная, 10А (2 этаж)</a></div>
          </div>
          <div class="col-md-3 col-sm-6 contact-box">
            <div class="contact_icon">
              <img src="img/con1.png" alt="">
            </div>
            <div class="contact_ttl">Будни: 10:00 - 22:00</div>
          </div>
        </div>
      </div>
    </div>
    <!-- <div class="desc_services">
      <h1 class="header_h"> Контакты </h1>
    </div> -->
  </div>
  <div id="map" class="map">
    <script src="https://api-maps.yandex.ru/2.1/?lang=ru_RU" type="text/javascript"></script>
    <script type="text/javascript">
      ymaps.ready(init);
      function init() {
        var myMap = new ymaps.Map("map", {
            center: [55.364852, 37.506234],
            zoom: 18,
            type: 'yandex#map'
          }),

          myPlacemark = new ymaps.Placemark([55.364852, 37.506234], {}, {
            iconLayout: 'default#image',
            iconImageClipRect: [
              [0, 0],
              [0, 0]
            ],
            iconImageHref: 'img/map3.png',
            iconImageSize: [64, 64],
            iconImageOffset: [-5, -70]
          });
        myMap.geoObjects.add(myPlacemark);
        myMap.behaviors.disable('scrollZoom');
      }
    </script>
  </div>
  <div id="buypop-up" class="buypop-up">
    <div id="buy-container" class="buy-container">
      <div id="buy-body" class="buy-body">
        <div class="buy-head">
          <div class="buy-title">
            Запись на пробное занятие
          </div>
          <form action="action.php" method="post">
            <div class="buy-name">
              <input name="buy-fio" type="text" required autocomplete="off" placeholder="ФИО" class="buy-input">
              <input name="buy-number" data-mask="phone" type="text" required autocomplete="off" id="number" placeholder="Номер телефона" class="buy-number">
              <button type="submit" class="buy-btn"> Отправить </button>
            </div>
          </form>
          <div id="buy-close" class="buy-close">&#10006</div>
        </div>
      </div>
    </div>
  </div>

  <div id="fomnpop-up" class="formnpop-up">
    <div class="formn-container">
      <div class="formn-body">
        <div class="formn-head">
          <div class="formn-title">
            <span id="title-span">Персональные тренировки</span>
          </div>
          <form action="#" method="post">
            <div class="formn-name">
              <span id="name-span">Lorem ipsum dolor sit amet consectetur, adipisicing elit. Ad, veniam earum impedit praesentium eum recusandae at sapiente fugiat. Non assumenda consectetur nam. Ipsum cupiditate sequi, necessitatibus ratione vitae facere iusto?</span>
            </div>
          </form>
          <div id="formn-close" class="formn-close">&#10006</div>
        </div>
      </div>
    </div>
  </div>
  <div class="contact-widget">
    <a class="icon icon-phone" href="tel:+79260377636"> <img src="img/tel3.svg" alt=""></a>
    <a class="icon icon-whats" href="https://wa.me/79260377636"><img src="img/whatsapp.svg"></a>
    <a class="icon icon-inst" href="https://instagram.com/emotion__fit?igshid=MzRlODBiNWFlZA=="><img src="img/inst2.svg"></a>
  </div>
  <script src="buy.js"></script>
  <script src="forms.js"></script>
  <script src="https://unpkg.com/imask"></script>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM" crossorigin="anonymous"></script>
</body>

</html>