create table PC
(
	numberPC int(4) not null primary key comment 'Номер ПК',
    ipAddress varchar(40) not null comment 'ip-адрес',
    CONSTRAINT `pcIp_chk` CHECK (ipAddress regexp '[1-9][0-9][0-9].[0-9][0-9][0-9].[0-9][0-9][0-9].[0-9]'),
    macAddress varchar(40) not null comment 'mac-адрес',
    CONSTRAINT `pcMac_chk` CHECK (macAddress regexp '[A-Z][0-9]-[A-Z][0-9]-[A-Z][A-Z]-[0-9][0-9][A-Z][0-9][A-Z][A-Z]'),
    name varchar(30) not null comment 'Название ПК',
    procModel varchar(30) not null comment 'Модель процессора',
    amountRAM integer not null comment 'Кол-во оперативной памяти',
    hdModel varchar(20) not null comment 'Модель жёсткого диска',
	typeVideoc varchar(30) not null comment 'Тип видеокарты',
    catSoft varchar(30) not null comment 'Категория установленного ПО',
    CONSTRAINT `pcCat_chk` CHECK (catSoft in ('Инструментальное','Прикладное','Системное' )),
	typePC varchar(20) not null comment 'Тип ПК',
    CONSTRAINT `pcType_chk` CHECK (typePC in ('Моноблок','Ноутбук','Стационарный' )),
    modelPC varchar(30) not null comment 'Модель ПК',
    statusPC varchar(30) not null comment 'Статус ПК',
    netStatus boolean not null comment 'Подключение к интернету',
    audience int not null comment 'Аудитория',
    typeRoom varchar(20) not null comment 'Тип помещения',
    invNum int(4) not null comment 'Инвертарный номер',
    addInfo varchar(30) comment 'Доп. информация',
    login varchar(30) comment 'Логин уч. записи адм.',
    password varchar(30) comment 'Пароль уч. записи адм'
);

create table Software 
(
	numberSoft int auto_increment not null primary key comment 'Номер ПО',
    typeLic varchar(20) not null comment 'Тип лицензии',
    statLic varchar(10) not null comment 'Статус лицензии',
    CONSTRAINT `softLic_chk` CHECK (statLic in('Активна','Неактивна')),
    validLic integer not null comment 'Действие лицензии',
    dateBuy date not null comment 'Дата покупки лицензии',
    dateEnd date not null comment 'Дата окончания лицензии',
    numLic int not null comment 'Количество лицензий',
    ver varchar(10) not null comment 'Версия',
    descript varchar(20) not null comment 'Описание',
    val int not null comment 'Стоимость лицензии',
    category varchar(20) not null comment 'Категория',
    CONSTRAINT `softCat_chk` CHECK (category in ('Инструментальное','Прикладное','Системное' )),
    division int not null comment 'Подразделение',
    needUpd bool not null comment 'Требует обновления',
    invNum int(4) not null comment 'Инвертарный номер',
    requirem varchar(255) not null comment 'Рекомендуемые системные требования',
    useLic int not null comment 'Использовано лицензий',
    licNumber varchar(7) not null comment 'Лиц. номер',
    CONSTRAINT `softNum_chk` CHECK (licNumber regexp '[0-9][0-9][0-9]-[0-9][0-9][0-9]'),
    pass varchar(20) not null comment 'Пароль',
    lang varchar(20) not null comment 'Язык',
    leftLic int not null comment 'Осталось лицензий'
);

create table Applications
(
	numberApp int auto_increment not null primary key comment 'Номер заявки',
    numberPC int(4) comment 'Номер ПК',
    numberSoft int comment 'Номер ПО',
    foreign key (numberPC) references PC(numberPC),
    foreign key (numberSoft) references Software(numberSoft),
    dateApp date not null comment 'Дата подачи заявки',
    status boolean not null comment 'Статус выполнения',
    executor varchar(30) not null comment 'Исполнитель, ФИО',
    dateComplete date comment 'Дата выполнения'
)