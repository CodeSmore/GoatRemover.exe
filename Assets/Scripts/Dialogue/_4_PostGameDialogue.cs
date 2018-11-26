using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _4_PostGameDialogue : MonoBehaviour {

    public Dialogue dialogue;
    public GameObject trigger;

	// Use this for initialization
	void Start () {
        SetName();

        dialogue.Sentences = new List<string>();
        // sample dialogue.Sentences.Add("Welcome to GoatRemover.exe. Would you kindly wait one moment while I prepare everything? Super...");
        dialogue.Sentences.Add("Thank you for waiting! \nNow to check the results of our scan...");
        dialogue.Sentences.Add("HOLY BALLS! \nYour CPU has soooo many goats. What kind of websites have you been going to!?");
        dialogue.Sentences.Add("Well, worry not, this problem is not permanent.");
        dialogue.Sentences.Add("All you have to do...");
        dialogue.Sentences.Add("...is download GoatAvenger.exe. Easy right? \n\nWould you kindly buy it?");
        dialogue.Sentences.Add("I'm happy to have been of service :D\n\nCya!");
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
        dialogue.Name = PlayerPrefsManager.GetGuideName();
    }
}
