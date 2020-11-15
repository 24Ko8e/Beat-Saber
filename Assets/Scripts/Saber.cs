using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saber : MonoBehaviour
{
    public LayerMask layer;
    Vector3 previousPos;
    public GameManager gameManager;

    void Start()
    {
        
    }

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 1.0f, layer))
        {
            if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > 130)
            {
                Destroy(hit.transform.gameObject);
                gameManager.updateScore();
            }
        }
        previousPos = transform.position;
    }
}
