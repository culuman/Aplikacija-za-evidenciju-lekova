using Apoteka.Repozitorijumi.Interfejsi;
using Apoteka.Repozitorijumi.Kontekst;
using Apoteka.Repozitorijumi.Repozitorijumi;
using Apoteka.Servisi.Interfejs;
using Apoteka.Servisi.Servisi;
using Autofac;


namespace Apoteka
{
    internal static class Program
    {
        private static IContainer _container;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Build the dependency injection container
            var builder = new ContainerBuilder();
            builder.RegisterType<ApotekaBPKontekst>().InstancePerLifetimeScope();
            builder.RegisterType<LekRepozitorijum>().As<ILekRepozitorijum>();
            builder.RegisterType<LekServis>().As<ILekServis>();
            builder.RegisterType<Form1>().As<Form>();
            // Register other dependencies here
            _container = builder.Build();

            // Resolve the main form from the container
            using var form = _container.Resolve<Form>();
            Application.Run(form);

        }
    }
}