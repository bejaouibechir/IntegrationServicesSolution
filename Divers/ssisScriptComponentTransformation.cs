using System;
using Microsoft.SqlServer.Dts.Pipeline.Wrapper;
using Microsoft.SqlServer.Dts.Runtime.Wrapper;

[Microsoft.SqlServer.Dts.Pipeline.SSISScriptComponentEntryPointAttribute]
public class ScriptMain : UserComponent
{
    public override void Input0_ProcessInputRow(Input0Buffer Row)
    {
        // Accéder à la colonne d'entrée
        decimal prixEnDollars = Row.Prix;

        // Appliquer la transformation : Convertir de dollars à euros
        decimal tauxDeChange = 0.85; // Exemple, le taux de change actuel
        decimal prixEnEuros = ConvertirEnEuros(prixEnDollars, tauxDeChange);

        // Ajouter la nouvelle colonne à la sortie
        Row.PrixEnEuros = prixEnEuros;
    }

    private decimal ConvertirEnEuros(decimal prixEnDollars, decimal tauxDeChange)
    {
        return prixEnDollars * tauxDeChange;
    }
}
