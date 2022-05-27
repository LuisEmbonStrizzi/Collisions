using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionsPlayer : MonoBehaviour
{
    Vector3 StartPos;
    // Start is called before the first frame update
    void Start()
    {
        StartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.collider.name == "DeathWall")
        {
            transform.position = StartPos;
        }
        
    }
}
