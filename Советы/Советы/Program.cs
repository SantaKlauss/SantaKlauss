﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Советы
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random(); 
            string[] sovet = new string[44]
            {
                "1. Жизнь несправедлива, но все же хороша.",
                "2. Если сомневаешься, сделай еще шажок вперед.",
                "3. Жизнь слишком коротка, чтобы тратить её на ненависть.",
                "4. Работа не позаботится о тебе, когда ты болеешь. Это сделают твои друзья и родители. Береги это!",
                "5. Каждый месяц оплачивай долги по кредиткам.",
                "6. Не обязательно выигрывать в каждом споре. Согласись или не согласись.",
                "7. Плачь вместе с кем-то. Это лечит лучше, чем плач в одиночестве.",
                "8. Допустимо злиться на Бога. Он поймет.",
                "9. Копи на пенсию с первой зарплаты.",
                "10. Когда дело доходит до шоколада, сопротивляться бессмысленно.",
                "11. Примирись со своим прошлым, чтобы оно не испортило твое настоящее.",
                "12. Можно позволить себе заплакать в присутствии своих детей",
                "13. Не сравнивай свою жизнь с чьей-то. Ты и понятия не имеешь, что им приходится испытывать на самом деле.",
                "14. Если отношения должны быть тайными, тебе не стоит в этом участвовать.",
                "15. Все может измениться в мгновение ока. Но не волнуйся: Бог никогда не проморгает.",
                "16. Сделай глубокий вдох. Это успокаивает мысли.",
                "17. Избавься от всего, что нельзя назвать полезным, красивым или забавным.",
                "18. Что не убивает, делает тебя сильнее.",
                "19. Никогда не поздно иметь счастливое детство. Однако второе детство зависит исключительно от тебя..",
                "20. Когда приходит время следовать за тем, что ты действительно любишь в этой жизни, не говори нет.",
                "21. Жги свечи, пользуйся хорошими простынями, носи красивое нижнее белье.Ничего на храни для особого случая. Этот особый случай - сегодня.",
                "22. Подготовься с избытком, а потом будь что будет.",
                "23. Будь эксцентричным сейчас. Не жди старости, чтобы надеть ярко-красную одежду.",
                "24. Самый важный орган в сексе - это мозги.",
                "25. Никто, кроме тебя, не несет ответственности за твое счастье.",
                "26. При любой так называемой катастрофе задавай вопрос: Будет ли это важно через пять лет?",
                "27. Всегда выбирай жизнь.",
                "28. Прощай всё и всем.",
                "29. Что другие думают о тебе не должно тебя волновать.",
                "30. Время лечит почти всё. Дай времени время.",
                "31. Неважно, плоха ли ситуация или хороша - она изменится.",
                "32. Не принимай себя всерьез. Никто этого не делает.",
                "33. Верь в чудеса.",
                "34. Бог любит тебя потому что он - Бог, а не из-за того, что ты что-то сделал или нет.",
                "35. Не нужно изучать жизнь. Ты появляешься в ней и делаешь столько, сколько успеешь.",
                "36. Состариться - более выгодная альтернатива, чем умереть молодым.",
                "37. У твоих детей есть только одно будущее.",
                "38. Все, что в итоге имеет смысл - это то, что ты испытал любовь.",
                "39. Выходи гулять каждый день. Чудеса происходят повсеместно.",
                "40. Если бы мы сложили в кучу все наши проблемы и сравнили их с чужими, мы бы живо забрали свои.",
                "41. Зависть - это пустая трата времени. У тебя уже есть все, что нужно.",
                "42. Однако самое лучшее ждет впереди.",
                "43. Неважно, как ты себя чувствуешь, поднимись, оденься и выйди на люди.",
                "44. Уступай."
            };

            Console.WriteLine(sovet[r.Next(sovet.Length)]);
            Console.WriteLine(sovet[r.Next(sovet.Length)]);
            Console.WriteLine(sovet[r.Next(sovet.Length)]);
            Console.ReadKey();
        }
    }
}
