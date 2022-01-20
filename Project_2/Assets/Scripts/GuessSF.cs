using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuessSF : MonoBehaviour
{
    private float destroyTime = 1.0f;


    void Start()
    {
        Destroy(gameObject, destroyTime);
    }
}
