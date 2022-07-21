using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherDance : MonoBehaviour
{
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("Dance_1");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetTrigger("Dance_2");
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("Dance_3");
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            anim.SetTrigger("Dance_4");
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            anim.SetTrigger("Dance_5");
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            anim.SetTrigger("Dance_6");
        }
    }
}
