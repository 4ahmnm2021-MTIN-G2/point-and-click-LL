using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
public bool _con1 = false;
public bool con1{
        get
        {
            return _con1;
        } 
        set
        {
            _con1 = value; 
            Checkcon();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Checkcon(){
        if (_con1 == true){
            
        }
    }
    
}

