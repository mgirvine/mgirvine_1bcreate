using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanagerscript : MonoBehaviour
{

    public GameObject cookie;
    public int cookieAmount;
    public GameObject cursorPrefab;
    public GameObject grandmaPrefab;
    public GameObject farmPrefab;

    // Start is called before the first frame update
    void Start()
    {
        cookieAmount = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cookieAmount += 1;
            Debug.Log("You have " + cookieAmount + " cookies!");
            Instantiate(cookie);
        }


        if (cookieAmount == 10)
        {
            Debug.Log("You got a cursor! It begins making additional cookies!");
            Instantiate(cursorPrefab);
            GetComponent<AudioSource>().Play();
                if (Input.GetKeyDown(KeyCode.Space))
                {
                cookieAmount += 1;
                 }
        }

        if (cookieAmount == 20)
        {
            Debug.Log("You got a grandma! She begins making additional cookies");
            Instantiate(grandmaPrefab);
            GetComponent<AudioSource>().Play();
        }

        if (cookieAmount == 30)
        {
            Debug.Log("You got a cookie farm! It begins producing additional cookies!");
            Instantiate(farmPrefab);
            GetComponent<AudioSource>().Play();
        }

    }
}
