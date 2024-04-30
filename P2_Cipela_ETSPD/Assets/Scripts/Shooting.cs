using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform ShotPos;
    public GameObject ShurikenPre;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            shoot();
        }
    }
    private void shoot()
    {
        Instantiate(ShurikenPre, ShotPos.position, ShotPos.rotation);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Destroy(gameObject);
    }
}
