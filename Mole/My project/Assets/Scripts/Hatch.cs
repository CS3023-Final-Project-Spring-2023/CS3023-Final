﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hatch : MonoBehaviour {
    public GameObject mouse;
    private Transform mouseRoot;
	void Start () {
        mouseRoot = transform.GetChild(1);
        InvokeRepeating("Create", 0, 2f);
	}
	void Update () {
		
	}

    private void Create()
    {
        GameObject go = Instantiate(mouse);
        go.AddComponent<Mouse>().GetHole = (HoleNumber)Random.Range(0, 9);
        go.GetComponent<Mouse>().GetParent = mouseRoot;
        Destroy(go, 5f);
    }






}
