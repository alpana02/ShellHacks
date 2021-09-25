using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class buttonrk : MonoBehaviour
     
{
    
     public GameObject gamers;
     public Animator animator;
    
    // Use this for initialization
    void Start () {
      

    }
    void Arrestall(){
        animator.SetBool("isRoundKick",false);
        animator.SetBool("isRun",false);
        animator.SetBool("isWalk",false);
        animator.SetBool("isIdle",true);
        
    }


    public void StartAnimation(string str){
        if(str=="isRoundKick"){
            animator.SetBool(str,true);
            StartCoroutine(maketrue(0.5f,str));
            return;
        }
        Arrestall();
        animator.SetBool("isIdle",false);
        animator.SetBool(str,true);

        
          if(str=="isRun"||str=="isWalk"){
         gamers.transform.Translate(0, 0,-Time.deltaTime, Camera.main.transform);
         }
    }
        IEnumerator maketrue(float time,string st){
            
            yield return new WaitForSeconds(time);
            animator.SetBool(st,false);
        }
    
    // Update is called once per frame
    void Update () {
       
   

    }
}
