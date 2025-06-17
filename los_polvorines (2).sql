-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 15-06-2025 a las 21:35:09
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
-- Base de datos: `los polvorines`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE `clientes` (
  `Nombre` text NOT NULL,
  `Apellido` text NOT NULL,
  `Dni` int(8) NOT NULL,
  `Usuario` varchar(20) NOT NULL,
  `Password` varchar(40) NOT NULL,
  `Telefono` int(10) NOT NULL,
  `Email` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `clientes`
--

INSERT INTO `clientes` (`Nombre`, `Apellido`, `Dni`, `Usuario`, `Password`, `Telefono`, `Email`) VALUES
('Ivan', 'Arevalos', 47100266, 'Areski', 'Noviembre2211', 1124974712, 'ivanarevalos@isft220.edu.ar');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `facturas`
--

CREATE TABLE `facturas` (
  `Id_Factura` bigint(20) NOT NULL,
  `Dni` int(11) NOT NULL,
  `Fecha_Factura` date NOT NULL,
  `Categoria` text NOT NULL,
  `Nombre_Producto` text NOT NULL,
  `Precio_Total_Producto` int(11) NOT NULL,
  `Cantidad_Producto` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `facturas`
--

INSERT INTO `facturas` (`Id_Factura`, `Dni`, `Fecha_Factura`, `Categoria`, `Nombre_Producto`, `Precio_Total_Producto`, `Cantidad_Producto`) VALUES
(4, 47100266, '2025-06-15', 'indumentaria', 'Pantalón de trabajo', 9600, 3),
(5, 47100266, '2025-06-15', 'tornilleria', 'Tenaza', 2600, 2),
(6, 47100266, '2025-06-15', 'herramientas', 'Pinza universal', 7200, 4),
(7, 43212903, '2025-06-15', 'tornilleria', 'Cortafierro', 4200, 3),
(8, 43221456, '2025-06-15', 'herramientas', 'Destornillador', 1200, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `herramientas`
--

CREATE TABLE `herramientas` (
  `Codigo` int(100) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Marca` varchar(50) NOT NULL,
  `Stock` int(100) NOT NULL,
  `Costo` varchar(50) NOT NULL,
  `Proveedor` varchar(50) NOT NULL,
  `Precio_bruto` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `herramientas`
--

INSERT INTO `herramientas` (`Codigo`, `Nombre`, `Marca`, `Stock`, `Costo`, `Proveedor`, `Precio_bruto`) VALUES
(1, 'Martillo', 'Tramontina', 25, '1500', 'FerreMax', '2000'),
(2, 'Destornillador', 'Stanley', 39, '800', 'Distribuidora Norte', '1200'),
(3, 'Llave Inglesa', 'Bahco', 15, '2200', 'ProTools', '2800'),
(4, 'Pinza universal', 'Truper', 30, '1300', 'FerreMax', '1800'),
(5, 'Cinta métrica', 'Stanley', 50, '600', 'Ferretería Global', '950'),
(6, 'Serrucho', 'Irwin', 20, '1700', 'Herramientas SRL', '2200'),
(7, 'Destornillador Phillips', 'Bosch', 35, '900', 'Distribuidora Norte', '1400'),
(8, 'Llave Allen', 'Black & Decker', 60, '500', 'ProTools', '750'),
(9, 'Pala ancha', 'Bellota', 12, '2500', 'Ferretería Delta', '3200'),
(10, 'Tijera de podar', 'Gardena', 18, '1900', 'Jardín Tools', '2600');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `indumentaria`
--

CREATE TABLE `indumentaria` (
  `Codigo` int(100) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Talla` varchar(50) NOT NULL,
  `Material` varchar(50) NOT NULL,
  `Stock` int(50) NOT NULL,
  `Costo` varchar(50) NOT NULL,
  `Proveedor` varchar(50) NOT NULL,
  `Precio_bruto` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `indumentaria`
--

INSERT INTO `indumentaria` (`Codigo`, `Nombre`, `Talla`, `Material`, `Stock`, `Costo`, `Proveedor`, `Precio_bruto`) VALUES
(1, 'Guantes de trabajo', 'L', 'Cuero', 30, '1000', 'InduTextil', '1500'),
(2, 'Chaleco reflectivo', 'M', 'Poliéster', 20, '750', 'Seguridad Vial S.A.', '1200'),
(3, 'Pantalón de trabajo', 'XL', 'Jean', 12, '2500', 'Textil Sur', '3200'),
(4, 'Camisa de seguridad', 'L', 'Algodón', 25, '1800', 'InduTextil', '2400'),
(5, 'Botas de seguridad', '42', 'Cuero sintético', 15, '3500', 'CalzadoLab', '4800'),
(6, 'Casco de obra', 'Única', 'Plástico ABS', 40, '1200', 'ObraSegura', '1700'),
(7, 'Cinturón de herramientas', 'M', 'Cuero', 10, '2200', 'FerreMax', '2800'),
(8, 'Overol', 'XL', 'Jean', 8, '3000', 'Textil Sur', '4000'),
(9, 'Guantes térmicos', 'S', 'Lana', 22, '900', 'InduTextil', '1300'),
(10, 'Campera impermeable', 'L', 'Nylon', 17, '2800', 'RopaLab', '3500');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `personal`
--

CREATE TABLE `personal` (
  `Nombre` text NOT NULL,
  `Apellido` text NOT NULL,
  `Dni` int(8) NOT NULL,
  `Telefono` int(10) NOT NULL,
  `Usuario` varchar(100) NOT NULL,
  `Codigo` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `personal`
--

INSERT INTO `personal` (`Nombre`, `Apellido`, `Dni`, `Telefono`, `Usuario`, `Codigo`) VALUES
('Alexander', 'Smith', 43212932, 1139201342, 'Caja', 893221345),
('Juana', 'Lopez', 45890853, 1156782341, 'Caja\r\n', 732212579);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tornilleria`
--

CREATE TABLE `tornilleria` (
  `Codigo` int(11) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Medidas` varchar(50) NOT NULL,
  `Marca` varchar(50) NOT NULL,
  `Stock` int(50) NOT NULL,
  `Costo` varchar(50) NOT NULL,
  `Proveedor` varchar(50) NOT NULL,
  `Precio_bruto` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `tornilleria`
--

INSERT INTO `tornilleria` (`Codigo`, `Nombre`, `Medidas`, `Marca`, `Stock`, `Costo`, `Proveedor`, `Precio_bruto`) VALUES
(1, 'Sierra manual', '30cm', 'Irwin', 10, '1800', 'FerroSud', '2500'),
(2, 'Tenaza', '15cm', 'Truper', 25, '950', 'Ferretería Delta', '1300'),
(3, 'Nivel de burbuja', '60cm', 'Stanley', 18, '1600', 'Herramientas Rápidas', '2200'),
(4, 'Metro plegable', '2m', 'Bahco', 40, '700', 'Medidas S.A.', '1100'),
(5, 'Cortafierro', '20cm', 'Tramontina', 14, '900', 'Distribuidora Norte', '1400'),
(6, 'Serrucho japonés', '25cm', 'Makita', 8, '2700', 'ProTools', '3400'),
(7, 'Espátula', '10cm', 'Black & Decker', 35, '500', 'FerroSud', '850'),
(8, 'Taladro manual', '18cm', 'Bosch', 7, '3200', 'Herramientas Rápidas', '4000'),
(9, 'Martillo de goma', '30cm', 'Tramontina', 16, '1500', 'Distribuidora Norte', '2100'),
(10, 'Llave tubo', '12mm', 'Stanley', 28, '1100', 'FerreMax', '1600');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `clientes`
--
ALTER TABLE `clientes`
  ADD PRIMARY KEY (`Dni`);

--
-- Indices de la tabla `facturas`
--
ALTER TABLE `facturas`
  ADD PRIMARY KEY (`Id_Factura`);

--
-- Indices de la tabla `herramientas`
--
ALTER TABLE `herramientas`
  ADD PRIMARY KEY (`Codigo`);

--
-- Indices de la tabla `indumentaria`
--
ALTER TABLE `indumentaria`
  ADD PRIMARY KEY (`Codigo`);

--
-- Indices de la tabla `personal`
--
ALTER TABLE `personal`
  ADD PRIMARY KEY (`Dni`);

--
-- Indices de la tabla `tornilleria`
--
ALTER TABLE `tornilleria`
  ADD PRIMARY KEY (`Codigo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `facturas`
--
ALTER TABLE `facturas`
  MODIFY `Id_Factura` bigint(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de la tabla `herramientas`
--
ALTER TABLE `herramientas`
  MODIFY `Codigo` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de la tabla `indumentaria`
--
ALTER TABLE `indumentaria`
  MODIFY `Codigo` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de la tabla `tornilleria`
--
ALTER TABLE `tornilleria`
  MODIFY `Codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
