using UnityEngine;
using System.Collections;

public class ZombieReturn : MonoBehaviour
{
    public GameObject[] zombak;
    GameObject ArmyOfDead;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ArmyOfDead = (GameObject)Instantiate(zombak[Random.Range(0,7)], GameObject.Find("Sphere").transform.position, Quaternion.identity);
        }
    }
}