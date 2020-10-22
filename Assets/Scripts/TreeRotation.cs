using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeRotation : MonoBehaviour
{
    void Start()
    {
        gameObject.transform.Rotate(0f, Random.Range(0, 360), 0f);
    }
}
