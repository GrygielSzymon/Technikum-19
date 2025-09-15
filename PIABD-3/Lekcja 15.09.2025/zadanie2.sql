SELECT klienci.ImieKlienta, klienci.NazwiskoKlienta, SUM(produkty.CenaDetaliczna * dane_zamowien.ZamowionaIlosc)
FROM klienci 
INNER JOIN zamowienia ON klienci.IDKlienta = zamowienia.IDKlienta
INNER JOIN dane_zamowien ON zamowienia.NumerZamowienia = dane_zamowien.NumerZamowienia
INNER JOIN produkty ON produkty.NumerProduktu = dane_zamowien.NumerProduktu
GROUP BY klienci.ImieKlienta, klienci.NazwiskoKlienta
