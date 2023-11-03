using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoReservas.Data.Models;

public class Usuario
{
    [BsonId]
    public ObjectId Id { get; set; }
    public string Nombre { get; set; }

    public string apellido { get; set; }

    public string CorreoElectronico {  get; set; }

    public string Direccion { get; set; }

    public string Contrasenia {  get; set; }


}
