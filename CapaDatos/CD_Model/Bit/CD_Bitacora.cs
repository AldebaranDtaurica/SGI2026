using System;

namespace CapaDatos.CD_Model.Bit
{
    public class CD_Bitacora
    {
        public int IdBit { get; set; }
        public string TipoDato { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public string Alerta { get; set; }
        public string Evento { get; set; }
        public string Ubicacion { get; set; }
        public string Log { get; set; }
    }
}

/*
  Seccion: a b c 1 2 3

"Bitacora"
---detalle: ingreso al sisitema
---Fecha: ver fecha.
---Desde que clase o formularios se realizó
---Usuario: quien lo realizó

Datatable no pasar de clase en clase
Un metodo pase a una lista y pasar la lista.

CREATE TABLE [dbo].[EstudCursada](
	[IdCursada] [int] IDENTITY(1,1) NOT NULL,
	[IdEstudios] int NOT NULL,
	[IdMateria] int NOT NULL,
	[Equivalencia] bit NOT NULL,
	[Seccion] varchar(5) not null,
	[Cursa] bit not NULL,
    [Libre] bit not NULL,
	[ParcialA] bit not NULL,
	[ParcialB] bit not NULL,
	[RecuperatirioInst] bit not NULL,
	[Promociona] bit not NULL,


CREATE TABLE [dbo].[EstudFinal](
	[IdFinal] [int] IDENTITY(1,1) NOT NULL,
	[IdCursada] int NOT NULL,
	[Equivalencia] bit not NULL,
	[Dictamen] varchar(2000) null,
    [InscripcionFinal] date NULL,
	[AsistenciaFinal] date NULL,
	[NotaFinal] int NULL,
	[FolioFina] int NULL,  
	[TomoFinal] int NULL,  

  */