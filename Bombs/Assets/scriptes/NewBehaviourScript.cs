using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [ SerializeField ] Text textComp;
    public Button yourButton;
    Generator myScript;

	void Start () {
		Button btn = yourButton.GetComponent<Button>();
        myScript = GetComponent<Generator>();
		btn.onClick.AddListener(TaskOnClick);
	}

    // Update is called once per frame
    void Update()
    {
    
    }

	void TaskOnClick(){
		Debug.Log (myScript.arr);
	}
}
