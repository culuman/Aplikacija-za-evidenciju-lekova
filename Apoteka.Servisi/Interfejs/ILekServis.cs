using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apoteka.Modeli;

namespace Apoteka.Servisi.Interfejs
{
    public interface ILekServis
    {
        Task<IEnumerable<Lek>> UcitajPodatkeAsync();
        Task<IEnumerable<Lek>> prikazLekovaPoBolesti(object bolest);
        Task<IEnumerable<Lek>> prikazLekovaPoProizvodjacu(object proizvodjac);
        Task IzmeniLek(Lek obj, object ID);
        Task KreirajNovLek(Lek novLek);
        void ObrisiLek(object ID);
    }
}