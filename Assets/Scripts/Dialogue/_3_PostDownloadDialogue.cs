using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _3_PostDownloadDialogue : MonoBehaviour {

    public Dialogue dialogue;
    public GameObject trigger;

	// Use this for initialization
	void Start () {
        SetName();

        dialogue.Sentences = new List<string>();
        // sample dialogue.Sentences.Add("Welcome to GoatRemover.exe. Would you kindly wait one moment while I prepare everything? Super...");
        dialogue.Sentences.Add("Thank you. I can tell we're going to get along just fine.");
        dialogue.Sentences.Add("We'll have your CPU cleared of goats in no time.");
        dialogue.Sentences.Add("An intellectual such as yourself is probably wondering why I installed a goat.");
        dialogue.Sentences.Add("It's quite simple and elegant.\n\n...That's what I've been told anyways...");
    }

    public void TriggerDialogue()
    {
        GetComponent<DialogueController>().StartDialogue(dialogue);

        if (trigger)
        {
            trigger.SetActive(false);
        }
    }

    public void SetName()
    {
        dialogue.Name = GameObject.Find("NameInputField").transform.Find("Text").GetComponent<Text>().text.ToString();

        if (dialogue.Name == "")
        {
            dialogue.Name = "Don";
        }
    }
}
