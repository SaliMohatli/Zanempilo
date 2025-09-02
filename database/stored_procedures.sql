USE ZanempiloDB;
GO

/*
  ===========================================
  sp_ManageDonationType
  INSERT, UPDATE, DELETE on Donation_Type
  ===========================================
*/
IF OBJECT_ID('sp_ManageDonations','P') IS NOT NULL
  DROP PROCEDURE sp_ManageDonations;
GO

CREATE PROCEDURE sp_ManageDonations
  @Action          NVARCHAR(10),           -- 'INSERT', 'UPDATE' or 'DELETE'
  @Donation_ID     INT           = NULL,   -- Required for UPDATE / DELETE
  @Donor_ID        INT           = NULL,   -- Required for INSERT / UPDATE
  @DonationType    NVARCHAR(50)  = NULL,   -- Required for INSERT / UPDATE
  @Donation_Date   DATETIME      = NULL,   -- Required for INSERT / UPDATE
  @Description     NVARCHAR(50)  = NULL,   -- Optional
  @Quantity        INT           = NULL    -- Required for INSERT / UPDATE
AS
BEGIN
  SET NOCOUNT ON;

  IF @Action = 'INSERT'
  BEGIN
    -- ensure donor exists
    IF NOT EXISTS (SELECT 1 FROM Donor WHERE Donor_ID = @Donor_ID)
      RAISERROR('Donor_ID %d does not exist.', 16, 1, @Donor_ID);

    INSERT INTO Donation
      (Donor_ID, DonationType, Donation_Date, Description, Quantity)
    VALUES
      (@Donor_ID, @DonationType, @Donation_Date, @Description, @Quantity);

    SELECT SCOPE_IDENTITY() AS NewDonationID;
  END
  ELSE IF @Action = 'UPDATE'
  BEGIN
    UPDATE Donation
      SET Donor_ID       = @Donor_ID,
          DonationType   = @DonationType,
          Donation_Date  = @Donation_Date,
          Description    = @Description,
          Quantity       = @Quantity
    WHERE Donation_ID = @Donation_ID;

    SELECT @@ROWCOUNT AS RowsAffected;
  END
  ELSE IF @Action = 'DELETE'
  BEGIN
    DELETE FROM Donation
    WHERE Donation_ID = @Donation_ID;

    SELECT @@ROWCOUNT AS RowsDeleted;
  END
  ELSE
  BEGIN
    RAISERROR('Invalid @Action. Use INSERT, UPDATE or DELETE.', 16, 1);
  END
END;
GO


/*
  ===========================================
  sp_ManageDonor
  INSERT, UPDATE, DELETE on Donor
  ===========================================
*/
IF OBJECT_ID('sp_ManageDonor','P') IS NOT NULL
  DROP PROCEDURE sp_ManageDonor;
GO

CREATE PROCEDURE sp_ManageDonor
  @Action      NVARCHAR(10),          -- 'INSERT', 'UPDATE', 'DELETE'
  @Donor_ID    INT            = NULL, -- Required for UPDATE / DELETE
  @First_Name  NVARCHAR(20) = NULL,  -- Required for INSERT / UPDATE
  @Last_Name   NVARCHAR(20) = NULL,  -- Required for INSERT / UPDATE
  @Email       NVARCHAR(40) = NULL   -- Required for INSERT / UPDATE
AS
BEGIN
  SET NOCOUNT ON;

  IF @Action = 'INSERT'
  BEGIN
    INSERT INTO Donor (First_Name, Last_Name, Email)
      VALUES (@First_Name, @Last_Name, @Email);
    SELECT SCOPE_IDENTITY() AS NewDonorID;
  END
  ELSE IF @Action = 'UPDATE'
  BEGIN
    UPDATE Donor
      SET First_Name = @First_Name,
          Last_Name  = @Last_Name,
          Email      = @Email
    WHERE Donor_ID = @Donor_ID;

    SELECT @@ROWCOUNT AS RowsAffected;
  END
  ELSE IF @Action = 'DELETE'
  BEGIN
    DELETE FROM Donor
    WHERE Donor_ID = @Donor_ID;

    SELECT @@ROWCOUNT AS RowsDeleted;
  END
  ELSE
    RAISERROR('Invalid @Action. Use INSERT, UPDATE or DELETE.', 16, 1);
