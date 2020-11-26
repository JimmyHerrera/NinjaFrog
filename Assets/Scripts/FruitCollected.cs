using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FruitCollected : MonoBehaviour
{

    public AudioSource clip;
private void OnTriggerEnter2D(Collider2D collison)
{
    if (collison.CompareTag("Player"))
    {
        GetComponent<SpriteRenderer>().enabled = false;
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        
        Destroy(gameObject, 0.5f);
        Debug.Log("Fruta Destruida");

        clip.Play();
    }

}
}
