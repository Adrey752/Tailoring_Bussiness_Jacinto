-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 15, 2024 at 04:32 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `jacinto_tailoring_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `password` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`password`) VALUES
('broCode!'),
('broCode!');

-- --------------------------------------------------------

--
-- Table structure for table `client`
--

CREATE TABLE `client` (
  `client_id` int(11) NOT NULL,
  `name` varchar(150) NOT NULL,
  `address` varchar(150) NOT NULL,
  `contact` varchar(11) DEFAULT NULL,
  `status` tinyint(1) NOT NULL,
  `price` int(11) NOT NULL,
  `payment` int(11) NOT NULL,
  `quantity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `client`
--

INSERT INTO `client` (`client_id`, `name`, `address`, `contact`, `status`, `price`, `payment`, `quantity`) VALUES
(29, 'Adrial Evan P. Sarmiento', 'blk20, Winston Street,', '09090695744', 0, 0, 0, 0),
(30, 'Adrial Evan P. Sarmiento', 'i won\'t tell', '09039222', 0, 0, 0, 0),
(31, 'new Cliant', 'lsdfka', 'ksdflas', 0, 0, 0, 0),
(32, 'another 1', 'ain\'t norway', '0901838111', 0, 0, 0, 0),
(33, 'Bagong Klyente', 'Bagong address', '09837489292', 0, 0, 0, 0),
(34, 'Smaq Kyompyuter', 'Tapat ng School', '02348283472', 0, 0, 0, 0),
(35, 'Adrial Evan ', 'adrialsarmeint', '0382429348', 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `client_order`
--

CREATE TABLE `client_order` (
  `order_id` int(11) NOT NULL,
  `order_name` varchar(150) NOT NULL,
  `type` varchar(150) NOT NULL,
  `description` text NOT NULL,
  `price` decimal(10,2) DEFAULT NULL,
  `client_id` int(11) DEFAULT NULL,
  `done` tinyint(1) NOT NULL DEFAULT 0,
  `status` varchar(50) DEFAULT 'Pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `client_order`
--

INSERT INTO `client_order` (`order_id`, `order_name`, `type`, `description`, `price`, `client_id`, `done`, `status`) VALUES
(2, 'bag', 'Repair', 'bruh', 100.00, 32, 0, 'Pending'),
(3, 'Pa Print', 'Resize', 'skdjfwekwfklsdfwfsdf', 50293929.00, 34, 0, 'Pending'),
(4, 'Order1', 'Repair', 'sdfsefwefsdf', 0.00, 35, 0, 'Pending'),
(5, 'Order2', 'Repair', 'sdfsdf', 0.00, 35, 0, 'Pending'),
(6, 'sdkfj', 'Repair', 'sdfsdfs', 0.00, 35, 0, 'Pending');

-- --------------------------------------------------------

--
-- Table structure for table `garment_types`
--

CREATE TABLE `garment_types` (
  `garment_id` int(11) NOT NULL,
  `garment_type` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `garment_types`
--

INSERT INTO `garment_types` (`garment_id`, `garment_type`) VALUES
(1, 'cotton'),
(2, 'Silk'),
(3, 'Leather');

-- --------------------------------------------------------

--
-- Table structure for table `size_types`
--

CREATE TABLE `size_types` (
  `type_id` int(11) NOT NULL,
  `types` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `size_types`
--

INSERT INTO `size_types` (`type_id`, `types`) VALUES
(1, 'Neck'),
(2, 'Waist'),
(3, 'Chest'),
(4, 'Thighs');

-- --------------------------------------------------------

--
-- Table structure for table `size_values`
--

CREATE TABLE `size_values` (
  `size_valueId` int(11) NOT NULL,
  `type_id` int(11) DEFAULT NULL,
  `order_id` int(11) DEFAULT NULL,
  `size_value` decimal(10,2) DEFAULT NULL,
  `size_unit` varchar(50) DEFAULT NULL,
  `garment_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `size_values`
--

INSERT INTO `size_values` (`size_valueId`, `type_id`, `order_id`, `size_value`, `size_unit`, `garment_id`) VALUES
(2, 2, 2, 70.00, 'inch', 1),
(3, 2, 4, 403.00, 'inch', 1),
(4, 3, 4, 403.00, 'inch', 1),
(5, 2, 6, 2.00, 'inches', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `client`
--
ALTER TABLE `client`
  ADD PRIMARY KEY (`client_id`);

--
-- Indexes for table `client_order`
--
ALTER TABLE `client_order`
  ADD PRIMARY KEY (`order_id`),
  ADD KEY `fk_client` (`client_id`);

--
-- Indexes for table `garment_types`
--
ALTER TABLE `garment_types`
  ADD PRIMARY KEY (`garment_id`);

--
-- Indexes for table `size_types`
--
ALTER TABLE `size_types`
  ADD PRIMARY KEY (`type_id`);

--
-- Indexes for table `size_values`
--
ALTER TABLE `size_values`
  ADD PRIMARY KEY (`size_valueId`),
  ADD KEY `type_id` (`type_id`),
  ADD KEY `size_values_ibfk_2` (`order_id`),
  ADD KEY `fk_garment_id` (`garment_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `client`
--
ALTER TABLE `client`
  MODIFY `client_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- AUTO_INCREMENT for table `client_order`
--
ALTER TABLE `client_order`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `garment_types`
--
ALTER TABLE `garment_types`
  MODIFY `garment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `size_types`
--
ALTER TABLE `size_types`
  MODIFY `type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `size_values`
--
ALTER TABLE `size_values`
  MODIFY `size_valueId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `client_order`
--
ALTER TABLE `client_order`
  ADD CONSTRAINT `fk_client` FOREIGN KEY (`client_id`) REFERENCES `client` (`client_id`);

--
-- Constraints for table `size_values`
--
ALTER TABLE `size_values`
  ADD CONSTRAINT `fk_garment_id` FOREIGN KEY (`garment_id`) REFERENCES `garment_types` (`garment_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `size_values_ibfk_1` FOREIGN KEY (`type_id`) REFERENCES `size_types` (`type_id`),
  ADD CONSTRAINT `size_values_ibfk_2` FOREIGN KEY (`order_id`) REFERENCES `client_order` (`order_id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
