-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Aug 04, 2017 at 11:23 AM
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
  `item` varchar(15) NOT NULL,
  `quantity` int(20) DEFAULT NULL,
  `manu_id` varchar(20) DEFAULT NULL,
  `price` float(20,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `bakery`
--

INSERT INTO `bakery` (`item`, `quantity`, `manu_id`, `price`) VALUES
('Bun', 500, '6', 40.00);

-- --------------------------------------------------------

--
-- Table structure for table `beverage`
--

CREATE TABLE `beverage` (
  `item_name` varchar(20) NOT NULL,
  `quantity` int(20) DEFAULT NULL,
  `manu_id` varchar(20) DEFAULT NULL,
  `price` float(20,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `beverage`
--

INSERT INTO `beverage` (`item_name`, `quantity`, `manu_id`, `price`) VALUES
('Nepalice', 600, '1', 220.00);

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `category` varchar(15) NOT NULL,
  `sub_category` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `cereal`
--

CREATE TABLE `cereal` (
  `item_name` varchar(20) NOT NULL,
  `quantity` int(20) DEFAULT NULL,
  `manu_id` varchar(20) DEFAULT NULL,
  `price` float(20,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `chocolate`
--

CREATE TABLE `chocolate` (
  `item_name` varchar(20) NOT NULL,
  `quantity` int(20) DEFAULT NULL,
  `manu_id` varchar(20) DEFAULT NULL,
  `price` float(20,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 ROW_FORMAT=COMPACT;

--
-- Dumping data for table `chocolate`
--

INSERT INTO `chocolate` (`item_name`, `quantity`, `manu_id`, `price`) VALUES
('Dairy_milk_silk', 530, '1', 80.00),
('Snickers', 560, '3', 0.00);

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `cust_id` varchar(10) NOT NULL,
  `customer_name` varchar(50) DEFAULT NULL,
  `cust_contact` bigint(12) DEFAULT NULL,
  `cust_address` varchar(50) DEFAULT NULL,
  `room_reserved` varchar(10) DEFAULT NULL,
  `checked_intime` varchar(20) NOT NULL,
  `checkedout_time` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`cust_id`, `customer_name`, `cust_contact`, `cust_address`, `room_reserved`, `checked_intime`, `checkedout_time`) VALUES
('1', 'rasil', 985645321, 'banepa', '1', '2017-08-04 13:35:37', '2017-08-04 13:42:01'),
('2', 'Rasil Baidar', 9813702400, 'Banepa-10', '1', '2017-08-04 13:43:29', '2017-08-04 13:43:37');

-- --------------------------------------------------------

--
-- Table structure for table `dairy`
--

CREATE TABLE `dairy` (
  `item` varchar(15) NOT NULL,
  `quantity` int(20) DEFAULT NULL,
  `manu_id` varchar(20) DEFAULT NULL,
  `price` float(20,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `dealer_info`
--

CREATE TABLE `dealer_info` (
  `dealer_name` char(20) NOT NULL,
  `category` varchar(20) NOT NULL,
  `phone_no` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `grains`
--

CREATE TABLE `grains` (
  `item_name` varchar(20) NOT NULL,
  `quantity` int(20) DEFAULT NULL,
  `manu_id` varchar(20) DEFAULT NULL,
  `price` float(20,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `jarred__canned`
--

CREATE TABLE `jarred__canned` (
  `item_name` varchar(20) NOT NULL,
  `quantity` int(20) DEFAULT NULL,
  `manu_id` varchar(20) DEFAULT NULL,
  `price` float(20,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `junk_food`
--

CREATE TABLE `junk_food` (
  `item_name` varchar(20) NOT NULL,
  `quantity` int(20) DEFAULT NULL,
  `manu_id` varchar(20) DEFAULT NULL,
  `price` float(20,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `username` varchar(15) NOT NULL,
  `password` varchar(15) NOT NULL,
  `staff_id` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`username`, `password`, `staff_id`) VALUES
('0', '0', '1'),
('2', '2', '3');

-- --------------------------------------------------------

--
-- Table structure for table `manufacturer`
--

CREATE TABLE `manufacturer` (
  `manu_id` varchar(10) NOT NULL,
  `manu_name` varchar(20) DEFAULT NULL,
  `address` varchar(20) DEFAULT NULL,
  `phone_num` varchar(15) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `manufacturer`
--

INSERT INTO `manufacturer` (`manu_id`, `manu_name`, `address`, `phone_num`) VALUES
('1', 'Chaudhary_group', 'Kathmandu', '9841658752'),
('2', 'Cadbury', 'Kathmandu', '9841488752'),
('3', 'Mars', 'Bhaktapur', '9818658752'),
('4', 'Nestle', 'Birgunj', '9841689752'),
('5', 'Bourborn', 'Kathmandu', '9841658352'),
('6', 'Lottee', 'Biratnagar', '9841455252');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `order_id` int(15) NOT NULL,
  `cust_name` varchar(20) NOT NULL,
  `cust_phone` varchar(15) NOT NULL,
  `order_date` date NOT NULL,
  `delivery_date` date NOT NULL,
  `address` varchar(15) DEFAULT NULL,
  `stat` char(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `orders_product_detail`
--

CREATE TABLE `orders_product_detail` (
  `order_id` int(15) NOT NULL,
  `product_name` varchar(20) NOT NULL,
  `quantity` int(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `room`
--

CREATE TABLE `room` (
  `room_no` varchar(10) NOT NULL,
  `floor` int(5) DEFAULT NULL,
  `status` varchar(15) DEFAULT 'available',
  `cust_id` varchar(10) DEFAULT NULL,
  `price` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `room`
--

INSERT INTO `room` (`room_no`, `floor`, `status`, `cust_id`, `price`) VALUES
('1', 1, 'available', '', 2500),
('2', 1, 'available', '', 1500),
('3', 1, 'available', '', 3000);

-- --------------------------------------------------------

--
-- Table structure for table `sales_data`
--

CREATE TABLE `sales_data` (
  `bill_id` int(10) NOT NULL,
  `timestamp` date DEFAULT NULL,
  `amount` float(25,2) DEFAULT NULL,
  `cust_id` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

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
('3', 'Binay Kumar', 'Cashier', 9813006211, 'Banepa', 30000);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bakery`
--
ALTER TABLE `bakery`
  ADD PRIMARY KEY (`item`),
  ADD KEY `manu_id` (`manu_id`);

--
-- Indexes for table `beverage`
--
ALTER TABLE `beverage`
  ADD PRIMARY KEY (`item_name`),
  ADD KEY `manu_id` (`manu_id`);

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`category`,`sub_category`);

--
-- Indexes for table `cereal`
--
ALTER TABLE `cereal`
  ADD PRIMARY KEY (`item_name`),
  ADD KEY `manu_id` (`manu_id`);

--
-- Indexes for table `chocolate`
--
ALTER TABLE `chocolate`
  ADD PRIMARY KEY (`item_name`),
  ADD KEY `manu_id` (`manu_id`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`cust_id`);

--
-- Indexes for table `dairy`
--
ALTER TABLE `dairy`
  ADD PRIMARY KEY (`item`),
  ADD KEY `manu_id` (`manu_id`);

--
-- Indexes for table `dealer_info`
--
ALTER TABLE `dealer_info`
  ADD PRIMARY KEY (`dealer_name`,`category`),
  ADD KEY `category` (`category`);

--
-- Indexes for table `grains`
--
ALTER TABLE `grains`
  ADD PRIMARY KEY (`item_name`),
  ADD KEY `manu_id` (`manu_id`);

--
-- Indexes for table `jarred__canned`
--
ALTER TABLE `jarred__canned`
  ADD PRIMARY KEY (`item_name`),
  ADD KEY `manu_id` (`manu_id`);

--
-- Indexes for table `junk_food`
--
ALTER TABLE `junk_food`
  ADD PRIMARY KEY (`item_name`),
  ADD KEY `manu_id` (`manu_id`);

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`staff_id`);

--
-- Indexes for table `manufacturer`
--
ALTER TABLE `manufacturer`
  ADD PRIMARY KEY (`manu_id`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`order_id`);

--
-- Indexes for table `orders_product_detail`
--
ALTER TABLE `orders_product_detail`
  ADD PRIMARY KEY (`order_id`,`product_name`);

--
-- Indexes for table `room`
--
ALTER TABLE `room`
  ADD PRIMARY KEY (`room_no`);

--
-- Indexes for table `sales_data`
--
ALTER TABLE `sales_data`
  ADD PRIMARY KEY (`bill_id`),
  ADD KEY `cust_id` (`cust_id`);

--
-- Indexes for table `staff`
--
ALTER TABLE `staff`
  ADD PRIMARY KEY (`staff_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `order_id` int(15) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `sales_data`
--
ALTER TABLE `sales_data`
  MODIFY `bill_id` int(10) NOT NULL AUTO_INCREMENT;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `bakery`
--
ALTER TABLE `bakery`
  ADD CONSTRAINT `bakery_ibfk_1` FOREIGN KEY (`manu_id`) REFERENCES `manufacturer` (`manu_id`);

--
-- Constraints for table `beverage`
--
ALTER TABLE `beverage`
  ADD CONSTRAINT `beverage_ibfk_1` FOREIGN KEY (`manu_id`) REFERENCES `manufacturer` (`manu_id`);

--
-- Constraints for table `cereal`
--
ALTER TABLE `cereal`
  ADD CONSTRAINT `cereal_ibfk_1` FOREIGN KEY (`manu_id`) REFERENCES `manufacturer` (`manu_id`);

--
-- Constraints for table `chocolate`
--
ALTER TABLE `chocolate`
  ADD CONSTRAINT `chocolate_ibfk_1` FOREIGN KEY (`manu_id`) REFERENCES `manufacturer` (`manu_id`);

--
-- Constraints for table `dairy`
--
ALTER TABLE `dairy`
  ADD CONSTRAINT `dairy_ibfk_1` FOREIGN KEY (`manu_id`) REFERENCES `manufacturer` (`manu_id`);

--
-- Constraints for table `dealer_info`
--
ALTER TABLE `dealer_info`
  ADD CONSTRAINT `dealer_info_ibfk_1` FOREIGN KEY (`category`) REFERENCES `categories` (`category`);

--
-- Constraints for table `grains`
--
ALTER TABLE `grains`
  ADD CONSTRAINT `grains_ibfk_1` FOREIGN KEY (`manu_id`) REFERENCES `manufacturer` (`manu_id`);

--
-- Constraints for table `jarred__canned`
--
ALTER TABLE `jarred__canned`
  ADD CONSTRAINT `jarred__canned_ibfk_1` FOREIGN KEY (`manu_id`) REFERENCES `manufacturer` (`manu_id`);

--
-- Constraints for table `junk_food`
--
ALTER TABLE `junk_food`
  ADD CONSTRAINT `junk_food_ibfk_1` FOREIGN KEY (`manu_id`) REFERENCES `manufacturer` (`manu_id`);

--
-- Constraints for table `login`
--
ALTER TABLE `login`
  ADD CONSTRAINT `login_ibfk_1` FOREIGN KEY (`staff_id`) REFERENCES `staff` (`staff_id`);

--
-- Constraints for table `orders_product_detail`
--
ALTER TABLE `orders_product_detail`
  ADD CONSTRAINT `orders_product_detail_ibfk_1` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`);

--
-- Constraints for table `sales_data`
--
ALTER TABLE `sales_data`
  ADD CONSTRAINT `sales_data_ibfk_1` FOREIGN KEY (`cust_id`) REFERENCES `customer` (`cust_id`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
