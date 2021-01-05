 using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 using UnityEngine.UI;

 public class input : MonoBehaviour
 {
    
     public InputField n;
    
     public void onbc()
     {
        
         Debug.Log( n.text );

     }
     void Start()
     {
         print("able to execute command");
     }
 }
