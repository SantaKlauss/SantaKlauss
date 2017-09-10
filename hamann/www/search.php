<?php
$search = $_POST['search'];
$search = addslashes($search);
$search = htmlspecialchars($search);
$search = stripslashes($search);
if($search == '')
{
      exit("Начните вводить запрос");
}
$db = mysql_connect("localhost","root");
mysql_select_db("tuningdetails",$db);
mysql_query("SET NAMES utf8");
                
$query = mysql_query("SELECT * FROM deatils WHERE det_name LIKE '%". $search ."%'", $db);
if(mysql_num_rows($query) > 0){
   $sql = mysql_fetch_array($query);
   do{
     echo "<div>".$sql['det_name']."</div>";
   }while($sql = mysql_fetch_array($query));
}
else{
   echo "Нет соответствий";
}
?>