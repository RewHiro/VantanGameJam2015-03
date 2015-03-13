using UnityEngine;
using System.Collections;

public class EnemySpawnMob : MonoBehaviour {

  [SerializeField]
  private EnemyManager manager = null;

  /// <summary>
  /// 敵の出現間隔の揺らぎ
  /// </summary>
  [SerializeField]
  private float spawnInterval = 0;

  /// <summary>
  /// 次の敵が出現するまでの時間
  /// </summary>
  private float currentInterval = 0;

  [SerializeField]
  private GameObject[] prefab = new GameObject[3];

  private StageInformation stageInfo = null;

  void Start()
  {
    stageInfo = FindObjectOfType(typeof(StageInformation)) as StageInformation;
    SetInterval();
  }

  void Update()
  {
    
    if (!IsAbleToSpawn() || !manager.IsAbleToSpawnMob() || stageInfo.ChangeState != StageInformation.StageChangeState.Changed) return;

    SetInterval();
    SetEnemyData();
  }
  
  private bool IsAbleToSpawn()
  {
    if (currentInterval > 0) currentInterval -= Time.deltaTime;
    return currentInterval <= 0;
  }
  
  private void SetInterval()
  {
    const float FRAME_PER_SECOND = 1.0f;
    currentInterval = FRAME_PER_SECOND + Random.Range(0.0f, spawnInterval);
  }

  private void SetEnemyData()
  {
    var index = Random.Range(0, prefab.Length);
    var clone = (GameObject)Instantiate(prefab[index], transform.position, transform.rotation);
    clone.name = prefab[index].name;
    clone.transform.SetParent(transform);

    var cloneHealth = clone.GetComponent<EnemyLifeMob>();
    cloneHealth.SetHealth(stageInfo.MobHealthCalculate());
    
    manager.MobSpawn();
  }
}
