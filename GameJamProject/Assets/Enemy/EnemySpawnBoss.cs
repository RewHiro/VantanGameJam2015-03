using UnityEngine;
using System.Collections;

public class EnemySpawnBoss : MonoBehaviour {

  [SerializeField]
  private EnemyManager manager = null;

  [SerializeField]
  private GameObject prefab = null;

  private bool isSpawn = false;
  private StageInformation stageInfo = null;
  
  void Start()
  {
    stageInfo = FindObjectOfType(typeof(StageInformation)) as StageInformation;
  }

  void Update()
  {
    if (!manager.BossStage() || !manager.IsMobExtinction()) return;

    SetBossData();
  }

  public void SetBossData()
  {
    if (isSpawn) return;
    isSpawn = true;

    var clone = (GameObject)Instantiate(prefab, transform.position, transform.rotation);
    clone.name = prefab.name;
    clone.transform.SetParent(transform);

    var cloneHealth = clone.GetComponent<EnemyLifeBoss>();
    cloneHealth.SetHealth(stageInfo.BossHealthCalculate());
  }
}
