<?php
class sqlCon
{
    private $address, $username, $password;
    private $con;
    function __construct($address, $username, $password)
    {
        $this->address = $address;
        $this->username = $username;
        $this->password = $password;
    }
    public function openConnection()
    {
        try {
            $this->con = new PDO("mysql:host=" . $this->address . ";dbname=moto", $this->username, $this->password);
        } catch (PDOException $e) {
            echo "Connection failed " . $e->getMessage() . "<br>";
        }
    }

    public function getCon()
    {
        return $this->con;
    }

    public function selectList($idName, $nme, $table)
    {
        echo "<select name=\" " . $table . "\" class=\"form-control\" \"form-control-sm\" >";
        $query = $this->con->query("select " . $idName . "," . $nme . " from " . $table);
        while ($row = $query->fetch(PDO::FETCH_OBJ)) {
            echo "<option value=\" " . $row->$idName . "\" >" . $row->$nme . "</option> ";
        }
        echo "</select><br>";
    }

    public function addValue($arr)
    {
        try {
            $sql = "INSERT INTO products (idFirm, idCat, title, descript, price, inStock, img) VALUES (?, ?, ?, ?, ?, ?, ?)";
            $stmt = $this->con->prepare($sql);
            $rowsNumber = $stmt->execute($arr);
            if ($rowsNumber > 0) {
                echo "Data successfully added <br>";
            } else
                echo "Something went wrong <br>";
        } catch (PDOException $e) {
            echo "Database error: " . $e->getMessage() . "<br>";
        }
    }

    private function addHash()
    {
        $number = mt_rand(100, 9999);
        return crc32($number);
    }

    public function addFile(&$arr)
    {
        $filename = $_FILES["files"]["name"][0];
        $path = "img/" . $this->addHash() . $filename;
        if (move_uploaded_file($_FILES["files"]["tmp_name"][0], $path)) {
            array_push($arr, $path);
        }
    }

    public function outputProducts()
    {
        for ($i = 0; $i < 4; ++$i)
            $this->productAdds($i);
    }

    public function productAdds($idCat)
    {
        try {
            $sql = "select idProduct, title, inStock, price, img from products where idCat = " . $idCat;
            echo "
            <div class=\"container\" style=\"padding: 2% 1% 1% 10%;\">
                    <div class=\"row g-0\">
            ";
            foreach ($this->con->query($sql) as $row) {
                echo
                "
                    <div class=\"col-md-5 col-lg-3 col-sm-4\">
                        <div class=\"product-card\">
                            <div class=\"product-img\">
                                <a href=\"productShow.php?idc=". $row["idProduct"]. "\"> <img src=\" " . $row["img"] . "\" > </a>
                            </div>
                            <div class=\"product-title\">
                                <h5> <a href=\"productShow.php?idc=". $row["idProduct"]. "\"> " . $row["title"] . "</a> </h5>
                            </div>
                            <div class = \"product-description \">
                                <h6>В наличии: " . $row["inStock"] . " </h6>
                            </div>
                            <div class = \" product-bottom \">
                                <div class=\"product-price\">
                                    <small>" . $row["price"] . " руб </small> <br>
                                </div>
                            </div>
                            <div class=\"drop-card\">
                                <div class=\"btn-plus\">
                                    <input type=\"button\" class=\"pb\" id=\"bt-plus\" value=\"+\">
                                </div>
                                <div class=\"text-val\">
                                    <input type=\"text\" class=\"ab\" id=\"val-add\" value=\"1\">
                                </div>
                                <div class=\"btn-minus\">
                                    <input type=\"button\" class=\"mb\" id=\"bt-minus\" value=\"-\">
                                </div>
                                <input type=\"button\" id= \"" . $row["idProduct"] . " \" class=\"cart-btn\" onClick=\"cartAdd(this);\" value=\"В корзину\">
                            </div>
                        </div>
                    </div> 
                    <script src=\"js/cart.js\"></script>";
            }
            echo 
            "</div>
            </div>";
        } catch (PDOException $e) {
            echo "Database error: " . $e->getMessage() . "<br>";
        }
    }

    public function viewProduct($idc)
    {
        try{
        $sql = "select title, descript, price, img from products where idProduct = " . $idc;
        foreach ($this->con->query($sql) as $row)
        {
        echo
        "<div class=\"show-block\">
        <div class=\"topic\">
            <h1> " .  $row["title"] . "</h1>
        </div>
        <div class=\"inner\">
            <div class=\"product-view\">
                <div class=\"product-img\">
                    <img src=\" ".$row["img"]. "\">
                </div>
            </div>
            <div class=\"dpc-view\">
                <div class=\"price-view\">
                    <h2>" . $row["price"] . " руб</h2>
                </div>
                <div class=\"char-view\">
                    <h5>Характеристики</h5> ";
                    for ($i = 0; $i < 4; ++$i)
                    echo "<div class=\"table-item\">
                        <div class=\"table-name\">
                            Бренд
                        </div>
                        <div class=\"table-val\">
                            BMW
                        </div>
                    </div> ";
                echo "</div>
                <div class=\"des-view\">
                    <h5>Описание</h5>
                    <div class=\"des\">
                        <h6>". $row["descript"] . "</h6>
                    </div>
                </div>
                <div class=\"cart-view\">
                    <div class=\"plus-minus\">
                        <div class=\"btn-plus\">
                            <input type=\"button\" value=\"+\">
                        </div>
                        <div class=\"text-val\">
                            <input type=\"text\" id=\"val-add\" value=\"1\">
                        </div>
                        <div class=\"btn-minus\">
                            <input type=\"button\" value=\"-\"/>
                        </div>
                    </div>
                    <button type=\"button\" class=\"add-cart btn\">Добавить в корзину</button>
                </div>
            </div>
        </div>
    </div>";
        }
        } catch(PDOException $e)
        {
            echo "Database error: " . $e->getMessage() . "<br>";
        }
    }

    public function closeConnection()
    {
        $this->con = null;
        echo "Connection closed";
    }
}
