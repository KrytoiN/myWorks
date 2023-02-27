<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css">
    <script src="js/jquery-3.6.3.min.js"> </script>
    <link rel="stylesheet" href="css/style.css">
    <title>Мото</title>
</head>
<!-- style="background-color: #2e2e2e;" -->
<body>
    <?php
    session_start();
    require_once "configDB.php";
    include_once "header.php";
    if ( ($_GET != []) and ($_GET["brand"] != []))
        $con->productAdds($_GET["brand"]);
    ?>
</body>

</html>