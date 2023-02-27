<script src="js/jquery-3.6.3.min.js"> </script>
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css">
<link rel="stylesheet" href="css/product-style.css">
<?php
include_once "header.php";
require_once "configDB.php";
?>

<body>
    <?php
        if ($_GET["idc"] != [])
            $con->viewProduct($_GET["idc"]);
    ?>
</body>