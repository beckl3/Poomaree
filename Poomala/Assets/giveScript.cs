using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class giveScript : MonoBehaviour
{
    public quest01 quest;

    public GameObject player;

    public GameObject questWindow;
    public Text objectName;
    public Text questDialog;


    // activates the quest dialog
    public void openQuestDialog()
    {
        questWindow.SetActive(true);
        objectName.text = quest.questTitle;
        questDialog.text = quest.questDescription;
    }
}