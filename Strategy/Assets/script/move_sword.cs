﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_sword : MonoBehaviour
{
    Animation anim;
    // Start is called before the first frame update
    void Start()
    {
         anim = this.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.Play();
        }
    }
    
    void Swing()
    {

    }
}
