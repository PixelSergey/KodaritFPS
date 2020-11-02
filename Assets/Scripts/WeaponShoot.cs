using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShoot : MonoBehaviour
{
    public float shootForce = 10f;
    public GameObject bulletPrefab;
    public GameObject bullet = null;
    public float holdStart;
    public float maxHoldTime = 2f;
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
            holdStart = Time.time;
        }

        if(Input.GetButtonUp("Fire1")){
            if(bullet != null){
                Destroy(bullet);
            }

            float holdTime = Time.time - holdStart;
            float forceMultiplier = holdTime / maxHoldTime;
            if(forceMultiplier > 1f) forceMultiplier = 1f;

            bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(playerCam.transform.forward * shootForce * forceMultiplier, ForceMode.Impulse);
        }
    }
}
