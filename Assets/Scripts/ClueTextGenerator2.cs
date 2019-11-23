using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ClueTextGenerator2 : MonoBehaviour
{

    public GameObject cluePanelText2;

    private ArrayList clueTextList2 = new ArrayList();
    private int clueIndex2;

    public void GenerateClueText2()
    {
        Text clueText = cluePanelText2.GetComponent<Text>();

        if (clueIndex2 < clueTextList2.Count)
        {
            clueText.text = clueTextList2[clueIndex2].ToString();
            clueIndex2++;
        }
        else
        {
            clueIndex2 = 0;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        clueIndex2 = 0;

        clueTextList2.Add("It's pretty hot here, is there enough water for trees to thrive?");
        clueTextList2.Add("Dry, hot conditions are very dangerous when you're made out of wood.");
        clueTextList2.Add("Some animals eat seeds before they even get a chance to sprout.");
        clueTextList2.Add("Good soil is as important to a tree as a house is to a person, but it seems to be in short supply here.");
        clueTextList2.Add("The heat drives away or kills many of the animals that trees and other plants rely on to help spread their seeds.");
    }

    // Update is called once per frame
    void Update()
    {

    }
}