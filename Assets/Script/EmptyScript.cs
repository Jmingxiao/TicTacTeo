using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyScript : MonoBehaviour
{
    public int id;
    [HideInInspector]public GameObject cam;

    private void Start() {
        cam = Camera.main.gameObject;
    }
    private void OnMouseDown()
    {
        cam.GetComponent<GameScript>().Spawn(this.gameObject, id);
    }
}
