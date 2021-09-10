create proc BuscarCursoNombre
	@Title nvarchar(100)
as
select * from Course where Title like '%'+@Title+'%';

select * from Course;