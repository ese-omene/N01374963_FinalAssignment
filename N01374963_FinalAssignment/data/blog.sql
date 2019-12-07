-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Dec 07, 2019 at 04:12 AM
-- Server version: 5.7.24-log
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `blog`
--

-- --------------------------------------------------------

--
-- Table structure for table `blog_post`
--

CREATE TABLE `blog_post` (
  `blogid` int(10) NOT NULL,
  `blogtitle` varchar(255) COLLATE latin1_bin NOT NULL,
  `blogbody` longtext COLLATE latin1_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COLLATE=latin1_bin;

--
-- Dumping data for table `blog_post`
--

INSERT INTO `blog_post` (`blogid`, `blogtitle`, `blogbody`) VALUES
(1, 'first post', 'test test test i think we did it'),
(7, 'blog2', 'some content'),
(8, 'blog3', 'some more content'),
(9, 'blog4', 'even more content'),
(10, 'blog5', 'so much content'),
(11, 'blog6', 'now this is getting silly'),
(12, 'blog7', 'more content!!!'),
(13, 'blog9', 'this should be the last of the content'),
(14, 'blog 1 million', 'content'),
(15, 'was that a fluke', 'now the add post is working again'),
(16, 'Descend', 'I reversed the order so now the newest post \"SHOULD\" be at the top'),
(17, 'wanna add a long post', 'how long can a post be?'),
(19, 'test connect', 'test test test');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `blog_post`
--
ALTER TABLE `blog_post`
  ADD PRIMARY KEY (`blogid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `blog_post`
--
ALTER TABLE `blog_post`
  MODIFY `blogid` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
