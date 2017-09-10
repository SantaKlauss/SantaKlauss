<!DOCTYPE html>
<?php 
	include("connection.php");
	$sql = "SELECT * FROM `moshnost_details`";

    $query = mysql_query($sql);

	$count = mysql_num_rows($query);
?>

<html>

<head>
<meta charset="UTF-8">
<title>HAMANN - Наличие деталей</title>
<link href="style.css" type="text/css" rel="stylesheet">
<link rel="shortcut icon" href="favicon.ico" type="image/x-icon">
</head>

<SCRIPT language=javascript src="menu.js"></SCRIPT>
<SCRIPT language=javascript src="upbutton.js"></SCRIPT>

<body style="background-color: white; 
background-image: url(Бэкграунд.gif);
background-attachment: fixed;
background-position: 0px -100px">
<div class="container">

<header>
<center>
<a href="Главная.html"><img src="logo.jpg" alt="Логотип"></a>
</center>
</header>


<hr>
<center><H1>HAMANN - автомобильное тюнинг-ателье</H1></center>
<hr>





<center>
<p id=header onmouseover=P7_autoLayers(0)>HAMANN - это лучшее автомобильное тюнинг-ателье во всем мире, теперь доступно и в России! </p>
</center>




<hr>
<div style=" width:100%; height:1px; clear:both;"></div>
<div id="liniya" class="border"><a href="Главная.html" id=mediumfont onmouseover=P7_autoLayers(0)>Главная</a></div> 
<div id="liniya" class="border"><a href="Контакты.html" id=mediumfont onmouseover=P7_autoLayers(0)>Наши контакты</a></div> 
<div id="liniya"><a href="Сделатьзаказ.html" id=mediumfont onmouseover=P7_autoLayers(0)>Сделать заказ</a></div>
<div style=" width:100%; height:1px; clear:both;"></div>
<hr>


<center>

<H2>Информация об имеющихся в наличии деталях</H2>
<center>
<p style="font-size: 20px;">В данный момент на складе в наличии имеются следующие детали:
</center>
		<FORM method="POST" action="details.php">
			<TABLE border="1" width="90%">
				<TR>
					<TH width="30%">Серийный номер</TH>
					<TH width="40%">Название</TH>
					<TH width="20%">Цена, руб</TH>
					<TH width="10%">Вес, кг</TH>
				</TR>
				
				
				
				
<?php
			for($i=0;$i<$count;$i++) 
			{
		?>

				<TR align="center">
					<TD width="30%"><?php echo mysql_result($query,$i,det_seria);?></TD>
					<TD width="40%"><?php echo mysql_result($query,$i,det_name);?></TD>
					<TD width="20%"><?php echo mysql_result($query,$i,det_cost);?></TD>
					<TD width="10%"><?php echo mysql_result($query,$i,det_weight);?></TD>
				</TR>	
				
			<?php
		}
	?>



				
				
			</TABLE>
			

		</FORM>
<div class="categorii">Сортировать детали по категориям:
<a href="aerodinamics_details.php">Аэродинамика;</a>
<a href="vneshnijvid_details.php" >Внешний вид;</a>
<a href="moshnost_details.php" style="text-decoration: underline">Мощность;</a>
<a href="details.php">Все детали</a>
</div>


		</center>
<hr>




<div id=msa style="Z-INDEX: 9; LEFT: 435px; VISIBILITY: hidden; 
WIDTH: 500px; POSITION: absolute; TOP: 610px; HEIGHT: 45px">
<table id=bordertable width=400 border=0 bgcolor=#f1f1f1>
<tr><td id=tablefont><center><a href="М5.html" id=mediumfont>BMW M5 F10</a></center></td></tr>
<tr><td id=tablefont><center><a href="Авентадор.html" id=mediumfont>Lamborghini Aventador</a></center></td></tr>
<tr><td id=tablefont><center><a href="Ровер.html" id=mediumfont>Land Rover Range Rover Vogue</a></center></td></tr></table></div>



<footer id=footer>
<center>
2016
</center>
</footer>

<a href="#top"
   onclick="ScrollUp();return!1;"
   style="display:block;
   position:fixed;
   bottom:30px;right:30px;
        width:54px; height:32px; padding:12px 10px 2px; font-size:16px;
        opacity:0.7; 
        background:#ddd;
        -webkit-border-radius:15px;
        -moz-border-radius:15px;
        border-radius:15px">Наверх</a>



</div>
</body>

</html>