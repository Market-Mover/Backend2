DROP TABLE OrderLines
DROP TABLE Orders
DROP TABLE Users
DROP TABLE Adresses
DROP TABLE Products
DROP TABLE Categories
GO
CREATE Table Categories (
Id int not null identity primary key,
CategoryName nvarchar(33) not null
)
GO
CREATE TABLE Products (
Id int not null identity primary key,
CategoryId int not null references Categories(Id),
ProductName nvarchar(100) not null,
ShortDescription nvarchar(300) not null,
LongDescription nvarchar(max),
ImgUrl nvarchar(max),
Price money default 0,
InStock bit not null

)

CREATE TABLE Adresses (
Id int not null identity primary key,
AdressLine nvarchar(100),
ZipCode nvarchar(5),
City nvarchar(100)
)
GO

CREATE TABLE Users (
Id int not null identity primary key,
FirstName nvarchar(100) not null,
LastName nvarchar(100) not null,
Email nvarchar(100) not null,
Password nvarchar(max) not null,
AdressId int references Adresses(Id)
)

GO

CREATE TABLE Orders (
Id int not null identity primary key,
Status bit not null default 0,
UserId int not null references Users(Id)
)
GO
CREATE TABLE OrderLines(
ProductId int not null references Products(Id),
Quantity int not null,
OrderId int not null references Orders(Id)
Primary key (ProductId, OrderId)
)
GO

INSERT INTO Categories
VALUES ('Physical');
INSERT INTO Categories
VALUES ('Books');
INSERT INTO Categories
VALUES ('Imagination');


GO

INSERT INTO Products
VALUES (
1,
'Roswell stone',
'Replica of roswell stone',
'Replica of roswell stone with magnetic properties. 3D printed and hand-painted design.Approximate size: 6 cms. The color tone may vary a bit from the screen image. We can make other figures with our 3D printers. This article requires 2-4 business days to perform.',
'https://i.pinimg.com/originals/6d/e4/b6/6de4b6d1b165acfe237046d69ad8b8e1.jpg',
3995.95,
1

);
INSERT INTO Products
VALUES (
1,
'Masonic Championship Ring',
'Freemason ring',
'Style: Masonic Main Stone: Epoxy Material: Stainless Steel Sizable: Yes Theme: Freemasonry Metal: Stainless Steel Color: Silver or Gold Brand: SIGNATURE Ring Shape: G Square and Compass Ring Size: 8 - 12 ',
'https://i.ebayimg.com/images/g/ZYMAAOSwWplfTT0U/s-l400.jpg',
4595.95,
1

);
INSERT INTO Products
VALUES (
1,
'Metatron´s Cube',
'Metatrons Cube is a complex fractal',
'Metatrons Cube is a complex fractal, Sacred Geometry, which makes you comprehend how all sacred 3D geometries nest within each other. It is the Origin of the Flower of Life, which forms (in 3D) from the emerging Spheres of all nodes (crossing points). From the 3-dimensional Flower of Life you get the cross-section, or 2D-projection, and from the underlying structure, called the Fruit of Life, Metatron’s Cube can be formed again - in 2D.',
'https://i.etsystatic.com/18530382/r/il/df3592/3282838392/il_340x270.3282838392_84dt.jpg',
1995.95,
1

);
INSERT INTO Products
VALUES (
2,
'The Kybalion',
'A book of hermetic philosophy',
'The Kybalion is a compilation of Hermetic teachings. These same doctrines are based on principles originally explained by Hermes Trismegistus. The Kybalion provides a Master-Key for students to unlock the fundamental and basic teachings of esoteric philosophy.',
'http://prodimage.images-bn.com/pimages/9781935721253_p0_v1_s1200x630.jpg',
99.95,
1

);
INSERT INTO Products
VALUES (
2,
'The Power of Awareness',
'A Good book',
'The Power of Awareness allows those who rebelled against a rigid religious upbringing to renew some of the images etched in their consciousness, only in a more loving, positive and universal way.',
'https://images.penguinrandomhouse.com/cover/9780399162664',
99.95,
1

);
INSERT INTO Products
VALUES (
2,
'The Law of One (RA Material)',
'',
'lmost twenty years of experimental work with telepathy led to the "breakthrough" contact recorded in this book. The Ra Material is an account not only of the events leading up to this contact, but of over 200 pages of verbatim transcripts of each and every conversation!',
'https://images-na.ssl-images-amazon.com/images/I/717q2rEvfgL.jpg',
99.95,
1

);

INSERT INTO Products
VALUES (
3,
'Tessaract',
'A 4th dimentional cube ',
'In geometry, the tesseract is the four-dimensional analogue of the cube; the tesseract is to the cube as the cube is to the square. Just as the surface of the cube consists of six square faces, the hypersurface of the tesseract consists of eight cubical cells. The tesseract is one of the six convex regular 4-polytopes.',
'https://s2lab.cs.ucl.ac.uk/images/tesseract.gif',
9999.95,
1

);
INSERT INTO Products
VALUES (
3,
'Item of Imagination',
'',
'This item is for you who have a great creativity and who like to imagine things. You choose what the product should look like by ordering this fantastic thing today.',
'https://www.bahyrmaskiner.se/wp-content/uploads/2018/03/bild-saknas.jpg',
1.95,
1

);
INSERT INTO Products
VALUES (
3,
'Antimatter',
'Good luck buying this',
'Antimatter is the opposite of ordinary matter, which makes up our galaxy and the rest of our visible universe. There is an antiparticle for each common particle: for example proton – antiproton, neutron – antineutron and electron – positron.',
'https://scitechdaily.com/images/Matter-Antimatter-Concept.gif',
 62500000000000.00,
1

);
INSERT INTO Users (FirstName, LastName, Email, Password)
VALUES (
'Laban',
'Liffy',
'mail@domain.com',
'Bytmig123'
);

INSERT INTO Users (FirstName, LastName, Email, Password)
VALUES (
'Jan-Erik',
'Svensson',
'janne@domain.com',
'Bytmig123'
);

INSERT INTO Users (FirstName, LastName, Email, Password)
VALUES (
'Jinny',
'Sansson',
'jenny@domain.com',
'Bytmig123'
);
INSERT INTO Users (FirstName, LastName, Email, Password)
VALUES (
'Eiki',
'Lovolokockhoh',
'love@domain.com',
'Bytmig123'
);