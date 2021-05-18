using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDrop : MonoBehaviour
{
    private void Awake()
    {
        Destroy(gameObject);
    }
}