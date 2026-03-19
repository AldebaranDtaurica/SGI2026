using CapaDatos.CD_Model.Pers;
using CapaSesion;
using System;

namespace CapaLogica.CL_Model.Pers
{
    public class CL_PersSaludAlergias
    {
        public int IdPersSaludAlergias { get; set; }
        public int IdPersona { get; set; }
        public bool Activo { get; set; }
        public bool Medicamentos { get; set; }
        public bool InternacMedicamentos { get; set; }
        public bool PicInsect { get; set; }
        public bool InternacPicInsect { get; set; }
        public bool Vacunas { get; set; }
        public bool InternacVacunas { get; set; }
        public bool Estacionales { get; set; }
        public bool InternacEstacionales { get; set; }
        public bool Alimentos { get; set; }
        public bool InternacAlimentos { get; set; }
        public bool Otras { get; set; }
        public bool InternacOtras { get; set; }
        public string DescripOtras { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }



        public void GuardarDatos(CL_PersSaludAlergias PersSaludAlergias)
        {
            Usuario = CSE_UserCache.IdUser.ToString();
            var cdPersSaludAlergias = new CD_PersSaludAlergias
            {
                Medicamentos = Medicamentos,
                InternacMedicamentos = InternacMedicamentos,
                PicInsect = PicInsect,
                InternacPicInsect = InternacPicInsect,
                Vacunas = Vacunas,
                InternacVacunas = InternacVacunas,
                Estacionales = Estacionales,
                InternacEstacionales = InternacEstacionales,
                Alimentos = Alimentos,
                InternacAlimentos = InternacAlimentos,
                Otras = Otras,
                InternacOtras = InternacOtras,
                DescripOtras = DescripOtras
            };

            cdPersSaludAlergias.Guardar(cdPersSaludAlergias);

        }
    }
}
