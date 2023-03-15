using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceScript : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    int isdancingHash;
    int secondDanceHash;
    public bool dance = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isdancingHash = Animator.StringToHash("isOnDiamond");
        
    }

    public void setdance(bool diam) { animator.SetBool(isdancingHash, diam); }
    // Update is called once per frame
    void Update()
    {
      
        
      
    }
    
}

