using System;
using UnityEngine;
using UnityEngine.UI;

public class PlayControl : MonoBehaviour
{
    public Image Con1;
    public Image Con2;
    public Image Con3;
    public static bool diceonoff;
    private int dicemun3;
    public GameObject count01;


    private void Awake()
    {
        diceonoff = true;

    }
    public void Dice()
    {
        if (diceonoff)
        {
            Con1.color = new Color(0, 1, 0, 0.5f);
            Con2.color = new Color(0, 1, 0, 0.5f);
            Con3.color = new Color(0, 1, 0, 0.5f);
            dicemun3 = 3;
            Invoke("createcount01", 1.1f);
        }
    }
    public void createcount01()
    {
        Vector3 pos01 = new Vector3(-0.6f, 4.3f, 0);
        Vector3 pos02 = new Vector3(0.3f, 4.3f, 0);
        Vector3 pos03 = new Vector3(1.2f, 4.3f, 0);
        Instantiate(count01, pos01, Quaternion.identity);
        Instantiate(count01, pos02, Quaternion.identity);
        Instantiate(count01, pos03, Quaternion.identity);
    }


    public void Dice1234()
    {
        Vector3 pos021 = new Vector3(-8.15f, -3, 0);
        Vector3 pos031 = new Vector3(-6.4f, -3, 0);
        Vector3 pos041 = new Vector3(-4.8f, -3, 0);
        Vector3 pos051 = new Vector3(-3.25f, -3, 0);
        Vector3 pos061 = new Vector3(-1.55f, -3, 0);
        Vector3 pos071 = new Vector3(0, -3, 0);
        Vector3 pos081 = new Vector3(1.7f, -3, 0);
        Vector3 pos091 = new Vector3(3.35f, -3, 0);
        Vector3 pos101 = new Vector3(4.95f, -3, 0);
        Vector3 pos111 = new Vector3(6.6f, -3, 0);
        Vector3 pos121 = new Vector3(8.25f, -3, 0);

        if (dicemun3 == 3)
        {
            print(dice.Dic12);
            print(dice.Dic34);
            if (dice.Dic12 == 2) Instantiate(count01, pos021, Quaternion.identity);
            if (dice.Dic34 == 2) Instantiate(count01, pos021, Quaternion.identity);
            if (dice.Dic12 == 3) Instantiate(count01, pos031, Quaternion.identity);
            if (dice.Dic34 == 3) Instantiate(count01, pos031, Quaternion.identity);
            if (dice.Dic12 == 4) Instantiate(count01, pos041, Quaternion.identity);
            if (dice.Dic34 == 4) Instantiate(count01, pos041, Quaternion.identity);
            if (dice.Dic12 == 5) Instantiate(count01, pos051, Quaternion.identity);
            if (dice.Dic34 == 5) Instantiate(count01, pos051, Quaternion.identity);
            if (dice.Dic12 == 6) Instantiate(count01, pos061, Quaternion.identity);
            if (dice.Dic34 == 6) Instantiate(count01, pos061, Quaternion.identity);
            if (dice.Dic12 == 7) Instantiate(count01, pos071, Quaternion.identity);
            if (dice.Dic34 == 7) Instantiate(count01, pos071, Quaternion.identity);
            if (dice.Dic12 == 8) Instantiate(count01, pos081, Quaternion.identity);
            if (dice.Dic34 == 8) Instantiate(count01, pos081, Quaternion.identity);
            if (dice.Dic12 == 9) Instantiate(count01, pos091, Quaternion.identity);
            if (dice.Dic34 == 9) Instantiate(count01, pos091, Quaternion.identity);
            if (dice.Dic12 == 10) Instantiate(count01, pos101, Quaternion.identity);
            if (dice.Dic34 == 10) Instantiate(count01, pos101, Quaternion.identity);
            if (dice.Dic12 == 11) Instantiate(count01, pos111, Quaternion.identity);
            if (dice.Dic34 == 11) Instantiate(count01, pos111, Quaternion.identity);
            if (dice.Dic12 == 12) Instantiate(count01, pos121, Quaternion.identity);
            if (dice.Dic34 == 12) Instantiate(count01, pos121, Quaternion.identity);
        }


    }
    public void Dice1324()
    {

    }
    public void Dice1423()
    {

    }

    void Update()
    {

    }
}
