﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goto_Acute : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            SceneManager.LoadScene(2);
        }
    }
}
