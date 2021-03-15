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

    void Update()
    {
        ersteNummer = int.Parse(Input1.text);
        zweiteNummer = int.Parse(Input2.text);
    }

    public void AddNumbers()
    {
        //-------------------------
        int value = 0;

        if (int.TryParse(Input1.text, out value)) // or float.TryParse, or double.TryParse etc
        {
            Input1.image.color = Color.white;
        }
        else
        {
            Input1.text = "Geben Sie eine gültige Zahl ein";
            Input1.image.color = Color.red;
        }

        if (int.TryParse(Input2.text, out value))
        {
            Input1.image.color = Color.white;
        }
        else
        {
            Input2.text = "Geben Sie eine gültige Zahl ein";
            Input2.image.color = Color.red;
        }
        //--------------------------------

        Ergebnis = ersteNummer + zweiteNummer;

        ErgebnisTxt.text = Ergebnis.ToString();
    }
}
