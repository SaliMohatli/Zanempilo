USE ZanempiloDB;
GO

-- Donors
INSERT INTO Donor (First_Name, Last_Name, Email) VALUES
  ('Thabo',   'Mokoena',        'thabo.mokoena@example.com'),
  ('Naledi',  'Khumalo',        'naledi.khumalo@example.com'),
  ('Pieter',  'van der Merwe',  'pieter.vdmerwe@example.com'),
  ('Aisha',   'Patel',          'aisha.patel@example.com'),
  ('Sipho',   'Dlamini',        'sipho.dlamini@example.com');
GO

-- Donations (10 rows)
INSERT INTO Donation (Donor_ID, DonationType, Donation_Date, Description, Quantity) VALUES
  (1, 'Food',             '2025-08-20', 'Canned Food Packs',      100),
  (2, 'Medical Supplies', '2025-08-21', 'Surgical Masks',         200),
  (3, 'Clothing',         '2025-08-22', 'Warm Blankets',           50),
  (4, 'Hygiene',          '2025-08-23', 'Toothbrushes & Soap',    150),
  (5, 'Food',             '2025-08-24', 'Bottled Water Cases',     75),
  (1, 'Clothing',         '2025-08-25', 'Winter Jackets',          30),
  (2, 'Food',             '2025-08-26', 'Rice Bags (10 kg)',       60),
  (3, 'Medical Supplies', '2025-08-27', 'Bandages & Dressings',   120),
  (4, 'Food',             '2025-08-28', 'Snack Bars',              90),
  (5, 'Hygiene',          '2025-08-29', 'Sanitary Pads',          200);
GO

-- Stock (one row per donation)
INSERT INTO Stock (Donation_ID, Description, Quantity_In_Stock) VALUES
  (1,  'Canned Food Packs',        100),
  (2,  'Surgical Masks',           200),
  (3,  'Warm Blankets',             50),
  (4,  'Toothbrushes & Soap',      150),
  (5,  'Bottled Water Cases',       75),
  (6,  'Winter Jackets',            30),
  (7,  'Rice Bags (10 kg)',         60),
  (8,  'Bandages & Dressings',     120),
  (9,  'Snack Bars',                90),
  (10, 'Sanitary Pads',            200);
GO

-- Clients
INSERT INTO Client (First_Name, Last_Name, Email) VALUES
  ('Lindiwe', 'Zulu',     'lindiwe.zulu@example.com'),
  ('Johan',   'Smit',     'johan.smit@example.com'),
  ('Fatima',  'Mohamed',  'fatima.mohamed@example.com'),
  ('Lebo',    'Nkosi',    'lebo.nkosi@example.com'),
  ('Mandla',  'Nkosi',    'mandla.nkosi@example.com');
GO

-- Client Orders (10 rows)
INSERT INTO Client_Order (Client_ID, Stock_ID, Quantity, Order_Date, Order_Time) VALUES
  (1,  1,  20, '2025-09-01', '09:00:00'),
  (1,  5,  10, '2025-09-01', '09:30:00'),
  (2,  2,  15, '2025-09-02', '10:00:00'),
  (2,  8,   5, '2025-09-02', '10:30:00'),
  (3,  3,   2, '2025-09-03', '11:00:00'),
  (3, 10,  50, '2025-09-03', '11:30:00'),
  (4,  4,  30, '2025-09-04', '12:00:00'),
  (4,  7,  20, '2025-09-04', '12:30:00'),
  (5,  6,   5, '2025-09-05', '13:00:00'),
  (5,  9,  10, '2025-09-05', '13:30:00');
GO
