USE ZanempiloDB;
GO

/* =========================================
   sp_ManageDonations
   INSERT / UPDATE / DELETE on Donation
   ========================================= */
IF OBJECT_ID('sp_ManageDonations','P') IS NOT NULL
  DROP PROCEDURE sp_ManageDonations;
GO

CREATE PROCEDURE sp_ManageDonations
  @Action          NVARCHAR(10),
  @Donation_ID     INT           = NULL,  -- for UPDATE/DELETE
  @Donor_ID        INT           = NULL,  -- for INSERT/UPDATE
  @DonationType    NVARCHAR(50)  = NULL,  -- for INSERT/UPDATE
  @Donation_Date   DATETIME      = NULL,  -- for INSERT/UPDATE
  @Description     NVARCHAR(50)  = NULL,  -- optional
  @Quantity        INT           = NULL   -- for INSERT/UPDATE
AS
BEGIN
  SET NOCOUNT ON;

  IF @Action = 'INSERT'
  BEGIN
    IF NOT EXISTS (SELECT 1 FROM Donor WHERE Donor_ID = @Donor_ID)
      THROW 50000, FORMATMESSAGE('Donor_ID %d does not exist.', @Donor_ID), 1;

    INSERT INTO Donation
      (Donor_ID, DonationType, Donation_Date, Description, Quantity)
    VALUES
      (@Donor_ID, @DonationType, @Donation_Date, @Description, @Quantity);

    SELECT SCOPE_IDENTITY() AS NewDonationID;
    RETURN;
  END

  ELSE IF @Action = 'UPDATE'
  BEGIN
    UPDATE Donation
      SET Donor_ID      = @Donor_ID,
          DonationType  = @DonationType,
          Donation_Date = @Donation_Date,
          Description   = @Description,
          Quantity      = @Quantity
    WHERE Donation_ID = @Donation_ID;

    SELECT @@ROWCOUNT AS RowsAffected;
    RETURN;
  END

  ELSE IF @Action = 'DELETE'
  BEGIN
    DELETE FROM Donation
    WHERE Donation_ID = @Donation_ID;

    SELECT @@ROWCOUNT AS RowsDeleted;
    RETURN;
  END

  THROW 50001, 'Invalid @Action. Use INSERT, UPDATE or DELETE.', 1;
END;
GO


/* =========================================
   sp_ManageDonor
   INSERT / UPDATE / DELETE on Donor
   ========================================= */
IF OBJECT_ID('sp_ManageDonor','P') IS NOT NULL
  DROP PROCEDURE sp_ManageDonor;
GO

CREATE PROCEDURE sp_ManageDonor
  @Action      NVARCHAR(10),
  @Donor_ID    INT           = NULL,
  @First_Name  NVARCHAR(20)  = NULL,
  @Last_Name   NVARCHAR(20)  = NULL,
  @Email       NVARCHAR(40)  = NULL
AS
BEGIN
  SET NOCOUNT ON;

  IF @Action = 'INSERT'
  BEGIN
    INSERT INTO Donor (First_Name, Last_Name, Email)
      VALUES (@First_Name, @Last_Name, @Email);
    SELECT SCOPE_IDENTITY() AS NewDonorID;
    RETURN;
  END

  ELSE IF @Action = 'UPDATE'
  BEGIN
    UPDATE Donor
      SET First_Name = @First_Name,
          Last_Name  = @Last_Name,
          Email      = @Email
    WHERE Donor_ID = @Donor_ID;

    SELECT @@ROWCOUNT AS RowsAffected;
    RETURN;
  END

  ELSE IF @Action = 'DELETE'
  BEGIN
    DELETE FROM Donor
    WHERE Donor_ID = @Donor_ID;

    SELECT @@ROWCOUNT AS RowsDeleted;
    RETURN;
  END

  THROW 50002, 'Invalid @Action. Use INSERT, UPDATE or DELETE.', 1;
END;
GO


/* =========================================
   sp_ManageStock
   INSERT / UPDATE / DELETE on Stock
   ========================================= */
IF OBJECT_ID('sp_ManageStock','P') IS NOT NULL
  DROP PROCEDURE sp_ManageStock;
GO

CREATE PROCEDURE sp_ManageStock
  @Action            NVARCHAR(10),
  @Stock_ID          INT           = NULL,
  @Donation_ID       INT           = NULL,
  @Description       NVARCHAR(50)  = NULL,
  @Quantity_In_Stock INT           = NULL
