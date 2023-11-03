using MongoDB.Driver;
using ProyectoReservas.Data.Models;
using ProyectoReservas.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoReservas.Data.Repositories;

public interface IUsuariosCollection
{
    void Crear (Usuario usuario);

    List<Usuario> Listar();

    Usuario ObtenerUsuarioPorId(string id);
}


public class UsuariosCollection : IUsuariosCollection
{
    internal MongoDBRepository _repository = new MongoDBRepository();
    private IMongoCollection<Usuario> Collection;

    public UsuariosCollection()
    {
        Collection = _repository.db.GetCollection<Usuario>("Usuarios");
    }

    public void Crear(Usuario usuario)
    {
        Collection.InsertOneAsync(usuario);
    }

    public List<Usuario> Listar()
    {
        throw new NotImplementedException();
    }

    public Usuario ObtenerUsuarioPorId(string id)
    {
        throw new NotImplementedException();
    }
}





