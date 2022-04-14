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
        names[0].SetText("速度");
        names[1].SetText("速度");
        names[2].SetText("攻击加成");
        names[3].SetText("暴击");
        names[4].SetText("暴击伤害");

        values[0].SetText("57");
        values[1].SetText(Random.Range(2.0f, 3.0f).ToString("0.00"));
        values[2].SetText(Random.Range(3.0f, 4.0f).ToString("0.00"));
        values[3].SetText(Random.Range(2.0f, 3.0f).ToString("0.00"));
        values[4].SetText(Random.Range(3.0f, 4.0f).ToString("0.00"));

    }





    public void Reset()
    {
        names[0].SetText("主属性名称");
        names[1].SetText("副属性名称");
        names[2].SetText("副属性名称");
        names[3].SetText("副属性名称");
        names[4].SetText("副属性名称");

        values[0].SetText("数值");
        values[1].SetText("数值");
        values[2].SetText("数值");
        values[3].SetText("数值");
        values[4].SetText("数值");

    }


}
