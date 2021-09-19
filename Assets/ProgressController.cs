using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressController : MonoBehaviour
{
    
    public static int CurrentControl = 0;
    public static int TotalControls = 7;

    void Update()
    {
        var textField = this.gameObject.GetComponent<Text>();
        textField.text = CurrentControl + "/" + TotalControls;

    }
}
