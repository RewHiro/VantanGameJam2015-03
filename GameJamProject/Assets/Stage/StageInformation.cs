using UnityEngine;
using System.Collections;

public class StageInformation : MonoBehaviour {

    /// <summary>
    /// 現在のステージ数
    /// </summary>
    [SerializeField]
    private int nowStageNumber = 0;

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

    /// <summary>
    /// プレステージ数
    /// </summary>
    private int PrestigeCount = 0;

    [SerializeField]
    private int StageMax = 100;




	// Use this for initialization
	void Start () {
        ChangeState = StageChangeState.Changed;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
    
    /// <summary>
    /// ステージを変えます！！！
    /// </summary>
    /// <param name="nextStage">次のステージ数</param>
    public void GoNextStage()
    {
        nowStageNumber++;
    }


    /// <summary>
    /// 現在のステージの敵の最大数を得る
    /// </summary>
    /// <returns>敵の最大数</returns>
    public float StageMobNumber()
    {
        
        return MobNumberFact(nowStageNumber);
    }

    public int MobHealthCalculate()
    {
        if (nowStageNumber <= 1) return FirstStageMobHealth;

        return (int)(FirstStageMobHealth * Mathf.Pow(IncreaseMobHealthPowered,nowStageNumber-1));

    }

    private float MobNumberFact(int stage)
    {
        float MobNumber = FirstStageEnemyNumber;
        if (nowStageNumber <= 1) return MobNumber;

        MobNumber = ((MobNumberFact(stage - 1) + 1) * 1.05f);

        return MobNumber;
    }

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


}
