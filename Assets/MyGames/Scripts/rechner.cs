using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rechner : MonoBehaviour
{
    public InputField input1;
    public InputField input2;

    int ersteNummer;
    int zweiteNummer; 

    int ergebnis;

    public Text ergebnisTxt;

    bool num1 = true;
    bool num2 = true;

    public void AddNumbers()
    {
        try
        {
            ersteNummer = int.Parse(input1.text);
            input1.image.color = Color.white;
            num1 = true;
        }

        catch (System.Exception)
        {
            input1.image.color = Color.red;
            input1.text = "Geben Sie eine gültige Zahl ein";
            num1 = false;
        }

        try
        {
            zweiteNummer = int.Parse(input2.text);
            input2.image.color = Color.white;
            num2 = true;
        }

        catch (System.Exception)
        {
            input2.image.color = Color.red;
            input2.text = "Geben Sie eine gültige Zahl ein";
            num2 = false;
        }

        if(num1 && num2)
        {
            ergebnis = ersteNummer + zweiteNummer;

            ergebnisTxt.text = ergebnis.ToString();
        }
    }
}
