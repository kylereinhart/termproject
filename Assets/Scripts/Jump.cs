using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private Vector3 mjumpForce;
    private Rigidbody _rigidbody;

    // Update is called once per frame
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1"))
        {
            _rigidbody.AddForce(mjumpForce);
        }
    }
}
