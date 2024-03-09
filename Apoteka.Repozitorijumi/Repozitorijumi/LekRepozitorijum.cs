using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apoteka.Modeli;
using Apoteka.Repozitorijumi.Kontekst;
using Apoteka.Repozitorijumi.Interfejsi;
using Microsoft.EntityFrameworkCore;

namespace Apoteka.Repozitorijumi.Repozitorijumi
{
    public class LekRepozitorijum : ILekRepozitorijum
    {
        private readonly ApotekaBPKontekst _ctx;

        public LekRepozitorijum(ApotekaBPKontekst ctx)
        {
            _ctx = ctx;
        }

        public Lek Izmeni(Lek obj)
        {
            try
            {
                _ctx.Entry(obj).State = EntityState.Modified;

                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Lek Dodaj(Lek obj)
        {
            return _ctx.Lek.Add(obj).Entity;
        }

        public void Obrisi(object PK)
        {
            var postoji = _ctx.Lek.Find(PK);
            if (postoji is null)
                throw new ArgumentNullException();

            _ctx.Lek.Remove(postoji);
        }

        public Lek PrikaziPoIDAsync(object ID)
        {
            var postoji = _ctx.Lek.Find(ID);
            if (postoji is not null)
            {
                _ctx.Entry(postoji).State = EntityState.Detached;
                return postoji;
            }
            else throw new ArgumentNullException();
        }

        public async Task<IEnumerable<Lek>> UcitajPodatke()
        {
            var podaci = await _ctx.Lek
                            .ToListAsync();

            return podaci;
        }

        public async Task<IEnumerable<Lek>> prikazLekovaPoBolesti(object bolest)
        {
            var podaci = await _ctx.Lek
                    .Where(x => x.Bolest == bolest).ToListAsync();

            return podaci;
        }

        public async Task<IEnumerable<Lek>> prikazLekovaPoProizvodjacu(object proizvodjac)
        {
            var podaci = await _ctx.Lek
                    .Where(x => x.Proizvodjac == proizvodjac).ToListAsync();

            return podaci;
        }

        public void Sacuvaj()
        {
            _ctx.SaveChanges();
        }
    }
}