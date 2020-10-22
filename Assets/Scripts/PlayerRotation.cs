using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    private Quaternion targetRotation;

    [SerializeField] private float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotateSpeed);
    }

    public void Rotate(Vector3 movement)
    {
        targetRotation = Quaternion.LookRotation(movement);
    }
}
