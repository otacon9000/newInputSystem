using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MainLambda : MonoBehaviour
{
    public Action<int, int> Sum;

    private void Start()
    {
        Sum = (a, b) => Debug.Log(a + b);

        Sum(5, 12);
    }

    void CalculateSum(int a, int b) 
    {
        var total = a + b;
        Debug.Log("Total: " + total);
    }
}
