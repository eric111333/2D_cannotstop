using UnityEngine;
using UnityEngine.UI;

public class dice : MonoBehaviour
{
    public Image diceimage;
    public Image diceimage2;
    public Image diceimage3;
    public Image diceimage4;
    public Image dice1;
    public Image dice11;
    public Image dice12;
    public Image dice2;
    public Image dice21;
    public Image dice22;
    public Image dice3;
    public Image dice31;
    public Image dice32;
    public Image dice4;
    public Image dice41;
    public Image dice42;
    public Text D14;
    public Text D12;
    public Text D13;
    public Text D23;
    public Text D24;
    public Text D34;



    public Sprite[] dicepoint;

    public void DiceRoll()
    {

        int mun = Random.Range(0, dicepoint.Length);
        int mun2 = Random.Range(0, dicepoint.Length);
        int mun3 = Random.Range(0, dicepoint.Length);
        int mun4 = Random.Range(0, dicepoint.Length);
        diceimage.sprite = dicepoint[mun];
        diceimage2.sprite = dicepoint[mun2];
        diceimage3.sprite = dicepoint[mun3];
        diceimage4.sprite = dicepoint[mun4];
        dice1.sprite= dicepoint[mun];
        dice11.sprite= dicepoint[mun];
        dice12.sprite= dicepoint[mun];
        dice2.sprite= dicepoint[mun2];
        dice21.sprite= dicepoint[mun2];
        dice22.sprite= dicepoint[mun2];
        dice3.sprite= dicepoint[mun3];
        dice31.sprite= dicepoint[mun3];
        dice32.sprite= dicepoint[mun3];
        dice4.sprite= dicepoint[mun4];
        dice41.sprite= dicepoint[mun4];
        dice42.sprite= dicepoint[mun4];
        D14.text = ""+((mun+1)+(mun4+1));
        D23.text = ""+((mun2+1)+(mun3+1));
        D12.text = ""+((mun2+1)+(mun+1));
        D13.text = ""+((mun+1)+(mun3+1));
        D24.text = ""+((mun2+1)+(mun4+1));
        D34.text = ""+((mun4+1)+(mun3+1));

    }

}
