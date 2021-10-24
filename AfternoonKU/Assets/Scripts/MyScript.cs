using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public string myName = "Nutchapol";
    // Start is called before the first frame update
    void Start()
    {
        print("Hello " + myName);
    }

    private void Awake()
    {
        print("Awake!");
    }

    // Update is called once per frame
    void Update()
    {
        print("Hello Update!");
    }
}
