-- phpMyAdmin SQL Dump
-- version 3.2.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Erstellungszeit: 02. Februar 2023 um 10:03
-- Server Version: 5.1.41
-- PHP-Version: 5.3.1

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";

DROP TABLE IF EXISTS `aldi_sued`;
CREATE TABLE IF NOT EXISTS `aldi_sued` (
  `mitarbeiternr` int(11) NOT NULL AUTO_INCREMENT,
  `filialennr` int(11) COLLATE latin1_german2_ci DEFAULT NULL,
  `vorname` varchar(255) COLLATE latin1_german2_ci NOT NULL,
  `nachname` varchar(255) COLLATE latin1_german2_ci NOT NULL,
  `geschlecht` enum('m','w') COLLATE latin1_german2_ci NOT NULL,
  `position` varchar(255) COLLATE latin1_german2_ci DEFAULT NULL,
  `vertragstyp` varchar(255) COLLATE latin1_german2_ci NOT NULL,
  PRIMARY KEY (`mitarbeiternr`)
  
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 COLLATE=latin1_german2_ci AUTO_INCREMENT=9 ;

--
-- Daten für Tabelle `aldi_sued`
--

INSERT INTO `aldi_sued` (`mitarbeiternr`, `filialennr`, `vorname`, `nachname`, `geschlecht`, `position`,`vertragstyp`) VALUES
('187329','13','Samed','Trnka','m','Verkaufsleiter','Vollzeitvertrag'),
('194739','7','Sanel','Trnka','m','Regionalverkaufsleiter','Vollzeitvertrag'),
('273849','16','Belend','Mohammed','m','Filialverantwortlicher','Vollzeitvertrag'),
('898712','10','Emma','Müller','w','Mitarbeiter','Teilzeitvertrag'),
('678901','23','Maximilian','Schmidt','m','Mitarbeiter','Vollzeitvertrag'),
('789012','34','Sophia','Bauer','w','Mitarbeiter','befristeter Vertrag'),
('456789','45','Lukas','Koch','m','Mitarbeiter','Vollzeitvertrag'),
('345678','56','Mia','Richter','w','Aushilfe','Teilzeitvertrag'),
('234567','67','Julia','Weber','w','Aushilfe','Teilzeitvertrag'),
('567890','78','Lea','Schulz','w','Aushilfe','Teilzeitvertrag')
;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;