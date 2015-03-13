using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoulMover : MonoBehaviour {

    [SerializeField]
    float minSpeedX = -5.0f;

    [SerializeField]
    float maxSpeedX = 5.0f;

    [SerializeField]
    float maxSpeedY = 5.0f;

    [SerializeField]
    float mass = 1.0f;

    [SerializeField]
    float AbsorptionTime = 5.0f;

    [SerializeField]
    float AbsorptionArrivalTime = 4.0f;

    GameObject stopTrigger = null;
    GameObject goldParent = null;
    Vector3 velocity = Vector3.zero;
    float force = 0;
    long soulValue = 0;
    RectTransform rectTrans = null;

    enum State
    {
        Create,
        Stop,
        Absorption,
    }

    State state = State.Create;

    // Use this for initialization
    void Start()
    {
        stopTrigger = GameObject.Find("SoulStopTrigger");
        goldParent = GameObject.Find("SoulMoney");
        var xSpeed = Random.Range(minSpeedX, maxSpeedX);
        var ySpeed = Random.Range(1, maxSpeedY);
        velocity = new Vector3(xSpeed, ySpeed, 0);
        rectTrans = transform as RectTransform;
    }

    // Update is called once per frame
    void Update()
    {
        Create();
    }

    /// <summary>
    /// 生成時の移動
    /// </summary>
    void Create()
    {
        if (state != State.Create) return;

        transform.Translate(velocity * Time.deltaTime);
        velocity.Set(velocity.x, velocity.y - force, 0);

        StopTrigger();

        if (force >= 1) return;
        force += mass * Time.deltaTime;
    }

    /// <summary>
    /// 停止トリガー
    /// </summary>
    void StopTrigger()
    {
        var stopTriggerPosY = stopTrigger.transform.position.y;
        if (stopTriggerPosY >= transform.position.y)
        {
            var triggerRectTrans = stopTrigger.transform as RectTransform;
            rectTrans.anchoredPosition3D = new Vector3(rectTrans.anchoredPosition3D.x, triggerRectTrans.anchoredPosition3D.y, 0);
            state = State.Stop;
            StartCoroutine("StartAbsorption");
        }
    }

    /// <summary>
    /// 吸収し始める
    /// </summary>
    /// <returns></returns>
    IEnumerator StartAbsorption()
    {
        yield return new WaitForSeconds(AbsorptionTime);

        iTween.MoveTo(gameObject, iTween.Hash("position", goldParent.transform.position,
            "time", AbsorptionArrivalTime, "easetype", iTween.EaseType.easeInOutQuad));

    }

    /// <summary>
    /// ソウルの値を設定する
    /// </summary>
    /// <param name="value"></param>
    public void SetSoulValue(long value)
    {
        soulValue = value;
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == goldParent.name)
        {
            goldParent.GetComponent<SoulAbsorptionAnimator>().StartAbsorptionAnimation();
            var soul = FindObjectOfType(typeof(SoulParameter)) as SoulParameter;
            soul.AddNum(soulValue);
            Destroy(gameObject);
        }
    }

}
