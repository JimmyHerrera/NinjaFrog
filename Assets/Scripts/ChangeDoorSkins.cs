using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDoorSkins : MonoBehaviour
{
   public GameObject skinsPanel;
   private bool inDoor=false;
   public GameObject player;

   private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            skinsPanel.gameObject.SetActive(true);
            inDoor=true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        skinsPanel.gameObject.SetActive(false);
        inDoor=false;
    }

    public void SetPlayerFrog()
    {
        PlayerPrefs.SetString("PlayerSelected","Frog");
        ResetPlayerSkin();
    }
    public void SetPlayerVirtualGuy()
    {
        PlayerPrefs.SetString("PlayerSelected","VirtualGuy");
        ResetPlayerSkin();
    }
    public void SetPlayerPinkMan()
    {
        PlayerPrefs.SetString("PlayerSelected","PinkMan");
        ResetPlayerSkin();
    }
    public void SetPlayerMaskDude()
    {
        PlayerPrefs.SetString("PlayerSelected","MaskDude");
        ResetPlayerSkin();
    }

    void ResetPlayerSkin()
    {
        skinsPanel.gameObject.SetActive(false);
        player.GetComponent<PlayerSelect>().ChangePlayerInMenu(); 
    }
}
