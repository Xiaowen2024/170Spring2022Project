using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    // Start is called before the first frame update
   public enum State {
    ALIVE, DEAD
}

public State playerState = State.ALIVE;

public int maxHealth;

private int health;

void Start () {
    health = maxHealth;
}

public void Hurt(int damage) {
    if (playerState == State.ALIVE) {
        health -= damage;
        if (health <= 0) {
            Die();
        }
    }
}

void Die() {
    Application.Quit();
}


}
