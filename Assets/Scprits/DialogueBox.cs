using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class DialogueBox : MonoBehaviour {

    public List<string> message_list = new List<string>();

    private bool showing;
    private int current_message;
    private Text text;

    public void TriggerDialogue() {
        if (!showing) {
            showing = true;
            current_message = 0;
            text.text = message_list[current_message];
            gameObject.SetActive(true);
        }
    }

    void Start() {
        text = GetComponentInChildren<Text>();
        if (message_list.Count == 0)
            message_list.Add("Default msg");
        gameObject.SetActive(false);
    }

    void Update() {
        if (showing) {
            if (Input.GetKeyDown(KeyCode.Return))
                ChangeToNextMessage();
        }
    }

    private void ChangeToNextMessage() {
        if (current_message >= message_list.Count - 1) {
            showing = false;
        }
        else {
            current_message++;
            text.text = message_list[current_message];
        }
    }
}
