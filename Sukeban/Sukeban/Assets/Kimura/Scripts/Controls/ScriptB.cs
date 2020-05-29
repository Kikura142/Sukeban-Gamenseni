using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ScriptB : MonoBehaviour
{
    int b;
    // Start is called before the first frame update
    void Start()
    {
        b = ScriptA.getA();
        print(b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
