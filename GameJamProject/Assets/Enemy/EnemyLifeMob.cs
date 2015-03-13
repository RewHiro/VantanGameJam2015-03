using UnityEngine;
using System.Collections;

public class EnemyLifeMob : MonoBehaviour {

  [SerializeField]
  private int health = 1;

  [SerializeField]
  private float alphaTime = 1.0f;

  StageInformation stageInfo = null;
  SoulCreator soulCreator = null;

  private bool isDead = false;
  private EnemyManager manager = null;

  void Start()
  {
    manager = FindObjectOfType(typeof(EnemyManager)) as EnemyManager;
    stageInfo = FindObjectOfType(typeof(StageInformation)) as StageInformation;
    soulCreator = FindObjectOfType(typeof(SoulCreator)) as SoulCreator;
  }

  void Update()
  {
    if (!isDead && IsDead()) DeadTask();
  }

  private void DeadTask()
  {
    isDead = true;

    soulCreator.Create(new SoulCreator.CreateData(5, stageInfo.MobSoulCalculate(), transform.position));
    
    manager.EnemyDead();
    GameObject.Destroy(gameObject, alphaTime);

    iTween.FadeTo(gameObject, iTween.Hash("alpha", 0,
                                          "time", alphaTime-0.02,
                                          "easetype", iTween.EaseType.easeInCubic));
  }

  public bool IsDead()
  {
    return health <= 0;
  }

  public void Damage(int attackPower)
  {
    health -= attackPower;
  }

  public void SetHealth(int healthPower)
  {
    health = healthPower;
  }
}
