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

Здесь можно оформить заказ на тюнинг Вашего автомобиля. После оформления заказа с Вами свяжется наш оператор, поэтому внимательно заполняйте поля! 

</p>


<form id=mediumfontroman action="cars.php" method="post" onmouseover=P7_autoLayers(0)>
</center>

<fieldset>
<legend style="text-align: center" id=mediumfontroman>Контактная информация</legend>
            <p id=mediumfontroman>Имя
<input  style="margin-left: 150px;"  type="text" name="name" size="20"
            maxlength="50" value="" onkeyup="isNotEmpty(this.id)">
			<p id=mediumfontroman>Фамилия
<input style="margin-left: 104px;" id=mediumfontroman type="text" name="sirname" size="20"
            maxlength="50" value="">
			<p id=mediumfontroman>Отчество
<input style="margin-left: 103px;" id=mediumfontroman type="text" name="otchestvo" size="20"
            maxlength="50" value="">
			<p id=mediumfontroman>Номер телефона
<input style="margin-left: 37px;" id=mediumfontroman type="text" name="phonenumber" size="20"
            maxlength="50" value="">
</fieldset>

  <fieldset>
  
    <legend  style="text-align: center" id=mediumfontroman>Выберите марку вашего автомобиля:</legend>
      <select style="margin-left: 394px;" id=mediumfontroman  name="car">
        <option id=mediumfontroman value="BMW">BMW</option>
        <option id=mediumfontroman value="Mercedes-Benz">Mercedes-Benz</option>
        <option id=mediumfontroman value="Audi">Audi</option>
        <option id=mediumfontroman value="Toyota">Toyota</option>
        <option id=mediumfontroman value="Mitsubishi">Mitsubishi</option>
		<option id=mediumfontroman value="ВАЗ">ВАЗ</option>
      </select>
  </fieldset>
  

  
 
 
  
  <fieldset>
    <legend id=mediumfontroman style="text-align: center">Выберите детали, которые Вы бы хотели установить на Ваш автомобиль:</legend>
    <label id=mediumfontroman for="BumperPered">
    <input id="BumperPered" type="checkbox" name="tuning[]" value="Передний бампер X-Con"> Передний бампер X-Con</label>
    <br><label id=mediumfontroman for="BumperZad">
    <input id="BumperZad" type="checkbox" name="tuning[]" value="Задний бампер X-Con"> Задний бампер X-Con</label>
    <br><label id=mediumfontroman for="Spoiler">
    <input id="Spoiler" type="checkbox" name="tuning[]" value="Спойлер X-Con"> Спойлер X-Con</label>
    <br><label id=mediumfontroman for="Vihlop">
    <input id="Vihlop" type="checkbox" name="tuning[]" value="Прямоточная выхлопная система Vihlop Boost"> Прямоточная выхлопная система Vihlop Boost</label>
    <br><label id=mediumfontroman for="Turbina">
    <input id="Turbina" type="checkbox" name="tuning[]" value="Турбина"> Турбина</label>
    <br><label id=mediumfontroman for="Diski">
    <input id="Diski" type="checkbox" name="tuning[]" value="Легкосплавные 17' диски"> Легкосплавные 17' диски</label>
    <br><label id=mediumfontroman for="Ksenon">
    <input id="Ksenon" type="checkbox" name="tuning[]" value="Ксеноновые лампы в фары"> Ксеноновые лампы в фары</label>
    <br><label id=mediumfontroman for="Tonirovka">
    <input id="Tonirovka" type="checkbox" name="tuning[]" value="Тонировка стекол"> Тонировка стекол</label>
	
	<br>
	<hr>
	<center><div style="margin-top: 10px; margin-bottom: 15px; hover:" ><a href="details.php" id=mediumfont style="color: red;">Узнать о наличии деталей на складе</a></div></center>
	<hr>
  </fieldset>
  
  
  
  
<center>
<input style="margin-top: 10px;" id=mediumfont  type="submit" value="Далее">
</center>


</form>






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
        width:54px; height:32px; padding:12px 10px 2px 14px;font-size:16px;
        opacity:0.7; 
        background:#fff;
        -webkit-border-radius:15px;
        -moz-border-radius:15px;
        border-radius:15px">Наверх</a>



</div>
</body>

</html>