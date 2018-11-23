using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroDialogue : MonoBehaviour {

    public Dialogue dialogue;

	// Use this for initialization
	void Start () {
        dialogue.Name = "???";

        dialogue.Sentences = new List<string>();
        dialogue.Sentences.Add("Welcome to GoatRemover.exe. Would you kindly wait one moment while I prepare everything? Super...");
        dialogue.Sentences.Add("While you're waiting, would you kindly enter the name of the most annoying person you know?");
        dialogue.Sentences.Add("Like Don, that stupid carrot...");
	}

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueController>().StartDialogue(dialogue);

        gameObject.SetActive(false);
    }
}
