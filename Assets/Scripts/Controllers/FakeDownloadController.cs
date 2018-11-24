using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FakeDownloadController : MonoBehaviour {

    public Image downloadBar;
    public Text downloadMessage;
    public Button downloadButton;

    public _3_PostDownloadDialogue nextDialogue;

	// Use this for initialization
	void Start () {
        downloadBar.fillAmount = 0;
	}

    public void BeginDownload()
    {
        downloadButton.interactable = false;

        downloadMessage.text = "Downloading GOAT Virus";
        StartCoroutine(Download());
    }

    IEnumerator Download()
    {
        while (downloadBar.fillAmount < 1)
        {
            downloadBar.fillAmount += Time.deltaTime;

            yield return null;
        }

        downloadMessage.text = "Download Complete";
        downloadButton.gameObject.SetActive(false);

        // Begin Dialogue
        nextDialogue.TriggerDialogue();
    }
}
