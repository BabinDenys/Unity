using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [ SerializeField ] Text textComp;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)) {
         Debug.Log(123);
        };

        if(Input.GetButton("Button")) {
           Debug.Log(123); 
        }


        
    }

    // protected void OnMouseDown(Input){

    // }
}
