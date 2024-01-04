using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("wakawakaaaa");
        //Debug.LogWarning("veo la luz...");
        //Debug.LogError("ya me mori wey");
    
    
        for (int i = 0; i < 10; i++)
        {
            Debug.LogFormat($"<color=blue> {i} </color>");
        }
    }

    
    
}
