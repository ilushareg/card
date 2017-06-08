using UnityEngine;
using System.Collections;

public class testtint : MonoBehaviour {

	// Use this for initialization
	void Start () {
    }
    private void Awake()
    {
        UnityEngine.Color c = new UnityEngine.Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
        Renderer rend = GetComponent<Renderer>();
        rend.material.SetColor("_Tint", c);


    }

    // Update is called once per frame
    void Update () {
	
	}
}
