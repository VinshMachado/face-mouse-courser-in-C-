using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AttackSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 mouseScreenPosition = Mouse.current.position.ReadValue();
        
        
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
        
        
        mouseWorldPosition.z = 0f;
        
        
        Vector3 direction = mouseWorldPosition - transform.position;
        
       
        transform.up = direction.normalized;
    }
}
