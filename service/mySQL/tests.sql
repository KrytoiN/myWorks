select numberApp, numberPC, numberSoft, dateApp, executor, dateComplete from applications where status = true;
select distinct executor from applications;
select numberApp, numberPC, numberSoft, dateApp, dateComplete from applications where (executor = "Княлев Федор Петрович" and status = true);
select numberApp, numberPC, numberSoft, dateApp, status, dateComplete from applications where executor = "Княлев Федор Петрович";
select * from applications;
update pc set statusPC = 'Плохое' where numberPC = 25;
select dateEnd from software where dateBuy = '2001-10-16';
select numberSoft, statLic, validLic, numLic, ver, descript, val, division, needUpd, invNum, requirem, useLic, licNumber, pass, lang, leftLic from Software where typeLic = 'Коммерческое' and dateBuy = '2011-01-25' and dateEnd = '2011-05-25' and category = 'Инструментальное';

select pc.name, pc.ipAddress, pc.macAddress, software.descript from pc
inner join applications using(numberPC)
inner join software using(numberSoft) where applications.status = true and numberPC = 121;