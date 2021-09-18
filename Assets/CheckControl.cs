using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckControl : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("At Control");
    }

}
