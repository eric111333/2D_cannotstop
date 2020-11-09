using UnityEngine;
using UnityEngine.UI;

public class dice : MonoBehaviour
{
    public Image diceimage;
    public Sprite[] dicepoint;

    public void DiceRoll()
    {

        int mun = Random.Range(0, dicepoint.Length);
        diceimage.sprite = dicepoint[mun];

        print(dicepoint[mun]);
    }

}
