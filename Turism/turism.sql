-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Хост: 127.0.0.1
-- Время создания: Дек 09 2014 г., 18:36
-- Версия сервера: 5.5.25
-- Версия PHP: 5.5.16

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- База данных: `turism`
--

-- --------------------------------------------------------

--
-- Структура таблицы `additioncost`
--

CREATE TABLE IF NOT EXISTS `additioncost` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `country` int(11) NOT NULL,
  `cost` float NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=13 ;

--
-- Дамп данных таблицы `additioncost`
--

INSERT INTO `additioncost` (`id`, `country`, `cost`) VALUES
(1, 1, 1500),
(2, 2, 1500),
(3, 3, 1500),
(4, 4, 1500),
(5, 5, 1500),
(6, 6, 1500),
(7, 7, 1500),
(8, 8, 1500),
(9, 9, 2000),
(10, 10, 2000),
(11, 11, 2000),
(12, 12, 3500);

-- --------------------------------------------------------

--
-- Структура таблицы `countries`
--

CREATE TABLE IF NOT EXISTS `countries` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `description` text NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=13 ;

--
-- Дамп данных таблицы `countries`
--

INSERT INTO `countries` (`id`, `name`, `description`) VALUES
(1, 'Австрия', 'Австрия — страна, каждый уголок которой приготовил для туристов свой «лакомый кусочек». Любители оперы, достопримечательностей и архитектуры едут, разумеется, в столицу Австрии Вену, поклонники классической музыки — в Зальцбург, а к чистейшим озерам и горячим минеральным источникам туристы отправляются в очаровательную Каринтию.\r\n'),
(2, 'Болгария', 'Туристические курорты Болгарии характеризуются особенным климатом, развитой отельной базой, экскурсиями и развлечениями. Отели Болгарии являются одними из самых недорогих в Европе. Все местные гостиницы соответствуют стандартной европейской классификации: от одной до пяти звезд. Большинство отелей Болгарии трех и четырехзвездочные, что делает страну доступной для отдыха людям с любыми финансовыми возможностями.'),
(3, 'Греция', 'Греция - страна удивительной красоты, где яркое солнце согревает жителей практически круглый год. Лазурное море, золотистые пляжи, белые дома, аромат крепкого кофе и хвойных растений - неповторимая атмосфера Греции располагает к незабываемому и потрясающему отдыху.'),
(4, 'Испания', 'Испания расположена на крайнем юго-западе Европы. Ей принадлежат Балеарские и Питиусские острова в Средиземном море и Канарские острова в Атлантическом океане. Граничит с Францией, Андоррой, Португалией.\r\n\r\nИсточник: http://www.votpusk.ru/country/country.asp?CN=ES#ixzz3LNhcJiiB\r\n'),
(5, 'Италия', 'Секрет успеха Италии прост: отличный пляжный отдых на Средиземном море, сверхбогатая «экскурсионка», горнолыжные курорты плюс выгодный шопинг. От Рима до Неаполя, от заснеженных Альп до солнечных островов — все об Италии: карты, виза, дорога, фото, отели.\r\n'),
(6, 'Франция', 'Элегантная красавица-Франция — это отдых с шармом: насыщенная «экскурсионка», отдых на утонченном Лазурном Берегу, знаменитые музеи, гастрономические провинции и замки Луары. Кухня, вино и горнолыжные курорты — все о Франции: туры, цены, отели и достопримечательности.\r\n'),
(7, 'Хорватия', 'Живописная Хорватия предлагает туристам широкие чистейшие пляжи Адриатики в окружении сосен и скал, хлебосольную кухню и лечение на минеральных источниках. Столица — средневековый Загреб и курортная Истрия — все о Хорватии: туры, цены, отели.'),
(8, 'Чехия', 'В Чехии — множество симпатичных старинных городков: Колин с великолепным собором, столица Моравии Брно, Кутна-Гора с собором Св. Варвары и костницей, Табор, Пльзень и другие. Стоит съездить в заповедник «Чешский Рай» (~100 км от Праги), в котором помимо нескольких средневековых замков находятся очень эффектные скальные массивы, среди которых проложены пешие маршруты. Или отправиться купаться на Махово озеро — чешский популярный пляжный курорт.'),
(9, 'Египет', 'Достоинства Египта известны каждому: качественный пляжный отдых круглый год на Средиземном и Красном морях, разбавленный отличным дайвингом, плюс разнообразная «экскурсионка»: пирамиды, Сфинкс и Луксор. Все о Египте от Хургады до Шарма: туры, отели, цены, погода.\r\n'),
(10, 'Тунис', 'Африка по-французски, Тунис — это белопесчаные пляжи, руины великого Карфагена и целительная талассотерапия всего в 4 часах полета от Москвы. Лучшие отели от Хаммамета до Сахары, актуальная погода и отзывы об отдыхе, карты и фото — все о Тунисе от Тонкостей туризма.\r\n'),
(11, 'Турция', 'Турция — это не только отличные пляжи четырех морей, но и великолепный Стамбул с Голубой мечетью и дворцом Топкапы, термальные источники Яловы и белоснежный Памуккале, монастыри Каппадокии, горные лыжи и классный шоппинг. Все о Турции: отели, туры, погода, цены.'),
(12, 'ОАЭ', 'В ОАЭ не бывает плохой погоды и низкого сезона — ведь здесь что в ноябре, что в июле роскошные отели для качественного отдыха и отличный шопинг по привлекательным ценам. Все об Эмиратах — Дубай и Шарджа, пляжный отдых, экскурсии и достопримечательности на карте.');

