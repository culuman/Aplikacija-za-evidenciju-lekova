using Apoteka.Modeli;
using Apoteka.Repozitorijumi.Interfejsi;
using Apoteka.Repozitorijumi.Repozitorijumi;
using Apoteka.Servisi.Servisi;
using Moq;
using NUnit.Framework;
using Xunit;


namespace Apoteka.Testovi
{
    public class LekTest
    {

        private readonly Mock<ILekRepozitorijum> _mockRepo;

        public LekTest()
        {
            _mockRepo = new Mock<ILekRepozitorijum>();
        }

        [Fact]
        public async Task KreirajNovLek_DodajeLekURepozitorijum()
        {
            //Arrange
            var lek = new Lek
            {
                Naziv = "Test lek",
                Vrsta = "Test vrsta",
                Proizvodjac = "Test proizvodjac",
                Bolest = "Test bolest",
                Kolicina = "Test kolicina"
            };

            var servis = new LekServis(_mockRepo.Object);

            //Act
            await servis.KreirajNovLek(lek);

            //Assert
            _mockRepo.Verify(repo => repo.Dodaj(It.IsAny<Lek>()), Times.Once);
            _mockRepo.Verify(repo => repo.Sacuvaj(), Times.Once);
        }

        [Fact]
        public async Task KreirajNovLek_UnosiPodatkeIspravno()
        {
            //Arrange
            var lek = new Lek
            {
                Naziv = "Test lek",
                Vrsta = "Test vrsta",
                Proizvodjac = "Test proizvodjac",
                Bolest = "Test bolest",
                Kolicina = "Test kolicina"
            };

            var servis = new LekServis(_mockRepo.Object);

            //Act
            await servis.KreirajNovLek(lek);

            //Asset
            _mockRepo.Verify(repo => repo.Dodaj(It.Is<Lek>(a =>
            a.Naziv == "Test lek" &&
            a.Vrsta == "Test vrsta" &&
            a.Proizvodjac == "Test proizvodjac" &&
            a.Bolest == "Test bolest" &&
            a.Kolicina == "Test kolicina")), Times.Once);
        }

        [Fact]
        public async Task IzmeniLek_PostojiIAzuriraSe()
        {
            //Arrange
            var id = 1;
            var lek = new Lek
            {
                Id = id,
                Naziv = "Novi lek",
                Vrsta = "Nova vrsta",
                Proizvodjac = "Novi proizvodjac",
                Bolest = "Nova bolest",
                Kolicina = "Nova kolicina"
            };

            var postojeciLek = new Lek
            {
                Id = id,
            };

            _mockRepo.Setup(repo => repo.PrikaziPoIDAsync(id)).Returns(postojeciLek);
            var servis = new LekServis(_mockRepo.Object);

            //Act
            await servis.IzmeniLek(lek, id);

            //Assert
            _mockRepo.Verify(repo => repo.PrikaziPoIDAsync(id), Times.Once);
            _mockRepo.Verify(repo => repo.Izmeni(It.IsAny<Lek>()), Times.Once);
            _mockRepo.Verify(repo => repo.Sacuvaj(), Times.Once);
        }

        [Fact]
        public void ObrisiLek_PozivaMetodeRepozitorijuma()
        {
            //Arrange
            var id = 1;
            var servis = new LekServis(_mockRepo.Object);

            //Act
            servis.ObrisiLek(id);

            //Assert
            _mockRepo.Verify(repo => repo.Obrisi(id), Times.Once);
            _mockRepo.Verify(repo => repo.Sacuvaj(), Times.Once);
        }

        [Fact]
        public async Task PrikazSvihLekova()
        {
            //Arrange
            var listaLekova = new List<Lek>
            {
                new Lek { Id = 1, Naziv = "Lek 1", Vrsta = "Vrsta 1", Proizvodjac = "Proizvodjac 1", Bolest = "Bolest 1", Kolicina = "Kolicina 1" },
                new Lek { Id = 2, Naziv = "Lek 2", Vrsta = "Vrsta 2", Proizvodjac = "Proizvodjac 2", Bolest = "Bolest 2", Kolicina = "Kolicina 2" }
            };

            _mockRepo.Setup(repo => repo.UcitajPodatke()).ReturnsAsync(listaLekova);
            var servis = new LekServis(_mockRepo.Object);

            //Act
            var rezultat = await servis.UcitajPodatkeAsync();

            //Assert
            _mockRepo.Verify(repo => repo.UcitajPodatke(), Times.Once);
        }

        [Fact]
        public async Task prikazLekovaPoBolesti_PrikazujeSveLekovePremaBolesti()
        {
            //Arrange
            var bolest = "Glavobolja";
            var listaLekova = new List<Lek>
            {
                new Lek { Id = 1, Naziv = "Lek 1", Vrsta = "Vrsta 1", Proizvodjac = "Proizvodjac 1", Bolest = "Bolest 1", Kolicina = "Kolicina 1" },
                new Lek { Id = 2, Naziv = "Lek 2", Vrsta = "Vrsta 2", Proizvodjac = "Proizvodjac 2", Bolest = "Glavobolja", Kolicina = "Kolicina 2" }
            };

            _mockRepo.Setup(repo => repo.prikazLekovaPoBolesti(bolest)).ReturnsAsync(listaLekova.Where(a => a.Bolest == bolest));
            var servis = new LekServis(_mockRepo.Object);

            //Act
            var rezultat = await servis.prikazLekovaPoBolesti(bolest);

            //Assert
            _mockRepo.Verify(repo => repo.prikazLekovaPoBolesti(bolest), Times.Once);
        }

        [Fact]
        public async Task prikazLekovaPoProizvodjacu_PrikazujeSveLekovePremaProizvodjacu()
        {
            //Arrange
            var proizvodjac = "AbelaPharm";
            var listaLekova = new List<Lek>
            {
                new Lek { Id = 1, Naziv = "Lek 1", Vrsta = "Vrsta 1", Proizvodjac = "AbelaPharm", Bolest = "Bolest 1", Kolicina = "Kolicina 1" },
                new Lek { Id = 2, Naziv = "Lek 2", Vrsta = "Vrsta 2", Proizvodjac = "Proizvodjac 2", Bolest = "Glavobolja", Kolicina = "Kolicina 2" }
            };

            _mockRepo.Setup(repo => repo.prikazLekovaPoProizvodjacu(proizvodjac)).ReturnsAsync(listaLekova.Where(a => a.Proizvodjac == proizvodjac));
            var servis = new LekServis(_mockRepo.Object);

            //Act
            var rezultat = await servis.prikazLekovaPoProizvodjacu(proizvodjac);

            //Assert
            _mockRepo.Verify(repo => repo.prikazLekovaPoProizvodjacu(proizvodjac), Times.Once);
        }

    }
}