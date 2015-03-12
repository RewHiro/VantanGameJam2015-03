<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;

public class Aspecter : MonoBehaviour {

    float width = 640.0f;
    float height = 960.0f;
    Rect camRect = new Rect();

	// Use this for initialization
	void Start () {
        var targetAspect = width / height;
        var curAspect = Screen.width  *1.0f / Screen.height;
        var ratio = curAspect / targetAspect;

        if (1.0f > ratio)
        {
            camRect.x = 0.0f;
            camRect.width = 1.0f;
            camRect.y = (1.0f - ratio) / 2.0f;
            camRect.height = ratio;
            Camera.main.orthographicSize = Screen.width / 2.0f;
        }
        else
        {
            ratio = 1.0f / ratio;
            camRect.x = (1.0f - ratio) / 2.0f;
            camRect.width = ratio;
            camRect.y = 0.0f;
            camRect.height = 1.0f;
            Camera.main.orthographicSize = Screen.height / 2.0f;
        }
        Camera.main.rect = camRect;
	}
	
	// Update is called once per frame
	void Update () {
        var targetAspect = width / height;
        var curAspect = Screen.width * 1.0f / Screen.height;
        var ratio = curAspect / targetAspect;

        if (1.0f > ratio)
        {
            camRect.x = 0.0f;
            camRect.width = 1.0f;
            camRect.y = (1.0f - ratio) / 2.0f;
            camRect.height = ratio;
            Camera.main.orthographicSize = Screen.width / 2.0f;
        }
        else
        {
            ratio = 1.0f / ratio;
            camRect.x = (1.0f - ratio) / 2.0f;
            camRect.width = ratio;
            camRect.y = 0.0f;
            camRect.height = 1.0f;
            Camera.main.orthographicSize = Screen.height / 2.0f;
        }
        Camera.main.rect = camRect;
	}
}
=======
﻿using UnityEngine;
using System.Collections;

public class Aspecter : MonoBehaviour {

    float width = 640.0f;
    float height = 960.0f;
    Rect camRect = new Rect();

	// Use this for initialization
	void Start () {
        var targetAspect = width / height;
        var curAspect = Screen.width  *1.0f / Screen.height;
        var ratio = curAspect / targetAspect;

        if (1.0f > ratio)
        {
            camRect.x = 0.0f;
            camRect.width = 1.0f;
            camRect.y = (1.0f - ratio) / 2.0f;
            camRect.height = ratio;
            Camera.main.orthographicSize = Screen.width / 2.0f;
        }
        else
        {
            ratio = 1.0f / ratio;
            camRect.x = (1.0f - ratio) / 2.0f;
            camRect.width = ratio;
            camRect.y = 0.0f;
            camRect.height = 1.0f;
            Camera.main.orthographicSize = Screen.height / 2.0f;
        }
        Camera.main.rect = camRect;
	}
	
	// Update is called once per frame
	void Update () {
        var targetAspect = width / height;
        var curAspect = Screen.width * 1.0f / Screen.height;
        var ratio = curAspect / targetAspect;

        if (1.0f > ratio)
        {
            camRect.x = 0.0f;
            camRect.width = 1.0f;
            camRect.y = (1.0f - ratio) / 2.0f;
            camRect.height = ratio;
            Camera.main.orthographicSize = Screen.width / 2.0f;
        }
        else
        {
            ratio = 1.0f / ratio;
            camRect.x = (1.0f - ratio) / 2.0f;
            camRect.width = ratio;
            camRect.y = 0.0f;
            camRect.height = 1.0f;
            Camera.main.orthographicSize = Screen.height / 2.0f;
        }
        Camera.main.rect = camRect;
	}
}
>>>>>>> 46c16a0561a83314d4af8df6b6d4351dcce8dc7a
