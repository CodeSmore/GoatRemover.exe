using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Reference to events (not unity events) that will happen throughout the game. 
// Essentially a timeline of things that happen :D
public class ProgressController : MonoBehaviour {

    public static List<GameObject> objectList;

    public static int ProgressCount = 0;

    // Use this for initialization
    void Start () {
        objectList = new List<GameObject>();

        objectList.Add(GameObject.Find("NameInput"));
        objectList.Add(GameObject.Find("Download"));
        objectList.Add(GameObject.Find("MinigamePrompt"));
        
        foreach (GameObject obj in objectList)
        {
            obj.SetActive(false);
        }

	}

    public static void MakeProgress()
    {
        objectList[ProgressCount].SetActive(true);

        ProgressCount++;
    }



    //   Original idea was to progress using touches to the screen when the highlighted edges appeared as a prompt
    //   I still like the idea, but, due to self-imposed time constraints, is better to be saved for refactoring
    //   if the project gets that far ;)

    //   When using, put...

    //HighlightEdges = GameObject.Find("HighlightEdges").GetComponentsInChildren<Image>();
    //HideHighlightEdges();

    // ...in Start() method

    // and 'private Image[] HighlightEdges { get; set; }' above it

    //private void HideHighlightEdges()
    //{
    //    foreach (var edge in HighlightEdges)
    //    {
    //        edge.color = new Color(edge.color.r, edge.color.g, edge.color.b, 0);
    //    }
    //}

    //private void FadeInHighlightEdges()
    //{
    //    foreach (var edge in HighlightEdges)
    //    {
    //        edge.color = new Color(edge.color.r, edge.color.g, edge.color.b, 1);
    //    }
    //}
}
