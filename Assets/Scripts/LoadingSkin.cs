using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingSkin : MonoBehaviour
{
    public GameObject defaultSkin;
    public static GameObject skin;
    private void Awake()
    {
        if (skin!= null){

            Destroy(defaultSkin);
            Instantiate(skin, transform);
        }
    }
}
