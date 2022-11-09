use Przedsiêbiorstwo
GO

declare Up³yw_terminu_badañ cursor for 
select b.Id_pracownika, Imie, Nazwisko, data_wyk_bad_okresowych, data_wa¿noœci_badañ_okr 
from Badania_lekarskie b
inner join Pracownicy p on p.Id_pracownika = b.Id_pracownika
where DATEDIFF(d, b.data_wa¿noœci_badañ_okr, GETDATE()) < 1
declare @Id_pracownika int, @imie varchar(20), @nazwisko varchar(30), @data_wyk_bad_okresowych datetime, @data_wa¿noœci_badañ_okr datetime
print'Pracownicy z niewa¿nymi badaniami'
open Up³yw_terminu_badañ
fetch next from Up³yw_terminu_badañ INTO @Id_pracownika, @imie, @nazwisko, @data_wyk_bad_okresowych, @data_wa¿noœci_badañ_okr
WHILE @@FETCH_STATUS = 0
	begin
		print cast(@Id_pracownika as varchar)+' '+@imie+' '+@nazwisko+' '+cast(@data_wyk_bad_okresowych as varchar)+' '+cast(@data_wa¿noœci_badañ_okr as varchar)
		fetch next from Up³yw_terminu_badañ into @Id_pracownika, @imie, @nazwisko, @data_wyk_bad_okresowych, @data_wa¿noœci_badañ_okr
	end
close Up³yw_terminu_badañ
deallocate Up³yw_terminu_badañ

 /*
create procedure Up³yw_terminu_badañ
 as
select b.Id_pracownika, Imie, Nazwisko, data_wyk_bad_okresowych, data_wa¿noœci_badañ_okr 
from Badania_lekarskie b
inner join Pracownicy p on p.Id_pracownika = b.Id_pracownika
where DATEDIFF(d, b.data_wa¿noœci_badañ_okr, GETDATE()) < 1
GO
*/