using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    bool Run = false;
    private Game game;

     void Start()
    {
        game = FindObjectOfType<Game>();
    }
    void OnEnable () 
	{ 
		Lean.Touch.LeanTouch.OnFingerTap += Beg; 
	} 
    void OnDisable () 
	{ 
		Lean.Touch.LeanTouch.OnFingerTap -= Beg;
	} 
    public void Beg (Lean.Touch.LeanFinger finger)
    { 
        Run = true;
       
    }
    
    public void Update ()
    {
        if (Run)
        {
            gameObject.GetComponent<RectTransform>().localPosition += new Vector3 (0, 1500, 0) * Time.deltaTime;
        }
    }
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Kryg"))
        {
            transform.parent = collision.transform;
            Run = false;
            Spawn.spawn();
            GetComponent<Knife>().enabled = false;
        }

    }
    private void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Knif"))
        {
           game.ReloadCurrentLevel();
        }
    }
}
