using GC.Entites;
using GC.ConsoleUI;
using Microsoft.Extensions.Configuration;
using Unity;
using GC.DAL.JSON;
using GC.DAL.XML;

namespace Module09_ApplicationGraphique2
{
    internal static class Program
    {
        private static string _fichierDepotClientsJSON = "clients.json";
        private static string _fichierDepotClientsXML = "clients.xml";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            GenererFichiersDepotSiNonExistant(true);
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
            .AddJsonFile("appsettings.json", false)
            .Build();

            string repertoireDepotClient = configuration["RepertoireDepotsClients"];
            string nomFichierDepotClient = configuration["NomFichierDepotClients"];
            string cheminComplet = Path.Combine(repertoireDepotClient, nomFichierDepotClient);

            string typeDepot = configuration["TypeDepot"];

            //if (!File.Exists(cheminComplet))
            //{
            //    throw new InvalidOperationException($"Le fichier {cheminComplet} n'existe pas ou est inaccessible");
            //}


            IUnityContainer conteneur = new UnityContainer();
            conteneur.RegisterInstance(configuration, InstanceLifetime.Singleton);
            switch (typeDepot.ToLower())
            {
                case "json":
                    conteneur.RegisterType<IDepotClients, DepotClientsJSON>(TypeLifetime.Singleton, new Unity.Injection.InjectionConstructor(new object[] { cheminComplet }));
                    break;
                case "xml":
                    conteneur.RegisterType<IDepotClients, DepotClientsXML>(TypeLifetime.Singleton, new Unity.Injection.InjectionConstructor(new object[] { cheminComplet }));
                    break;
                default:
                    throw new InvalidOperationException("le type de dépot n'est pas valide, mettre json ou xml");
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new fPrincipale(conteneur.Resolve<IDepotClients>()));          
        }
        private static void GenererFichiersDepotSiNonExistant(bool p_forceCreation)
        {
            bool fichierDepotClientJSONExiste = File.Exists(_fichierDepotClientsJSON);
            bool fichierDepotClientXMLExiste = File.Exists(_fichierDepotClientsXML);

            if (fichierDepotClientJSONExiste && p_forceCreation)
            {
                File.Delete(_fichierDepotClientsJSON);
            }

            if (fichierDepotClientXMLExiste && p_forceCreation)
            {
                File.Delete(_fichierDepotClientsXML);
            }

            if (!fichierDepotClientJSONExiste || p_forceCreation)
            {
                GenerateurDonnees.GenererDepotJsonClients(_fichierDepotClientsJSON);
            }
            if (!fichierDepotClientJSONExiste || p_forceCreation)
            {
                GenerateurDonnees.GenererDepotXMLClients(_fichierDepotClientsXML);
            }
        }

    }
}