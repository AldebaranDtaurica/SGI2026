using System;
namespace CapaServicios
{
    public static class CSR_ArmarMail
    {
        public static string DireccionCorreo { get; set; }
        public static string DireccionCopCorreo { get; set; }
        public static string Asunto { get; set; }
        public static string NuevaContraseña { get; set; }
        public static string Mensaje { get; set; }

        public static void Preparar()
        {
            int year = DateTime.Now.Year;
            string body = $@"<style>
                                h1{{color:dodgerblue;}}
                                h2{{color:darkorange;}}
                                </style>
                                <p>¡Hola!</span></p>
                                <p>Se ha realizado el alta de usuario, será informado por la institución.</p></br></br>
                                <h1>Contraseña para su primer ingreso.</h1></br>
                                <h2>Clave de Ingreso: {NuevaContraseña}</h2></br></br>
                                <h3>Si este mail no fue solicitado por usted desestímelo.</h3></br></br></br></br>
                                <h4>Gracias por utilizar nuestros servicios.<h4></br></br>
                                <h5>Este mensaje es generado automáticamente, por favor no responda.<h5></br></br></br>
                                <p>Sistema de Gestión Institucional © {year}.</p>";

            CSR_EnviarMail.SendMail(DireccionCorreo, Asunto, body);
        }

        public static void PrepararRec()
        {
            int year = DateTime.Now.Year;
            string body = $@"<style>
                                h1{{color:dodgerblue;}}
                                h2{{color:darkorange;}}
                                </style>
                                <p>¡Hola!</span></p>
                                <p>Se ha solicitado la recuperación de contraseña para su usuario.</p></br></br>
                                <h1>Recuperación de contraseña.</h1></br>
                                <h2>Clave de Ingreso: {NuevaContraseña}</h2></br></br>
                                <h3>Si este mail no fue solicitado por usted desestímelo.</h3></br></br></br></br>
                                <h4>Gracias por utilizar nuestros servicios.</h4></br></br>
                                <h5>Este mensaje es generado automáticamente, por favor no responda.</h5></br></br></br>
                                <p>Sistema de Gestión Institucional © {year}.</p>";

            CSR_EnviarMail.SendMail(DireccionCorreo, Asunto, body);
        }

        public static void PrepararMsj()
        {
            int year = DateTime.Now.Year;
            string body = $@"<style>
                                h1{{color:dodgerblue;}}
                                h2{{color:darkorange;}}
                                </style>
                                <h1>Formulario de contacto:</h1></br>
                                <p>¡Hola! Este es un envío desde el form de contato de la app.</span></p>
                                <p>{Mensaje}.</p></br></br>
                                <h5>Por favor, responda este mensaje a {DireccionCopCorreo}.<h5></br></br></br>
                                <h4>Gracias por utilizar nuestros servicios.<h4></br></br> 
                                <p>Sistema de Gestión Institucional © {year}.</p>";

            CSR_EnviarMail.SendMail(DireccionCopCorreo, Asunto, Mensaje, body);
        }
    }
}