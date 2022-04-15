using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YuHun : MonoBehaviour
{
    public Dictionary<int, YuhunInfo> singleYuhun;

    /// <summary>
    /// 生成主属性
    /// </summary>
    public YuhunInfo GenMainProperty(int type)
    {
        YuhunInfo kvp = new YuhunInfo("主属性1", 2);


        return kvp;
    }
    /// <summary>
    /// 生成fu属性
    /// </summary>
    public YuhunInfo GenSubProperty(int type)
    {
        YuhunInfo kvp = new YuhunInfo("附属性1", 2);


        return kvp;
    }


    public void GenNewYuhun(int type)
    {
        //主属性
        YuhunInfo main = GenMainProperty(type);
        singleYuhun.Add(0,main);
        int subNum = Random.Range(2, 5);
        //副属性
        for (int i = 0; i < subNum; i++)
        {
            YuhunInfo sub = GenSubProperty(type);
            singleYuhun.Add(i+1, sub);
        }
        //生成完了

    }

    public YuhunInfo GetYuhun(int pos)
    {
        YuhunInfo yuhunInfo;
        yuhunInfo = singleYuhun;
        return yuhunInfo;
    }

    public struct YuhunInfo
    {
        public string name;
        public float value;

        public YuhunInfo(string name, float value)
        {
            this.name = name;
            this.value = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
