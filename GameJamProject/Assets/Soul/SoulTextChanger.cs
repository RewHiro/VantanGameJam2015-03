using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class SoulTextChanger : MonoBehaviour {

    /// <summary>
    /// 桁を切り替えるための構造体
    /// </summary>
    [System.Serializable]
    struct ChangeDigitData
    {
        public ChangeDigitData(long digit, string digitText):this()
        {
            this.digit = digit;
            this.digitText = digitText;
        }

        public long digit;
        public string digitText;
    };

    [SerializeField]
    List<ChangeDigitData> changeDigitData = new List<ChangeDigitData>();

    Text soulText = null;
    long digitNum = 1;
    string digitText = string.Empty;

	// Use this for initialization
	void Awake () {
        soulText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    /// <summary>
    /// 魂の数の文字を変化させる
    /// </summary>
    /// <param name="num"></param>
    public void Change(float num)
    {
        foreach (var data in changeDigitData)
        {
            if (num >= data.digit)
            {
                digitNum = data.digit;
                digitText = data.digitText;
            }
        }

        double numString = (num / digitNum);
        soulText.text = numString.ToString("0.00") + digitText;
    }
}
