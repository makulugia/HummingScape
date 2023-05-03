using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsMoveScript : MonoBehaviour
{
    public float moveSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x < -75)
        {
            Debug.Log("Obstacle deleted at x= " + transform.position.x);
            Destroy(gameObject);
        }
    }
}
