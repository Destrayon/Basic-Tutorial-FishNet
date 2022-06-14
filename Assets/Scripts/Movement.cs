using FishNet.Object;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : NetworkBehaviour
{
    [SerializeField] private float speed;
    private void Update()
    {
        if (!IsOwner) return;

        Vector3 movementInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        transform.position += speed * movementInput * Time.deltaTime;
    }
}
