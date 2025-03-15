using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte2_TallerMecanico
{
    internal class Parte2_TallerMecanico
    {
        static void Main(string[] args)
        {
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

            public Taller(string nombre, string ubicacion, string telefono, string email)
            {
                Nombre = nombre;
                Ubicacion = ubicacion;
                Telefono = telefono;
                Email = email;

            }
        }
    }
}
