<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css">
<link rel="stylesheet" href="css/style.css">
<?php
include_once "header.php";
require_once "configDB.php";
if (($_POST and $_FILES) != []) {
    $arr = array();
    foreach ($_POST as $key => $value)
        array_push($arr, $value);
    $con->addFile($arr);
    $con->addValue($arr);
}
?>
<div class="container mt-4">
    <form method="post" enctype='multipart/form-data'>
        <?php
        echo "<h6 class=\"text\"> Фирма </h6>";
        $con->selectList("idFirm", "nme", "firm");
        echo "<h6 class=\"text\"> Категория </h6>";
        $con->selectList("idCat", "nme", "cat");
        ?>
        <h6 class="text"> Название</h6>
        <input type="text" class="form-control" name="title" placeholder="Название" required /> <br>
        <h6 class="text"> Описание</h6>
        <input type="text" class="form-control" name="descr" placeholder="Описание " required /> <br>
        <h6 class="text"> Цена</h6>
        <input type="text" class="form-control" name="price" placeholder="Цена " required /> <br>
        <h6 class="text"> В наличии </h6>
        <input type="text" class="form-control" name="total" placeholder="В наличии" required /> <br>
        <h6 class="text"> Изображение </h6>
        <input type="file" class="form-control" name="files[]" required /> <br>
        <button type="submit" class="btn btn-success"> Добавить элемент </button>
        <button type="reset" class="btn btn-outline-danger" name="reset"> Сбросить </button>
    </form>
</div>