using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apoteka.Repozitorijumi.Interfejsi
{
    public interface IRepozitorijum<T> where T : class
    {
        void Obrisi(object PK);
        Task<IEnumerable<T>> UcitajPodatke();
        Task<IEnumerable<T>> prikazLekovaPoBolesti(object bolest);
        Task<IEnumerable<T>> prikazLekovaPoProizvodjacu(object proizvodjac);
        T PrikaziPoIDAsync(object ID);
        T Dodaj(T obj);
        T Izmeni(T obj);
        void Sacuvaj();
    }
}