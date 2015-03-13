using UnityEngine;
using System.Collections;

public class StageInformation : MonoBehaviour {

    /// <summary>
    /// 現在のステージ数
    /// </summary>
    [SerializeField]
    private int nowStageNumber = 1;

    public int nowStage { get { return nowStageNumber; } }

    public enum StageChangeState {
        BeChange,
        Changing,
        Changed
    }

    public StageChangeState ChangeState { get; private set; }

    /// <summary>
    /// 第一ステージの敵の最大数
    /// </summary>
    [SerializeField]
    private int FirstStageEnemyNumber = 30;

    /// <summary>
    /// 1ステージごとに増える敵の量
    /// </summary>
    [SerializeField]
    private float IncreaseEnemyPowered = 1.2f;

    /// <summary>
    /// 第一ステージの敵のHP
    /// </summary>
    [SerializeField]
    private int FirstStageMobHealth = 150;

    [SerializeField]
    private float IncreaseMobHealthPowered = 1.08f;

    [SerializeField]
    private int IncreaseBossHealthValue = 75;

    [SerializeField]
    private float FirstStagePlayerAttack = 5.0f;

    [SerializeField]
    private float IncreasePlayerAttackPowered = 1.05f;

    [SerializeField]
    private float nowChangingTime = 0.0f;

    [SerializeField]
    private float needChangingTime = 0.0f;

    private EnemyManager enemyMngr = null;


    /// <summary>
    /// 地獄の門の参照
    /// </summary>
    private LeftDoorOpener leftGate = null;
    private RightDoorOpener rightGate = null;

    /// <summary>
    /// プレステージ数
    /// </summary>
    private int PrestigeCount = 0;

    [SerializeField]
    private int StageMax = 100;

    private StageBackGroundParameter backGround = null;

    	// Use this for initialization
	void Start () {
        ChangeState = StageChangeState.Changing;

        enemyMngr = GameObject.FindObjectOfType(typeof(EnemyManager)) as EnemyManager;
        leftGate = GameObject.FindObjectOfType(typeof(LeftDoorOpener)) as LeftDoorOpener;
        rightGate = GameObject.FindObjectOfType(typeof(RightDoorOpener)) as RightDoorOpener;
        backGround = GetComponent<StageBackGroundParameter>();
        backGround.ChangeData();
	}
	
	// Update is called once per frame
	void Update () {
	    if(nowChangingTime > needChangingTime)
        {
            leftGate.DoorOpen();
            rightGate.DoorOpen();

            ChangeState = StageChangeState.Changed;
            nowChangingTime = 0.0f;
        }

        if(ChangeState == StageChangeState.BeChange)
        {
            leftGate.DoorClose();
            rightGate.DoorClose();

            ChangeState = StageChangeState.Changing;
        }

	    if(ChangeState == StageChangeState.Changing)
        {
            nowChangingTime += Time.deltaTime;
        }
        if(JudgeGoNext())
        {
            GoNextStage();
        }

	}
    
    /// <summary>
    /// ステージを変えます！！！
    /// </summary>
    /// <param name="nextStage">次のステージ数</param>
    public void GoNextStage()
    {
        nowStageNumber++;
        backGround.ChangeData();

        ChangeState = StageChangeState.BeChange;
    }

    /// <summary>
    /// 次ステージに行くかどうかをチェックする
    /// </summary>
    public bool JudgeGoNext()
    {
        if(enemyMngr.IsEnemyExtinction())
        {
            return true;
        }

        return false;
    }


    /// <summary>
    /// 現在のステージの敵の最大数を得る
    /// </summary>
    /// <returns>mobの最大数</returns>
    public float StageMobNumber()
    {        
        return MobNumberFact(nowStageNumber);
    }


    /// <summary>
    /// MobのHPを計算して返します
    /// </summary>
    /// <returns>mobのHP</returns>
    public int MobHealthCalculate()
    {
        if (nowStageNumber <= 1) return FirstStageMobHealth;

        return (int)(FirstStageMobHealth * Mathf.Pow(IncreaseMobHealthPowered,nowStageNumber-1));

    }

    /// <summary>
    /// Mobの最大数を求める再帰関数
    /// </summary>
    /// <param name="stage">現在のステージ数</param>
    /// <returns>敵の数</returns>
    private float MobNumberFact(int stage)
    {
        float MobNumber = FirstStageEnemyNumber;
        if (stage <= 1) return MobNumber;

        MobNumber = ((MobNumberFact(stage - 1) + 1) * 1.05f);

        return MobNumber;
    }

    /// <summary>
    /// プレイヤーの攻撃力を計算する関数です
    /// </summary>
    /// <returns>プレイヤーの攻撃力</returns>
    public float PlayerAttackPower()
    {
        if(nowStageNumber <= 1) return FirstStagePlayerAttack;

        return FirstStagePlayerAttack * Mathf.Pow(IncreasePlayerAttackPowered,nowStageNumber - 1);
    }

    /// <summary>
    /// 現在ステージでのボスのHPを得る
    /// </summary>
    /// <returns>ボスのHP</returns>
    public int BossHealthCalculate()
    {
        return MobHealthCalculate() * IncreaseBossHealthValue;
    }

    /// <summary>
    /// 現在ステージでの敵1人が落とすソウル量を決める
    /// </summary>
    /// <returns>ソウル量</returns>
    public long MobSoulCalculate()
    {
        var Base = 5;
        return (long)(Base * Mathf.Pow(1.02f, nowStageNumber));
    }

    /// <summary>
    /// エクストリーム（必殺技）の総攻撃力を得る
    /// </summary>
    /// <returns>必殺技の攻撃力</returns>
    public int ExtremeDamageCalculate()
    {
        var IncreaseValue = 2;
        return BossHealthCalculate() * IncreaseValue;
    }




}
