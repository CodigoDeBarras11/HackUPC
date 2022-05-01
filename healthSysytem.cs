using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthSysytem : MonoBehaviour
{
    
    public Image heart; 
    
    public void dead() 
    {
        Destroy(heart);
    }
}
