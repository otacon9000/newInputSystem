using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : MonoBehaviour
{
    public Text scoreText;

    private void OnEnable()
    {
        MainLambda.OnHello = () => Debug.Log("Hello");
    }

    private void Start()
    {
        MainEvent.onClick += TurnRed;
        MainEvent.onTeleport += Teleport;
        MainAction.OnScoreChange += UpdateScoreText;

        
    }

    public void TurnRed()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    public void Teleport(Vector3 pos)
    {
        Debug.Log("teleport...");
        transform.position = pos;
    }

    public void UpdateScoreText(int scoreUpdated)
    {
        scoreText.text = "Score: " + scoreUpdated.ToString();
    }
}
