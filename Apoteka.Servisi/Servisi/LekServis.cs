using Apoteka.Servisi.Interfejs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apoteka.Modeli;
using Apoteka.Repozitorijumi.Interfejsi;

namespace Apoteka.Servisi.Servisi
{
    public class LekServis : ILekServis
    {

        private readonly ILekRepozitorijum _lekRepozitorijum;

        public LekServis(ILekRepozitorijum lekRepozitorijum)
        {
            _lekRepozitorijum = lekRepozitorijum;
        }

        public Task IzmeniLek(Lek obj, object ID)
        {

            var podaci = _lekRepozitorijum.PrikaziPoIDAsync(ID);
            if (podaci == null) throw new ArgumentNullException();

            Lek LekZaIzmenu = new()
            {
                Id = podaci.Id,
                Naziv = obj.Naziv,
                Vrsta = obj.Vrsta,
                Proizvodjac = obj.Proizvodjac,
                Bolest = obj.Bolest,
                Kolicina = obj.Kolicina
            };

            _lekRepozitorijum.Izmeni(LekZaIzmenu);
            _lekRepozitorijum.Sacuvaj();
            return Task.CompletedTask;
        }

        public Task KreirajNovLek(Lek obj)
        {
            Lek novLek = new()
            {
                Naziv = obj.Naziv,
                Vrsta = obj.Vrsta,
                Proizvodjac = obj.Proizvodjac,
                Bolest = obj.Bolest,
                Kolicina = obj.Kolicina
            };

            _lekRepozitorijum.Dodaj(novLek);
            _lekRepozitorijum.Sacuvaj();
            return Task.CompletedTask;
        }

        public void ObrisiLek(object ID)
        {
            _lekRepozitorijum.Obrisi(ID);
            _lekRepozitorijum.Sacuvaj();
        }


        public async Task<IEnumerable<Lek>> UcitajPodatkeAsync()
        {
            var podaci = await _lekRepozitorijum.UcitajPodatke();

            List<Lek> lek = new();
            Lek lekovi;

            foreach (var obj in podaci)
            {
                lekovi = new Lek
                {
                    Id = obj.Id,
                    Naziv = obj.Naziv,
                    Vrsta = obj.Vrsta,
                    Proizvodjac = obj.Proizvodjac,
                    Bolest = obj.Bolest,
                    Kolicina = obj.Kolicina
                };
                lek.Add(lekovi);
            }
            return lek.ToList();
        }


        public async Task<IEnumerable<Lek>> prikazLekovaPoBolesti(object bolest)
        {
            var podaci = await _lekRepozitorijum.prikazLekovaPoBolesti(bolest);
            if (podaci is null) throw new ArgumentNullException();

            List<Lek> lek = new();
            Lek lekovi;

            foreach (var obj in podaci)
            {
                lekovi = new Lek
                {
                    Id = obj.Id,
                    Naziv = obj.Naziv,
                    Vrsta = obj.Vrsta,
                    Proizvodjac = obj.Proizvodjac,
                    Bolest = obj.Bolest,
                    Kolicina = obj.Kolicina
                };
                lek.Add(lekovi);
            }
            return lek.ToList();
        }


        public async Task<IEnumerable<Lek>> prikazLekovaPoProizvodjacu(object proizvodjac)
        {
            var podaci = await _lekRepozitorijum.prikazLekovaPoProizvodjacu(proizvodjac);
            if (podaci is null) throw new ArgumentNullException();

            List<Lek> lek = new();
            Lek lekovi;

            foreach (var obj in podaci)
            {
                lekovi = new Lek
                {
                    Id = obj.Id,
                    Naziv = obj.Naziv,
                    Vrsta = obj.Vrsta,
                    Proizvodjac = obj.Proizvodjac,
                    Bolest = obj.Bolest,
                    Kolicina = obj.Kolicina
                };
                lek.Add(lekovi);
            }
            return lek.ToList();
        }

    }
}
