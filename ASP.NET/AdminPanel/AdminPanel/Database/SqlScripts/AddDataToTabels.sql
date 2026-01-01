USE ProniaAppDb



INSERT INTO Sliders (UpTitle, Title, SupTitle, ImagePath, [Order], IsDeleted)
VALUES
('YAZ KAMPANIYASI', 'Gul kolleksiyasi', 'Yeni sezon guller', '1-1-524x617.png', 2, 0),
('XUSUSI TEKLIF', 'Toy gulleri', 'Xususi dizayn buketler', '1-2-524x617.png', 1, 0),
('EN COX SATILAN', 'Dekorativ guller', 'Ev ve ofis ucun', '1-2-570x633.jpg', 4, 0),
('YENI MEHSULLAR', 'Mini buketler', 'Serfeli qiymetlerle', '1-2-270x300.jpg', 3, 0),
('TEST MEHSULLAR', 'Mini buketler', 'Serfeli qiymetlerle', '1-2-270x300.jpg', 1, 0);

INSERT INTO Purchaces
(Name, StatusReport, Office, Price, [Date], GrossAmount, IsDeleted)
VALUES
('Alvin Fisher', 'Ui design completed', 'East Mayra', 23230, '2018-07-18', 83127, 0),
('Emily Cunningham', 'support', 'Makennaton', 939, '2018-07-16', 29177, 0),
('Minnie Farmer', 'support', 'Agustinaborough', 30, '2018-04-30', 44617, 0),
('Betty Hunt', 'Ui design not completed', 'Lake Sandrafort', 571, '2018-06-25', 78952, 0),
('Myrtie Lambert', 'Ui design completed', 'Cassinbury', 36, '2018-11-05', 36422, 0),
('Jacob Kennedy', 'New project', 'Cletaborough', 314, '2018-07-12', 34167, 0),
('Ernest Wade', 'Levelled up', 'West Fidelmouth', 484, '2018-09-08', 50862, 0);


INSERT INTO Categories (Name, IsDeleted)
VALUES
('Bansai', 0),
('House Plants', 0),
('Indoor Living', 0),
('Perennnials', 0),
('Plant For Gift', 0),
('Garden Tools', 0);


INSERT INTO Products (Name, Price, Description, SKU, CategoryId, IsDeleted)
VALUES
-- Category 1 : Bansai
('BagdaGul', 25.23, 'Bagdaki Gul', 'CS-1.6', 1, 0),
('MiniBansai', 45.50, 'Mini bansai agaci', 'CS-1.9', 1, 0),
('DekorBansai', 60.00, 'Dekorativ bansai', 'CS-1.10', 1, 0),

-- Category 2 : House Plants
('DagdaGul', 34.24, 'Dagdaki gul', 'CS-1.7', 2, 0),
('EvGuluPlus', 40.00, 'Boyuk ev gulu', 'CS-1.11', 2, 0),
('YasillikBitkisi', 29.99, 'Ev ucun yasilliq', 'CS-1.12', 2, 0),

-- Category 3 : Indoor Living
('EvdeGul', 12.23, 'Evdeki gul', 'CS-1.8', 3, 0),
('MiniDekor', 18.75, 'Kicik dekorativ gul', 'CS-1.13', 3, 0),
('OfisGulu', 55.00, 'Ofis ucun gul', 'CS-1.14', 3, 0),

-- Category 4 : Perennnials
('BagGulu', 22.00, 'Bag ucun gul', 'CS-1.15', 4, 0),
('YazGulu', 27.80, 'Yaz movsumu gulu', 'CS-1.16', 4, 0),

-- Category 5 : Plant For Gift
('HediyyeGulu', 70.00, 'Hediyye ucun gul', 'CS-1.17', 5, 0),
('RomantikBuket', 85.00, 'Romantik buket', 'CS-1.18', 5, 0),

-- Category 6 : Garden Tools
('BagQaychisi', 15.00, 'Bag qaychisi', 'CS-1.19', 6, 0),
('SuSebeti', 20.00, 'Bag su sebeti', 'CS-1.20', 6, 0);



INSERT INTO ProductImages (ImageUrl, IsPrimary, ProductId, IsDeleted)
VALUES
('1-1-570x633.jpg', 1, 1, 0),
('1-2-570x633.jpg', 0, 1, 0),
('1-3-570x633.jpg', NULL, 1, 0),
('1-2-570x633.jpg', 1, 2, 0),
('1-3-570x633.jpg', 0, 2, 0),
('1-4-570x633.jpg', NULL, 2, 0),
('1-1-570x633.jpg', 1, 3, 0),
('1-2-570x633.jpg', 0, 3, 0),
('1-3-570x633.jpg', NULL, 3, 0),
('1-1-570x633.jpg', 1, 4, 0),
('1-2-570x633.jpg', 0, 4, 0),
('1-1-524x617.png', 1, 6, 0),
('1-2-524x617.png', 0, 6, 0),
('1-1920x465.jpg', NULL, 6, 0),
('1-1-1820x443.jpg', 1, 7, 0),
('1-1-770x300.jpg', 0, 7, 0),
('1-4-770x300.jpg', NULL, 7, 0);




INSERT INTO ProductImages (ImageUrl, IsPrimary, ProductId, IsDeleted)
VALUES
-- Product 7
('1-1-570x633.jpg', 1, 7, 0),
('1-2-570x633.jpg', 0, 7, 0),
('1-3-570x633.jpg', NULL, 7, 0),

-- Product 8
('1-2-570x633.jpg', 1, 8, 0),
('1-3-570x633.jpg', 0, 8, 0),
('1-4-570x633.jpg', NULL, 8, 0),

-- Product 9
('1-1-570x633.jpg', 1, 9, 0),
('1-2-570x633.jpg', 0, 9, 0),
('1-3-570x633.jpg', NULL, 9, 0),

-- Product 10
('1-1-570x633.jpg', 1, 10, 0),
('1-2-570x633.jpg', 0, 10, 0),

-- Product 11
('1-1-524x617.png', 1, 11, 0),
('1-2-524x617.png', 0, 11, 0),

-- Product 12
('1-1-570x633.jpg', 1, 12, 0),
('1-2-570x633.jpg', 0, 12, 0),

-- Product 13
('1-2-570x633.jpg', 1, 13, 0),
('1-3-570x633.jpg', 0, 13, 0),

-- Product 14
('1-1-570x633.jpg', 1, 14, 0),

-- Product 15
('1-2-570x633.jpg', 1, 15, 0);