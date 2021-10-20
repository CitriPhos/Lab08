using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float minY, maxY;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 pos = transform.position;

        if (pos.y < minY)
        {
            pos.y = minY;
        }

        if (pos.y > maxY)
        {
            pos.y = maxY;
        }

        transform.position = pos + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);
    }
}
