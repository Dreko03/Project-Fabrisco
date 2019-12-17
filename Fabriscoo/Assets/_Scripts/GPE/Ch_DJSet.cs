﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch_DJSet : MonoBehaviour
{
    Animator an;

    private void Awake()
    {
        an = GetComponentInChildren<Animator>();
    }

    public void Change()
    {
        an.SetBool("Change", true);
    }

    public void Unchange()
    {
        an.SetBool("change", false);
    }
}
