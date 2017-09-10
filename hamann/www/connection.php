<?php
$link = @mysql_connect("localhost", "root") 
or die("Невозможно соединиться с сервером");
$db=@mysql_select_db("tuning_details") or die("Нет такой базы данных");

?>
