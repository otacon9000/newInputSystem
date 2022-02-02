using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public delegate void ChangeColor(Color newColor);
    public ChangeColor onColorChange;

    public delegate void OnComplete();
    public OnComplete onComplete;


    private void OnEnable()
    {
        onColorChange = UpdateColor;
        onComplete += Task1;
        onComplete += Task2;
        onComplete += Task3;
    }

    private void OnDisable()
    {
        onColorChange -= UpdateColor;
        onComplete -= Task1;
        onComplete -= Task2;
        onComplete -= Task3;
    }

    private void Start()
    {
        //onColorChange = UpdateColor;
        //onComplete += Task1;
        //onComplete += Task2;
        //onComplete += Task3;

        onComplete();
        onColorChange(Color.red);
    }


    public void UpdateColor(Color color)
    {
        Debug.Log("new color updated is: " + color.ToString());
    }

    public void Task1()
    {
        Debug.Log("Task1 Finished");
    } 

    public void Task2()
    {
        Debug.Log("Task2 Finished");
    }

    public void Task3()
    {
        Debug.Log("Task3 Finished");
    }
}
 