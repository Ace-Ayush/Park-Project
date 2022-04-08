using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_wave : MonoBehaviour
{
    // Start is called before the first frame update
     Animator anim;
<<<<<<< Updated upstream
    bool iswaving;
=======
     
    bool iswaving=false;
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
<<<<<<< Updated upstream
        iswaving=true;
=======

>>>>>>> Stashed changes
    }

    // Update is called once per frame
   void FixedUpdate()
    {
                     anim.SetBool("iswaving",true);


        /*
       if(Input.GetKeyDown(KeyCode.Y)&&iswaving==false){
            anim.SetBool("iswaving",true);
            iswaving=true;
       }
        if(Input.GetKeyDown(KeyCode.Y)&&iswaving==true){
                            anim.SetBool("iswaving",false);
                            iswaving=false;

       }*/
        
    }
}
