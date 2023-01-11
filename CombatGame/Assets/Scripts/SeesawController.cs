using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeesawController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody2d;

    [SerializeField] private PlayerButtons left;

    [SerializeField] private PlayerButtons right;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(InputManager.GetKey(left)))
        {
            rigidbody2d.AddTorque(1);
        }
        else if (Input.GetKey(InputManager.GetKey(right)))
        {
            rigidbody2d.AddTorque(-1);
        }
        
    }
}
