#create database moto;
#use moto;

create table cat
(
	idCat int auto_increment not null primary key comment 'Номер категории',
    nme varchar(40) not null comment 'Название категории',
    img varchar(30) not null comment 'Изображение'
);

create table firm
(
	idFirm int auto_increment not null primary key comment 'Номер фирмы',
    nme varchar(40) not null comment 'Название фирмы'
);

create table products
(
	idProduct int auto_increment not null primary key comment 'Номер товара',
    idFirm int not null comment 'Номер фирмы',
    idCat int not null comment 'Номер категории',
    title varchar(100) not null comment 'Название товара',
    descript text not null comment 'Описание товара',
    price int not null comment 'Цена товара',
    inStock int not null comment 'В наличии товара',
    img varchar(30) not null comment 'Изображение',
    foreign key (idFirm) references firm(idFirm),
    foreign key (idCat) references cat(idCat)
);

create table users
(
	idUser int auto_increment not null primary key comment 'Номер пользователя',
    username varchar(40) not null comment 'Логин',
    pass varchar(30) not null comment 'Пароль',
    email varchar(40) not null comment 'Email',
    bonuses int not null comment 'Кол-во бонусов',
    fio varchar(80) not null comment 'ФИО покупателя',
    phone varchar(32) not null comment 'Номер телефона',
    address varchar(40) comment 'Адрес'
);

create table orders
(
	idOrder int auto_increment not null primary key comment 'Номер заказа',
    idUser int comment 'Идентификатор покупателя',
    foreign key (idUser) references users(idUser),
    fio varchar(80) not null comment 'ФИО покупателя',
    phone varchar(32) not null comment 'Номер телефона покупателя',
    address varchar(40) comment 'Адрес заказчика',
    bonus int comment 'Кол-во бонусов, которое будет получено',
    datebuy datetime not null comment 'Дата заказа'
);

create table ordProd
(
	id int not null comment 'Номер заказанного товара',
    idProduct int not null comment 'Номер товара',
    idOrder int not null comment 'Номер заказа',
    count int not null comment 'Количество товара',
    foreign key (idOrder) references orders(idOrder),
    foreign key (idProduct) references products(idProduct)
);
