using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text time;
    private float surviveTime;
    private bool isGameOver;
    private GameObject player;
    public GameObject endText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<Playercontroller>().gameObject;
        surviveTime = 60;
        isGameOver = false;


    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            surviveTime -= Time.deltaTime;
            surviveTime = Mathf.Max(surviveTime, 0);
            time.text = "Time:" + (int)surviveTime;

        }
    }
       
}