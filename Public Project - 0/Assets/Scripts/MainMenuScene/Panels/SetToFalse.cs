using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetToFalse: MonoBehaviour
{
    void Start()
    {
        GameObject[] gameObjects;
        gameObjects = Resources.FindObjectsOfTypeAll<GameObject>();
        gameObject.SetActive(false);

    }
}