-- --------------------------------------------------------

--
-- Структура таблицы `discount`
--

CREATE TABLE IF NOT EXISTS `discount` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `discount` float NOT NULL,
  `name` varchar(256) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=6 ;

--
-- Дамп данных таблицы `discount`
--

INSERT INTO `discount` (`id`, `discount`, `name`) VALUES
(1, 25, 'Скидка для детей до 7 лет'),
(2, 10, 'Скидка для студентов'),
(3, 25, 'Скидка для пенсионеров'),
(4, 7, 'Скидка для постоянных  клиентов'),
(5, 5, 'Скидка для клиентов с подарочными картами');

-- --------------------------------------------------------

--
-- Структура таблицы `hotel`
--

CREATE TABLE IF NOT EXISTS `hotel` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(256) NOT NULL,
  `category` int(11) NOT NULL,
  `cost` float NOT NULL,
  `country` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=28 ;

--
-- Дамп данных таблицы `hotel`
--

INSERT INTO `hotel` (`id`, `name`, `category`, `cost`, `country`) VALUES
(1, 'Ibis Mariahilf 3', 3, 1500, 1),
(2, 'De France 5*', 5, 12130, 1),
(3, 'Delta', 4, 3100, 1),
(4, 'Kolping Wien Zentral', 2, 850, 1),
(5, 'Тракия Гарден', 3, 1600, 2),
(6, 'SOL Luna bay', 4, 3200, 2),
(7, 'Адмирал', 5, 12500, 2),
(8, 'Mitsis Faliraki Beach', 4, 3100, 3),
(9, 'Pilot Beach Resort', 5, 8500, 3),
(10, 'Estival Park Salou Hotel', 4, 3500, 4),
(11, 'Best Cap Salou', 3, 2600, 4),
(12, 'Citta Del Mare', 4, 3800, 5),
(13, 'Donau', 3, 4000, 5),
(14, 'Fiat', 2, 1200, 6),
(15, 'Apollo Opera', 3, 1800, 6),
(16, 'Delfin', 2, 1350, 7),
(17, 'Laguna Molindrio', 4, 3670, 7),
(18, 'Olsanka', 3, 2300, 8),
(19, 'Spa Resort Sanssouci ', 4, 5700, 8),
(20, ' Maritim Jolie Ville Royal Peninsula Hotel & Resort', 5, 15100, 9),
(21, 'Dessole Marlin Inn Beach Resort', 4, 8500, 9),
(22, 'Dessole Bella Vista', 4, 4200, 10),
(23, 'Riu Palace Hammamet Marhaba', 5, 16200, 10),
(24, 'Justiniano Club Alanya', 4, 5600, 11),
(25, ' Rubi Platinum Spa Resort & Suites', 5, 14200, 11),
(26, ' The Ajman Palace Hotel', 5, 15600, 12),
(27, 'Citymax Bur Dubai', 3, 2400, 12);

-- --------------------------------------------------------

--
-- Структура таблицы `seasons`
--

CREATE TABLE IF NOT EXISTS `seasons` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `country` int(11) NOT NULL,
  `season` int(11) NOT NULL,
  `month` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=145 ;

--
-- Дамп данных таблицы `seasons`
--

