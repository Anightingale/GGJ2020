using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoblinHealth : MonoBehaviour
{
    public GameObject gremlin;
    public GameObject deathEffect;
    public GameObject hitEffect;
    public GameObject sweatEffect;

    private int health;
    public int startingHealth = 100;
    public bool isAlive = true;
    public bool isSweating = false;

    public Image healthBar;

    // Start is called before the first frame update
    void Start()
    {
        health = startingHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("space"))
        {
            //SweatToggle();
            TakeDamage(20);
        }
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        healthBar.fillAmount = (float)health / (float)startingHealth;

        //Takes a hit
        Hit();

        if (health <= 0)
        {
            //Death
            Death();
        }

        Debug.Log("Current health: " + health);

    }

    public void Death()
    {
        Debug.Log("Dead");
		
        AudioManager.instance.Play("GremlinDeath");
        StartCoroutine(PlayParticle(deathEffect, 3f));
        gremlin.SetActive(false);
        isAlive = false;
    }

    public void Respawn()
    {
        Debug.Log("Respawn");
        isAlive = true;
        health = startingHealth;
        gremlin.SetActive(true);       
    }

    public void Hit()
    {
        Debug.Log("Hit");
        AudioManager.instance.Play("GremlinHit");
        StartCoroutine(PlayParticle(hitEffect, 0.25f));
    }

    public void SweatToggle()
    {
        isSweating = !isSweating;
        if (isSweating)
        {
            sweatEffect.SetActive(true);
        }
        else
        {
            sweatEffect.SetActive(false);
        }
    }

    IEnumerator PlayParticle(GameObject particleEffect, float sec)
    {
        particleEffect.SetActive(true);
        yield return new WaitForSeconds(sec);
        particleEffect.SetActive(false);
    }
}
