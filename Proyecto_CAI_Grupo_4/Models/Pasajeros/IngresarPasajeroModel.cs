using Proyecto_CAI_Grupo_4.Entities;
using Proyecto_CAI_Grupo_4.Modules;
using Proyecto_CAI_Grupo_4.Utils;
using System.Reflection;

namespace Proyecto_CAI_Grupo_4.Models
{
    public class IngresarPasajeroModel
    {
        private PasajerosEnt Pasajero;

        public PresupuestoEnt GetPresupuestoById(int id)
        {
            return PresupuestosModule.GetPresupuestoById(id);
        }

        public static AgregarPasajerosParams GetAgregarPasajerosParamsStatic()
        {
            return PasajerosModule.GetAgregarPasajerosParams();
        }

        public AgregarPasajerosParams GetAgregarPasajerosParams()
        {
            return PasajerosModule.GetAgregarPasajerosParams();
        }

        public void ConfigurarParametros()
        {
            SetAgregarPasajerosParams(new AgregarPasajerosParams
            {
                PresupuestoId = GetAgregarPasajerosParams().PresupuestoId,
                InitBuscarPasajeros = true
            });
        }

        public void SetAgregarPasajerosParams(AgregarPasajerosParams agregarPasajerosParams)
        {
            PasajerosModule.SetAgregarPasajerosParams(agregarPasajerosParams);
        }

        private void AgregarPasajero(PasajerosEnt pasajero)
        {
            PasajerosModule.AgregarPasajero(pasajero);
        }

        public string? ValidarDatos(string nombre, string apellido, string dni, string fchNacimiento, int cantidadProductosSeleccionados)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                return "Debe ingresar un nombre";
            }

            if (string.IsNullOrWhiteSpace(apellido))
            {
                return "Debe ingresar un apellido";
            }

            if (string.IsNullOrWhiteSpace(dni))
            {
                return "Debes ingresar un número de DNI.";
            }

            if (!dni.EsDNI())
            {
                return "Debes ingresar un DNI correcto. El mismo debe ser numérico y tener entre 7 y 8 cifras.";
            }

            if (DateTime.Parse(fchNacimiento) > DateTime.Now)
            {
                return "La fecha de nacimiento no puede ser mayor a la fecha actual";
            }

            if (cantidadProductosSeleccionados < 1)
            {
                return "Debe seleccionar al menos un producto para asignar al pasajero";
            }

            return null;
        }

        public void CrearPasajero(string nombre, string apellido, string dni, string fchNacimiento)
        {
            Pasajero = new PasajerosEnt(GetAgregarPasajerosParams().PresupuestoId, nombre, apellido, int.Parse(dni), DateTime.Parse(fchNacimiento));
        }

        public void AsignarAereoSeleccionadoAPasajero(string id, int idProducto)
        {
            Pasajero.AsignarAereo(new AereoSeleccionado(id, idProducto));
        }

        public void AsignarHotelSeleccionadoAPasajero(string id, int idProducto)
        {
            Pasajero.AsignarHotel(new HotelSeleccionado(id, idProducto));
        }

        public void GuardarPasajero()
        {
            AgregarPasajero(Pasajero);
        }

        public IEnumerable<ItemAsignableAPasajero> TraerAereosAsignables()
        {
            var presupuestoId = GetAgregarPasajerosParams().PresupuestoId;

            var itinerario = GetPresupuestoById(presupuestoId);

            var aereosAsignables = AereosModule
                .GetAereosByIds(itinerario.IdAereosSeleccionados
                    .Select(x => x.IdAereo))
                .ToList();

            return itinerario.IdAereosSeleccionados
                .Join(
                    aereosAsignables,
                    aereoSeleccionadoEnItinerario => aereoSeleccionadoEnItinerario.IdAereo,
                    aereo => aereo.Id,
                    (aereoSeleccionadoEnItinerario, aereo) => new ItemAsignableAPasajero()
                    {
                        TextoMostrado = $"{aereo.Nombre} - {aereo.Tarifa.TipoDePasajero.ToUpper()}",
                        Id = aereoSeleccionadoEnItinerario.Id,
                        IdProducto = aereo.Id,
                        TipoDeServicio = "Aereo"
                    });
        }

        public IEnumerable<ItemAsignableAPasajero> TraerHotelesAsignables()
        {
            var presupuestoId = GetAgregarPasajerosParams().PresupuestoId;

            var itinerario = GetPresupuestoById(presupuestoId);

            var hotelesAsignables = HotelesModule
                .GetHotelesByIds(itinerario.IdHotelesSeleccionados
                    .Select(x => x.IdHotel))
                .ToList();

            return itinerario.IdHotelesSeleccionados
                .Join(
                    hotelesAsignables,
                    hotelSeleccionadoEnItinerario => hotelSeleccionadoEnItinerario.IdHotel,
                    hotel => hotel.Id,
                    (hotelSeleccionadoEnItinerario, hotel) => new ItemAsignableAPasajero()
                    {
                        TextoMostrado = $"{hotel.Nombre} - {GetTextoPermitidosHoteles(hotel.Disponibilidad.CantidadMaximaMenores, hotel.Disponibilidad.CantidadMaximaInfantes)}",
                        Id = hotelSeleccionadoEnItinerario.Id,
                        IdProducto = hotel.Id,
                        TipoDeServicio = "Hotel"
                    });
        }

        private string GetTextoPermitidosHoteles(int cantidadMaximaMenores, int cantidadMaximaInfantes)
        {
            var str = "";

            if (cantidadMaximaInfantes > 0 && cantidadMaximaMenores > 0)
            {
                str += "Permite Infantes y Menores";
            }
            else if (cantidadMaximaInfantes > 0)
            {
                str += "Permite Infantes";
            }
            else if (cantidadMaximaMenores > 0)
            {
                str += "Permite Menores";
            }
            else
            {
                str += "Permite solo adultos";
            }
            return str;
        }
    }
}
