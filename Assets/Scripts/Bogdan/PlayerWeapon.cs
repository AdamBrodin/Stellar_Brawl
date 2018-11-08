﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour //Bogdan C. SU17A\\
{
    public Transform firepointTop;
    public Transform firepointDown;
    public GameObject beamPrefab;
	
	void Update ()
    {
		if (Input.GetButtonDown("Jump"))
        {
            StartCoroutine(Shoot());
        }
	}

    // Spawns BeamPrefabs wich as bullets
    private IEnumerator Shoot()
    {
        Instantiate(beamPrefab, firepointTop.position, firepointTop.rotation);
        Instantiate(beamPrefab, firepointDown.position, firepointDown.rotation);
        yield return new WaitForSeconds(0.5f);
      //  Debug.Log("SHOOT!");
    }


}
