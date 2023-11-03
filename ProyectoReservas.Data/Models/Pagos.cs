using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoReservas.Data.Models;

public enum MetodoPago
{
    TarjetaDeCredito,
    TarjetaDeDebito,
    PayPal,
    TransferenciaBancaria,
    PagoEnEfectivo
}

public class Pagos
{
    [BsonId]
    public ObjectId Id { get; set; }

    public MetodoPago MetodoDePago {  get; set; }

    public double Importe { get; set; }



}
