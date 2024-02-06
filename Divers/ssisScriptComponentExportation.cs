using System;
using System.IO;
using Microsoft.SqlServer.Dts.Pipeline.Wrapper;
using Microsoft.SqlServer.Dts.Runtime.Wrapper;

[Microsoft.SqlServer.Dts.Pipeline.SSISScriptComponentEntryPointAttribute]
public class ScriptMain : UserComponent
{
    private StreamWriter writer; // Déclarer le StreamWriter pour écrire dans un fichier ou une autre destination

    public override void PreExecute()
    {
        // Initialiser le StreamWriter avec le chemin de fichier ou d'autres paramètres nécessaires
        string cheminFichier = @"C:\Chemin\Vers\Votre\Fichier.txt";
        writer = new StreamWriter(cheminFichier, false);

        // Écrire l'en-tête du fichier si nécessaire
        writer.WriteLine("Produit,QuantitéVendue");
    }

    public override void Input0_ProcessInputRow(Input0Buffer Row)
    {
        // Accéder aux colonnes d'entrée
        string produit = Row.Produit;
        int quantiteVendue = Row.QuantiteVendue;

        // Exporter les données vers la destination (fichier, base de données, etc.)
        writer.WriteLine($"{produit},{quantiteVendue}");
    }

    public override void PostExecute()
    {
        // Fermer le StreamWriter après l'exportation de toutes les lignes
        writer.Close();
    }
}
