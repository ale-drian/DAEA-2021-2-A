create proc BuscarPersonaInscripcion
	@EnrollmentDate datetime
as
select * from Person where CAST(EnrollmentDate AS DATE) = CAST(@EnrollmentDate AS DATE);

create proc BuscarPersonaContrato
	@HireDate datetime
as
select * from Person where CAST(HireDate AS DATE)= CAST(@HireDate AS DATE);

create proc BuscarPersonaCodigo
	@PersonID int
as
select * from Person where PersonID = @PersonID;

create proc BuscarPersonaApellido
	@LastName nvarchar(100)
as
select * from Person where LastName like '%'+@LastName+'%';

select * from Person;