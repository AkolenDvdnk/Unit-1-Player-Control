﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 20f);
    }
}