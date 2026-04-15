-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 16, 2026 at 12:10 AM
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
-- Database: `fitapp`
--

-- --------------------------------------------------------

--
-- Table structure for table `korisnik`
--

CREATE TABLE `korisnik` (
  `KorisnikID` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `PasswordHash` varchar(64) NOT NULL,
  `Ime` varchar(50) DEFAULT NULL,
  `Prezime` varchar(50) DEFAULT NULL,
  `Godine` int(11) DEFAULT NULL,
  `Tezina` decimal(5,2) DEFAULT NULL,
  `Visina` decimal(5,2) DEFAULT NULL,
  `ProfilnaSlika` varchar(500) DEFAULT NULL,
  `ZapamtiMe` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `korisnik`
--

INSERT INTO `korisnik` (`KorisnikID`, `Username`, `PasswordHash`, `Ime`, `Prezime`, `Godine`, `Tezina`, `Visina`, `ProfilnaSlika`, `ZapamtiMe`) VALUES
(1, 'test', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'Marko', 'Petrovic', 22, 80.00, 180.00, NULL, 0),
(3, 'test1', 'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 'Marko', 'Petrovic', 22, 80.00, 180.00, NULL, 0);

-- --------------------------------------------------------

--
-- Table structure for table `planvjezba`
--

CREATE TABLE `planvjezba` (
  `PlanVjezbaID` int(11) NOT NULL,
  `PlanID` int(11) NOT NULL,
  `VjezbaID` int(11) NOT NULL,
  `BrojSetova` int(11) DEFAULT 3,
  `BrojPonavljanja` int(11) DEFAULT 10
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `planvjezba`
--

INSERT INTO `planvjezba` (`PlanVjezbaID`, `PlanID`, `VjezbaID`, `BrojSetova`, `BrojPonavljanja`) VALUES
(2, 1, 1, 3, 10),
(3, 1, 2, 3, 10),
(4, 2, 2, 3, 10),
(5, 3, 1, 3, 10);

-- --------------------------------------------------------

--
-- Table structure for table `trening`
--

CREATE TABLE `trening` (
  `TreningID` int(11) NOT NULL,
  `KorisnikID` int(11) NOT NULL,
  `PlanID` int(11) DEFAULT NULL,
  `Datum` date NOT NULL,
  `Napomena` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `trening`
--

INSERT INTO `trening` (`TreningID`, `KorisnikID`, `PlanID`, `Datum`, `Napomena`) VALUES
(1, 3, 2, '2026-04-12', NULL),
(2, 3, 1, '2026-04-13', NULL),
(3, 3, 1, '2026-04-14', NULL),
(4, 3, 2, '2026-04-14', NULL),
(5, 3, 2, '2026-04-14', NULL),
(6, 3, 1, '2026-04-14', NULL),
(7, 3, 3, '2026-04-14', NULL),
(8, 3, 3, '2026-04-14', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `treningplan`
--

CREATE TABLE `treningplan` (
  `PlanID` int(11) NOT NULL,
  `KorisnikID` int(11) NOT NULL,
  `Naziv` varchar(100) NOT NULL,
  `Opis` text DEFAULT NULL,
  `DatumKreiranja` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `treningplan`
--

INSERT INTO `treningplan` (`PlanID`, `KorisnikID`, `Naziv`, `Opis`, `DatumKreiranja`) VALUES
(1, 3, 'Plan 09.04.2026', NULL, '2026-04-09'),
(2, 3, 'Novi plan 12.04.2026', NULL, '2026-04-12'),
(3, 3, 'BenchNeki', NULL, '2026-04-14');

-- --------------------------------------------------------

--
-- Table structure for table `treningvjezba`
--

CREATE TABLE `treningvjezba` (
  `ID` int(11) NOT NULL,
  `TreningID` int(11) NOT NULL,
  `VjezbaID` int(11) NOT NULL,
  `OdradjeniSetovi` int(11) DEFAULT 0,
  `OdradjenaPonavlajnja` int(11) DEFAULT NULL,
  `MaxTezina` decimal(6,2) DEFAULT 0.00,
  `Uradjeno` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `treningvjezba`
--

INSERT INTO `treningvjezba` (`ID`, `TreningID`, `VjezbaID`, `OdradjeniSetovi`, `OdradjenaPonavlajnja`, `MaxTezina`, `Uradjeno`) VALUES
(1, 1, 2, 0, NULL, 0.00, 0),
(2, 3, 1, 3, NULL, 2.00, 1),
(3, 3, 2, 3, NULL, 13.00, 1),
(4, 5, 2, 3, NULL, 7.00, 1),
(5, 6, 1, 3, NULL, 3.00, 1),
(6, 6, 2, 3, NULL, 6.00, 1),
(7, 7, 1, 3, NULL, 20.00, 1),
(8, 8, 1, 3, NULL, 333.00, 1);

-- --------------------------------------------------------

--
-- Table structure for table `vjezba`
--

CREATE TABLE `vjezba` (
  `VjezbaID` int(11) NOT NULL,
  `Naziv` varchar(100) NOT NULL,
  `Opis` text DEFAULT NULL,
  `Tip` varchar(30) NOT NULL,
  `MisicnaGrupa` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `vjezba`
--

INSERT INTO `vjezba` (`VjezbaID`, `Naziv`, `Opis`, `Tip`, `MisicnaGrupa`) VALUES
(1, 'Bench', 'compund vjezba za snagu', 'Snaga', 'Prsa'),
(2, 'Zgibovi', 'Fokus na lat', 'Snaga', 'Ledja'),
(3, 'Bench Press', 'Osnovna compound vjezba za prsa sa sipkom', 'Snaga', 'Prsa'),
(4, 'Kosi Bench Press', 'Bench press na kosoj klupi, fokus na gornja prsa', 'Snaga', 'Prsa'),
(5, 'Dumbbell Fly', 'Izolacijska vjezba za prsa sa bučicama', 'Snaga', 'Prsa'),
(6, 'Push Up', 'Sklekovi, vjezba sa sopstvenom tjelesnom tezinom', 'Snaga', 'Prsa'),
(7, 'Cable Crossover', 'Izolacija prsa na kablovskoj masini', 'Snaga', 'Prsa'),
(8, 'Zgibovi', 'Compound vjezba za ledja sa sopstvenom tjelesnom tezinom', 'Snaga', 'Ledja'),
(9, 'Deadlift', 'Osnovna compound vjezba za cijelo ledja i zadnju lanu', 'Snaga', 'Ledja'),
(10, 'Bent Over Row', 'Rowing sa sipkom u pretklonu, sirina ledja', 'Snaga', 'Ledja'),
(11, 'Lat Pulldown', 'Lat pulldown na masini, zamjena za zgibove', 'Snaga', 'Ledja'),
(12, 'Seated Cable Row', 'Vucenje kabla u sjedu, debljina ledja', 'Snaga', 'Ledja'),
(13, 'T-Bar Row', 'Rowing na T-bar masini, fokus na srednja ledja', 'Snaga', 'Ledja'),
(14, 'Squat', 'Osnovna compound vjezba za noge sa sipkom', 'Snaga', 'Noge'),
(15, 'Leg Press', 'Potisak nogama na masini', 'Snaga', 'Noge'),
(16, 'Romanian Deadlift', 'Mrtvo dizanje za zadnju loznu i zadnjicu', 'Snaga', 'Noge'),
(17, 'Leg Curl', 'Izolacija zadnje lozne na masini', 'Snaga', 'Noge'),
(18, 'Leg Extension', 'Izolacija prednje lozne (kvadriceps) na masini', 'Snaga', 'Noge'),
(19, 'Calf Raise', 'Dizanje na prste, izolacija listova', 'Snaga', 'Noge'),
(20, 'Lunges', 'Iskoraci sa bučicama ili sipkom', 'Snaga', 'Noge'),
(21, 'Overhead Press', 'Potisak iznad glave sa sipkom stojeći', 'Snaga', 'Ramena'),
(22, 'Dumbbell Shoulder Press', 'Potisak ramena sa bučicama', 'Snaga', 'Ramena'),
(23, 'Lateral Raise', 'Podizanje ruku u strane, izolacija bočne glave deltoidea', 'Snaga', 'Ramena'),
(24, 'Front Raise', 'Podizanje ruku naprijed, prednja glava deltoidea', 'Snaga', 'Ramena'),
(25, 'Face Pull', 'Vucenje kabla prema licu, zadnja glava deltoidea', 'Snaga', 'Ramena'),
(26, 'Bicep Curl', 'Podizanje bučice za biceps', 'Snaga', 'Ruke'),
(27, 'Hammer Curl', 'Curl sa neutralnim hvatom, brachialis i biceps', 'Snaga', 'Ruke'),
(28, 'Tricep Pushdown', 'Potiskivanje kabla prema dole, izolacija tricepsa', 'Snaga', 'Ruke'),
(29, 'Skull Crusher', 'Lezeci potisak za triceps sa sipkom ili bučicama', 'Snaga', 'Ruke'),
(30, 'Dips', 'Paralelne ruke, compound vjezba za triceps i prsa', 'Snaga', 'Ruke'),
(31, 'Trcanje na traci', 'Kardio na treadmillu, razlicite brzine i nagib', 'Kardio', 'Cijelo tijelo'),
(32, 'Voznja bicikla', 'Stacionarni bicikl, nizak uticaj na zglobove', 'Kardio', 'Cijelo tijelo');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `korisnik`
--
ALTER TABLE `korisnik`
  ADD PRIMARY KEY (`KorisnikID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- Indexes for table `planvjezba`
--
ALTER TABLE `planvjezba`
  ADD PRIMARY KEY (`PlanVjezbaID`),
  ADD KEY `fk_planvjezba_plan` (`PlanID`),
  ADD KEY `fk_planvjezba_vjezba` (`VjezbaID`);

--
-- Indexes for table `trening`
--
ALTER TABLE `trening`
  ADD PRIMARY KEY (`TreningID`),
  ADD KEY `fk_trening_korisnik` (`KorisnikID`),
  ADD KEY `fk_trening_plan` (`PlanID`);

--
-- Indexes for table `treningplan`
--
ALTER TABLE `treningplan`
  ADD PRIMARY KEY (`PlanID`),
  ADD KEY `fk_plan_korisnik` (`KorisnikID`);

--
-- Indexes for table `treningvjezba`
--
ALTER TABLE `treningvjezba`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `fk_treningvjezba_trening` (`TreningID`),
  ADD KEY `fk_treningvjezba_vjezba` (`VjezbaID`);

--
-- Indexes for table `vjezba`
--
ALTER TABLE `vjezba`
  ADD PRIMARY KEY (`VjezbaID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `korisnik`
--
ALTER TABLE `korisnik`
  MODIFY `KorisnikID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `planvjezba`
--
ALTER TABLE `planvjezba`
  MODIFY `PlanVjezbaID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `trening`
--
ALTER TABLE `trening`
  MODIFY `TreningID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `treningplan`
--
ALTER TABLE `treningplan`
  MODIFY `PlanID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `treningvjezba`
--
ALTER TABLE `treningvjezba`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `vjezba`
--
ALTER TABLE `vjezba`
  MODIFY `VjezbaID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `planvjezba`
--
ALTER TABLE `planvjezba`
  ADD CONSTRAINT `fk_planvjezba_plan` FOREIGN KEY (`PlanID`) REFERENCES `treningplan` (`PlanID`) ON DELETE CASCADE,
  ADD CONSTRAINT `fk_planvjezba_vjezba` FOREIGN KEY (`VjezbaID`) REFERENCES `vjezba` (`VjezbaID`) ON DELETE CASCADE;

--
-- Constraints for table `trening`
--
ALTER TABLE `trening`
  ADD CONSTRAINT `fk_trening_korisnik` FOREIGN KEY (`KorisnikID`) REFERENCES `korisnik` (`KorisnikID`) ON DELETE CASCADE,
  ADD CONSTRAINT `fk_trening_plan` FOREIGN KEY (`PlanID`) REFERENCES `treningplan` (`PlanID`) ON DELETE SET NULL;

--
-- Constraints for table `treningplan`
--
ALTER TABLE `treningplan`
  ADD CONSTRAINT `fk_plan_korisnik` FOREIGN KEY (`KorisnikID`) REFERENCES `korisnik` (`KorisnikID`) ON DELETE CASCADE;

--
-- Constraints for table `treningvjezba`
--
ALTER TABLE `treningvjezba`
  ADD CONSTRAINT `fk_treningvjezba_trening` FOREIGN KEY (`TreningID`) REFERENCES `trening` (`TreningID`) ON DELETE CASCADE,
  ADD CONSTRAINT `fk_treningvjezba_vjezba` FOREIGN KEY (`VjezbaID`) REFERENCES `vjezba` (`VjezbaID`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
