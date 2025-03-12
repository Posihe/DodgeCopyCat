using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Potal : MonoBehaviour
{
  

    public GameObject black;
    public Transform player;
    public Transform[] potal;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    IEnumerator teleport1()
    {
        black.SetActive(true);
        player.position = potal[1].position+new Vector3(0,0,10);

        yield return new WaitForSeconds(5f);

        black.SetActive(false);
    }


}
