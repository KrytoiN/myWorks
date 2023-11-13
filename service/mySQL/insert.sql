insert into pc values(0121, '104.193.196.0', 'C0-D0-EF-00D0EF', 'Рабочий1', 'AMD Ryzen 5', 16, 'Toshiba', 'Nvidia GeForce 1050TI', 'Прикладное', 'Стационарный', 'Samsung', 'Хорошее', true, 242, 'Аудитория', 1524, 'Отсутствует', 'admin', 'admin'),
					 (3250, '105.192.196.0', 'D0-D0-ED-01D4EF', 'Рабочий2', 'AMD Ryzen 5', 16, 'Samsung', 'Nvidia GeForce 980', 'Инструментальное', 'Стационарный', 'Xiaomi', 'Отличное', true, 342, 'Аудитория', 1234, 'Отсутствует', 'joke', 'vas23'),
					 (3040, '164.191.194.1', 'A0-D1-EV-02D4DF', 'Рабочий3', 'Intel core I5', 8, 'Toshiba', 'Nvidia GeForce 2050TI', 'Прикладное', 'Ноутбук', 'Toshiba', 'Хорошее', false, 521, 'Офис', 1474, 'Мышка отходит', 'viskas', 'cvc223'),
					 (3580, '116.193.192.0', 'V1-D0-DF-03D3BF', 'Рабочий4', 'Intel core I7', 16, 'Keramika', 'Nvidia GeForce 3050TI', 'Прикладное', 'Ноутбук', 'Samsung', 'Хорошее', false, 443, 'Офис', 2125, 'Шнур отходит', 'lokie', 'vvasd23'),
					 (0025, '124.153.146.1', 'B3-D0-BJ-00D0BF', 'Рабочий5', 'AMD Ryzen 7', 8, 'Jakuzy', 'Nvidia GeForce 1080TI', 'Системное', 'Моноблок', 'Jikers', 'Плохое', true, 111, 'Подвал', 4217, 'Не работает локальная сеть', 'lider1', 'valcue');

insert into software (typeLic, statLic, validLic, dateBuy, dateEnd, numLic, ver, descript, val, category, division, needUpd, invNum, requirem, useLic, licNumber, pass, lang, leftLic) values 
							('Бесплатное','Активна', 180, '2001-10-16', '2002-04-16', 40, '1.0', 'Антивирус Avast', 0, 'Системное', 24, true, 1567, 'AMD Ryzen 5, 16 ГБ, Geforce 1050TI', 5, '157-146', '123', 'Rus', 35),
                            ('Коммерческое', 'Неактивна', 120, '2011-01-25', '2011-05-25', 30, '1.4', 'Skype', 1000, 'Инструментальное', 11, false, 4024, 'AMD Ryzen 5, 16 ГБ, Geforce 980', 10, '127-136', 'vasy', 'Rus', 20),
							('Бесплатное', 'Активна', 60, '2022-03-26', '2022-05-26', 25, '2.2', 'MySQL', 0, 'Прикладное', 43, true, 3056, 'Intel core I5, 8 ГБ, Geforce 2050TI', 12, '248-179', 'zxc', 'Eng', 13),
							('Коммерческое', 'Активна', 30, '2005-05-5', '2005-06-05', 10, '1.3', 'Visual Studio Pro', 3000, 'Прикладное', 18, true, 0025, 'Intel core I7, 16 ГБ, Geforce 3050TI', 10, '214-821', 'hsas', 'Rus', 0),
							('Коммерческое', 'Неактивна', 90, '2008-04-2', '2008-07-02', 15, '4.5', 'Nayhem', 2000, 'Прикладное', 56, false, 7423, 'AMD Ryzen 7, 8 ГБ, 1080TI', 13, '757-116', 'kelsd', 'Eng', 2);

insert into applications (numberPC, numberSoft, dateApp, status, executor, dateComplete) values
						 (0121, 1, '2001-10-16', true, 'Княлев Федор Петрович', '2001-10-18'),
                         (3250, 2, '2011-01-25', false, 'Лев Александр Николаевич', null),
                         (3040, 3, '2022-05-26', false, 'Федоров Пётр Алексеевич', null),
                         (3580, 4, '2005-06-05', true, 'Пушкин Александр Иванович', '2005-06-09'),
                         (0025, 5, '2008-07-02', true, 'Есенин Олег Егорьев', '2008-07-10')