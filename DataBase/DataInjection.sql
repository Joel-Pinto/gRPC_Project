use teatroDB

Insert Into Role (Name)

values ('User')

Insert Into Role (Name)

values ('Gestor')

Insert Into Role (Name)

values ('Admin')

use teatroDB
Insert Into Wallet(ID_User, WalletAmount)

Values(1, 50)

Insert Into Wallet(ID_User, WalletAmount)

Values(2, 150)

Insert Into Wallet(ID_User, WalletAmount)

Values(3, 250)

Insert Into _User(ID_Role, ID_Wallet ,UserName, Location, Age, Name)

values (3, 3,'Fockester', 'Viseu', 22, 'Joel Pinto')

Insert Into _User(ID_Role, ID_Wallet ,UserName, Location, Age, Name)

values (2, 2,'CodingMaestro', 'Chaves', 22, 'Bruno Medeiros')

Insert Into _User(ID_Role, ID_Wallet ,UserName, Location, Age, Name)

values (1, 1,'Random123', 'Vila Real', 20, 'Random Marques')



Insert Into Theater (Location, Name, Contact, Address)

Values ('Lisboa' , 'Teatro da Politecnica', 963547212, 'Rua Direita');

Insert Into Theater (Location, Name, Contact, Address)

Values ('Porto' , 'Teatro da bandeira', 933572281, 'Rua Esquerda');

Insert Into Theater (Location, Name, Contact, Address)

Values ('Coimbra' , 'Teatro da Peixeira', 912562887, 'Rua De Cima');


use teatroDB
Insert Into Show (Name, StartDate, EndDate, Synopse, Price ,HasSeen)

Values ('LE PETIT BAIN', '1/06/2022', '3/06/2022', 'Há um homem que toma banho. Não. É um dançarino que está a esculpir nuvens.
Não',7.5,0)

Insert Into Show (Name, StartDate, EndDate, Synopse, Price , HasSeen)

Values ('BRUNA LOUISE', '2/06/2022', '5/06/2022', 'Bruna Louise é um dos principais destaques da comédia stand-up no Brasil.',10,0)

Insert Into Show (Name, StartDate, EndDate, Synopse, Price , HasSeen)

Values ('BELA E O MONSTRO', '5/06/2022', '7/06/2022', 'Protegido por uma capa poeirenta, um livro perfumado de rosas conta-nos a história de um rico mercador que perde toda a sua fortuna e parte numa louca viagem, 
prometendo restituir a dignidade à sua família.',9.5,0)

--Corresponde ao show LE PETIT BAIN
use teatroDB
Insert Into _Session (ID_show,Date, StartHour, EndHour, TotalSeats, AvailableSeats)

Values(1005,'1/06/2022','16:30','17:30',150,15)

Insert Into _Session (ID_show,Date, StartHour, EndHour, TotalSeats, AvailableSeats)

Values(1005,'2/06/2022','16:30','17:30',150,7)

Insert Into _Session (ID_show,Date, StartHour, EndHour, TotalSeats, AvailableSeats)

Values(1005,'3/06/2022','16:30','17:30',150,80)

use teatroDB
--Corresponde ao BRUNA LOUISE
Insert Into _Session (ID_show,Date, StartHour, EndHour, TotalSeats, AvailableSeats)

Values(1006,'2/06/2022','14:00','15:30',200,2)

Insert Into _Session (ID_show,Date, StartHour, EndHour, TotalSeats, AvailableSeats)

Values(1006,'3/06/2022','14:00','15:30',200,20)

Insert Into _Session (ID_show,Date, StartHour, EndHour, TotalSeats, AvailableSeats)

Values(1006,'4/06/2022','14:00','15:30',200,50)

Insert Into _Session (ID_show,Date, StartHour, EndHour, TotalSeats, AvailableSeats)

Values(1006,'5/06/2022','14:00','15:30',200,70)

use teatroDB
--Corresponde a BELA E O MONSTRO
Insert Into _Session (ID_show,Date, StartHour, EndHour, TotalSeats, AvailableSeats)

Values(1007,'5/06/2022','18:00','20:30',250,50)

Insert Into _Session (ID_show,Date, StartHour, EndHour, TotalSeats, AvailableSeats)

Values(1007,'6/06/2022','18:00','20:30',250,20)

Insert Into _Session (ID_show,Date, StartHour, EndHour, TotalSeats, AvailableSeats)

Values(1007,'7/06/2022','18:00','20:30',250,70)


use teatroDB
Insert Into Theater_Show (ID_theater, ID_show)

Values(1, 1005)

Insert Into Theater_Show (ID_theater, ID_show)

Values(2, 1006)

Insert Into Theater_Show (ID_theater, ID_show)

Values(3, 1007)

