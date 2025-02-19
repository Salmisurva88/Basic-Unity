using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLampu : MonoBehaviour
{
    public GameObject lampu;
    public bool isPlayerOnArea;

    public GameObject canvasText;

    // Start is called before the first frame update
    void Start()
    {
        canvasText.SetActive(false);
        lampu.SetActive(false);
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canvasText.SetActive(true);
            isPlayerOnArea = true;
            Debug.Log("Player Msuk");
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Player STay");
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            canvasText.SetActive(false);
            isPlayerOnArea = false;
            Debug.Log("Player Keluar");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnOffButton();
        }
    }

    public void OnOffButton()
    {
        if (isPlayerOnArea)
        {
            if (lampu.activeSelf)
            {
                lampu.SetActive(false);
            }
            else
            {
                lampu.SetActive(true);
            }
         
        }

    }

}
