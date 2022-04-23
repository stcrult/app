CREATE TABLE public.employee
(
    id integer NOT NULL GENERATED ALWAYS AS IDENTITY,
    name character varying(50),
    birthdate date,
    email character varying(100),
    PRIMARY KEY (id),
    CONSTRAINT email UNIQUE (email)
);


insert into employee (name, birthdate, email) values ('Ricardo', '2020-11-02', 'rjalland0@discovery.com');
insert into employee (name, birthdate, email) values ('Jarid', '2021-03-15', 'jenrrico1@desdev.cn');
insert into employee (name, birthdate, email) values ('Brannon', '2022-03-13', 'bcurrell2@adobe.com');
insert into employee (name, birthdate, email) values ('Jill', '2020-02-05', 'janstiss3@blogtalkradio.com');
insert into employee (name, birthdate, email) values ('Iris', '2022-03-25', 'ilehr4@wordpress.com');
insert into employee (name, birthdate, email) values ('Killy', '2020-11-19', 'kbonevant5@elegantthemes.com');
insert into employee (name, birthdate, email) values ('Brandtr', '2020-07-31', 'blaugier6@pbs.org');
insert into employee (name, birthdate, email) values ('Reid', '2022-03-11', 'rporte7@cam.ac.uk');
insert into employee (name, birthdate, email) values ('Iormina', '2020-12-26', 'ihaysom8@jiathis.com');
insert into employee (name, birthdate, email) values ('Brandy', '2021-01-15', 'bhiddersley9@reuters.com');
insert into employee (name, birthdate, email) values ('Guglielma', '2020-08-03', 'gkulica@examiner.com');
insert into employee (name, birthdate, email) values ('Toby', '2019-11-01', 'tfowlstonb@linkedin.com');
insert into employee (name, birthdate, email) values ('Jerrie', '2020-05-22', 'jfairbridgec@nih.gov');
insert into employee (name, birthdate, email) values ('Darline', '2021-02-12', 'dreveyd@google.com');
insert into employee (name, birthdate, email) values ('Bent', '2020-03-19', 'bmotione@mapy.cz');
insert into employee (name, birthdate, email) values ('Noak', '2020-07-08', 'nrosensteinf@google.cn');
insert into employee (name, birthdate, email) values ('Norri', '2020-04-25', 'nbarracloughg@ucsd.edu');
insert into employee (name, birthdate, email) values ('Devan', '2019-10-30', 'dstannush@linkedin.com');
insert into employee (name, birthdate, email) values ('Kristina', '2020-01-05', 'knewisi@vistaprint.com');
insert into employee (name, birthdate, email) values ('Kinsley', '2022-04-14', 'khellenj@senate.gov');
insert into employee (name, birthdate, email) values ('Raoul', '2022-04-04', 'rgiffardk@indiegogo.com');
insert into employee (name, birthdate, email) values ('Dav', '2022-03-08', 'drandlesl@dagondesign.com');
insert into employee (name, birthdate, email) values ('Debbie', '2020-12-11', 'dheggm@imageshack.us');
insert into employee (name, birthdate, email) values ('Talia', '2020-02-09', 'tminghin@nba.com');
insert into employee (name, birthdate, email) values ('Bernadine', '2020-12-31', 'bguerrino@wisc.edu');
insert into employee (name, birthdate, email) values ('Alvin', '2021-11-23', 'acordinglyp@auda.org.au');
insert into employee (name, birthdate, email) values ('Dasi', '2020-01-21', 'dfalconerq@uiuc.edu');
insert into employee (name, birthdate, email) values ('Connor', '2021-04-18', 'ccadanyr@techcrunch.com');
insert into employee (name, birthdate, email) values ('Rachel', '2020-02-03', 'rparrams@arstechnica.com');
insert into employee (name, birthdate, email) values ('Logan', '2021-11-27', 'ljacoxt@paypal.com');
insert into employee (name, birthdate, email) values ('Nissie', '2020-03-29', 'noxshottu@chronoengine.com');
insert into employee (name, birthdate, email) values ('Hernando', '2021-02-22', 'hleflemingv@addthis.com');
insert into employee (name, birthdate, email) values ('Darby', '2021-01-30', 'dancketillw@wired.com');
insert into employee (name, birthdate, email) values ('Grier', '2020-05-06', 'gworrellx@pinterest.com');
insert into employee (name, birthdate, email) values ('Andris', '2021-09-27', 'amoensy@biblegateway.com');
insert into employee (name, birthdate, email) values ('Tamara', '2021-07-03', 'tbroadz@apache.org');
insert into employee (name, birthdate, email) values ('Barrie', '2021-01-13', 'bloalday10@infoseek.co.jp');
insert into employee (name, birthdate, email) values ('Moises', '2020-11-17', 'mcoundley11@wsj.com');
insert into employee (name, birthdate, email) values ('Dodie', '2020-03-29', 'dyerrill12@nature.com');
insert into employee (name, birthdate, email) values ('Bren', '2021-06-13', 'bantognozzii13@is.gd');
insert into employee (name, birthdate, email) values ('Constance', '2021-07-18', 'cruller14@foxnews.com');
insert into employee (name, birthdate, email) values ('Margaretha', '2021-06-07', 'mhinstridge15@woothemes.com');
insert into employee (name, birthdate, email) values ('Celia', '2021-11-26', 'cgalsworthy16@slashdot.org');
insert into employee (name, birthdate, email) values ('Buckie', '2021-05-11', 'bgerson17@rediff.com');
insert into employee (name, birthdate, email) values ('Devonna', '2020-03-01', 'dbertlin18@eventbrite.com');
insert into employee (name, birthdate, email) values ('Gerti', '2020-07-20', 'gheathcott19@abc.net.au');
insert into employee (name, birthdate, email) values ('Lazarus', '2020-05-27', 'leim1a@e-recht24.de');
insert into employee (name, birthdate, email) values ('Ardine', '2021-08-02', 'athorndycraft1b@omniture.com');
insert into employee (name, birthdate, email) values ('Carolee', '2021-10-18', 'cfried1c@slate.com');
insert into employee (name, birthdate, email) values ('Aggie', '2021-11-26', 'atetlow1d@tiny.cc');


update employee set name = 'Angle' where email = 'atetlow1d@tiny.cc';
update employee set name = 'Gerald' where birthdate = '2020-07-20';
update employee set birthdate = '1980-03-20' where id = 1;
update employee set email = 'dd@nowhere.com' where id = 10;
update employee set email = 'dfkdfk@na.com' where name = 'Bren';


delete from employee where id = 1;
delete from employee where name = 'Gerti';
delete from employee where birthdate = '2021-11-26';
delete from employee where email = 'dancketillw@wired.com';
delete from employee where name like 'A%'
