use Przedsiêbiorstwo
GO
create procedure Historia_badañ_pracownika @Id_pracownika int
as 
if exists(select * from Zmiany_Badania_lekarskie zm where zm.Id_pracownika = @Id_pracownika)
	begin
		select * from Zmiany_Badania_lekarskie zm
		where @Id_pracownika  = zm.Id_pracownika
	end 
else if exists(select * from Badania_lekarskie b where b.Id_pracownika = @Id_pracownika)
	begin
		select * from Badania_lekarskie b
		where @Id_pracownika  = b.Id_pracownika
	end 
else 
	begin 
	print'Nie ma badañ takiego pracownika w ewidencji!'
	end
GO