AS
BEGIN
  SET NOCOUNT ON;

  IF @Action = 'INSERT'
  BEGIN
    INSERT INTO Stock (Donation_ID, Description, Quantity_In_Stock)
      VALUES (@Donation_ID, @Description, @Quantity_In_Stock);
    SELECT SCOPE_IDENTITY() AS NewStockID;
    RETURN;
  END

  ELSE IF @Action = 'UPDATE'
  BEGIN
    UPDATE Stock
      SET Donation_ID       = @Donation_ID,
          Description       = @Description,
          Quantity_In_Stock = @Quantity_In_Stock
    WHERE Stock_ID = @Stock_ID;

    SELECT @@ROWCOUNT AS RowsAffected;
    RETURN;
  END

  ELSE IF @Action = 'DELETE'
  BEGIN
    DELETE FROM Stock
    WHERE Stock_ID = @Stock_ID;

    SELECT @@ROWCOUNT AS RowsDeleted;
    RETURN;
  END

  THROW 50003, 'Invalid @Action. Use INSERT, UPDATE or DELETE.', 1;
END;
GO


/* =========================================
   sp_ManageClient
   INSERT / UPDATE / DELETE on Client
   ========================================= */
IF OBJECT_ID('sp_ManageClient','P') IS NOT NULL
  DROP PROCEDURE sp_ManageClient;
GO

CREATE PROCEDURE sp_ManageClient
  @Action     NVARCHAR(10),
  @Client_ID  INT           = NULL,
  @First_Name NVARCHAR(20)  = NULL,
  @Last_Name  NVARCHAR(20)  = NULL,
  @Email      NVARCHAR(40)  = NULL
AS
BEGIN
  SET NOCOUNT ON;

  IF @Action = 'INSERT'
  BEGIN
    INSERT INTO Client (First_Name, Last_Name, Email)
      VALUES (@First_Name, @Last_Name, @Email);
    SELECT SCOPE_IDENTITY() AS NewClientID;
    RETURN;
  END

  ELSE IF @Action = 'UPDATE'
  BEGIN
    UPDATE Client
      SET First_Name = @First_Name,
          Last_Name  = @Last_Name,
          Email      = @Email
    WHERE Client_ID = @Client_ID;

    SELECT @@ROWCOUNT AS RowsAffected;
    RETURN;
  END

  ELSE IF @Action = 'DELETE'
  BEGIN
    DELETE FROM Client
    WHERE Client_ID = @Client_ID;

    SELECT @@ROWCOUNT AS RowsDeleted;
    RETURN;
  END

  THROW 50004, 'Invalid @Action. Use INSERT, UPDATE or DELETE.', 1;
END;
GO


/* =========================================
   sp_ManageClientOrder
   INSERT / UPDATE / DELETE on Client_Order
   ========================================= */
IF OBJECT_ID('sp_ManageClientOrder','P') IS NOT NULL
  DROP PROCEDURE sp_ManageClientOrder;
GO

CREATE PROCEDURE sp_ManageClientOrder
  @Action     NVARCHAR(10),
  @Order_ID   INT          = NULL,
  @Client_ID  INT          = NULL,
  @Stock_ID   INT          = NULL,
  @Quantity   INT          = NULL,
  @Order_Date DATE         = NULL,
  @Order_Time TIME         = NULL
AS
BEGIN
  SET NOCOUNT ON;

  IF @Action = 'INSERT'
  BEGIN
    INSERT INTO Client_Order
      (Client_ID, Stock_ID, Quantity, Order_Date, Order_Time)
    VALUES
      (@Client_ID, @Stock_ID, @Quantity, @Order_Date, @Order_Time);

    SELECT SCOPE_IDENTITY() AS NewOrderID;
    RETURN;
  END

  ELSE IF @Action = 'UPDATE'
  BEGIN
    UPDATE Client_Order
      SET Client_ID  = @Client_ID,
          Stock_ID   = @Stock_ID,
          Quantity   = @Quantity,
          Order_Date = @Order_Date,
          Order_Time = @Order_Time
    WHERE Order_ID = @Order_ID;

    SELECT @@ROWCOUNT AS RowsAffected;
    RETURN;
  END

  ELSE IF @Action = 'DELETE'
  BEGIN
    DELETE FROM Client_Order
    WHERE Order_ID = @Order_ID;

    SELECT @@ROWCOUNT AS RowsDeleted;
    RETURN;
  END

  THROW 50005, 'Invalid @Action. Use INSERT, UPDATE or DELETE.', 1;
END;
GO
