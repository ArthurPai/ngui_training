using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletinManager : MonoBehaviour
{
    public GameObject MessagePrefab;

    public GameObject MessageGrid;
    public GameObject MessageInput;

    int m_MessageCount = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SendNewMessage() {
        string message = MessageInput.GetComponent<UILabel>().text;

        if (message.Length > 0) {
            AddMessage(message);
            MessageInput.GetComponent<UILabel>().text = "";
        }
    }

    public void AddMessage(string message) {
        GameObject item = NGUITools.AddChild(MessageGrid, MessagePrefab);

        m_MessageCount++;
        item.name = "message" + m_MessageCount;
        item.GetComponent<UILabel>().text = message;

        MessageGrid.GetComponent<UIGrid>().Reposition();
    }
}
