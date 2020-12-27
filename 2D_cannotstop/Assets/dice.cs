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
    public static int Dic12;
    public static int Dic13;
    public static int Dic14;
    public static int Dic23;
    public static int Dic24;
    public static int Dic34;
    public bool DiceRandom;



    public Sprite[] dicepoint;

    public void OnMouseDown()
    {
        if (PlayControl.diceonoff)
        { 
        DiceRandom = true;
        Invoke("stop", 1);
        Invoke("DiceRoll", 1.1f);
        }
    }

    public void stop()
    {
        DiceRandom = false;
    }
    public void DiceRoll()
    {
        
        if (PlayControl.diceonoff)
        {
            int mun = Random.Range(0, dicepoint.Length);
            int mun2 = Random.Range(0, dicepoint.Length);
            int mun3 = Random.Range(0, dicepoint.Length);
            int mun4 = Random.Range(0, dicepoint.Length);
            diceimage.sprite = dicepoint[mun];
            diceimage2.sprite = dicepoint[mun2];
            diceimage3.sprite = dicepoint[mun3];
            diceimage4.sprite = dicepoint[mun4];
            dice1.sprite = dicepoint[mun];
            dice11.sprite = dicepoint[mun];
            dice12.sprite = dicepoint[mun];
            dice2.sprite = dicepoint[mun2];
            dice21.sprite = dicepoint[mun2];
            dice22.sprite = dicepoint[mun2];
            dice3.sprite = dicepoint[mun3];
            dice31.sprite = dicepoint[mun3];
            dice32.sprite = dicepoint[mun3];
            dice4.sprite = dicepoint[mun4];
            dice41.sprite = dicepoint[mun4];
            dice42.sprite = dicepoint[mun4];
            D14.text = "" + ((mun + 1) + (mun4 + 1));
            D23.text = "" + ((mun2 + 1) + (mun3 + 1));
            D12.text = "" + ((mun2 + 1) + (mun + 1));
            D13.text = "" + ((mun + 1) + (mun3 + 1));
            D24.text = "" + ((mun2 + 1) + (mun4 + 1));
            D34.text = "" + ((mun4 + 1) + (mun3 + 1));
            Dic12 = (mun2 + 1) + (mun + 1);
            Dic13 = (mun3 + 1) + (mun + 1);
            Dic14 = (mun4 + 1) + (mun + 1);
            Dic23 = (mun2 + 1) + (mun3 + 1);
            Dic24 = (mun2 + 1) + (mun4 + 1);
            Dic34 = (mun3 + 1) + (mun4 + 1);
            //PlayControl.diceonoff = false;
        }

    }
    private void FixedUpdate()
    {
        if(DiceRandom)
        { 
        int mun0 = Random.Range(0, dicepoint.Length);
        int mun02 = Random.Range(0, dicepoint.Length);
        int mun03 = Random.Range(0, dicepoint.Length);
        int mun04 = Random.Range(0, dicepoint.Length);
        diceimage.sprite = dicepoint[mun0];
        diceimage2.sprite = dicepoint[mun02];
        diceimage3.sprite = dicepoint[mun03];
        diceimage4.sprite = dicepoint[mun04];
        }
    }


}
