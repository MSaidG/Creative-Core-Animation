using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunTrigger : MonoBehaviour
{
    public Animator anim;
    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("Trigger_Sun");
    }

    private void OnTriggerExit(Collider other)
    {
        anim.SetTrigger("Trigger_Sun");
    }
}
