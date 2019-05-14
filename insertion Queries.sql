
-- AIRCOMPANY table
INSERT INTO [dbo].[AIRCOMPANY] ([COMPANY_NAME] , [LOCATION]) VALUES ('The Boeing' , 'Chicago')
INSERT INTO [dbo].[AIRCOMPANY] ([COMPANY_NAME] , [LOCATION]) VALUES ('Airbus SE' , 'Netherlands')
INSERT INTO [dbo].[AIRCOMPANY] ([COMPANY_NAME] , [LOCATION]) VALUES ('UTC' , 'Farmington')
INSERT INTO [dbo].[AIRCOMPANY] ([COMPANY_NAME] , [LOCATION]) VALUES ('Northrop Grumman' , 'germany')


-- AIRCRAFT table
INSERT INTO [dbo].[AIRCRAFT] VALUES ( ' Growle' , 'EA-18G' ,'The Boeing',5000, 2001)
INSERT INTO [dbo].[AIRCRAFT] VALUES ( 'Hornet' , 'F/A-18' ,'The Boeing',5000, 2017)
INSERT INTO [dbo].[AIRCRAFT] VALUES ( 'Chinook' , 'CH-47' ,'The Boeing',5000, 2008)
INSERT INTO [dbo].[AIRCRAFT] VALUES ( 'Strike Eagle' , 'F-15' ,'The Boeing',5000, 2012)
INSERT INTO [dbo].[AIRCRAFT] VALUES ( 'Tanker' , 'KC-46A' ,'The Boeing',5000, 1999)
INSERT INTO [dbo].[AIRCRAFT] VALUES ( 'Poseidon' , 'P-8' ,'The Boeing',5000, 2001)
INSERT INTO [dbo].[AIRCRAFT] VALUES ( 'airlifter' , 'A400M' ,'Airbus SE' , 4000 , 2001)
INSERT INTO [dbo].[AIRCRAFT] VALUES ( 'MRTT' , 'A331' ,'Airbus SE' , 4000 , 2011)
INSERT INTO [dbo].[AIRCRAFT] VALUES ( 'XWB' , 'A320' ,'Airbus SE' , 4000 , 2005)
INSERT INTO [dbo].[AIRCRAFT] VALUES ( 'XWB' , 'A330' ,'Airbus SE' , 4000 , 1987)
INSERT INTO [dbo].[AIRCRAFT] VALUES ( 'XWB' , 'A350' ,'Airbus SE' , 4000 , 1999)
INSERT INTO [dbo].[AIRCRAFT] VALUES ( 'airborne' , 'C4ISR' ,'Northrop Grumman' , 6000 , 1999)
INSERT INTO [dbo].[AIRCRAFT] VALUES ( 'Spirit bomber' , 'B-2' ,'Northrop Grumman' , 6000 , 1999)
INSERT INTO [dbo].[AIRCRAFT] VALUES ( 'Raider bomber' , 'B-21' ,'Northrop Grumman' , 6000 , 1999)
INSERT INTO [dbo].[AIRCRAFT] VALUES ( 'unmanned' , 'X-47B' ,'Northrop Grumman' , 6000 , 1999)


-- PASSENGER table
INSERT INTO [dbo].[PASSENGER] VALUES ('AA110' ,  'AymenAA110@gmail.com' , 'Aymen' , 'Admen')
INSERT INTO [dbo].[PASSENGER] VALUES ('AA111' ,'AhmedAA111@gmail.com' , 'Ahmed' , 'Admen')
INSERT INTO [dbo].[PASSENGER] VALUES ('AA112' ,'LaliaAA112@gmail.com'  , 'Lalia' ,'Admen')
INSERT INTO [dbo].[PASSENGER] VALUES ('AA113' ,'AmiraAA113@yahoo.com' , 'Amira' , 'Admen')

-- Flights
INSERT INTO [dbo].[FLIGHT]
VALUES( '20190718 10:00:00 AM' , 'Alexanderia' , 'P110' , 0 , 0.5 , 'Cairo' , 'FN110' , 1000)
INSERT INTO [dbo].[FLIGHT]
VALUES( '20191204 01:45:00 PM' , 'Alexanderia' , 'P111' , 0 , 0.5 , 'Cairo' , 'FN111' , 1000)
INSERT INTO [dbo].[FLIGHT]
VALUES( '20190405 12:30:00 AM' , 'Alexanderia' , 'P112' , 0 , 0.5 , 'Cairo' , 'FN112' , 1000)

