-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 14-01-2025 a las 17:35:57
-- Versión del servidor: 10.4.32-MariaDB
-- Versión de PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `inventario`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categorias`
--

CREATE TABLE `categorias` (
  `id_categoria` int(11) NOT NULL,
  `nombre_categoria` varchar(100) NOT NULL,
  `descripcion_categoria` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `categorias`
--

INSERT INTO `categorias` (`id_categoria`, `nombre_categoria`, `descripcion_categoria`) VALUES
(1, 'Electrónica', 'Productos electrónicos y dispositivos tecnológicos'),
(2, 'Ropa', 'Prendas de vestir para hombres, mujeres y niños'),
(3, 'Hogar', 'Artículos y utensilios para el hogar'),
(4, 'Deportes', 'Equipamiento y accesorios deportivos'),
(5, 'Alimentos', 'Productos alimenticios y bebidas'),
(6, 'Libros', 'Libros, revistas y otros materiales de lectura'),
(7, 'Juguetes', 'Juguetes y juegos para niños de todas las edades');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `id_producto` int(11) NOT NULL,
  `nombre_producto` varchar(100) NOT NULL,
  `precio_producto` float NOT NULL,
  `stock_producto` int(11) NOT NULL,
  `categoria_producto` int(11) NOT NULL,
  `descripcion_producto` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_spanish2_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`id_producto`, `nombre_producto`, `precio_producto`, `stock_producto`, `categoria_producto`, `descripcion_producto`) VALUES
(1, 'Televisor 55 pulgadas', 45000, 10, 1, 'Televisor LED con resolución 4K'),
(2, 'Smartphone Galaxy A53', 120000, 15, 1, 'Teléfono móvil con cámara de 64MP y 128GB de almacenamiento'),
(3, 'Auriculares Bluetooth', 8000, 30, 1, 'Auriculares inalámbricos con micrófono integrado'),
(4, 'Camiseta deportiva', 2500, 50, 2, 'Camiseta de algodón para uso diario'),
(5, 'Pantalón de jean', 8000, 20, 2, 'azul clásico'),
(6, 'Mesa de comedor', 18000, 5, 3, 'Mesa de madera con capacidad para 6 personas'),
(7, 'Lámpara de escritorio', 1500, 20, 3, 'Lámpara LED para estudio o trabajo'),
(8, 'Pelota de fútbol', 2500, 25, 4, 'Pelota de cuero oficial tamaño 5'),
(9, 'Bicicleta de montaña', 85000, 7, 4, 'Bicicleta para adultos con 21 velocidades'),
(10, 'Cereal integral', 350, 100, 5, 'Cereal para desayuno con alto contenido de fibra'),
(11, 'Botella de agua', 100, 500, 5, 'Botella de 1 litro de agua mineral'),
(12, 'Novela de ficción', 1200, 30, 6, 'Libro de literatura contemporánea'),
(13, 'Diccionario bilingüe', 2000, 10, 6, 'Diccionario inglés-español'),
(14, 'Muñeca de colección', 4500, 12, 7, 'Muñeca articulada con ropa y accesorios'),
(15, 'Set de bloques de construcción', 3000, 20, 7, 'Bloques de construcción para niños mayores de 3 años');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `categorias`
--
ALTER TABLE `categorias`
  ADD PRIMARY KEY (`id_categoria`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`id_producto`),
  ADD KEY `fk_categoria` (`categoria_producto`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `categorias`
--
ALTER TABLE `categorias`
  MODIFY `id_categoria` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `id_producto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `productos`
--
ALTER TABLE `productos`
  ADD CONSTRAINT `fk_categoria` FOREIGN KEY (`categoria_producto`) REFERENCES `categorias` (`id_categoria`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
