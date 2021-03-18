using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Image colorImage;

    int randomizer;

    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            randomizer = Random.Range(0, 4);

            if(randomizer == 0)
            {   
                colorImage.color = new Color32(255,205,25,100);
            }
            
            if(randomizer == 1)
            {
                colorImage.color = new Color32(95,34,0,100);
            }

            if(randomizer == 2)
            {
                colorImage.color = new Color32(207,63,21,100);
            }
            
            if(randomizer == 3)
            {
                colorImage.color = new Color32(102, 47, 84, 100);
            }
        }
    }
}
  