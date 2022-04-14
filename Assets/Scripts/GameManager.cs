using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public YuHun yuhun;

    public TMP_Text[] names;
    public TMP_Text[] values;

    public Button buyButton;
    public Button addThreeButton;
    public Button maxButton;
    public Button restartButton;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyOne()
    {
        names[0].SetText("�ٶ�");
        names[1].SetText("�ٶ�");
        names[2].SetText("�����ӳ�");
        names[3].SetText("����");
        names[4].SetText("�����˺�");

        values[0].SetText("57");
        values[1].SetText(Random.Range(2.0f, 3.0f).ToString("0.00"));
        values[2].SetText(Random.Range(3.0f, 4.0f).ToString("0.00"));
        values[3].SetText(Random.Range(2.0f, 3.0f).ToString("0.00"));
        values[4].SetText(Random.Range(3.0f, 4.0f).ToString("0.00"));

    }





    public void Reset()
    {
        names[0].SetText("����������");
        names[1].SetText("����������");
        names[2].SetText("����������");
        names[3].SetText("����������");
        names[4].SetText("����������");

        values[0].SetText("��ֵ");
        values[1].SetText("��ֵ");
        values[2].SetText("��ֵ");
        values[3].SetText("��ֵ");
        values[4].SetText("��ֵ");

    }


}