END;
GO


/*
  ===========================================
  sp_ManageStock
  INSERT, UPDATE, DELETE on Stock
  ===========================================
*/
IF OBJECT_ID('sp_ManageStock','P') IS NOT NULL
  DROP PROCEDURE sp_ManageStock;
GO

CREATE PROCEDURE sp_ManageStock
  @Action            NVARCHAR(10),          -- 'INSERT', 'UPDATE', 'DELETE'
  @Stock_ID          INT            = NULL, -- Required for UPDATE / DELETE
  @Donation_ID       INT            = NULL, -- Required for INSERT / UPDATE
  @Description       NVARCHAR(50) = NULL,  -- Optional for INSERT / UPDATE
  @Quantity_In_Stock INT            = NULL  -- Required for INSERT / UPDATE
AS
BEGIN
  SET NOCOUNT ON;

  IF @Action = 'INSERT'
  BEGIN
    INSERT INTO Stock (Donation_ID, Description, Quantity_In_Stock)
      VALUES (@Donation_ID, @Description, @Quantity_In_Stock);
    SELECT SCOPE_IDENTITY() AS NewStockID;
  END
  ELSE IF @Action = 'UPDATE'
  BEGIN
    UPDATE Stock
      SET Donation_ID       = @Donation_ID,
          Description       = @Description,
          Quantity_In_Stock = @Quantity_In_Stock
    WHERE Stock_ID = @Stock_ID;

    SELECT @@ROWCOUNT AS RowsAffected;
  END
  ELSE IF @Action = 'DELETE'
  BEGIN
    DELETE FROM Stock
    WHERE Stock_ID = @Stock_ID;

    SELECT @@ROWCOUNT AS RowsDeleted;
  END
  ELSE
    RAISERROR('Invalid @Action. Use INSERT, UPDATE or DELETE.', 16, 1);
END;
GO


/*
  ===========================================
  sp_ManageClient
  INSERT, UPDATE, DELETE on Client
  ===========================================
*/
IF OBJECT_ID('sp_ManageClient','P') IS NOT NULL
  DROP PROCEDURE sp_ManageClient;
GO

CREATE PROCEDURE sp_ManageClient
  @Action     NVARCHAR(10),           -- 'INSERT', 'UPDATE', 'DELETE'
  @Client_ID  INT            = NULL,  -- Required for UPDATE / DELETE
  @First_Name NVARCHAR(20) = NULL,   -- Required for INSERT / UPDATE
  @Last_Name  NVARCHAR(20) = NULL,   -- Required for INSERT / UPDATE
  @Email      NVARCHAR(40) = NULL    -- Required for INSERT / UPDATE
AS
BEGIN
  SET NOCOUNT ON;

  IF @Action = 'INSERT'
  BEGIN
    INSERT INTO Client (First_Name, Last_Name, Email)
      VALUES (@First_Name, @Last_Name, @Email);
    SELECT SCOPE_IDENTITY() AS NewClientID;
  END
  ELSE IF @Action = 'UPDATE'
  BEGIN
    UPDATE Client
      SET First_Name = @First_Name,
          Last_Name  = @Last_Name,
          Email      = @Email
    WHERE Client_ID = @Client_ID;

    SELECT @@ROWCOUNT AS RowsAffected;
  END
  ELSE IF @Action = 'DELETE'
  BEGIN
    DELETE FROM Client
    WHERE Client_ID = @Client_ID;

    SELECT @@ROWCOUNT AS RowsDeleted;
  END
  ELSE
    RAISERROR('Invalid @Action. Use INSERT, UPDATE or DELETE.', 16, 1);
END;
GO

  DECLARE @OrderID INT;
  INSERT INTO Client_Order (Client_ID, Order_Date)
    VALUES (@ClientID, @OrderDate);
  SET @OrderID = SCOPE_IDENTITY();

  INSERT INTO Order_Detail (Order_ID, Stock_ID, Quantity)
    VALUES (@OrderID, @StockID, @Qty);
END;
GO


