-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 11, 2017 at 08:13 AM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 5.5.37

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotelmanagement`
--

-- --------------------------------------------------------

--
-- Table structure for table `bakery`
--

CREATE TABLE `bakery` (
  `item_name` varchar(50) NOT NULL,
  `rate` float NOT NULL,
  `stock` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `beverage`
--

CREATE TABLE `beverage` (
  `item_name` varchar(50) NOT NULL,
  `rate` float NOT NULL,
  `stock` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `cart`
--

CREATE TABLE `cart` (
  `item_name` varchar(20) NOT NULL,
  `quantity` int(10) NOT NULL,
  `total_cost` float(25,2) NOT NULL,
  `category` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `cust_id` int(20) NOT NULL,
  `customer_name` varchar(50) DEFAULT NULL,
  `cust_contact` bigint(12) DEFAULT NULL,
  `cust_address` varchar(50) DEFAULT NULL,
  `room_reserved` varchar(10) DEFAULT NULL,
  `checked_intime` datetime NOT NULL,
  `checkedout_time` datetime DEFAULT '0000-00-00 00:00:00',
  `total_bill` float(20,2) DEFAULT '0.00'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`cust_id`, `customer_name`, `cust_contact`, `cust_address`, `room_reserved`, `checked_intime`, `checkedout_time`, `total_bill`) VALUES
(1, NULL, NULL, NULL, NULL, '0000-00-00 00:00:00', NULL, 1373.46),
(2, NULL, NULL, NULL, NULL, '0000-00-00 00:00:00', NULL, 100.00),
(3, NULL, NULL, NULL, NULL, '0000-00-00 00:00:00', NULL, 2077.46),
(4, 'Rasil', 9813702400, 'Banepa', '', '2017-08-10 15:38:47', '2017-08-11 11:37:47', 303721.00);

-- --------------------------------------------------------

--
-- Table structure for table `desert`
--

CREATE TABLE `desert` (
  `item_name` varchar(50) NOT NULL,
  `rate` float NOT NULL,
  `stock` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `username` varchar(15) DEFAULT NULL,
  `password` varchar(15) DEFAULT NULL,
  `staff_id` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`username`, `password`, `staff_id`) VALUES
('1', '1', '1');

-- --------------------------------------------------------

--
-- Table structure for table `non_veg`
--

CREATE TABLE `non_veg` (
  `item_name` varchar(50) NOT NULL,
  `rate` float NOT NULL,
  `stock` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `non_veg`
--

INSERT INTO `non_veg` (`item_name`, `rate`, `stock`) VALUES
('Mutton', 350, 7);

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `order_id` int(15) NOT NULL,
  `cust_phone` varchar(15) NOT NULL,
  `order_date` date NOT NULL,
  `delivery_date` date NOT NULL,
  `address` varchar(15) DEFAULT NULL,
  `stat` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

CREATE TABLE `room` (
  `room_no` varchar(10) NOT NULL,
  `floor` int(5) DEFAULT NULL,
  `status` varchar(15) DEFAULT 'available',
  `cust_id` int(20) DEFAULT NULL,
  `price` float(20,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `room`
--

INSERT INTO `room` (`room_no`, `floor`, `status`, `cust_id`, `price`) VALUES
('1', 1, 'available', 0, 2500.00);

-- --------------------------------------------------------

--
-- Table structure for table `sales_data2`
--

CREATE TABLE `sales_data2` (
  `bill_id` int(10) NOT NULL,
  `cust_id` int(20) DEFAULT NULL,
  `date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `total_bill` float(25,2) DEFAULT NULL,
  `grand_total` float(20,2) NOT NULL DEFAULT '0.00'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `sales_data2`
--

INSERT INTO `sales_data2` (`bill_id`, `cust_id`, `date`, `total_bill`, `grand_total`) VALUES
(13, 4, '2017-08-09 18:15:00', 4851.00, 0.00),
(14, 4, '2017-08-09 18:15:00', 2695.00, 0.00),
(15, 4, '2017-08-09 18:15:00', 2310.00, 0.00),
(16, 4, '2017-08-09 18:15:00', 385.00, 0.00),
(17, 4, '2017-08-09 18:15:00', 385.00, 0.00),
(18, 4, '2017-08-09 18:15:00', 385.00, 0.00);

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `staff_id` varchar(10) NOT NULL,
  `staff_name` varchar(15) DEFAULT NULL,
  `Designation` varchar(10) DEFAULT NULL,
  `phone_num` bigint(12) DEFAULT NULL,
  `address` varchar(10) DEFAULT NULL,
  `salary` int(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`staff_id`, `staff_name`, `Designation`, `phone_num`, `address`, `salary`) VALUES
('1', 'Rasil', 'Manager', 9813702400, 'Banepa', 1000000),
('2', 'Binaya', 'cashier', 9813001162, 'Bnaepa', 500000);

-- --------------------------------------------------------

--
-- Table structure for table `vegeterian`
--

CREATE TABLE `vegeterian` (
  `item_name` varchar(50) NOT NULL,
  `rate` float NOT NULL,
  `stock` int(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `vegeterian`
--

INSERT INTO `vegeterian` (`item_name`, `rate`, `stock`) VALUES
('dhaniya soup', 100, 20),
('saag', 20, 20);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bakery`
--
ALTER TABLE `bakery`
  ADD PRIMARY KEY (`item_name`);

--
-- Indexes for table `beverage`
--
ALTER TABLE `beverage`
  ADD PRIMARY KEY (`item_name`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`cust_id`),
  ADD KEY `room_reserved` (`room_reserved`);

--
-- Indexes for table `desert`
--
ALTER TABLE `desert`
  ADD PRIMARY KEY (`item_name`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`staff_id`);

--
-- Indexes for table `non_veg`
--
ALTER TABLE `non_veg`
  ADD PRIMARY KEY (`item_name`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`order_id`);

--
-- Indexes for table `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`room_no`),
  ADD KEY `cust_id` (`cust_id`);

--
-- Indexes for table `sales_data2`
--
ALTER TABLE `sales_data2`
  ADD PRIMARY KEY (`bill_id`),
  ADD KEY `cust_id` (`cust_id`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`staff_id`);

--
-- Indexes for table `vegeterian`
--
ALTER TABLE `vegeterian`
  ADD PRIMARY KEY (`item_name`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `cust_id` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `order_id` int(15) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `sales_data2`
--
ALTER TABLE `sales_data2`
  MODIFY `bill_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `login`
--
ALTER TABLE `login`
  ADD CONSTRAINT `login_ibfk_1` FOREIGN KEY (`staff_id`) REFERENCES `staff` (`staff_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `sales_data2`
--
ALTER TABLE `sales_data2`
  ADD CONSTRAINT `sales_data2_ibfk_1` FOREIGN KEY (`cust_id`) REFERENCES `customer` (`cust_id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
