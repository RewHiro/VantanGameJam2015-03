using UnityEngine;
using System.Collections;

public class SoulAbsorptionAnimator : MonoBehaviour {

    [SerializeField]
    float animationTime = 2.0f;

    [SerializeField]
    float scale = 1.5f;

    [SerializeField]
    float latencyScale = 5;

    Vector3 originScale = Vector3.zero;
    float count = 0;
    bool canAnimation = false;

    // Use this for initialization
    void Start()
    {
        originScale = transform.localScale;
        StartAbsorptionAnimation();
    }

    // Update is called once per frame
    void Update()
    {
        OriginReturn();
    }

    /// <summary>
    /// 元に戻す
    /// </summary>
    void OriginReturn()
    {
        if (!canAnimation) return;

        count += Time.deltaTime;
        if (count >= latencyScale)
        {
            count = 0;
            iTween.ScaleTo(gameObject, iTween.Hash("scale", originScale,
                "time", animationTime, "easetype", iTween.EaseType.easeInOutQuad));
            canAnimation = false;
        }
    }

    /// <summary>
    /// 吸収した時のアニメーションを始める
    /// </summary>
    public void StartAbsorptionAnimation()
    {
        if (canAnimation) return;

        count = 0;
        canAnimation = true;
        iTween.ScaleTo(gameObject, iTween.Hash("scale", originScale * scale,
            "time", animationTime, "easetype", iTween.EaseType.easeOutExpo));
    }

}
