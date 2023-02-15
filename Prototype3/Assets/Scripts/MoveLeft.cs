using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayeController playeControllerScript;
    private float leftBound = -15;

    // Start is called before the first frame update
    void Start()
    {
        playeControllerScript = GameObject.Find("Player").GetComponent<PlayeController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playeControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }

    }
}
