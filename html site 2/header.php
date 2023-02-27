<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css">
<link rel="stylesheet" href="css/header-style.css">
<header class="header">
        <div class="container bg">
            <div class="row flex-nowrap justify-content-between align-items-center">
                <div class="col-lg-3 pt-1 header-icon">
                    <a href="index.php"> <img src="img/logo.svg"> </a>
                </div>
                <div class="col-lg-3 pt-1">
                    <input class="form-control searcher" type="search" placeholder="Search">
                </div>
                <div class="col-lg-3 pt-1 right-icon">
                    <a href="#"><img src="img/profile-svgrepo-com.svg"></a>
                    <a href="cart.php"><img src="img/cart-svgrepo-com.svg"></a>
                </div>
            </div>
            <div class="navigation">
                <div class="drop-down">
                    <a class="menu-item" href="#"><img class="burger" src="img/menu-svgrepo-com.svg">КАТАЛОГ</a>
                    <div class="dropdown-content">
                        <a href="index.php?brand=1"> Мотоциклы </a>
                        <a href="index.php?brand=2"> Экипировка </a>
                        <a href="index.php?brand=3"> Запчасти </a>
                    </div>
                </div>
                <div class="drop-down">
                    <a class= "<?= $_SERVER["REQUEST_URI"] == "/html%20site%202/addProducts.php" ? "menu-item active" : "menu-item" ?>" href="addProducts.php">ДОБАВЛЕНИЕ ТОВАРА</a>
                </div>
            </div>
        </div>
    </header>