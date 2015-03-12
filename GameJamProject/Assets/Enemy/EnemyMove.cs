using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

  [SerializeField]
  float moveSpeedMin = 0.0f;

  [SerializeField]
  float moveSpeedMax = 0.0f;

  const float X_RANGE = 3.0f;

  void Start() {
    Vector3 pos = new Vector3(Random.Range(-X_RANGE, X_RANGE), GetPosY(), 0);
    float moveTime = Random.Range(moveSpeedMin, moveSpeedMax);

    iTween.MoveTo(gameObject, iTween.Hash("x", pos.x,
                                          "y", pos.y,
                                          "z", pos.z,
                                          "time", moveTime,
                                          "easeType", iTween.EaseType.easeOutExpo));
  }

  float GetPosY() {
    float posY = 0.0f;
    if (gameObject.tag == "Fly") posY = 3.0f;

    return posY;
  }
}
