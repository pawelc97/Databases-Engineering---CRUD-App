use Przedsi�biorstwo
GO

declare Up�yw_terminu_bada� cursor for 
select b.Id_pracownika, Imie, Nazwisko, data_wyk_bad_okresowych, data_wa�no�ci_bada�_okr 
from Badania_lekarskie b
inner join Pracownicy p on p.Id_pracownika = b.Id_pracownika
where DATEDIFF(d, b.data_wa�no�ci_bada�_okr, GETDATE()) < 1
declare @Id_pracownika int, @imie varchar(20), @nazwisko varchar(30), @data_wyk_bad_okresowych datetime, @data_wa�no�ci_bada�_okr datetime
print'Pracownicy z niewa�nymi badaniami'
open Up�yw_terminu_bada�
fetch next from Up�yw_terminu_bada� INTO @Id_pracownika, @imie, @nazwisko, @data_wyk_bad_okresowych, @data_wa�no�ci_bada�_okr
WHILE @@FETCH_STATUS = 0
	begin
		print cast(@Id_pracownika as varchar)+' '+@imie+' '+@nazwisko+' '+cast(@data_wyk_bad_okresowych as varchar)+' '+cast(@data_wa�no�ci_bada�_okr as varchar)
		fetch next from Up�yw_terminu_bada� into @Id_pracownika, @imie, @nazwisko, @data_wyk_bad_okresowych, @data_wa�no�ci_bada�_okr
	end
close Up�yw_terminu_bada�
deallocate Up�yw_terminu_bada�

 /*
create procedure Up�yw_terminu_bada�
 as
select b.Id_pracownika, Imie, Nazwisko, data_wyk_bad_okresowych, data_wa�no�ci_bada�_okr 
from Badania_lekarskie b
inner join Pracownicy p on p.Id_pracownika = b.Id_pracownika
where DATEDIFF(d, b.data_wa�no�ci_bada�_okr, GETDATE()) < 1
GO
*/