-- CREATE DATABASE novenytermesztes;
-- USE novenytermesztes;

CREATE TABLE kaktuszok (
	id INT PRIMARY KEY IDENTITY,
	nev VARCHAR(50),
	tud VARCHAR(50),
	nehezseg INT,
	vizigeny INT,
	fenyigeny INT);

INSERT INTO kaktuszok VALUES
('Orgona kaktusz', 'Cephalocereus senilis', 1, 150, 1000),
('Ezüstkaktusz', 'Pachycereus marginatus', 2, 100, 2000),
('Vitorlavirágú kaktusz', 'Epiphyllum anguliger', 3, 200, 1500),
('Oroszlánfarkú kaktusz', 'Mammillaria elongata', 1, 100, 2000),
('Golyós kaktusz', 'Echinocactus grusonii', 2, 100, 1500),
('Gömbkaktusz', 'Parodia magnifica', 1, 100, 1500),
('Császári kaktusz', 'Cereus peruvianus', 2, 150, 2000),
('Kőtörő kaktusz', 'Astrophytum asterias', 1, 100, 1000),
('Gyertyakaktusz', 'Gymnocalycium mihanovichii', 3, 200, 1500),
('Páfránykaktusz', 'Epiphyllum oxypetalum', 2, 150, 1000),
('Labdarózsa kaktusz', 'Gymnocalycium baldianum', 1, 100, 2000),
('Láncos kaktusz', 'Rhipsalis cereuscula', 2, 200, 1500),
('Húsevő kaktusz', 'Ferocactus latispinus', 1, 150, 2000),
('Kúpkaktusz', 'Rebutia muscula', 1, 100, 1500),
('Sárkánykaktusz', 'Selenicereus grandiflorus', 2, 150, 1000),
('Rózsa kaktusz', 'Pereskia grandifolia', 3, 200, 1500),
('Pisztráng kaktusz', 'Hatiora salicornioides', 1, 150, 1000),
('Leánykökörcsin kaktusz', 'Echinopsis chamaecereus', 1, 100, 2000),
('Ezerlábú kaktusz', 'Myrtillocactus geometrizans', 2, 150, 1500),
('Ördögnyelvű kaktusz', 'Stenocactus multicostatus', 1, 100, 2000),
('Napraforgó kaktusz', 'Helianthocereus speciosus', 2, 100, 1500),
('Varjúháj kaktusz', 'Euphorbia obesa', 1, 150, 1000),
('Méhkas kaktusz', 'Melocactus matanzanus', 3, 100, 2000),
('Ostoros kaktusz', 'Opuntia rufida', 1, 100, 1500),
('Csillagkaktusz', 'Astrophytum capricorne', 2, 150, 2000),
('Gombkaktusz', 'Ferocactus hamatacanthus', 2, 150, 1000),
('Babérlevél kaktusz', 'Schlumbergera truncata', 1, 200, 1500),
('Világtábla kaktusz', 'Opuntia monacantha', 3, 150, 2000),
('Nyúl farkú kaktusz', 'Hatiora gaertneri', 1, 150, 1000),
('Pálmalevél kaktusz', 'Ariocarpus retusus', 1, 100, 1500),
('Pipacs kaktusz', 'Mammillaria spinosissima', 2, 150, 1000),
('Domború kaktusz', 'Echinocereus pectinatus', 2, 100, 2000),
('Koronás kaktusz', 'Cleistocactus strausii', 3, 150, 1500),
('Tűkaktusz', 'Mammillaria hahniana', 1, 100, 2000),
('Csüngő kaktusz', 'Hoya carnosa', 2, 150, 1000),
('Bükkfa kaktusz', 'Pereskiopsis spathulata', 1, 100, 1500),
('Lóhere kaktusz', 'Mammillaria bombycina', 1, 100, 2000),
('Halházi kaktusz', 'Cactoideae pereskiopsis', 2, 150, 1500),
('Szegfű kaktusz', 'Echinopsis oxygona', 1, 150, 1000),
('Ragadós kaktusz', 'Notocactus scopa', 2, 200, 1500),
('Sarlós kaktusz', 'Sclerocactus parviflorus', 3, 100, 2000),
('Mandula kaktusz', 'Parodia erubescens', 1, 100, 1500);
