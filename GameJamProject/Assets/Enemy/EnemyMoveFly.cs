using UnityEngine;
using System.Collections;

public class EnemyMoveFly : MonoBehaviour {
  
  [SerializeField]
  private float moveSpeedMin = 0.0f;
  
  [SerializeField]
  private float moveSpeedMax = 0.0f;

  private const float X_RANGE = 3.0f;
  private const float POS_Y = 3.5f;
  
  void Start()
  {
    Vector3 goalPos = new Vector3(Random.Range(-X_RANGE, X_RANGE), POS_Y, 0);
    float moveTime = Random.Range(moveSpeedMin, moveSpeedMax);
    
    iTween.MoveTo(gameObject, iTween.Hash("x", goalPos.x,
                                          "y", goalPos.y,
                                          "z", goalPos.z,
                                          "time", moveTime,
                                          "easetype", iTween.EaseType.easeOutExpo));
  }
}
