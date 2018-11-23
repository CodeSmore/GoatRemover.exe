using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressController : MonoBehaviour {

    private Image[] HighlightEdges { get; set; }

    // Use this for initialization
    void Start () {
        HighlightEdges = GameObject.Find("HighlightEdges").GetComponentsInChildren<Image>();

        HideHighlightEdges();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            FadeInHighlightEdges();
        }
	}

    private void HideHighlightEdges()
    {
        foreach (var edge in HighlightEdges)
        {
            edge.color = new Color(edge.color.r, edge.color.g, edge.color.b, 0);
        }
    }

    private void FadeInHighlightEdges()
    {
        foreach (var edge in HighlightEdges)
        {
            edge.color = new Color(edge.color.r, edge.color.g, edge.color.b, 1);
        }
    }
}
