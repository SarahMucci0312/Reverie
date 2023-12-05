using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ConvoStarter : MonoBehaviour
{
    public NPCConversation myConversation;
    public bool doneTalking = false;

    //Initiate dialogue
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0) && !doneTalking && !NightmareParams.isTalking)
        {
            doneTalking = true;
            ConversationManager.Instance.StartConversation(myConversation);
        }
    }
}
