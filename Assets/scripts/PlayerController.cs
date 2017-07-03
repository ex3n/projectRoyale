using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    // Use this for initialization
    void Start() {


    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 500.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 399.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    void Fire()
    {
        //Creates bullet from prefab
        var bullet = (GameObject)Instantiate(
            bulletPrefab,
            bulletSpawn.position,
            bulletSpawn.rotation);

        //velocity for bullet
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6;

        //remove the bullets after 2 seconds
        Destroy(bullet, 2.0f);
    }
}

