using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public Animator anim;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
            anim.SetTrigger("PlayerProximity");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            anim.SetTrigger("PlayerProximity");
    }
}
