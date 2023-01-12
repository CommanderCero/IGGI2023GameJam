using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeesawController : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;

    [SerializeField] private PlayerButtons button;
    [SerializeField] private float force;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(InputManager.GetKey(button)))
        {
            rigidbody2d.AddTorque(force);
        }
    }
}
