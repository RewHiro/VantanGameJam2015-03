using UnityEngine;
using System.Collections;

public class StageInformation : MonoBehaviour {

    /// <summary>
    /// 現在のステージ数
    /// </summary>
    [SerializeField]
    private int nowStageNumber = 0;

    public int nowStage { get { return nowStageNumber; } }

    /// <summary>
    /// 第一ステージの敵の最大数
    /// </summary>
    [SerializeField]
    private int FirstStageEnemyNumber = 30;

    /// <summary>
    /// 1ステージごとに増える敵の量
    /// </summary>
    [SerializeField]
    private float IncreaceEnemyPowered = 1.2f;

    [SerializeField]
    private int FirstStageBossHealth = 150;

    [SerializeField]
    private int AddBossHealthValue = 100;

    [SerializeField]
    private int IncreaceBossHealthPowerd = 2;
    


	// Use this for initialization
	void Start () {
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
    public int StageEnemyNumber()
    {
        return (int)(FirstStageEnemyNumber * Mathf.Pow(IncreaceEnemyPowered, nowStageNumber));
    }

    int fact(int enemyNumber,int factCount)
    {
        return (int)(30 * Mathf.Pow(1.05f, nowStageNumber));
    }


    /// <summary>
    /// 現在ステージでのボスのHPを得る
    /// </summary>
    /// <returns>ボスのHP</returns>
    public int BossHealthCalculate()
    {
        return FirstStageBossHealth + AddBossHealthValue * (IncreaceBossHealthPowerd * (nowStageNumber / 5 - 1));
    }


}
