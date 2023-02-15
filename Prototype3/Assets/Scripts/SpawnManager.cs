using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeaRate = 2;
    private PlayeController playeControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playeControllerScript = GameObject.Find("Player").GetComponent<PlayeController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeaRate);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle ()
    {
        if(playeControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
