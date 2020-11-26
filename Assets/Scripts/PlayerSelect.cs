using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour
{

    public bool enableSelectCharacter;

    public enum Player{Frog, VirtualGuy, PinkMan, MaskDude};
    public Player playerSelectd;

    public Animator animator;
    public SpriteRenderer spriteRenderer;

    public RuntimeAnimatorController[] playersController;
    public Sprite[] playerRenderer;


    void Start()
    {
        if (!enableSelectCharacter)
        {
            ChangePlayerInMenu();
        }else
        {
        switch(playerSelectd)
        {
            case Player.Frog:
            spriteRenderer.sprite = playerRenderer[0];
            animator.runtimeAnimatorController = playersController[0];
            break;
            case Player.VirtualGuy:
            spriteRenderer.sprite = playerRenderer[1];
            animator.runtimeAnimatorController = playersController[2];
            break;
            case Player.PinkMan:
            spriteRenderer.sprite = playerRenderer[2];
            animator.runtimeAnimatorController = playersController[2];
            break;
            case Player.MaskDude:
            spriteRenderer.sprite = playerRenderer[3];
            animator.runtimeAnimatorController = playersController[3];
            break;

            default:
            break;
        }
    }
    }
    public void ChangePlayerInMenu()
    {
        switch(PlayerPrefs.GetString("PlayerSelected"))
        {
            case "Frog":
            spriteRenderer.sprite = playerRenderer[0];
            animator.runtimeAnimatorController = playersController[0];
            break;

            case "VirtualGuy":
            spriteRenderer.sprite = playerRenderer[1];
            animator.runtimeAnimatorController = playersController[1];
            break;

            case "PinkMan":
            spriteRenderer.sprite = playerRenderer[2];
            animator.runtimeAnimatorController = playersController[2];
            break;

            case "MaskDude":
            spriteRenderer.sprite = playerRenderer[3];
            animator.runtimeAnimatorController = playersController[3];
            break;

            default:
            break;
        }
    }


}
