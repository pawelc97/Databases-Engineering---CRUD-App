use Przedsiêbiorstwo
GO
create or alter trigger T_Badania_lekarskie_I 
on Badania_lekarskie
instead of insert
as
declare @Id_pracownika int 
select @Id_pracownika = i.Id_pracownika from inserted i
begin transaction
	if not exists(select * from Badania_lekarskie b where @Id_pracownika = b.Id_pracownika)
		begin
			insert into Badania_lekarskie
			select Id_pracownika, Data_wyk_bad_wstêpnych, data_wyk_bad_okresowych, Data_wa¿noœci_badañ_okr from inserted
			commit transaction
		end
	else
		begin
			select 'Informacja o badaniu/badaniach klient ju¿ istnieje w tabeli'
			rollback transaction
		end 
GO

create or alter trigger T_Badania_lekarskie_U 
on Badania_lekarskie
instead of update
as
declare @data_wyk_bad_okresowych datetime, @data_wa¿noœci_badañ_okr datetime 
declare @Id_badania int, @Id_pracownika int, @Stara_data_wyk_bad_okr datetime, @Stara_data_wa¿_bad_okr datetime
select @data_wyk_bad_okresowych = i.data_wyk_bad_okresowych, @data_wa¿noœci_badañ_okr = i.data_wa¿noœci_badañ_okr from inserted i
select @Id_badania = d.Id_badania, @Id_pracownika = d.Id_pracownika, @Stara_data_wyk_bad_okr = d.data_wyk_bad_okresowych, @Stara_data_wa¿_bad_okr = d.data_wa¿noœci_badañ_okr from deleted d
begin
	update Badania_lekarskie 
	set data_wyk_bad_okresowych = @data_wyk_bad_okresowych, data_wa¿noœci_badañ_okr = @data_wa¿noœci_badañ_okr 
	insert into Zmiany_Badania_lekarskie values (@Id_badania, @Id_pracownika, GETDATE(), @Stara_data_wyk_bad_okr, @Stara_data_wa¿_bad_okr, @data_wyk_bad_okresowych, @data_wa¿noœci_badañ_okr)
end
GO

create or alter trigger T_Badania_lekarskie_D 
on Badania_lekarskie
instead of delete
as
declare @Id_badania int
select @Id_badania = d.Id_badania from deleted d
begin transaction
	if exists(select * from Badania_lekarskie b where @Id_badania = b.Id_badania)
		begin
			delete from Badania_lekarskie where Id_badania = @Id_badania
			delete from Zmiany_Badania_lekarskie where Id_badania = @Id_badania
			print 'Wiersze zosta³y usuniête!' 
			commit transaction
		end 
	else 
		begin
			select 'Wiersz o podanym Id nie istnieje!'  
			rollback transaction
		end
GO