// https://www.youtube.com/watch?v=DA-DQsmPItU&ab_channel=CrieSeusJogos

using system.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour{
    float health;
    int speed;
    string enemyName;
    EnemyWeapon weapon;

    int[] intAraay = new int [] {1, 2, 3};

    List <int> intList = new List<int> () {1, 2, 3};

    void Movement(){
        foreach (int intNumbers int intAraay){

        }

        for (int i=0; i<intAraay.Length; i++){
            int currentNumber = intAraay[i];
        }

        for (int i = 0; i < intList.Count; i++)
        {
            int currentNumber = intList[i];
        }
    }

    void Dead(){
        if (health <= 0){

        }
    }

    void Attack(){
        weapon.demage = 30;
        weapon.fireRate = 0.4f;
        weapon.Shoot();
    }

}

public class EnemyWeapon{
    public float demage;
    public float fireRate;

    public void Shoot(){

    }
}