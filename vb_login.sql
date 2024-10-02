-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 03, 2024 at 12:29 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `vb_login`
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
(1, 'Rain Ardhie Calibog', 'blk 19 edging street, don Antonio, San manuel', '994329392', 0, 0, 0, 0),
(2, 'Aeron Monan', 'blk 189, Litex', '99837235', 0, 0, 0, 0),
(3, 'Leunam', 'blk 39, Batasan Street', '999832', 0, 0, 0, 0),
(4, 'Edloy Backshot', 'Everlasting', '928374', 0, 0, 0, 0),
(5, 'Markian Egg smoke bomb', 'malapit sa gym yung bahay', '998758907', 0, 0, 0, 0),
(6, 'Random guy', 'ikj', '9986', 0, 0, 0, 0),
(7, 'bru', 'shdf', 'sodfsd', 0, 0, 0, 0),
(8, 'Bro', 'sdfwe', 'sdfekaeane', 0, 0, 0, 0),
(9, '', '', '', 0, 0, 0, 0),
(10, 'jorge', 'jorgeville', '696969', 0, 0, 0, 0),
(11, '', '', '', 0, 0, 0, 0),
(12, '', '', '', 0, 0, 0, 0),
(13, 'P Diddy', 'Diddy party', '09696969696', 0, 0, 0, 0),
(14, '', '', '', 0, 0, 0, 0),
(15, 'Aeron', 'bta', '234234', 0, 0, 0, 0),
(16, 'dsdfskq', 'sdfsdfkwle', 'sdkfwlefksd', 0, 0, 0, 0),
(17, '', '', '', 0, 0, 0, 0),
(18, '', '', '', 0, 0, 0, 0),
(19, 'Client Name', 'Client Address', '0430423', 0, 0, 0, 0),
(20, 'Aeron', 'sdfsdf', 'sdfsdf', 0, 0, 0, 0),
(21, 'New Client', 'sdfsdf', 'sdfsdf', 0, 0, 0, 0),
(22, 'Edloy BackShot', 'Everylasting', '03493043', 0, 0, 0, 0),
(23, 'carlos_Lulo', '12sadhkksagddasas', '09123093210', 0, 0, 0, 0),
(24, 'aeron monan', 'bulbol st', '09393939393', 0, 0, 0, 0),
(25, 'Adrial Evan P. Sarmiento', 'blk18 lsoe, sdlfkw1', '090927482', 0, 0, 0, 0),
(26, 'Adrial Evan P. Sarmiento', 'blk180328', '09879769', 0, 0, 0, 0),
(27, 'Adrial Evan P. Sarmiento', 'blk18', '0998986967', 0, 0, 0, 0),
(28, 'Adrial Evan P. Sarmiento', 'blk20, Winston Street,', '09090695744', 0, 0, 0, 0),
(29, 'Adrial Evan P. Sarmiento', 'blk20, Winston Street,', '09090695744', 0, 0, 0, 0),
(30, 'Adrial Evan P. Sarmiento', 'i won\'t tell', '09039222', 0, 0, 0, 0),
(31, 'new Cliant', 'lsdfka', 'ksdflas', 0, 0, 0, 0),
(32, 'another 1', 'ain\'t norway', '0901838111', 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `client_order`
--

CREATE TABLE `client_order` (
  `order_id` int(11) NOT NULL,
  `order_name` varchar(150) NOT NULL,
  `type` varchar(150) NOT NULL,
  `garment_type` int(11) NOT NULL,
  `description` text NOT NULL,
  `price` int(11) NOT NULL,
  `client_id` int(11) DEFAULT NULL,
  `done` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `client_order`
--

INSERT INTO `client_order` (`order_id`, `order_name`, `type`, `garment_type`, `description`, `price`, `client_id`, `done`) VALUES
(1, 'Bag', 'Repair', 0, 'Sira zipper harap pati labas', 0, 28, 0),
(2, 'bag', 'Repair', 0, 'bruh', 100, 32, 0);

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
  `size_unit` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `size_values`
--

INSERT INTO `size_values` (`size_valueId`, `type_id`, `order_id`, `size_value`, `size_unit`) VALUES
(2, 2, 2, 70.00, 'inch');

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
  ADD KEY `size_values_ibfk_2` (`order_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `client`
--
ALTER TABLE `client`
  MODIFY `client_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `client_order`
--
ALTER TABLE `client_order`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `size_types`
--
ALTER TABLE `size_types`
  MODIFY `type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `size_values`
--
ALTER TABLE `size_values`
  MODIFY `size_valueId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

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
  ADD CONSTRAINT `size_values_ibfk_1` FOREIGN KEY (`type_id`) REFERENCES `size_types` (`type_id`),
  ADD CONSTRAINT `size_values_ibfk_2` FOREIGN KEY (`order_id`) REFERENCES `client_order` (`order_id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
