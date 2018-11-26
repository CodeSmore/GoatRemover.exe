using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _2_InputDialogue : MonoBehaviour {

    public Dialogue dialogue;
    public GameObject trigger;

	// Use this for initialization
	void Start () {
        dialogue.Name = "???";

        dialogue.Sentences = new List<string>();
        // sample dialogue.Sentences.Add("Welcome to GoatRemover.exe. Would you kindly wait one moment while I prepare everything? Super...");
        dialogue.Sentences.Add("Ahem, thank you.");
        dialogue.Sentences.Add("Now, just to make sure everything in is order, would you kindly press the button on your screen?");
	}

    public void TriggerDialogue()
    {
        GetComponent<DialogueController>().StartDialogue(dialogue);

        trigger.SetActive(false);
    }

    public void SetName()
    {
        dialogue.Name = gameObject.GetComponent<DialogueController>().nameText.text; // make player prefs save and load

        if (dialogue.Name == "")
        {
            dialogue.Name = "Don";
        }

        PlayerPrefsManager.SaveGuideName(dialogue.Name);
    }
}
