using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] List<GameObject> bodyParts = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            ChangeHealth(-1);
        }
    }

    public void ChangeHealth(int amt)
    {
        health += amt;
        
        for(int i = bodyParts.Count - 1; i >= health; i--)
        {
            bodyParts[i].SetActive(false);
        }
    }
}
