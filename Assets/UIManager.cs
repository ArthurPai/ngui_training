using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public UIPanel m_LobbyPanel;
    public UIPanel m_BulletinPanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
  
    public void OpenBulletin() {
        m_LobbyPanel.gameObject.SetActive(false);
        m_BulletinPanel.gameObject.SetActive(true);
    }

    public void BackLobby() {
        m_LobbyPanel.gameObject.SetActive(true);
        m_BulletinPanel.gameObject.SetActive(false);
    }
}
