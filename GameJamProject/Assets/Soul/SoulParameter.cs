﻿using UnityEngine;
using System.Collections;

public class SoulParameter : MonoBehaviour {

    /// <summary>
    /// 魂の数
    /// </summary>
    public long num { get; private set; }

    [SerializeField]
    SoulTextChanger soulTextChanger = null;

    void Start()
    {
        soulTextChanger.Change(0);
    }

    void Update()
    {
        AddNum(1000);
    }

    /// <summary>
    /// 数を加算していく
    /// </summary>
    /// <param name="value"></param>
    public void AddNum(long value)
    {
        num += value;
        soulTextChanger.Change(num);
    }

}
