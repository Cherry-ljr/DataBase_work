--�˿ͱ�
CREATE TABLE Customer
	(nickname     VARCHAR(8),
	 username   VARCHAR(8)
	 CONSTRAINT GK_G1 UNIQUE,
	 passwd VARCHAR(8)
	 CONSTRAINT GK_G2 NOT NULL,
	 vip	  VARCHAR(1)
	 CONSTRAINT GK_VIP CHECK (vip IN('Y','N')),
	 tel		  VARCHAR(15),
	 address		  VARCHAR(15),
	 myinfo		VARCHAR(30),
	 cus_age	INT
	 CONSTRAINT GK_G3 CHECK (cus_age BETWEEN 5 AND 100),
	 cus_sex	VARCHAR(5)
	 CONSTRAINT GK_G4 CHECK (cus_sex IN('��','Ů')),
	 CONSTRAINT GK_PK PRIMARY KEY(username)
	);


--����Ա��
CREATE TABLE Manager
	(nickname     VARCHAR(8),
	 username   VARCHAR(8),
	 passwd VARCHAR(8)
	 CONSTRAINT M1 NOT NULL,
	 tel		  VARCHAR(15),
	 address		  VARCHAR(15),
	 myinfo		VARCHAR(30),
	 CONSTRAINT M2 PRIMARY KEY(username)
	);
	
--��Ӧ�̼�¼��
CREATE TABLE Supporter
	(Sup_no		VARCHAR(8),
	 Sup_name		VARCHAR(8)
	 CONSTRAINT GYS_NAME NOT NULL,
	 address			VARCHAR(5),
	 tel			VARCHAR(15),
	 CONSTRAINT GYS_PK PRIMARY KEY(Sup_no)
	);
	alter table Supporter alter column Sup_name varchar(15)
	alter table Supporter alter column address varchar(15)
	
	alter table Book add Book_category varchar(10)

--�鼮��
CREATE TABLE Book
	(Book_no	int primary key identity(1,1),
	 name		VARCHAR(8),
	 author			VARCHAR(5),
	 publish			VARCHAR(15),
	 origin_price	FLOAT,
	 price			FLOAT,
	 Sup_no			VARCHAR(8),
	 Book_category VARCHAR(30),
	 CONSTRAINT BOOK_FK FOREIGN KEY(Sup_no) REFERENCES Supporter(Sup_no)
	);
	

	
	
--���ﳵ
CREATE TABLE ShoppingCar
	(SC_no		    int primary key identity(1,1),
	 username		VARCHAR(8),
	 Book_no		INT,
	 Book_num		INT,
	);
	
	
alter table ShoppingCar add SC_status varchar(2) CHECK (SC_status IN('Y','N'))


--������Ϣ��
CREATE TABLE OrderInfo
	(Order_no		int primary key identity(1,1),
	 username		VARCHAR(8),
	 SC_no		INT,
	 status		VARCHAR(1), 
	 time 		DATETIME,
	 CONSTRAINT OI_STATUS CHECK (status IN('Y','N')),

	 CONSTRAINT OI_FK2 FOREIGN KEY(SC_no)
	 REFERENCES ShoppingCar(SC_no)
	);

--���ͼ���
CREATE TABLE Repository
	(Rep_no			int primary key identity(1,1),
	 Book_no		INT,
	 Book_num			INT,
	);
insert into Repository(Book_no,Book_num) values(1,5)
--insert into Repository(Book_no,Book_num) values(2,5)
insert into Repository(Book_no,Book_num) values(3,5)
insert into Repository(Book_no,Book_num) values(4,5)
insert into Repository(Book_no,Book_num) values(5,5)

select * from Book
insert into Book(name,author,publish,origin_price,price,Book_category) 
values('����','����','���ݴ�ѧ������','20','30','��ѧ����')
insert into Book(name,author,publish,origin_price,price,Book_category)
 values('�㷨��������','����','���ݴ�ѧ������','20','30','��ѧ����')

