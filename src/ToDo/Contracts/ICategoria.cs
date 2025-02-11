﻿using System.Runtime.Serialization;
using ToDo.Models;

namespace ToDo.Contracts
{
    public interface ICategoria
    {
        CategoriaDC? Detail(int id);
        void Delete(int[] ids);
        void DeleteCategoriaFromTarefa(int tarefaId, int idCategoria);
        CategoriaDC Create(CategoriaNovaDC categoria);
        CategoriaDC Update(CategoriaDC categoria);
        IEnumerable<CategoriaDC> Search(string? nome);
    }

    [DataContract]
    public class CategoriaDC
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nome { get; set; }
    }

    [DataContract]
    public class CategoriaNovaDC
    {
        [DataMember]
        public string Nome { get; set; }
    }
}
