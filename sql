CREATE TABLE Invoices (
  InvoiceId INT PRIMARY KEY AUTO_INCREMENT,
  InvoiceNumber VARCHAR(50) NOT NULL,
  CustomerName VARCHAR(100) NOT NULL,
  Amount DECIMAL(10, 2) NOT NULL,
  -- Add additional columns as needed
  CreatedDate DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE Payments (
  PaymentId INT PRIMARY KEY AUTO_INCREMENT,
  InvoiceId INT NOT NULL,
  Amount DECIMAL(10, 2) NOT NULL,
  PaymentDate DATETIME NOT NULL,
  -- Add additional columns as needed
  FOREIGN KEY (InvoiceId) REFERENCES Invoices(InvoiceId)
);
