using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class StageBackGroundParameter : MonoBehaviour {

    [System.Serializable]
    struct BackGroundData
    {
        public BackGroundData(Sprite sprite, string bgmResName):this()
        {
            this.sprite = sprite;
            this.bgmResName = bgmResName;
        }

        public Sprite sprite;
        public string bgmResName;

    };

    [SerializeField]
    List<BackGroundData> backGround = new List<BackGroundData>();

    [SerializeField]
    GameObject uiBackGround = null;

    [SerializeField]
    BGMPlayer bgmPlayer = null;

    Image backGroundImage = null;
    int nextIndex = 0;

    void Start()
    {
        backGroundImage = uiBackGround.GetComponent<Image>();
    }

    /// <summary>
    /// 次のステージに行くときに使用
    /// </summary>
    public void ChangeData()
    {
        var sprite = backGround[nextIndex].sprite;
        backGroundImage.sprite = sprite;

        if(bgmPlayer.IsPlaying)
        {
            bgmPlayer.Stop();
        }

    }

    void Update()
    {
        if (!bgmPlayer.IsPlaying)
        {
            bgmPlayer.Play(backGround[nextIndex].bgmResName, new FadeTimeData(2, 2));
            Limit();
        }
    }

    void Limit()
    {
        nextIndex++;
        if (nextIndex >= backGround.Count)
        {
            nextIndex = 0;
        }
    }
}
