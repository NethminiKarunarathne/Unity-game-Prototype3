using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    private Vector3 spawnPos = new Vector3(25,0,0);
    public GameObject obstaclePrefab;
    private float startDelay =2;
    private float Interval = 2;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("spawnObstacle", startDelay, Interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
       
    }
}
