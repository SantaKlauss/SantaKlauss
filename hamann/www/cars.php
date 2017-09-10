<!DOCTYPE html>
<html>

<head>
<meta charset="UTF-8">
<title>HAMANN - сделать заказ</title>
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
<div id="liniya" class="border"><a href="Нашиработы.html" id=mediumfont ONMOUSEOVER=P7_autoLayers(0,'msa','Closer')>Наши работы</a></div> 
<div id="liniya"><a href="Контакты.html" id=mediumfont onmouseover=P7_autoLayers(0)>Наши контакты</a></div>
<div style=" width:100%; height:1px; clear:both;"></div>
<hr>

<center>


<p id=mediumfontroman onmouseover=P7_autoLayers(0)> 


<?php

	echo ' Ваш автомобиль - ';
    echo isset($_POST['car']) ? $_POST['car'] : '';

?>


</p>


<p id=mediumfontroman onmouseover=P7_autoLayers(0)>

<?php 
    $tuning = isset($_POST['tuning']) ? $_POST['tuning'] : '';
	
	if (!empty($tuning))
	{
		
		echo 'Вы выбрали следующие детали: <br>' ;
		
		foreach ($tuning as $a)
		{			
			echo '<br>';
			echo $a;			
		}
	}
	else {echo '<h1>Вы не выбрали ни одной детали!</h1>';}

?>
</p>
<p id=mediumfontroman onmouseover=P7_autoLayers(0)>
<?php

$name = isset($_POST['name']) ? $_POST['name'] : '';
$otchestvo = isset($_POST['otchestvo']) ? $_POST['otchestvo'] : '';
$sirname = isset($_POST['sirname']) ? $_POST['sirname'] : '';
$phone = isset($_POST['phonenumber']) ? $_POST['phonenumber'] : '';


if (empty($name))
	echo  '<h1>Введите Ваше имя!</h1>';
else if (empty($sirname))
	echo '<h1>Введите Вашу фамилию!</h1>';
else if (empty($otchestvo))
	echo '<h1>Введите Ваше отчество!</h1>';
else if (empty($phone))
	echo '<h1>Введите Ваш номер телефона!</h1>';
else{
echo isset($_POST['name']) ? $_POST['name'] : '';
echo ' ';
echo isset($_POST['otchestvo']) ? $_POST['otchestvo'] : '';
echo ', в ближайшее время с Вами свяжется наш оператор по указанному номеру, чтобы уточнить Ваш заказ. Пожалуйста, ожидайте звонка!';
}

?>

</p>

</center>


<hr>
<center>


<?php  echo '<a id=mediumfont href="zakazzapol.php?name1=' . $name . '&sirname1=' . $sirname . '&otchestvo1=' . $otchestvo . '&phone1=' . $phone . '"><--Назад</a>'; ?>


</center>
<hr>


<div id=msa style="Z-INDEX: 9; LEFT: 762px; VISIBILITY: hidden; 
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

