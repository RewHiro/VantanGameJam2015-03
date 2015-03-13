using UnityEngine;
using System.Collections;

public class EnemySpawnBoss : MonoBehaviour {

  [SerializeField]
  private GameObject prefab = null;

  private StageInformation stageInfo = null;
  
  void Start()
  {
    stageInfo = FindObjectOfType(typeof(StageInformation)) as StageInformation;
  }

  void Update()
  {
  }

  public void SetBossData()
  {
    var boss = FindObjectOfType(typeof(EnemyLifeBoss)) as EnemyLifeBoss;
    if (boss == null) return;

    var clone = (GameObject)Instantiate(prefab, transform.position, transform.rotation);
    clone.name = prefab.name;
    clone.transform.SetParent(transform);

    var cloneHealth = clone.GetComponent<EnemyLifeBoss>();
    cloneHealth.SetHealth(stageInfo.BossHealthCalculate());
  }
}
