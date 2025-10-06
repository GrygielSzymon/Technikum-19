SELECT 
    k.MiastoKlienta,
    SUM(p.CenaDetaliczna * dz.Zamowionailosc) AS wart
FROM 
    dane_zamowien dz
    JOIN produkty p 
        ON dz.NumerProduktu = p.NumerProduktu
    JOIN zamowienia z 
        ON dz.NumerZamowienia = z.NumerZamowienia
    JOIN klienci k 
        ON z.IDKlienta = k.IDKlienta
GROUP BY 
    k.MiastoKlienta
