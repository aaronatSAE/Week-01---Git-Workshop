using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatlingGun : MonoBehaviour
{
    [SerializeField] private bool isShooting = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isShooting = true;
            Debug.Log("GUM GUM GATLING!");
        }

        if (Input.GetMouseButtonUp(0))
        {
            isShooting = false;
        }

        if (isShooting)
        {
            // SHOOTING FUNCTIONALITY GOES HERE
            Debug.Log("YA TA TA TA TA TA TA TA TA TA TA TA TA TA");
        }
    }
}
