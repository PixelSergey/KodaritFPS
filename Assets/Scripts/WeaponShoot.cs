using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShoot : MonoBehaviour
{
    public float shootForce = 10f;
    public GameObject bulletPrefab;
    Camera playerCam;

    // Start is called before the first frame update
    void Start()
    {
        playerCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(playerCam.transform.forward * shootForce, ForceMode.Impulse);
        }
    }
}
