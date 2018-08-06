using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_info : MonoBehaviour {

    #region singeltype
    private Player_info _instance;
    public Player_info Instance
    {
        get
        {
            if(_instance==null)
            {
                _instance = new Player_info();
            }
            return _instance;
        }
    }
    #endregion
    #region 角色属性
    //创建角色的属性
    private int health;
    private int power;
    private float movespeed;
    private Weapon weapontype;

    public  enum Weapon
    {
        saber=0,
        lancer=1,
        archer=2
    }
    public int Health
    {
        get { return health; }
        set { health = value; }
    }
    public int Power
    {
        get { return power; }
        set { power = value; }
    }
    public float Movespeed
    {
        get { return movespeed; }
        set { movespeed = value; }
    }
    public Weapon Weapontype
    {
        get { return weapontype; }
        set { weapontype = value; }
    }
    #endregion
}
