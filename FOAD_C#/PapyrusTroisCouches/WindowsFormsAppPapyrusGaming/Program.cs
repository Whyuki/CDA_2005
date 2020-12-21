using ClassLibraryMetierFournisseur;
using ClassLibraryPersistanceSQLServer;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppPapyrusGaming
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connectionString = ConfigurationManager.ConnectionStrings["papyrusConnectionString"].ConnectionString;
            Fournisseur.MaPersistanceFournisseur = new PersistanceFournisseur(connectionString);
            Application.Run(new FormFournisseur());
        }
    }
}
