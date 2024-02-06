using System;
using Microsoft.SqlServer.Dts.Runtime;

public class ScriptMain
{
    public void Main()
    {
        try
        {
            // Accéder à la variable SSIS
            string maVariable = (string)Dts.Variables["MaVariable"].Value;

            // Concaténer avec une chaîne spécifique
            string nouvelleValeur = maVariable + " ChaîneSpécifique";

            // Afficher dans le journal SSIS
            Dts.Events.FireInformation(0, "Script Task", "Nouvelle valeur : " + nouvelleValeur, "", 0, ref fireAgain);

            // Écrire la nouvelle valeur dans la variable
            Dts.Variables["MaVariable"].Value = nouvelleValeur;

            // Indiquer le résultat de la tâche
            Dts.TaskResult = (int)ScriptResults.Success;
        }
        catch (Exception ex)
        {
            // Gérer les erreurs
            Dts.Events.FireError(0, "Script Task", ex.Message, "", 0);
            Dts.TaskResult = (int)ScriptResults.Failure;
        }
    }
}
