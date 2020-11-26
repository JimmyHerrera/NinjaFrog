using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    public GameObject transition;
    public Text totalFruits;
    public Text fruitsCollected;
    private int totalFruitsInLevel;


    private void Start()
    {
        totalFruitsInLevel = transform.childCount;
    }

    private void Update()
    {
        AllFruitsCollected();
        totalFruits.text = totalFruitsInLevel.ToString();
        fruitsCollected.text = transform.childCount.ToString();
    }

    // Update is called once per frame
    public void AllFruitsCollected()
    {
        if (transform.childCount==0)
        {
            Debug.Log("No quedan frutas, Pasas de nivel");
            transition.SetActive(true);
            Invoke("ChangeScene",1);
        }
    }

    void ChangeScene()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
