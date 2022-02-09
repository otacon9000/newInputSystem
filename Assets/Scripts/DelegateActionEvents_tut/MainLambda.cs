using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MainLambda : MonoBehaviour
{
    public Action<int, int> Sum;

    public static Action OnHello;

    public Func<int> onGetName;

    public Func<int, int, string> onCalculateSum;

    private void Start()
    {
        Sum = (a, b) =>
        {
            var total = a + b;

            Debug.Log("Total: " + total);
        };

        Sum(5, 12);

        if (OnHello != null)
            OnHello();

        onGetName = () => this.gameObject.name.Length;

        int nameCount = onGetName();

        onCalculateSum = (a, b) => (a + b).ToString();

        //string value = onCalculateSum(21, 1);

        Debug.Log(onCalculateSum(21, 1));
   

    }
    
}
