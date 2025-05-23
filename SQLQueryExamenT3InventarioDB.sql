CREATE DATABASE InventarioDB;
GO

-- Usar la base de datos
USE InventarioDB;
GO

-- Crear tabla Productos
CREATE TABLE Productos (
    ProductoId INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(100) NOT NULL,
    Precio REAL NOT NULL,
    Cantidad INT NOT NULL,
    Categoria VARCHAR(50),
    Descripcion VARCHAR(255)
);

INSERT INTO Productos (Nombre, Precio, Cantidad, Categoria, Descripcion) VALUES
('Lápiz HB',         3.50,   100, 'Papelería',     'Lápiz de grafito de dureza HB'),
('Cuaderno Profesional', 45.00,  50,  'Papelería',     'Cuaderno con 100 hojas, tamaño carta'),
('Botella de Agua',  12.00,  200, 'Bebidas',       'Agua natural embotellada de 600ml'),
('Mouse Óptico',     150.00, 30,  'Tecnología',    'Mouse USB de 3 botones'),
('Café Soluble',     85.00,  60,  'Alimentos',     'Frasco de 100g de café instantáneo'),
('Memoria USB 32GB', 110.00, 25,  'Tecnología',    'Memoria USB 3.0 de 32GB'),
('Taza Cerámica',    35.00,  80,  'Hogar',         'Taza blanca de 350ml'),
('Resaltador Amarillo', 7.00, 120, 'Papelería',     'Marcador fluorescente color amarillo'),
('Chocolate 85g',    25.00,  75,  'Alimentos',     'Tableta de chocolate con leche'),
('Detergente Líquido', 65.00, 40, 'Limpieza',      'Botella de 1L para ropa de color');
