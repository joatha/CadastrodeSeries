using System;
using System.Collections.Generic;
using Series.Interfaces;

namespace Series
{
    public class SerieRepositorio : IRepositorio<Series>
    {
        private List<Series> listaserie = new List<Series>();
        public void Atualizar(int id, Series entidade)
        {
            listaserie[id] = objeto;
        }

        public void Excluir(int id)
        {
            listaserie[id].Excluir();
        }

        public void Insere(Series entidade)
        {
            listaserie.Add(objeto);
        }

        public List<Series> Lista()
        {
            return listaserie;
        }

        public int ProximoId()
        {
            return listaserie.Count;
        }

        public Series RetornaPorId(int id)
        {
            return listaserie[id];
        }
    }
}