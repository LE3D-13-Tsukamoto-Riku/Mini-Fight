using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;

    void Update()
    {

        bool fire = Input.GetKeyDown(KeyCode.Space);
        if (fire == true)
        {
            Vector3 placePosition = this.transform.position;
            Vector3 offsetGun = new Vector3(0, 0, 2);

            Quaternion q1 = this.transform.rotation;
            Quaternion q2 = Quaternion.AngleAxis(90, new Vector3(1, 0, 0));
            Quaternion q = q1 * q2;

            placePosition = q1 * offsetGun + placePosition;
            Instantiate(bullet, placePosition, q);
        }
        //Destroy(bullet, 3.0f);
    }
}