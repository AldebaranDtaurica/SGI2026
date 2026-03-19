namespace CapaDatos
{
    public class CD_AccesoBD : CD_EjecutarSP
    {
        /*public void CargarCodyFHRecupero( int id, string cod, DateTime fechaCaducidad )
        {
            SqlParameter param1 = new SqlParameter("@id_usuario", id) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@fh_cod_email", fechaCaducidad) { SqlDbType = SqlDbType.DateTime };
            SqlParameter param3 = new SqlParameter("@cod_email", cod) { SqlDbType = SqlDbType.NChar };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3 };
                DataTable resultado = EjecutarConsultas("upCodFechaRecupero_sp", listaParametros.ToArray(), true);
        }*/

        /* public void upPolPass(bool min_carct, bool comb_may, bool num_letras, bool caract_esp, bool contra_ant, bool datos_per)
         {
             SqlParameter param1 = new SqlParameter("@min_caracteres", min_carct) { SqlDbType = SqlDbType.Bit };
             SqlParameter param2 = new SqlParameter("@comb_mayus", comb_may) { SqlDbType = SqlDbType.Bit };
             SqlParameter param3 = new SqlParameter("@num_letras", num_letras) { SqlDbType = SqlDbType.Bit };
             SqlParameter param4 = new SqlParameter("@caract_especial", caract_esp) { SqlDbType = SqlDbType.Bit };
             SqlParameter param5 = new SqlParameter("@contra_anteriores", contra_ant) { SqlDbType = SqlDbType.Bit };
             SqlParameter param6 = new SqlParameter("@datos_personales", datos_per) { SqlDbType = SqlDbType.Bit };
             List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4, param5, param6 };
             DataTable resultado = EjecutarConsultas("upPoliticaPass_sp", listaParametros.ToArray(), true);
         }*/

        /* 
        public DataTable ConsultarPerfiles()
        {
            List<SqlParameter> listaParametros = new List<SqlParameter>() { };
            DataTable resultado = EjecutarConsultas("consultar_perfiles_sp", listaParametros.ToArray());
            return resultado;
        }

        public DataTable ConsultarTodasPregSeg()
        {
            DataTable resultado = EjecutarConsultasSinParam("consultarPreguntas_sp");
            return resultado;
        }

        public DataTable ConsultaRtaSeg(int usuario)
        {
            SqlParameter param1 = new SqlParameter("@id_usuario", usuario) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("consultarRespuestas_sp", listaParametros.ToArray());
            return resultado;
        }

        public DataTable Consulta1PgtaSeg(int pgtas)
        {
            SqlParameter param1 = new SqlParameter("@id_pregunta", pgtas) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable resultado = EjecutarConsultas("consultarPreg_sp", listaParametros.ToArray());
            return resultado;
        }

        public void InsertarNuevaPass( string user, string pass, string dig, bool nueva)
        {
            SqlParameter param1 = new SqlParameter("@usuario", user) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param2 = new SqlParameter("@password", pass) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param3 = new SqlParameter("@digitoVerf", dig) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param4 = new SqlParameter("@nuevo", nueva) { SqlDbType = SqlDbType.Bit };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3, param4 };
            DataTable resultado = EjecutarConsultas("upPassword_sp", listaParametros.ToArray(), true);
        }

        public void InsertarRespuestaSeg( int idUs, string rta, int idPregunta)
        {
            SqlParameter param1 = new SqlParameter("@id_usuario", idUs) { SqlDbType = SqlDbType.Int };
            SqlParameter param2 = new SqlParameter("@respuesta", rta) { SqlDbType = SqlDbType.VarChar };
            SqlParameter param3 = new SqlParameter("@id_pregunta", idPregunta) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1, param2, param3 };
            DataTable resultado = EjecutarConsultas("InsRespuesta_sp", listaParametros.ToArray(), true);
        }

        public string ConsultarMailPersona(int id_persona) //Este metodo falló, no tiene referencias hay que verlo luego
        {
            SqlParameter param1 = new SqlParameter("@id_persona", id_persona) { SqlDbType = SqlDbType.Int };
            List<SqlParameter> listaParametros = new List<SqlParameter>() { param1 };
            DataTable email = EjecutarConsultas("consultar_mail_persona_sp", listaParametros.ToArray());
            return email.Rows[0][0].ToString();
        }*/
    }
}

