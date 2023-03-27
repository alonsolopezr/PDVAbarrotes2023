CREATE DATABASE productos_pdv;

use productos_pdv;

CREATE TABLE `productos` (
  `id` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `codigo_barras` varchar(20) NOT NULL,
  `descripcion` text DEFAULT NULL,
  `precio` double NOT NULL,
  `imagen` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`id`, `nombre`, `codigo_barras`, `descripcion`, `precio`, `imagen`) VALUES
(1, 'Maruchan Habanero Rebelde', '123123123', 'Maruchan limón camarón habanero', 16.5, '123123');


use productos_pdv;

CREATE TABLE `usuarios` (
  `id` int(255) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `correo` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `imagen` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `usuarios` (`id`, `nombre`, `Correo`, `password`, `imagen`) VALUES
(0, 'Admin', 'Admin@uhtermosillo.edu.mx', 'admin123', '1231235');
