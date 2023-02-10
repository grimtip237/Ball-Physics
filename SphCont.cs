using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphCont : MonoBehaviour
{
    int num = 0;
    static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision arg) {
        if(arg.gameObject.name=="Plane")
        {
            num = num + 1;
            //print (num);

            if(num==2) {
                print("Лопнул");
                Destroy(gameObject);
            }
        }
    }

    void OnMouseDown() {
        score = score + 1;
        Destroy(gameObject);
        print(score);
        if(score==5) {
            print("Поздравляю ты поймал все шарики!");
        }
    }
}
