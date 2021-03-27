using System;
using System.IO;
namespace Altas__bajas__cambios_y_curps_s
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta = null;
            string ruta = @"C:\Users\Dell\Desktop\Carpeta\";
            do
            {
                //menu 
                Console.WriteLine("Digite una opción");
                Console.WriteLine("Opción 1.- Altas");
                Console.WriteLine("Opción 2.- Bajas");
                Console.WriteLine("Opción 1.- Cambios");
                Console.WriteLine("Opción 4.- Ver CURP");
                byte opcion = byte.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine("Bienvenido a la opción de altas");
                            //*Nombre Completo : Apellido paterno, Materno, Nombres
                            //Fecha de Nacimineto: DD/MM/AAAA
                            //Entodad de nacimiento
                            //Sexo 
                            //6 renglones por registro y 2 renglones de control (8 renglones)

                            StreamWriter escritura = File.AppendText(ruta + "datos.txt");
                            escritura.WriteLine("1");//... Escritura dinamica
                            Console.WriteLine("Ingresa tu apellido paterno");
                            string temporal = Console.ReadLine();
                            escritura.WriteLine(temporal);
                            Console.WriteLine("Ingresa tu apellido materno");
                            temporal = Console.ReadLine();
                            escritura.WriteLine(temporal);
                            Console.WriteLine("Ingresa tu nombre o nombres");
                            temporal = Console.ReadLine();
                            escritura.WriteLine(temporal);
                            Console.WriteLine("Ingresa tu fecha de nacimiento: DD/MM/AAAA - Ejemplo 21/07/1986");
                            temporal = Console.ReadLine();
                            escritura.WriteLine(temporal);
                            Console.WriteLine("Ingresa tu entidad de nacimiento");
                            temporal = Console.ReadLine();
                            escritura.WriteLine(temporal);
                            Console.WriteLine("Ingresa Hombre o Mujer");
                            temporal = Console.ReadLine();
                            escritura.WriteLine(temporal);
                            escritura.WriteLine("activo");
                            escritura.Close();
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Bienvenido a la opción de bajas");
                            //Inicio de lectura del archivo
                            StreamReader lectura = File.OpenText(ruta + "datos.txt");
                            string contenido = lectura.ReadToEnd();
                            lectura.Close();
                            string[] renglones = contenido.Split('\n');
                            //Fin de lecturadel archivo


                            Console.WriteLine("Los registros son: ");
                            for (int x = 0; x < renglones.Length; x++)
                            {
                                Console.WriteLine(renglones[x]);
                            }
                            //Busqueda de registro
                            Console.WriteLine("Ingresa el Id del regitro a dar de baja");
                            string id = Console.ReadLine();
                            for (int x = 0; x < renglones.Length; x = x + 8)
                            {
                                if (id.Equals(renglones[x].Trim()))//.Trim()
                                {
                                    //ID encontrado
                                    renglones[x + 7] = "inactivo";
                                    Console.WriteLine("El registro ya fue dado de baja");
                                }
                            }
                            //Fin de busqueda y modificación en memoria
                            StreamWriter cambios = File.CreateText(ruta + "datos.txt");

                            for (int x = 0; x < renglones.Length; x++)
                            {

                                cambios.WriteLine(renglones[x].Trim());
                            }
                            cambios.Close();
                            break;
                        }
                    case 3:
                        {
                            string temporal1;
                            byte idcambio = 0;
                            Console.Clear();
                            Console.WriteLine("Bienvenido a la opción de cambios");
                            StreamReader lectura = File.OpenText(ruta + "datos.txt");
                            string contenido = lectura.ReadToEnd();
                            lectura.Close();
                            string[] renglones = contenido.Split('\n');
                            Console.WriteLine("Los registros son: ");
                            for (int x = 0; x < renglones.Length; x++)
                            {
                                Console.WriteLine(renglones[x]);
                            }
                            Console.WriteLine("Digite el id para cambiar");
                            string id = Console.ReadLine();
                            Console.WriteLine("Elija lo que va a cambiar\n1. Apelllido Paterno\n2. Apelllido Materno\n3. Nombre\n4. Fecha Nacimiento\n5. Entidad\n6. Sexo");
                            idcambio = byte.Parse(Console.ReadLine());
                            switch (idcambio)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Ingresa tu apellido paterno");
                                    temporal1 = Console.ReadLine();
                                    for (int x = 0; x < renglones.Length; x = x + 8)
                                    {
                                        if (id.Equals(renglones[x].Trim()))
                                        {

                                            renglones[x + 1] = temporal1;
                                            Console.WriteLine("EL Registro fue cambiado exitosamente");

                                        }
                                    }

                                    StreamWriter cambios = File.CreateText(ruta + "datos.txt");

                                    for (int x = 0; x < renglones.Length; x++)
                                    {
                                        cambios.WriteLine(renglones[x].Trim());
                                    }
                                    cambios.Close();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Ingresa tu apellido materno");
                                    temporal1 = Console.ReadLine();
                                    for (int x = 0; x < renglones.Length; x = x + 8)
                                    {
                                        if (id.Equals(renglones[x].Trim()))
                                        {

                                            renglones[x + 2] = temporal1;
                                            Console.WriteLine("EL Registro fue cambiado exitosamente");

                                        }
                                    }
                                    cambios = File.CreateText(@"C:\Users\Dell\Desktop\Carpeta\datos.txt");
                                    for (int x = 0; x < renglones.Length; x++)
                                    {
                                        cambios.WriteLine(renglones[x].Trim());
                                    }
                                    cambios.Close();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.WriteLine("Ingresa tu nombre");
                                    temporal1 = Console.ReadLine();
                                    for (int x = 0; x < renglones.Length; x = x + 8)
                                    {
                                        if (id.Equals(renglones[x].Trim()))
                                        {

                                            renglones[x + 3] = temporal1;
                                            Console.WriteLine("EL Registro fue cambiado exitosamente");

                                        }
                                    }
                                    cambios = File.CreateText(@"C:\Users\Dell\Desktop\Carpeta\datos.txt");
                                    for (int x = 0; x < renglones.Length; x++)
                                    {
                                        cambios.WriteLine(renglones[x].Trim());
                                    }
                                    cambios.Close();
                                    break;
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine("Ingresa tu fecha de nacimiento: DD/MM/AAAA - Ejemplo 21/07/1986");
                                    temporal1 = Console.ReadLine();
                                    for (int x = 0; x < renglones.Length; x = x + 8)
                                    {
                                        if (id.Equals(renglones[x].Trim()))
                                        {

                                            renglones[x + 4] = temporal1;
                                            Console.WriteLine("EL Registro fue cambiado exitosamente");

                                        }
                                    }
                                    cambios = File.CreateText(@"C:\Users\Dell\Desktop\Carpeta\datos.txt");
                                    for (int x = 0; x < renglones.Length; x++)
                                    {
                                        cambios.WriteLine(renglones[x].Trim());
                                    }
                                    cambios.Close();
                                    break;
                                case 5:
                                    Console.Clear();
                                    Console.WriteLine("Ingresa tu entidad de nacimiento");
                                    temporal1 = Console.ReadLine();
                                    for (int x = 0; x < renglones.Length; x = x + 8)
                                    {
                                        if (id.Equals(renglones[x].Trim()))
                                        {

                                            renglones[x + 5] = temporal1;
                                            Console.WriteLine("EL Registro fue cambiado exitosamente");

                                        }
                                    }
                                    cambios = File.CreateText(ruta + "datos.txt");
                                    for (int x = 0; x < renglones.Length; x++)
                                    {
                                        cambios.WriteLine(renglones[x].Trim());
                                    }
                                    cambios.Close();
                                    break;
                                case 6:
                                    Console.Clear();
                                    Console.WriteLine("Ingresa Hombre o Mujer");
                                    temporal1 = Console.ReadLine();
                                    for (int x = 0; x < renglones.Length; x = x + 8)
                                    {
                                        if (id.Equals(renglones[x].Trim()))
                                        {

                                            renglones[x + 6] = temporal1;
                                            Console.WriteLine("EL Registro fue cambiado exitosamente");

                                        }
                                    }
                                    cambios = File.CreateText(ruta + "datos.txt");
                                    for (int x = 0; x < renglones.Length; x++)
                                    {
                                        cambios.WriteLine(renglones[x].Trim());
                                    }
                                    cambios.Close();
                                    break;
                                default:
                                    Console.WriteLine("Digite una opción correcta");
                                    break;
                            }
                            break;
                        }
                    case 4:
                        {
                            /*GOLS021203HDFNPRA9
                            González (González).Substrings(0,2)
                            López    (López).Substrings(0,1)
                            Sergio    (Sergio).Substrings(0,1)
                            03/12/2002
                            Hombre
                            
                            Curp --> VADA860721HQTRZL08
                            Vargas --> (Vargas).Substring(0,2);
                            Diaz   --> (Diaz).Substring(0,1);
                            Jose Alejandro --> if(que no sea jose o maria el primer nombre)
                                                    (primerNombre).Substring(0,1);
                                                    else(valor sea x)

                            86/07/21 -->(86/07/21).SubString(0,2);(86/07/21).Substring(3,2)
                                        (86/07/21).Split('/') --> [86,07,21] Console.Write(860721)
                            Hombre -->(Hombre).SubString(0,1);
                            */
                            Console.WriteLine("Bienvenidos a CURP's");
                            //Construcción de curps
                            StreamWriter escritura = File.CreateText(ruta + "curps.txt");

                            //Apellido paterno
                            Console.WriteLine("Ingresa tu apellido paterno");
                            //string temporal = Console.ReadLine();
                            string ApellidoPaterno = Console.ReadLine().ToUpper();
                            string c1 = ApellidoPaterno.Substring(0, 2);
                            //escritura.WriteLine(temporal);

                            //Apelldio materno
                            Console.WriteLine("Ingresa tu apellido materno");
                            //temporal = Console.ReadLine();
                            string ApellidoMaterno = Console.ReadLine().ToUpper();
                            string c2 = ApellidoMaterno.Substring(0, 1);
                            //escritura.WriteLine(temporal);

                            //Nombre o nombres
                            Console.WriteLine("Ingresa tu nombre o nombres");
                            //temporal = Console.ReadLine();
                            string nombre = Console.ReadLine().ToUpper();
                            string c3 = null;
                            if (nombre.Contains("MARIA"))
                            {
                                c3 = nombre.Replace("MARIA", "");//_ es la variable c3
                            }
                            else if (nombre.Contains("JOSE") || nombre.Contains("JOSÉ"))
                            {
                                c3 = nombre.Replace("JOSE", "");//_ es la variable c3
                                _ = nombre.Replace("JOSÉ", "");//_ es la variable c3
                            }
                            else
                            {
                                c3 = nombre.Substring(0, 1);//.ToUpper()
                                //escritura.WriteLine(temporal);
                            }





                            //Fecha de nacimiento
                            Console.WriteLine("Ingresa tu fecha de nacimiento: DD/MM/AA - Ejemplo 21/07/1986");
                            //temporal = Console.ReadLine();
                            string fechaNac = Console.ReadLine();
                            string[] c4 = fechaNac.Split('/');
                            string uno = c4[0];
                            string dos = c4[1];
                            string tres = c4[2].Substring(2, 2); //2002
                            /*for (int x = 0; x < c4.Length; x++)
                            {
                                Console.Write(c4[x]);
                                
                            }*/
                            //escritura.WriteLine(temporal);

                            //Genero
                            Console.WriteLine("\nIngrese su sexo: Hombre o Mujer");
                            //temporal = Console.ReadLine();
                            string genero = Console.ReadLine().ToUpper();
                            string c5 = genero.Substring(0, 1);
                            //escritura.WriteLine(temporal);

                            //Entidad de nacimineto
                            Console.WriteLine("Ingresa tu entidad de nacimiento");
                            //temporal = Console.ReadLine();
                            string entidad = Console.ReadLine().ToUpper();
                            string c6 = null;
                            switch (entidad)
                            {
                                case "AGUAS CALIENTES":
                                    c6 = "AS";
                                    break;

                                case "BAJA CALIFORNIA":
                                    c6 = "BC";
                                    break;

                                case "BAJA CALIFORNIA SUR":
                                    c6 = "BS";
                                    break;

                                case "Campeche":
                                    c6 = "CC";
                                    break;

                                case "COAHUILA":
                                    c6 = "CL";
                                    break;

                                case "COLIMA":
                                    c6 = "CM";
                                    break;

                                case "CHIAPAS":
                                    c6 = "CS";
                                    break;

                                case "CHIHUAHUA":
                                    c6 = "CH";
                                    break;

                                case "DISTRITO FEDERAL":
                                    c6 = "DF";
                                    break;

                                case "DURANGO":
                                    c6 = "DG";
                                    break;

                                case "GUANAJUATO":
                                    c6 = "GT";
                                    break;

                                case "GUERRERO":
                                    c6 = "GR";
                                    break;

                                case "HIDALGO":
                                    c6 = "HG";
                                    break;

                                case "JALISCO":
                                    c6 = "JC";
                                    break;

                                case "ESTADO DE MÉXICO":
                                    c6 = "MC";
                                    break;

                                case "ESTADO DE MEXICO":
                                    c6 = "MC";
                                    break;

                                case "MICHOACAN":
                                    c6 = "MN";
                                    break;

                                case "MORELOS":
                                    c6 = "MS";
                                    break;

                                case "NAYARIT":
                                    c6 = "NT";
                                    break;

                                case "NUEVO LEÓN":
                                    c6 = "NL";
                                    break;

                                case "NUEVO LEON":
                                    c6 = "NL";
                                    break;

                                case "OAXACA":
                                    c6 = "OC";
                                    break;

                                case "PUEBLA":
                                    c6 = "PL";
                                    break;

                                case "QUERÉTARO":
                                    c6 = "QT";
                                    break;

                                case "QUERETARO":
                                    c6 = "QT";
                                    break;
                                case "QUINTANA ROO":
                                    c6 = "QR";
                                    break;

                                case "SAN LUIS POTOSI":
                                    c6 = "SP";
                                    break;

                                case "SINALOA":
                                    c6 = "SL";
                                    break;

                                case "SONORA":
                                    c6 = "SR";
                                    break;

                                case "TABASCO":
                                    c6 = "TC";
                                    break;

                                case "TAMAULIPAS":
                                    c6 = "TS";
                                    break;

                                case "TLAXCALA":
                                    c6 = "TL";
                                    break;

                                case "VERACRUZ":
                                    c6 = "VZ";
                                    break;

                                case "YUCATAN":
                                    c6 = "YN";
                                    break;

                                case "ZACATECAS":
                                    c6 = "ZS";
                                    break;

                            }
                            //string c6 = entidad.Substring(0, 2);

                            //Las consonantes del Apellido Paterno
                            string c7 = null;
                            for (int x = 1; x < ApellidoPaterno.Length; x++)
                            {
                                string ap1 = ApellidoPaterno.Substring(x, 1);
                                if (ap1 != "A" && ap1 != "E" && ap1 != "I" && ap1 != "O" && ap1 != "U")
                                {
                                    c7 = ap1;
                                    break;
                                }
                            }

                            //Las consonantes del Apellido Materno
                            string c8 = null;
                            for (int x = 1; x < ApellidoMaterno.Length; x++)
                            {
                                string ap2 = ApellidoMaterno.Substring(x, 1);
                                if (ap2 != "A" && ap2 != "E" && ap2 != "I" && ap2 != "O" && ap2 != "U")
                                {
                                    c8 = ap2;
                                    break;
                                }
                            }

                            //Las consonantes del nombre
                            string c9 = null;
                            for (int x = 1; x < nombre.Length; x++)
                            {
                                string ap3 = nombre.Substring(x, 1);
                                if (ap3 != "A" && ap3 != "E" && ap3 != "I" && ap3 != "O" && ap3 != "U")
                                {
                                    c9 = ap3;
                                    break;
                                }
                            }


                            //Mostar CURP
                            //escritura.WriteLine(temporal);
                            escritura.WriteLine(c1 + c2 + c3 + tres + dos + uno + c5 + c6 + c7 + c8 + c9);
                            escritura.Close();


                            //Fin de la construcción
                            StreamReader lectura = File.OpenText(ruta + "curps.txt");
                            string contenido = lectura.ReadToEnd();
                            lectura.Close();

                            Console.WriteLine("Las Curps almacenadas son: ");
                            Console.WriteLine(contenido);
                            break;
                        }
                }
                Console.WriteLine("Desea repetir el programa\nSi\nNo");
                respuesta = Console.ReadLine().ToUpper();
            } while (respuesta == "SI");

        }
    }
}
//Curp --> VADA860721HQTRZL08
//VARGAS --> (VARGAS).SubString(0,2);
//DIAZ   --> (DIAZ).SubString(0,1);
//JOSE ALEJANDRO --> if(que no sea jose o maria el primer nombre)
//(primerNombre).SubString(0,1)
//else (valor sea X)

//86/07/21 ---> (86/07/21).SubString(0,2);(86/07/21).SubString(3,2);(86/07/21).SubString(5,2);
//(86/07/21).Split('/')--> [86,07,21] Console.Write(860721)
//fecha[0]+fecha[1]+fecha[3]...
//HOMBRE -->(HOMBRE).SubString(0,1)
//Queretaro --> (QUERETARO).SubString(0,2);
//VARGAS --> A partir de la segunda posición 
//DIAZ   --> A partir de la primera posición
//JOSE ALEJANDRO --> a patir de la primera posición