INSERT INTO [dbo].[FLIGHT]
VALUES( '20201018 11:30:00 AM' , 'Cairo' , 'P113' , 0 , 2 , 'Paris' , 'FN113' , 1000)
INSERT INTO [dbo].[FLIGHT]
VALUES( '20190620 05:10:00 AM' , 'Cairo' , 'P114' , 0 , 2 , 'Paris' , 'FN114' , 1000)
INSERT INTO [dbo].[FLIGHT]
VALUES( '20190830 10:30:00 AM' , 'Cairo' , 'P115' , 0 , 2 , 'Paris' , 'FN115' , 1000)

INSERT INTO [dbo].[FLIGHT]
VALUES( '20190926 04:15:00 AM' , 'Alexanderia' , 'P116' , 2 , 6 , 'Chicago' , 'FN116' , 700)
INSERT INTO [dbo].[FLIGHT]
VALUES( '20190427 12:30:00 AM' , 'Alexanderia' , 'P117' , 2 , 6 , 'Chicago' , 'FN117' , 500)
INSERT INTO [dbo].[FLIGHT]
VALUES( '20191020 10:30:00 AM' , 'Alexanderia' , 'P118' , 2 , 6 , 'Chicago' , 'FN118' , 500)

INSERT INTO [dbo].[FLIGHT]
VALUES( '20191120 05:40:00 AM' , 'Aswan' , 'P119' , 0 , 1.5 , 'Cairo' , 'FN119' , 500)
INSERT INTO [dbo].[FLIGHT]
VALUES('20190325 06:30:00 AM' , 'Aswan' , 'P120' , 0 , 1.5 , 'Cairo' , 'FN120' , 400)
INSERT INTO [dbo].[FLIGHT]
VALUES( '20190623 07:45:00 AM' , 'Aswan' , 'P121' , 0 , 1.5 , 'Cairo' , 'FN121' , 800)

INSERT INTO [dbo].[FLIGHT]
VALUES( '20191118 10:40:00 AM' , 'Cairo' , 'P122' , 0 , 1.5 , 'Riyadh' , 'FN122' , 600)
INSERT INTO [dbo].[FLIGHT]
VALUES( '20190115 11:30:00 AM' , 'Cairo' , 'P123' , 0 , 1.5 , 'Riyadh' , 'FN123' , 600)
INSERT INTO [dbo].[FLIGHT]
VALUES( '20190920 12:30:00 AM' , 'Cairo' , 'P124' , 0 , 1.5 , 'Riyadh' , 'FN124' , 600)

INSERT INTO [dbo].[FLIGHT]
VALUES( '20190218 12:15:00 AM' , 'Alexanderia' , 'P125' , 0 , 1.5 , 'wien' , 'FN125' , 600)
INSERT INTO [dbo].[FLIGHT]
VALUES( '20190720 06:30:00 AM' , 'Alexanderia' , 'P126' , 0 , 1.5 , 'wien' , 'FN126' , 600)
INSERT INTO [dbo].[FLIGHT]
VALUES( '20191101 04:20:00 AM' , 'Alexanderia' , 'P127' , 0 , 1.5 , 'wien' , 'FN127' , 600)

INSERT INTO [dbo].[FLIGHT]
VALUES( '20190130 10:30:00 AM' , 'Alexanderia' , 'P128' , 0 , 1.5 , 'Berlin' , 'FN128' , 600)
INSERT INTO [dbo].[FLIGHT]
VALUES( '20190718 10:30:00 AM' , 'Alexanderia' , 'P129' , 0 , 1.5 , 'Berlin' , 'FN129' , 600)
INSERT INTO [dbo].[FLIGHT]
VALUES( '20191030 10:30:00 AM' , 'Alexanderia' , 'P130' , 0 , 1.5 , 'Berlin' , 'FN130' , 600)



