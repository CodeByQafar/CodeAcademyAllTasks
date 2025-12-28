USE ProniaAppAdminDb

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
('BagdaGul', 25.23, 'Bagdaki Gul', 'Cs-1.6', 1, 0),
('DagdaGul', 34.24, 'Dagdaki gul', 'Cs-1.7', 2, 0),
('EvdeGul', 12.23, 'Evdeki gul', 'CS-1.8', 3, 0);



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
('1-1-570x633.jpg', 1, 4, 0),
('1-2-570x633.jpg', 0, 4, 0);