insert into Book(name,author,publish,origin_price,price,Book_category) 
values('Java','����','���ݴ�ѧ������','20','30','����')
insert into Book(name,author,publish,origin_price,price,Book_category)
 values('����','����','�廪��ѧ������','20','30','��ѧ')

insert into Book(name,author,publish,origin_price,price,Book_category) 
values('���ݿ�','����','���ݴ�ѧ������','20','30','��ѧ����')
insert into Book(name,author,publish,origin_price,price,Book_category) 
values('��ѧӢ��','����','���ݴ�ѧ������','20','30','����ѧ')
insert into Book(name,author,publish,origin_price,price,Book_category) 
values('����','����','�廪��ѧ������','20','30','����ѧ')
insert into Book(name,author,publish,origin_price,price,Book_category) 
values('����','����','���ݴ�ѧ������','20','30','��ѧ����')
insert into Book(name,author,publish,origin_price,price,Book_category)
 values('��������','����','���ݴ�ѧ������','20','30','����')
insert into Book(name,author,publish,origin_price,price,Book_category)
 values('����','�����','���ݴ�ѧ������','20','30','��ѧ')


select Book_no '���',author'����',publish'������',price'�۸�',Sup_no'��Ӧ�̱��' from [Book] where name like '%��%';

select * from ShoppingCar;
select * from OrderInfo;
delete ShoppingCar;
select * from Repository



select * from Customer
select book_num from Repository where book_no = 1

select * from Book
select sum(Book_num) from ShoppingCar

select * from Customer



--�û���ѯ������ͼ
create view cus_orderSerch
as 
select OrderInfo.username,Book.name ,OrderInfo.time,OrderInfo.status
from Book,OrderInfo,ShoppingCar
where OrderInfo.SC_no=ShoppingCar.SC_no and Book.Book_no=ShoppingCar.Book_no

--�û���ѯ�鼮��ͼ
drop view cus_bookSerch
create view cus_bookSerch
as 
select Book_no'�鼮���', name'����',author'����',publish'������',Sup_no'���',Book_category'�鼮���'
from Book








select name'����',time'�µ�ʱ��' from cus_orderSerch where status='N' and username ='cherry'


select * from Customer
insert into Manager(nickname,username,passwd) values('LJR','Admin','12345')

select * from OrderInfo

select nickname'�˿��ǳ�',username'�û���',passwd'����',vip'��Ա',tel '�绰',address '��ַ',cus_sex'�Ա�',cus_age'����' from [Customer]
select * from Customer

create trigger trg_A
on Customer
for delete

as
begin

declare @str char(20)
select @str= username from deleted
delete OrderInfo where username=@str
delete ShoppingCar where username=@str
end

drop trigger trg_A
select * from Customer
delete Customer where username='lixiang'




select * from Supporter
delete from Supporter where Sup_no = 111 

#��ӹ�Ӧ��
insert into Supporter(Sup_no,Sup_name,address,tel) values('111','���ݹ�Ӧ��','����ʡ','134738')
insert into Supporter(Sup_no,Sup_name,address,tel) values('222','�Ĵ���Ӧ��','�Ĵ�ʡ','137238')
insert into Supporter(Sup_no,Sup_name,address,tel) values('333','���칩Ӧ��','������','1112138')
insert into Supporter(Sup_no,Sup_name,address,tel) values('444','������Ӧ��','����ʡ','2323238')


--�����ͼ
select * from Repository
create view Repository_manager
as 
select Book.Book_no,Book.name ,Repository.Book_num
from Book,Repository
where Book.Book_no=Repository.Book_no


--��ȡ���һ������
SELECT TOP 1 * FROM Book order by Book_no desc
select * from Book
create trigger trg_B
on Book
for delete
as
begin

declare @str char(20)
select @str= Book_no from deleted
delete Repository where Book_no=@str
end
delete  from Book where Book_no=13

drop trigger trg_B