using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class TutorialConvos : MonoBehaviour
{
    public NPCConversation myConversation;
    public bool doneTalking = false;

    //Initiate dialogue
    void Start()
    {
        doneTalking = true;
        ConversationManager.Instance.StartConversation(myConversation);

    }

}
