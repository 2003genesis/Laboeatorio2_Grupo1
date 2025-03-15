using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posible
{

namespace TallerMecanico
    {
        public class Cliente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
            public string Direccion { get; set; }
            public DateTime FechaRegistro { get; set; }
            public bool Estado { get; set; }

            public Cliente(int id, string nombre, string telefono, string email, string direccion, DateTime fechaRegistro, bool estado)
            {
                Id = id;
                Nombre = nombre;
                Telefono = telefono;
                Email = email;
                Direccion = direccion;
                FechaRegistro = fechaRegistro;
                Estado = estado;
            }
            public void MostrarInfo()
            {
                Console.WriteLine($"ID: {Id}, Nombre: {Nombre}, Teléfono: {Telefono}, Email: {Email}, Dirección: {Direccion}, Fecha: {FechaRegistro}, Activo: {Estado}");
            }

            public bool ValidarEmail()
            {
                return Email.Contains("@");
            }

            public void ActualizarDatos(string nombre, string telefono, string email, string direccion)
            {
                Nombre = nombre;
                Telefono = telefono;
                Email = email;
                Direccion = direccion;
                Console.WriteLine("Datos actualizados");
            }
        }
        public class Vehiculo
        {
            public string VIN { get; set; }
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public string Color { get; set; }
            public int Año { get; set; }
            public int ClienteId { get; set; }
            public string Estado { get; set; } // Ej: "En reparación", "Terminado"

            public Vehiculo(string vin, string marca, string modelo, string color, int año, int clienteId, string estado)
            {
                VIN = vin;
                Marca = marca;
                Modelo = modelo;
                Color = color;
                Año = año;
                ClienteId = clienteId;
                Estado = estado;
            }

            public void MostrarDetalle()
            {
                Console.WriteLine($"VIN: {VIN}, Marca: {Marca}, Modelo: {Modelo}, Color: {Color}, Año: {Año}, ClienteID: {ClienteId}, Estado: {Estado}");
            }

            public bool ValidarDatos()
            {
                return !string.IsNullOrEmpty(VIN) && Año > 1900;
            }

            public void ActualizarEstado(string nuevoEstado)
            {
                Estado = nuevoEstado;
                Console.WriteLine("Estado del vehículo actualizado.");
            }
        }
        public class Mecanico
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Especialidad { get; set; }
            public int ExperienciaAnios { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
            public bool Estado { get; set; }

            public Mecanico(int id, string nombre, string especialidad, int experienciaAnios, string telefono, string email, bool estado)
            {
                Id = id;
                Nombre = nombre;
                Especialidad = especialidad;
                ExperienciaAnios = experienciaAnios;
                Telefono = telefono;
                Email = email;
                Estado = estado;
            }

            public void MostrarInfo()
            {
                Console.WriteLine($"ID: {Id}, Nombre: {Nombre}, Especialidad: {Especialidad}, Años de Experiencia: {ExperienciaAnios}, Tel: {Telefono}, Email: {Email}, Activo: {Estado}");
            }

            public void AsignarServicio(int servicioId)
            {
                Console.WriteLine($"El servicio {servicioId} ha sido asignado al mecánico {Nombre}.");
            }

            public void ActualizarEstado(bool nuevoEstado)
            {
                Estado = nuevoEstado;
                Console.WriteLine("Estado del mecánico actualizado.");
            }
        }
        public class Servicio
        {
            public int Id { get; set; }
            public string TipoServicio { get; set; }
            public double Precio { get; set; }
            public int DuracionMinutos { get; set; }
            public string Descripcion { get; set; }
            public string VehiculoVIN { get; set; }
            public int MecanicoId { get; set; }

            public Servicio(int id, string tipoServicio, double precio, int duracionMinutos, string descripcion, string vehiculoVIN, int mecanicoId)
            {
                Id = id;
                TipoServicio = tipoServicio;
                Precio = precio;
                DuracionMinutos = duracionMinutos;
                Descripcion = descripcion;
                VehiculoVIN = vehiculoVIN;
                MecanicoId = mecanicoId;
            }

            public void RealizarServicio()
            {
                Console.WriteLine($"Realizando servicio: {TipoServicio} para el vehículo VIN: {VehiculoVIN}.");
            }

            public void MostrarDetalle()
            {
                Console.WriteLine($"ID: {Id}, Servicio: {TipoServicio}, Precio: {Precio:C}, Duración: {DuracionMinutos} min, Descripción: {Descripcion}, Vehículo VIN: {VehiculoVIN}, Mecánico ID: {MecanicoId}");
            }

            public double CalcularCosto(double impuesto)
            {
             
                return Precio + (Precio * impuesto);
            }
        }
        public class Factura
        {
            public int Id { get; set; }
            public DateTime Fecha { get; set; }
            public int ClienteId { get; set; }
            public int ServicioId { get; set; }
            public double Monto { get; set; }
            public string Detalle { get; set; }
            public bool EstadoPago { get; set; }

            public Factura(int id, DateTime fecha, int clienteId, int servicioId, double monto, string detalle, bool estadoPago)
            {
                Id = id;
                Fecha = fecha;
                ClienteId = clienteId;
                ServicioId = servicioId;
                Monto = monto;
                Detalle = detalle;
                EstadoPago = estadoPago;
            }

            public void GenerarFactura()
            {
                Console.WriteLine($"Generando factura {Id} para el cliente {ClienteId} por el servicio {ServicioId}.");
            }

            public void MostrarFactura()
            {
                Console.WriteLine($"Factura {Id}: Fecha: {Fecha}, ClienteID: {ClienteId}, ServicioID: {ServicioId}, Monto: {Monto:C}, Detalle: {Detalle}, Estado de Pago: {(EstadoPago ? "Pagado" : "Pendiente")}");
            }

            public void ActualizarPago(bool nuevoEstado)
            {
                EstadoPago = nuevoEstado;
                Console.WriteLine("Estado de pago actualizado.");
            }
        }
        public class Taller
        {
            public string Nombre { get; set; }
            public string Ubicacion { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
            public List<Cliente> ListaClientes { get; set; }
            public List<Vehiculo> ListaVehiculos { get; set; }
            public List<Mecanico> ListaMecanicos { get; set; }

            public Taller(string nombre, string ubicacion, string telefono, string email)
            {
                Nombre = nombre;
                Ubicacion = ubicacion;
                Telefono = telefono;
                Email = email;
                ListaClientes = new List<Cliente>();
                ListaVehiculos = new List<Vehiculo>();
                ListaMecanicos = new List<Mecanico>();
            }

            public void MostrarInformacion()
            {
                Console.WriteLine($"Taller: {Nombre}\nUbicación: {Ubicacion}\nTeléfono: {Telefono}\nEmail: {Email}");
                Console.WriteLine($"Clientes: {ListaClientes.Count}, Vehículos: {ListaVehiculos.Count}, Mecánicos: {ListaMecanicos.Count}");
            }

            public void AgregarCliente(Cliente cliente)
            {
                ListaClientes.Add(cliente);
                Console.WriteLine("Cliente agregado al taller.");
            }

            public void AgregarVehiculo(Vehiculo vehiculo)
            {
                ListaVehiculos.Add(vehiculo);
                Console.WriteLine("Vehículo agregado al taller.");
            }

            public void AgregarMecanico(Mecanico mecanico)
            {
                ListaMecanicos.Add(mecanico);
                Console.WriteLine("Mecánico agregado al taller.");
            }
        }

        class Program
        {
            static List<Cliente> clientes = new List<Cliente>();
            static List<Vehiculo> vehiculos = new List<Vehiculo>();
            static List<Mecanico> mecanicos = new List<Mecanico>();
            static List<Servicio> servicios = new List<Servicio>();
            static List<Factura> facturas = new List<Factura>();

            static Taller taller = new Taller("Taller Central", "Ciudad Central", "12345678", "taller@central.com");

            static void Main(string[] args)
            {
                bool exit = false;
                while (!exit)
                {
                    Console.Clear();
                    Console.WriteLine("Sistema Taller Mecánico");
                    Console.WriteLine("1. Agregar");
                    Console.WriteLine("2. Buscar");
                    Console.WriteLine("3. Listar");
                    Console.WriteLine("4. Información del Taller");
                    Console.WriteLine("5. Salir");
                    Console.Write("Elija una opción: ");
                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            AgregarMenu();
                            break;
                        case "2":
                            BuscarMenu();
                            break;
                        case "3":
                            ListarMenu();
                            break;
                        case "4":
                            taller.MostrarInformacion();
                            Console.WriteLine("\nPresione cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                        case "5":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                            break;
                    }
                }
            }

            static void AgregarMenu()
            {
                Console.Clear();
                Console.WriteLine("Menú Agregar ");
                Console.WriteLine("1. Agregar Cliente");
                Console.WriteLine("2. Agregar Vehículo");
                Console.WriteLine("3. Agregar Mecánico");
                Console.WriteLine("4. Agregar Servicio");
                Console.WriteLine("5. Agregar Factura");
                Console.WriteLine("6. Regresar");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarCliente();
                        break;
                    case "2":
                        AgregarVehiculo();
                        break;
                    case "3":
                        AgregarMecanico();
                        break;
                    case "4":
                        AgregarServicio();
                        break;
                    case "5":
                        AgregarFactura();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }

            static void AgregarCliente()
            {
                try
                {
                    Console.Write("Ingrese ID del Cliente: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese Teléfono: ");
                    string tel = Console.ReadLine();
                    Console.Write("Ingrese Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Ingrese Dirección: ");
                    string direccion = Console.ReadLine();
                    DateTime fecha = DateTime.Now;
                    bool estado = true;

                    Cliente cliente = new Cliente(id, nombre, tel, email, direccion, fecha, estado);
                    clientes.Add(cliente);
                    taller.AgregarCliente(cliente);
                    Console.WriteLine("Cliente agregado exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al agregar cliente: " + ex.Message);
                }
            }

            static void AgregarVehiculo()
            {
                try
                {
                    Console.Write("Ingrese VIN del Vehículo: ");
                    string vin = Console.ReadLine();
                    Console.Write("Ingrese Marca: ");
                    string marca = Console.ReadLine();
                    Console.Write("Ingrese Modelo: ");
                    string modelo = Console.ReadLine();
                    Console.Write("Ingrese Color: ");
                    string color = Console.ReadLine();
                    Console.Write("Ingrese Año: ");
                    int año = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el ID del Cliente propietario: ");
                    int clienteId = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese Estado (En reparación/Terminado): ");
                    string estado = Console.ReadLine();

                    Vehiculo vehiculo = new Vehiculo(vin, marca, modelo, color, año, clienteId, estado);
                    vehiculos.Add(vehiculo);
                    taller.AgregarVehiculo(vehiculo);
                    Console.WriteLine("Vehículo agregado exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al agregar vehículo: " + ex.Message);
                }
            }

            static void AgregarMecanico()
            {
                try
                {
                    Console.Write("Ingrese ID del Mecánico: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese Especialidad: ");
                    string especialidad = Console.ReadLine();
                    Console.Write("Ingrese Años de Experiencia: ");
                    int experiencia = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese Teléfono: ");
                    string tel = Console.ReadLine();
                    Console.Write("Ingrese Email: ");
                    string email = Console.ReadLine();
                    bool estado = true;

                    Mecanico mecanico = new Mecanico(id, nombre, especialidad, experiencia, tel, email, estado);
                    mecanicos.Add(mecanico);
                    taller.AgregarMecanico(mecanico);
                    Console.WriteLine("Mecánico agregado exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al agregar mecánico: " + ex.Message);
                }
            }

            static void AgregarServicio()
            {
                try
                {
                    Console.Write("Ingrese ID del Servicio: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese Tipo de Servicio: ");
                    string tipo = Console.ReadLine();
                    Console.Write("Ingrese Precio: ");
                    double precio = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese Duración en minutos: ");
                    int duracion = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese Descripción: ");
                    string descripcion = Console.ReadLine();
                    Console.Write("Ingrese VIN del Vehículo: ");
                    string vin = Console.ReadLine();
                    Console.Write("Ingrese ID del Mecánico: ");
                    int mecanicoId = int.Parse(Console.ReadLine());

                    Servicio servicio = new Servicio(id, tipo, precio, duracion, descripcion, vin, mecanicoId);
                    servicios.Add(servicio);
                    Console.WriteLine("Servicio agregado exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al agregar servicio: " + ex.Message);
                }
            }

            static void AgregarFactura()
            {
                try
                {
                    Console.Write("Ingrese ID de la Factura: ");
                    int id = int.Parse(Console.ReadLine());
                    DateTime fecha = DateTime.Now;
                    Console.Write("Ingrese ID del Cliente: ");
                    int clienteId = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese ID del Servicio: ");
                    int servicioId = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese Monto: ");
                    double monto = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese Detalle: ");
                    string detalle = Console.ReadLine();
                    bool estadoPago = false;

                    Factura factura = new Factura(id, fecha, clienteId, servicioId, monto, detalle, estadoPago);
                    facturas.Add(factura);
                    Console.WriteLine("Factura agregada exitosamente.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al agregar factura: " + ex.Message);
                }
            }

            static void BuscarMenu()
            {
                Console.Clear();
                Console.WriteLine("Menú Buscar");
                Console.WriteLine("1. Buscar Cliente");
                Console.WriteLine("2. Buscar Vehículo");
                Console.WriteLine("3. Buscar Mecánico");
                Console.WriteLine("4. Buscar Servicio");
                Console.WriteLine("5. Buscar Factura");
                Console.WriteLine("6. Regresar");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        BuscarCliente();
                        break;
                    case "2":
                        BuscarVehiculo();
                        break;
                    case "3":
                        BuscarMecanico();
                        break;
                    case "4":
                        BuscarServicio();
                        break;
                    case "5":
                        BuscarFactura();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }

            static void BuscarCliente()
            {
                try
                {
                    Console.Write("Ingrese ID del Cliente a buscar: ");
                    int id = int.Parse(Console.ReadLine());
                    Cliente cliente = clientes.Find(c => c.Id == id);
                    if (cliente != null)
                        cliente.MostrarInfo();
                    else
                        Console.WriteLine("Cliente no encontrado.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            static void BuscarVehiculo()
            {
                Console.Write("Ingrese VIN del Vehículo a buscar: ");
                string vin = Console.ReadLine();
                Vehiculo vehiculo = vehiculos.Find(v => v.VIN.Equals(vin, StringComparison.OrdinalIgnoreCase));
                if (vehiculo != null)
                    vehiculo.MostrarDetalle();
                else
                    Console.WriteLine("Vehículo no encontrado.");
            }

            static void BuscarMecanico()
            {
                try
                {
                    Console.Write("Ingrese ID del Mecánico a buscar: ");
                    int id = int.Parse(Console.ReadLine());
                    Mecanico mecanico = mecanicos.Find(m => m.Id == id);
                    if (mecanico != null)
                        mecanico.MostrarInfo();
                    else
                        Console.WriteLine("Mecánico no encontrado.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            static void BuscarServicio()
            {
                try
                {
                    Console.Write("Ingrese ID del Servicio a buscar: ");
                    int id = int.Parse(Console.ReadLine());
                    Servicio servicio = servicios.Find(s => s.Id == id);
                    if (servicio != null)
                        servicio.MostrarDetalle();
                    else
                        Console.WriteLine("Servicio no encontrado.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            static void BuscarFactura()
            {
                try
                {
                    Console.Write("Ingrese ID de la Factura a buscar: ");
                    int id = int.Parse(Console.ReadLine());
                    Factura factura = facturas.Find(f => f.Id == id);
                    if (factura != null)
                        factura.MostrarFactura();
                    else
                        Console.WriteLine("Factura no encontrada.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            static void ListarMenu()
            {
                Console.Clear();
                Console.WriteLine("Menú Listar");
                Console.WriteLine("1. Listar Clientes");
                Console.WriteLine("2. Listar Vehículos");
                Console.WriteLine("3. Listar Mecánicos");
                Console.WriteLine("4. Listar Servicios");
                Console.WriteLine("5. Listar Facturas");
                Console.WriteLine("6. Regresar");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ListarClientes();
                        break;
                    case "2":
                        ListarVehiculos();
                        break;
                    case "3":
                        ListarMecanicos();
                        break;
                    case "4":
                        ListarServicios();
                        break;
                    case "5":
                        ListarFacturas();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }

            static void ListarClientes()
            {
                Console.WriteLine("Lista de Clientes");
                foreach (var cliente in clientes)
                {
                    cliente.MostrarInfo();
                }
            }

            static void ListarVehiculos()
            {
                Console.WriteLine("Lista de Vehículos");
                foreach (var vehiculo in vehiculos)
                {
                    vehiculo.MostrarDetalle();
                }
            }

            static void ListarMecanicos()
            {
                Console.WriteLine("Lista de Mecánicos");
                foreach (var mecanico in mecanicos)
                {
                    mecanico.MostrarInfo();
                }
            }

            static void ListarServicios()
            {
                Console.WriteLine("Lista de Servicios");
                foreach (var servicio in servicios)
                {
                    servicio.MostrarDetalle();
                }
            }

            static void ListarFacturas()
            {
                Console.WriteLine("Lista de Facturas");
                foreach (var factura in facturas)
                {
                    factura.MostrarFactura();
                }
            }
        }
    }

}
    