INSERT INTO `seasons` (`id`, `country`, `season`, `month`) VALUES
(1, 1, 4, 1),
(2, 1, 4, 2),
(3, 1, 4, 3),
(4, 1, 4, 4),
(5, 1, 3, 5),
(6, 1, 3, 6),
(7, 1, 3, 7),
(8, 1, 3, 8),
(9, 1, 3, 9),
(10, 1, 3, 10),
(11, 1, 3, 11),
(12, 1, 4, 12),
(13, 2, 4, 1),
(14, 2, 4, 2),
(15, 2, 5, 3),
(16, 2, 5, 4),
(17, 2, 5, 5),
(18, 2, 1, 6),
(19, 2, 1, 7),
(20, 2, 1, 8),
(21, 2, 1, 9),
(22, 2, 5, 10),
(23, 2, 5, 11),
(24, 2, 5, 12),
(25, 3, 3, 1),
(26, 3, 3, 2),
(27, 3, 3, 3),
(28, 3, 3, 4),
(29, 3, 1, 5),
(30, 3, 1, 6),
(31, 3, 1, 7),
(32, 3, 1, 8),
(33, 3, 1, 9),
(34, 3, 3, 10),
(35, 3, 3, 11),
(36, 3, 3, 12),
(37, 4, 3, 1),
(38, 4, 5, 2),
(39, 4, 3, 3),
(40, 4, 3, 4),
(41, 4, 1, 5),
(42, 4, 1, 6),
(43, 4, 1, 7),
(44, 4, 1, 8),
(45, 4, 1, 9),
(46, 4, 1, 10),
(47, 4, 3, 11),
(48, 4, 3, 12),
(49, 5, 3, 1),
(50, 5, 3, 2),
(51, 5, 3, 3),
(52, 5, 3, 4),
(53, 5, 1, 5),
(54, 5, 1, 6),
(55, 5, 1, 7),
(56, 5, 1, 8),
(57, 5, 1, 9),
(58, 5, 3, 10),
(59, 5, 3, 11),
(60, 5, 3, 12),
(61, 6, 4, 1),
(62, 6, 4, 2),
(63, 6, 4, 3),
(64, 6, 3, 4),
(65, 6, 3, 5),
(66, 6, 1, 6),
(67, 6, 1, 7),
(68, 6, 1, 8),
(69, 6, 3, 9),
(70, 6, 3, 10),
(71, 6, 3, 11),
(72, 6, 4, 12),
(73, 7, 5, 1),
(74, 7, 5, 2),
(75, 7, 5, 3),
(76, 7, 5, 4),
(77, 7, 5, 5),
(78, 7, 1, 6),
(79, 7, 1, 7),
(80, 7, 1, 8),
(81, 7, 1, 9),
(82, 7, 5, 10),
(83, 7, 5, 11),
(84, 7, 5, 12),
(85, 8, 3, 1),
(86, 8, 3, 2),
(87, 8, 3, 3),
(88, 8, 3, 4),
(89, 8, 3, 5),
(90, 8, 3, 6),
(91, 8, 3, 7),
(92, 8, 3, 8),
(93, 8, 3, 9),
(94, 8, 3, 10),
(95, 8, 3, 11),
(96, 8, 3, 12),
(97, 9, 1, 1),
(98, 9, 1, 2),
(99, 9, 1, 3),
(100, 9, 1, 4),
(101, 9, 1, 5),
(102, 9, 1, 6),
(103, 9, 1, 7),
(104, 9, 1, 8),
(105, 9, 1, 9),
(106, 9, 1, 10),
(107, 9, 1, 11),
(108, 9, 1, 12),
(109, 10, 5, 1),
(110, 10, 5, 2),
(111, 10, 5, 3),
(112, 10, 5, 4),
(113, 10, 1, 5),
(114, 10, 1, 6),
(115, 10, 1, 7),
(116, 10, 1, 8),
(117, 10, 1, 9),
(118, 10, 1, 10),
(119, 10, 5, 11),
(120, 10, 5, 12),
(121, 11, 2, 1),
(122, 11, 2, 2),
(123, 11, 2, 3),
(124, 11, 2, 4),
(125, 11, 1, 5),
(126, 11, 1, 6),
(127, 11, 1, 7),
(128, 11, 1, 8),
(129, 11, 1, 9),
(130, 11, 1, 10),
(131, 11, 2, 11),
(132, 11, 2, 12),
(133, 12, 1, 1),
(134, 12, 1, 2),
(135, 12, 1, 3),
(136, 12, 1, 4),
(137, 12, 2, 5),
(138, 12, 2, 6),
(139, 12, 2, 7),
(140, 12, 2, 8),
(141, 12, 2, 9),
(142, 12, 1, 10),
(143, 12, 1, 11),
(144, 12, 1, 12);

-- --------------------------------------------------------

--
-- Структура таблицы `seasonskoefs`
--

CREATE TABLE IF NOT EXISTS `seasonskoefs` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(256) NOT NULL,
  `k` float NOT NULL,
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=6 ;

--
-- Дамп данных таблицы `seasonskoefs`
--

INSERT INTO `seasonskoefs` (`id`, `name`, `k`) VALUES
(1, 'Пляжный сезон', 1.25),
(2, 'Шоп-туры', 1.2),
(3, 'Сезон экскурсий', 1.15),
(4, 'Горнолыжный сезон', 1.1),
(5, 'Не сезон', 1.02);

-- --------------------------------------------------------

