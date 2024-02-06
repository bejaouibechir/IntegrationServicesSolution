using System;
using Microsoft.SqlServer.Dts.Pipeline.Wrapper;
using Microsoft.SqlServer.Dts.Runtime.Wrapper;

[Microsoft.SqlServer.Dts.Pipeline.SSISScriptComponentEntryPointAttribute]
public class ScriptMain : UserComponent
{
    public override void Input0_ProcessInputRow(Input0Buffer Row)
    {
        // Accéder aux colonnes d'entrée
        string nom = Row.Nom;
        int age = Row.Age;

        // Calculer le statut en fonction de l'âge
        string statut = CalculerStatut(age);

        // Ajouter la nouvelle colonne à la sortie
        Row.Statut = statut;
    }

    private string CalculerStatut(int age)
    {
        // Exemple simple : Si l'âge est supérieur à 25, le statut est "Adulte", sinon "Jeune"
        return (age > 25) ? "Adulte" : "Jeune";
    }
}
