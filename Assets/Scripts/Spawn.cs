using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    private GameObject knifcol;
    public RectTransform spawnPosition;
    public Transform parent;
    static private Spawn _s;
    [SerializeField]
    static private int a = 0;
    static private Game game;
    
     public static void spawn ()
    {
        Instantiate(_s.knifcol, _s.spawnPosition.position, Quaternion.Euler (0, 0, 0), _s.parent);
        a ++;
        if (a > 14)
        {
            game.ReloadCurrentLevel();
            a = 0;
        }
    }
    public void Start ()
    {
        spawnPosition = GetComponent<RectTransform>();
        _s = this;
        game = FindObjectOfType<Game>();
    }
    
    
}
