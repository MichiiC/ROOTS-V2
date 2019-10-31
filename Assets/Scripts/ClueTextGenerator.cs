using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ClueTextGenerator : MonoBehaviour
{

    public GameObject cluePanelText; 

    private ArrayList clueTextList = new ArrayList();
    private int clueIndex;

    public void GenerateClueText() {
        Text clueText = cluePanelText.GetComponent<Text>();

        if ( clueIndex < clueTextList.Count) {
            clueText.text = clueTextList[clueIndex].ToString();
            clueIndex++;
        }
        else {
            clueIndex = 0;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        clueIndex = 0;

        clueTextList.Add("My First Clue");   
        clueTextList.Add("My Second Clue");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
