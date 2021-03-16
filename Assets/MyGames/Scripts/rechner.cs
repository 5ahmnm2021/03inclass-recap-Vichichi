using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rechner : MonoBehaviour
{
    public InputField Input1;
    public InputField Input2;

    int ersteNummer;
    int zweiteNummer; 

    int Ergebnis;

    public Text ErgebnisTxt;

    public void AddNumbers()
    {
        try
        {
            ersteNummer = int.Parse(Input1.text);
            Input1.image.color = Color.white;
        }

        catch (System.Exception)
        {
            Input1.image.color = Color.red;
            Input1.text = "Geben Sie eine gültige Zahl ein";
        }

        try
        {
            zweiteNummer = int.Parse(Input2.text);
            Input2.image.color = Color.white;
        }

        catch (System.Exception)
        {
            Input2.image.color = Color.white;
            Input2.text = "Geben Sie eine gültige Zahl ein";
        }
        Ergebnis = ersteNummer + zweiteNummer;

        ErgebnisTxt.text = Ergebnis.ToString();
    }
}
