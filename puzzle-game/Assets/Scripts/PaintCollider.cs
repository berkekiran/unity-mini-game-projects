using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintCollider : MonoBehaviour
{
    public Material Ball;

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("LabyrinthBaseCube")){
            other.gameObject.GetComponent<Renderer>().material = Ball;
            GameMechanic.matCounter++;
            other.gameObject.tag = "LabyrinthBaseCubePainted";
        }
    }
}
