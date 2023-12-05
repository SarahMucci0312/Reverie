using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class ChandelleConvo : MonoBehaviour
{
    public NPCConversation myConversation;

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ConversationManager.Instance.StartConversation(myConversation);
            ConversationManager.Instance.SetInt("Progress", NightmareParams.numDialogues);
        }
    }
}
