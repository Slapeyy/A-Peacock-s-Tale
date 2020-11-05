using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueHold : MonoBehaviour {

    public string dialogue;
    private DialogueManager dMan;
    private bool questcheckstart = false;

    public string[] dialogueLines;

	// Use this for initialization
	void Start () {
        dMan = FindObjectOfType<DialogueManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            
                //dMan.ShowBox(dialogue);

                if (!dMan.dialogActive && !questcheckstart)
                {
                questcheckstart = true;
                Time.timeScale = 0f;
                    dMan.dialogLines = dialogueLines;
                    dMan.currentLine = 0;
                    dMan.ShowDialogue();
                }
            
        }
    }
}
