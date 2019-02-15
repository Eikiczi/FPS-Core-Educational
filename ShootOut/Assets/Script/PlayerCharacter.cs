using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{

    public int _health;
    // Start is called before the first frame update
    void Start()
    {
        _health = 3;
    }

    public void Hurt(int damage) {
        _health -= damage;
        Debug.Log("Zycie gracza " + _health);
    }
}
