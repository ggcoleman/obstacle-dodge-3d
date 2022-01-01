using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    Rigidbody rigidBody;
    MeshRenderer meshRenderer;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();

        rigidBody.useGravity = true;
        meshRenderer.enabled = true;
    }
}