--
-- Структура таблицы `strahovka`
--

CREATE TABLE IF NOT EXISTS `strahovka` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) DEFAULT NULL,
  `cost` float DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Дамп данных таблицы `strahovka`
--

INSERT INTO `strahovka` (`id`, `name`, `cost`) VALUES
(1, 'Эконом', 1000),
(2, 'Базовая', 3000),
(3, 'Экстра', 6000);

-- --------------------------------------------------------

--
-- Структура таблицы `transportcompany`
--

CREATE TABLE IF NOT EXISTS `transportcompany` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `transport` varchar(256) NOT NULL,
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=4 ;

--
-- Дамп данных таблицы `transportcompany`
--

INSERT INTO `transportcompany` (`id`, `transport`) VALUES
(1, 'Авиакомпания «UTair»'),
(2, 'РЖД'),
(3, 'Автобус');

-- --------------------------------------------------------

--
-- Структура таблицы `transporttarif`
--

CREATE TABLE IF NOT EXISTS `transporttarif` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `company` int(11) NOT NULL,
  `name` varchar(256) NOT NULL,
  `country` int(11) NOT NULL,
  `cost` float NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=61 ;

--
-- Дамп данных таблицы `transporttarif`
--

INSERT INTO `transporttarif` (`id`, `company`, `name`, `country`, `cost`) VALUES
(1, 1, 'Бизнес-класс', 1, 15000),
(2, 1, 'Эконом-класс', 1, 9000),
(3, 2, 'Купе', 1, 6000),
(4, 2, 'Плацкарт', 1, 3500),
(5, 3, 'Автобус', 1, 3000),
(6, 1, 'Бизнес-класс', 2, 15000),
(7, 1, 'Эконом-класс', 2, 9000),
(8, 2, 'Купе', 2, 6000),
(9, 2, 'Плацкарт', 2, 3500),
(10, 3, 'Автобус', 2, 3000),
(11, 1, 'Бизнес-класс', 3, 16000),
(12, 1, 'Эконом-класс', 3, 9000),
(13, 2, 'Купе', 3, 6000),
(14, 2, 'Плацкарт', 3, 3500),
(15, 3, 'Автобус', 3, 3000),
(16, 1, 'Бизнес-класс', 4, 15000),
(17, 1, 'Эконом-класс', 4, 12000),
(18, 2, 'Купе', 4, 6000),
(19, 2, 'Плацкарт', 4, 3500),
(20, 3, 'Автобус', 4, 3000),
(21, 1, 'Бизнес-класс', 5, 17000),
(22, 1, 'Эконом-класс', 5, 12000),
(23, 2, 'Купе', 5, 6000),
(24, 2, 'Плацкарт', 5, 3500),
(25, 3, 'Автобус', 5, 3000),
(26, 1, 'Бизнес-класс', 6, 14000),
(27, 1, 'Эконом-класс', 6, 8000),
(28, 2, 'Купе', 6, 6000),
(29, 2, 'Плацкарт', 6, 3500),
(30, 3, 'Автобус', 6, 3000),
(31, 1, 'Бизнес-класс', 7, 14000),
(32, 1, 'Эконом-класс', 7, 8000),
(33, 2, 'Купе', 7, 6000),
(34, 2, 'Плацкарт', 7, 3500),
(35, 3, 'Автобус', 7, 3000),
(36, 1, 'Бизнес-класс', 8, 14000),
(37, 1, 'Эконом-класс', 8, 8000),
(38, 2, 'Купе', 8, 6000),
(39, 2, 'Плацкарт', 8, 3500),
(40, 3, 'Автобус', 8, 3000),
(41, 1, 'Бизнес-класс', 9, 14000),
(42, 1, 'Эконом-класс', 9, 8000),
(43, 2, 'Купе', 9, 6000),
(44, 2, 'Плацкарт', 9, 3500),
(45, 3, 'Автобус', 9, 3000),
(46, 1, 'Бизнес-класс', 10, 16000),
(47, 1, 'Эконом-класс', 10, 9000),
(48, 2, 'Купе', 10, 6100),
(49, 2, 'Плацкарт', 10, 3600),
(50, 3, 'Автобус', 10, 3000),
(51, 1, 'Бизнес-класс', 11, 16000),
(52, 1, 'Эконом-класс', 11, 9000),
(53, 2, 'Купе', 11, 6100),
(54, 2, 'Плацкарт', 11, 3600),
(55, 3, 'Автобус', 11, 3500),
(56, 1, 'Бизнес-класс', 12, 16000),
(57, 1, 'Эконом-класс', 12, 10000),
(58, 2, 'Купе', 12, 6100),
(59, 2, 'Плацкарт', 12, 3600),
(60, 3, 'Автобус', 12, 3500);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
