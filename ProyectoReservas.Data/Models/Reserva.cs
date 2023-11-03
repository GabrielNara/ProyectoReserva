using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoReservas.Data.Models;

public class Reserva
{
    [BsonId]
    public ObjectId Id { get; set; }

    public string Lugar { get; set; }

    public DateTime FechaYHora { get; set; }


}
