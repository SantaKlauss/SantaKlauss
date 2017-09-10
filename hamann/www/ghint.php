<script type="text/javascript" src="chint.js"></script>
<?php
	$a[]="Бампер передний X-Con";
	$a[]="Бампер задний X-Con";
	$a[]="Спойлер X-Con";
	$a[]="Турбина";
	$a[]="Ксеноновые лампы в фары";
	$a[]="Тонировка";
	$a[]="Легкосплавные диски";
	$a[]="Прямоточная выхлопная система VihlopBoost";

	$q = $_GET["q"];
	if (strlen($q) > 0)
	{
		$hint = "";
		for($i = 0; $i<count($a); $i++)
		{
			if (strtolower($q) == strtolower(substr($a				[$i],0,strlen($q))))
			{
				if ($hint == "")
				{
					$hint=$a[$i];
				}
				else
				{
					$hint=$hint.", ".$a[$i];
				}
			}
		}
	}
		if ($hint !== "")
		{
			$response = $hint;
		}
		else
		{
			$response = "Нет соотвествий";
		}
		echo $response;
?>
