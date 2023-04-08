using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demolish : MonoBehaviour
{

    [SerializeField] private GameObject collding;
    public GameObject Colliding { get { return collding; } }


    private void OnTriggerEnter(Collider other)
    {
        collding = other.gameObject;
    }

}
