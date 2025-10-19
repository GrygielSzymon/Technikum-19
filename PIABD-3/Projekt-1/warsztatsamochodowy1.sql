-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Paź 19, 2025 at 09:57 PM
-- Wersja serwera: 10.4.32-MariaDB
-- Wersja PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `warsztatsamochodowy`
--

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `czas_pracy`
--

CREATE TABLE `czas_pracy` (
  `id_czasu` int(11) NOT NULL,
  `id_pracownika` int(11) NOT NULL,
  `data` date NOT NULL,
  `godz_od` time NOT NULL,
  `godz_do` time NOT NULL,
  `zmiana` enum('1','2') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `czas_pracy`
--

INSERT INTO `czas_pracy` (`id_czasu`, `id_pracownika`, `data`, `godz_od`, `godz_do`, `zmiana`) VALUES
(1, 1, '2025-10-18', '08:00:00', '16:00:00', '1'),
(2, 2, '2025-10-18', '09:00:00', '17:00:00', '1'),
(3, 3, '2025-10-18', '10:00:00', '18:00:00', '2');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `czesc`
--

CREATE TABLE `czesc` (
  `id_czesci` int(11) NOT NULL,
  `nazwa` varchar(100) NOT NULL,
  `kod` varchar(50) DEFAULT NULL,
  `producent` varchar(100) DEFAULT NULL,
  `cena_netto` decimal(10,2) NOT NULL,
  `stawka_vat` decimal(4,2) DEFAULT 23.00,
  `stan_magazynowy` int(11) DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `czesc`
--

INSERT INTO `czesc` (`id_czesci`, `nazwa`, `kod`, `producent`, `cena_netto`, `stawka_vat`, `stan_magazynowy`) VALUES
(1, 'Olej silnikowy 5W30', 'OIL5W30', 'Castrol', 100.00, 23.00, 50),
(2, 'Filtr oleju', 'FIL-OIL', 'Bosch', 30.00, 23.00, 80),
(3, 'Klocki hamulcowe (przód)', 'KL-HAM-FR', 'TRW', 200.00, 23.00, 40);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `dokument_sprzedazy`
--

CREATE TABLE `dokument_sprzedazy` (
  `id_dok` int(11) NOT NULL,
  `id_naprawy` int(11) NOT NULL,
  `typ` enum('Faktura','Paragon') NOT NULL,
  `numer` varchar(50) NOT NULL,
  `data` datetime NOT NULL DEFAULT current_timestamp(),
  `kwota_netto` decimal(10,2) NOT NULL,
  `kwota_vat` decimal(10,2) NOT NULL,
  `kwota_brutto` decimal(10,2) NOT NULL,
  `sposob_platnosci` enum('gotówka','karta','przelew') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `dokument_sprzedazy`
--

INSERT INTO `dokument_sprzedazy` (`id_dok`, `id_naprawy`, `typ`, `numer`, `data`, `kwota_netto`, `kwota_vat`, `kwota_brutto`, `sposob_platnosci`) VALUES
(1, 1, 'Faktura', 'FV/2025/001', '2025-10-11 16:05:00', 200.00, 46.00, 246.00, 'karta'),
(2, 2, 'Paragon', 'PAR/2025/002', '2025-10-12 15:30:00', 300.00, 69.00, 369.00, 'przelew'),
(3, 3, 'Faktura', 'FV/2025/003', '2025-10-13 11:15:00', 150.00, 34.50, 184.50, 'karta');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `dostawca`
--

CREATE TABLE `dostawca` (
  `id_dostawcy` int(11) NOT NULL,
  `nazwa` varchar(100) NOT NULL,
  `nip` varchar(15) DEFAULT NULL,
  `adres` varchar(200) DEFAULT NULL,
  `telefon` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `dostawca`
--

INSERT INTO `dostawca` (`id_dostawcy`, `nazwa`, `nip`, `adres`, `telefon`, `email`) VALUES
(1, 'AutoParts Sp. z o.o.', '1234567890', 'ul. Przemysłowa 1, Warszawa', '222100200', 'kontakt@autoparts.pl'),
(2, 'Mototech S.A.', '9876543210', 'ul. Produkcyjna 5, Poznań', '612200300', 'biuro@mototech.pl'),
(3, 'SerwisPlus', '5556667778', 'ul. Magazynowa 7, Łódź', '426003004', 'info@serwisplus.pl');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `faktura_zakup`
--

CREATE TABLE `faktura_zakup` (
  `id_faktura_zakup` int(11) NOT NULL,
  `id_dostawcy` int(11) NOT NULL,
  `numer` varchar(50) NOT NULL,
  `data` date NOT NULL,
  `kwota_netto` decimal(10,2) NOT NULL,
  `kwota_vat` decimal(10,2) NOT NULL,
  `kwota_brutto` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `faktura_zakup`
--

INSERT INTO `faktura_zakup` (`id_faktura_zakup`, `id_dostawcy`, `numer`, `data`, `kwota_netto`, `kwota_vat`, `kwota_brutto`) VALUES
(1, 1, 'FZ/2025/001', '2025-10-05', 1000.00, 230.00, 1230.00),
(2, 2, 'FZ/2025/002', '2025-10-06', 500.00, 115.00, 615.00),
(3, 3, 'FZ/2025/003', '2025-10-07', 750.00, 172.50, 922.50);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `kampania`
--

CREATE TABLE `kampania` (
  `id_kampanii` int(11) NOT NULL,
  `nazwa` varchar(100) NOT NULL,
  `typ` enum('SMS','Email') NOT NULL,
  `data_rozpoczecia` date NOT NULL,
  `opis` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `kampania`
--

INSERT INTO `kampania` (`id_kampanii`, `nazwa`, `typ`, `data_rozpoczecia`, `opis`) VALUES
(1, 'Jesienna promocja', 'Email', '2025-09-01', 'Zniżki na przeglądy i wymianę opon'),
(2, 'Przeglądy 2025', 'SMS', '2025-10-01', 'Przypomnienia o terminach przeglądów'),
(3, 'Zimowe opony', 'Email', '2025-11-01', 'Oferta na wymianę opon zimowych');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `kampania_klient`
--

CREATE TABLE `kampania_klient` (
  `id_kampania_klient` int(11) NOT NULL,
  `id_kampanii` int(11) NOT NULL,
  `id_klienta` int(11) NOT NULL,
  `status` enum('wysłano','otwarto','kliknięto','nie_dostarczono') DEFAULT 'wysłano'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `kampania_klient`
--

INSERT INTO `kampania_klient` (`id_kampania_klient`, `id_kampanii`, `id_klienta`, `status`) VALUES
(1, 1, 1, 'otwarto'),
(2, 2, 2, 'otwarto'),
(3, 3, 3, 'otwarto');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `klient`
--

CREATE TABLE `klient` (
  `id_klienta` int(11) NOT NULL,
  `imie` varchar(50) NOT NULL,
  `nazwisko` varchar(50) NOT NULL,
  `pesel_nip` varchar(15) DEFAULT NULL,
  `telefon` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `data_rejestracji` date DEFAULT curdate(),
  `status` enum('aktywny','nieaktywny') DEFAULT 'aktywny'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `klient`
--

INSERT INTO `klient` (`id_klienta`, `imie`, `nazwisko`, `pesel_nip`, `telefon`, `email`, `data_rejestracji`, `status`) VALUES
(1, 'Jan', 'Kowalski', '90010112345', '600100200', 'jan.kowalski@gmail.com', '2024-05-10', 'aktywny'),
(2, 'Anna', 'Nowak', '92020254321', '600200300', 'anna.nowak@o2.com', '2024-06-15', 'aktywny'),
(3, 'Piotr', 'Zieliński', '88030367890', '600300400', 'piotr.zielinski@wp.com', '2024-07-20', 'aktywny');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `klient_adres`
--

CREATE TABLE `klient_adres` (
  `id_klient_adres` int(11) NOT NULL,
  `id_klienta` int(11) NOT NULL,
  `ulica` varchar(100) DEFAULT NULL,
  `nr_domu` varchar(10) DEFAULT NULL,
  `nr_lokalu` varchar(10) DEFAULT NULL,
  `miasto` varchar(50) DEFAULT NULL,
  `kod_pocztowy` varchar(10) DEFAULT NULL,
  `data_od` date NOT NULL,
  `data_do` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `klient_adres`
--

INSERT INTO `klient_adres` (`id_klient_adres`, `id_klienta`, `ulica`, `nr_domu`, `nr_lokalu`, `miasto`, `kod_pocztowy`, `data_od`, `data_do`) VALUES
(1, 1, 'ul. Warszawska', '10', '2', 'Warszawa', '00-001', '2024-05-10', '2026-12-31'),
(2, 2, 'ul. Krakowska', '5', NULL, 'Kraków', '30-002', '2024-06-15', '2026-12-31'),
(3, 3, 'ul. Gdańska', '7A', '12', 'Gdańsk', '80-003', '2024-07-20', '2026-12-31');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `naprawa`
--

CREATE TABLE `naprawa` (
  `id_naprawy` int(11) NOT NULL,
  `id_samochodu` int(11) NOT NULL,
  `id_pracownika` int(11) DEFAULT NULL,
  `data_przyjecia` datetime NOT NULL DEFAULT current_timestamp(),
  `data_zakonczenia` datetime DEFAULT NULL,
  `opis` text DEFAULT NULL,
  `status` enum('przyjeta','w_trakcie','zakończona','odebrana') DEFAULT 'przyjeta'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `naprawa`
--

INSERT INTO `naprawa` (`id_naprawy`, `id_samochodu`, `id_pracownika`, `data_przyjecia`, `data_zakonczenia`, `opis`, `status`) VALUES
(1, 1, 1, '2025-10-10 08:30:00', '2025-10-11 16:00:00', NULL, 'zakończona'),
(2, 2, 1, '2025-10-12 09:00:00', NULL, NULL, 'w_trakcie'),
(3, 3, 3, '2025-10-13 10:00:00', NULL, NULL, 'przyjeta');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `naprawa_czesc`
--

CREATE TABLE `naprawa_czesc` (
  `id_naprawa_czesc` int(11) NOT NULL,
  `id_naprawy` int(11) NOT NULL,
  `id_czesci` int(11) NOT NULL,
  `ilosc` int(11) NOT NULL CHECK (`ilosc` > 0),
  `cena_netto_w_chwili_uzycia` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `naprawa_czesc`
--

INSERT INTO `naprawa_czesc` (`id_naprawa_czesc`, `id_naprawy`, `id_czesci`, `ilosc`, `cena_netto_w_chwili_uzycia`) VALUES
(1, 1, 1, 4, 100.00),
(2, 1, 2, 1, 30.00),
(3, 2, 3, 1, 200.00);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `pracownik`
--

CREATE TABLE `pracownik` (
  `id_pracownika` int(11) NOT NULL,
  `imie` varchar(50) NOT NULL,
  `nazwisko` varchar(50) NOT NULL,
  `pesel` varchar(11) DEFAULT NULL,
  `stanowisko` varchar(50) DEFAULT NULL,
  `data_zatrudnienia` date NOT NULL,
  `stan_cywilny` enum('kawaler/panna','żonaty','zamężna','rozwiedziony/a','wdowiec/wdowa') DEFAULT 'kawaler/panna',
  `aktywny` tinyint(1) DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pracownik`
--

INSERT INTO `pracownik` (`id_pracownika`, `imie`, `nazwisko`, `pesel`, `stanowisko`, `data_zatrudnienia`, `stan_cywilny`, `aktywny`) VALUES
(1, 'Adam', 'Mechanik', '82010112345', 'Mechanik', '2022-01-10', 'kawaler/panna', 1),
(2, 'Beata', 'Recepcja', '90020254321', 'Recepcjonista', '2023-03-01', 'kawaler/panna', 1),
(3, 'Cezary', 'Kierownik', '79030367890', 'Kierownik', '2020-09-15', 'kawaler/panna', 1);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `pracownik_rodzina`
--

CREATE TABLE `pracownik_rodzina` (
  `id_rodzina` int(11) NOT NULL,
  `id_pracownika` int(11) NOT NULL,
  `typ` enum('dziecko','małżonek') NOT NULL,
  `imie` varchar(50) NOT NULL,
  `nazwisko` varchar(50) NOT NULL,
  `data_urodzenia` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pracownik_rodzina`
--

INSERT INTO `pracownik_rodzina` (`id_rodzina`, `id_pracownika`, `typ`, `imie`, `nazwisko`, `data_urodzenia`) VALUES
(1, 1, 'dziecko', 'Kacper', 'Mechanik', '2015-06-10'),
(2, 2, '', 'Jan', 'Recepcja', '1992-04-12'),
(3, 3, 'dziecko', 'Ola', 'Kierownik', '2012-09-05');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `przeglad`
--

CREATE TABLE `przeglad` (
  `id_przegladu` int(11) NOT NULL,
  `id_samochodu` int(11) NOT NULL,
  `data_przegladu` date NOT NULL,
  `wynik` enum('pozytywny','negatywny') NOT NULL,
  `uwagi` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `przeglad`
--

INSERT INTO `przeglad` (`id_przegladu`, `id_samochodu`, `data_przegladu`, `wynik`, `uwagi`) VALUES
(1, 1, '2025-05-01', 'pozytywny', 'Bez uwag'),
(2, 2, '2025-05-10', 'pozytywny', 'Wymieniono wycieraczki'),
(3, 3, '2025-05-15', 'negatywny', 'Niesprawne hamulce');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `raport_kasowy`
--

CREATE TABLE `raport_kasowy` (
  `id_raportu` int(11) NOT NULL,
  `data` date NOT NULL,
  `suma_netto` decimal(10,2) NOT NULL DEFAULT 0.00,
  `suma_vat` decimal(10,2) NOT NULL DEFAULT 0.00,
  `suma_brutto` decimal(10,2) NOT NULL DEFAULT 0.00
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `raport_kasowy`
--

INSERT INTO `raport_kasowy` (`id_raportu`, `data`, `suma_netto`, `suma_vat`, `suma_brutto`) VALUES
(1, '2025-10-11', 200.00, 46.00, 246.00),
(2, '2025-10-12', 300.00, 69.00, 369.00),
(3, '2025-10-13', 150.00, 34.50, 184.50);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `raport_pozycja`
--

CREATE TABLE `raport_pozycja` (
  `id_pozycji` int(11) NOT NULL,
  `id_raportu` int(11) NOT NULL,
  `id_dok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `raport_pozycja`
--

INSERT INTO `raport_pozycja` (`id_pozycji`, `id_raportu`, `id_dok`) VALUES
(1, 1, 1),
(2, 2, 2),
(3, 3, 3);

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `samochod`
--

CREATE TABLE `samochod` (
  `id_samochodu` int(11) NOT NULL,
  `id_klienta` int(11) NOT NULL,
  `marka` varchar(50) NOT NULL,
  `model` varchar(50) NOT NULL,
  `rok_prod` year(4) DEFAULT NULL,
  `vin` varchar(17) NOT NULL,
  `nr_rejestracyjny` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `samochod`
--

INSERT INTO `samochod` (`id_samochodu`, `id_klienta`, `marka`, `model`, `rok_prod`, `vin`, `nr_rejestracyjny`) VALUES
(1, 1, 'Toyota', 'Corolla', '2015', 'JTDBR32E123456789', 'WWA12345'),
(2, 2, 'Volkswagen', 'Golf', '2018', 'WVZZZ3CZ8JP123456', 'KR1234AB'),
(3, 3, 'BMW', '320d', '2016', 'WBA8E9G57GNT12345', 'GDA9K32');

-- --------------------------------------------------------

--
-- Struktura tabeli dla tabeli `ubezpieczenie`
--

CREATE TABLE `ubezpieczenie` (
  `id_ubezpieczenia` int(11) NOT NULL,
  `id_rodzina` int(11) NOT NULL,
  `ubezpieczyciel` varchar(100) NOT NULL,
  `skladka` decimal(10,2) NOT NULL,
  `od_kiedy` date NOT NULL,
  `do_kiedy` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `ubezpieczenie`
--

INSERT INTO `ubezpieczenie` (`id_ubezpieczenia`, `id_rodzina`, `ubezpieczyciel`, `skladka`, `od_kiedy`, `do_kiedy`) VALUES
(1, 1, 'PZU', 120.00, '2025-01-01', '2025-12-31'),
(2, 2, 'Warta', 160.00, '2025-02-01', '2026-01-31'),
(3, 3, 'Allianz', 140.00, '2025-03-01', '2026-02-28');

--
-- Indeksy dla zrzutów tabel
--

--
-- Indeksy dla tabeli `czas_pracy`
--
ALTER TABLE `czas_pracy`
  ADD PRIMARY KEY (`id_czasu`),
  ADD KEY `id_pracownika` (`id_pracownika`);

--
-- Indeksy dla tabeli `czesc`
--
ALTER TABLE `czesc`
  ADD PRIMARY KEY (`id_czesci`),
  ADD UNIQUE KEY `kod` (`kod`);

--
-- Indeksy dla tabeli `dokument_sprzedazy`
--
ALTER TABLE `dokument_sprzedazy`
  ADD PRIMARY KEY (`id_dok`),
  ADD UNIQUE KEY `numer` (`numer`),
  ADD KEY `id_naprawy` (`id_naprawy`);

--
-- Indeksy dla tabeli `dostawca`
--
ALTER TABLE `dostawca`
  ADD PRIMARY KEY (`id_dostawcy`),
  ADD UNIQUE KEY `nip` (`nip`);

--
-- Indeksy dla tabeli `faktura_zakup`
--
ALTER TABLE `faktura_zakup`
  ADD PRIMARY KEY (`id_faktura_zakup`),
  ADD KEY `id_dostawcy` (`id_dostawcy`);

--
-- Indeksy dla tabeli `kampania`
--
ALTER TABLE `kampania`
  ADD PRIMARY KEY (`id_kampanii`);

--
-- Indeksy dla tabeli `kampania_klient`
--
ALTER TABLE `kampania_klient`
  ADD PRIMARY KEY (`id_kampania_klient`),
  ADD KEY `id_kampanii` (`id_kampanii`),
  ADD KEY `id_klienta` (`id_klienta`);

--
-- Indeksy dla tabeli `klient`
--
ALTER TABLE `klient`
  ADD PRIMARY KEY (`id_klienta`),
  ADD UNIQUE KEY `pesel_nip` (`pesel_nip`);

--
-- Indeksy dla tabeli `klient_adres`
--
ALTER TABLE `klient_adres`
  ADD PRIMARY KEY (`id_klient_adres`),
  ADD KEY `id_klienta` (`id_klienta`);

--
-- Indeksy dla tabeli `naprawa`
--
ALTER TABLE `naprawa`
  ADD PRIMARY KEY (`id_naprawy`),
  ADD KEY `id_samochodu` (`id_samochodu`);

--
-- Indeksy dla tabeli `naprawa_czesc`
--
ALTER TABLE `naprawa_czesc`
  ADD PRIMARY KEY (`id_naprawa_czesc`),
  ADD KEY `id_naprawy` (`id_naprawy`),
  ADD KEY `id_czesci` (`id_czesci`);

--
-- Indeksy dla tabeli `pracownik`
--
ALTER TABLE `pracownik`
  ADD PRIMARY KEY (`id_pracownika`),
  ADD UNIQUE KEY `pesel` (`pesel`);

--
-- Indeksy dla tabeli `pracownik_rodzina`
--
ALTER TABLE `pracownik_rodzina`
  ADD PRIMARY KEY (`id_rodzina`),
  ADD KEY `id_pracownika` (`id_pracownika`);

--
-- Indeksy dla tabeli `przeglad`
--
ALTER TABLE `przeglad`
  ADD PRIMARY KEY (`id_przegladu`),
  ADD KEY `id_samochodu` (`id_samochodu`);

--
-- Indeksy dla tabeli `raport_kasowy`
--
ALTER TABLE `raport_kasowy`
  ADD PRIMARY KEY (`id_raportu`),
  ADD UNIQUE KEY `data` (`data`);

--
-- Indeksy dla tabeli `raport_pozycja`
--
ALTER TABLE `raport_pozycja`
  ADD PRIMARY KEY (`id_pozycji`),
  ADD KEY `id_raportu` (`id_raportu`),
  ADD KEY `id_dok` (`id_dok`);

--
-- Indeksy dla tabeli `samochod`
--
ALTER TABLE `samochod`
  ADD PRIMARY KEY (`id_samochodu`),
  ADD UNIQUE KEY `vin` (`vin`),
  ADD UNIQUE KEY `nr_rejestracyjny` (`nr_rejestracyjny`),
  ADD KEY `id_klienta` (`id_klienta`);

--
-- Indeksy dla tabeli `ubezpieczenie`
--
ALTER TABLE `ubezpieczenie`
  ADD PRIMARY KEY (`id_ubezpieczenia`),
  ADD KEY `id_rodzina` (`id_rodzina`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `czas_pracy`
--
ALTER TABLE `czas_pracy`
  MODIFY `id_czasu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `czesc`
--
ALTER TABLE `czesc`
  MODIFY `id_czesci` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `dokument_sprzedazy`
--
ALTER TABLE `dokument_sprzedazy`
  MODIFY `id_dok` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `dostawca`
--
ALTER TABLE `dostawca`
  MODIFY `id_dostawcy` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `faktura_zakup`
--
ALTER TABLE `faktura_zakup`
  MODIFY `id_faktura_zakup` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `kampania`
--
ALTER TABLE `kampania`
  MODIFY `id_kampanii` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `kampania_klient`
--
ALTER TABLE `kampania_klient`
  MODIFY `id_kampania_klient` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `klient`
--
ALTER TABLE `klient`
  MODIFY `id_klienta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `klient_adres`
--
ALTER TABLE `klient_adres`
  MODIFY `id_klient_adres` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `naprawa`
--
ALTER TABLE `naprawa`
  MODIFY `id_naprawy` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `naprawa_czesc`
--
ALTER TABLE `naprawa_czesc`
  MODIFY `id_naprawa_czesc` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `pracownik`
--
ALTER TABLE `pracownik`
  MODIFY `id_pracownika` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `pracownik_rodzina`
--
ALTER TABLE `pracownik_rodzina`
  MODIFY `id_rodzina` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `przeglad`
--
ALTER TABLE `przeglad`
  MODIFY `id_przegladu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `raport_kasowy`
--
ALTER TABLE `raport_kasowy`
  MODIFY `id_raportu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `raport_pozycja`
--
ALTER TABLE `raport_pozycja`
  MODIFY `id_pozycji` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `samochod`
--
ALTER TABLE `samochod`
  MODIFY `id_samochodu` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `ubezpieczenie`
--
ALTER TABLE `ubezpieczenie`
  MODIFY `id_ubezpieczenia` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `czas_pracy`
--
ALTER TABLE `czas_pracy`
  ADD CONSTRAINT `czas_pracy_ibfk_1` FOREIGN KEY (`id_pracownika`) REFERENCES `pracownik` (`id_pracownika`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `dokument_sprzedazy`
--
ALTER TABLE `dokument_sprzedazy`
  ADD CONSTRAINT `dokument_sprzedazy_ibfk_1` FOREIGN KEY (`id_naprawy`) REFERENCES `naprawa` (`id_naprawy`) ON UPDATE CASCADE;

--
-- Constraints for table `faktura_zakup`
--
ALTER TABLE `faktura_zakup`
  ADD CONSTRAINT `faktura_zakup_ibfk_1` FOREIGN KEY (`id_dostawcy`) REFERENCES `dostawca` (`id_dostawcy`) ON UPDATE CASCADE;

--
-- Constraints for table `kampania_klient`
--
ALTER TABLE `kampania_klient`
  ADD CONSTRAINT `kampania_klient_ibfk_1` FOREIGN KEY (`id_kampanii`) REFERENCES `kampania` (`id_kampanii`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `kampania_klient_ibfk_2` FOREIGN KEY (`id_klienta`) REFERENCES `klient` (`id_klienta`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `klient_adres`
--
ALTER TABLE `klient_adres`
  ADD CONSTRAINT `klient_adres_ibfk_1` FOREIGN KEY (`id_klienta`) REFERENCES `klient` (`id_klienta`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `naprawa`
--
ALTER TABLE `naprawa`
  ADD CONSTRAINT `naprawa_ibfk_1` FOREIGN KEY (`id_samochodu`) REFERENCES `samochod` (`id_samochodu`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `naprawa_czesc`
--
ALTER TABLE `naprawa_czesc`
  ADD CONSTRAINT `naprawa_czesc_ibfk_1` FOREIGN KEY (`id_naprawy`) REFERENCES `naprawa` (`id_naprawy`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `naprawa_czesc_ibfk_2` FOREIGN KEY (`id_czesci`) REFERENCES `czesc` (`id_czesci`) ON UPDATE CASCADE;

--
-- Constraints for table `pracownik_rodzina`
--
ALTER TABLE `pracownik_rodzina`
  ADD CONSTRAINT `pracownik_rodzina_ibfk_1` FOREIGN KEY (`id_pracownika`) REFERENCES `pracownik` (`id_pracownika`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `przeglad`
--
ALTER TABLE `przeglad`
  ADD CONSTRAINT `przeglad_ibfk_1` FOREIGN KEY (`id_samochodu`) REFERENCES `samochod` (`id_samochodu`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `raport_pozycja`
--
ALTER TABLE `raport_pozycja`
  ADD CONSTRAINT `raport_pozycja_ibfk_1` FOREIGN KEY (`id_raportu`) REFERENCES `raport_kasowy` (`id_raportu`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `raport_pozycja_ibfk_2` FOREIGN KEY (`id_dok`) REFERENCES `dokument_sprzedazy` (`id_dok`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `samochod`
--
ALTER TABLE `samochod`
  ADD CONSTRAINT `samochod_ibfk_1` FOREIGN KEY (`id_klienta`) REFERENCES `klient` (`id_klienta`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `ubezpieczenie`
--
ALTER TABLE `ubezpieczenie`
  ADD CONSTRAINT `ubezpieczenie_ibfk_1` FOREIGN KEY (`id_rodzina`) REFERENCES `pracownik_rodzina` (`id_rodzina`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
