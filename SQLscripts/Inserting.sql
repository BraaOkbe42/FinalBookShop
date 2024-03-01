-- Insert Books
INSERT INTO Books (Title, Author, Price, StockQuantity, ImgUrl, Description)
VALUES
('To Kill a Mockingbird', 'Harper Lee', 18.99, 100, 'http://example.com/mockingbird.jpg', 'A novel about childhood in a sleepy Southern town and the crisis of conscience that rocked it.'),
('1984', 'George Orwell', 15.99, 200, 'http://example.com/1984.jpg', 'A dystopian novel set in Airstrip One, formerly Great Britain, a province of the superstate Oceania.'),
('The Great Gatsby', 'F. Scott Fitzgerald', 20.99, 150, 'http://example.com/gatsby.jpg', 'A novel about the themes of resistance to change, decadence, and the American Dream.');

-- Insert Users
INSERT INTO Users (Username, Email, Password)
VALUES
('JohnDoe', 'john.doe@example.com', 'hashedpassword1'),
('JaneSmith', 'jane.smith@example.com', 'hashedpassword2'),
('AliceJohnson', 'alice.johnson@example.com', 'hashedpassword3');

-- Assuming Cart and Order tables are correctly related to User, and CartItem to Cart and Book.
-- Insert Carts (linking to Users)
INSERT INTO Carts (UserID)
VALUES
((SELECT UserID FROM Users WHERE Username = 'JohnDoe')),
((SELECT UserID FROM Users WHERE Username = 'JaneSmith')),
((SELECT UserID FROM Users WHERE Username = 'AliceJohnson'));

-- Insert CartItems (assuming CartID and BookID need to match existing records)
INSERT INTO CartItems (CartID, BookID, Quantity)
VALUES
(1, 1, 2), -- Example: User 1 adds 2 copies of Book 1 to their cart
(2, 2, 1), -- Example: User 2 adds 1 copy of Book 2 to their cart
(3, 3, 1); -- Example: User 3 adds 1 copy of Book 3 to their cart

-- Insert Orders (assuming UserID and calculated total price)
INSERT INTO Orders (UserID, OrderDate, TotalPrice)
VALUES
((SELECT UserID FROM Users WHERE Username = 'JohnDoe'), '2024-03-02', 37.98),
((SELECT UserID FROM Users WHERE Username = 'JaneSmith'), '2024-03-03', 15.99),
((SELECT UserID FROM Users WHERE Username = 'AliceJohnson'), '2024-03-04', 20.99);
