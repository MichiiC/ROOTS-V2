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

        clueTextList.Add("There's a limited amount of resources for plants to grow in areas like this, do you see any competition that a tree might face?");   
        clueTextList.Add("It seems these construction workers weren't very careful with their belongings. Do you see anything they shouldn't leave lying around?");
        clueTextList.Add("Trees need space to grow! What might be taking up too much space?");
        clueTextList.Add("A construction site like this relies on generators for power. What could be used as evidence of this?");
        clueTextList.Add("While they don't have lungs, trees need to breathe. What might make it harder to breathe?");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
