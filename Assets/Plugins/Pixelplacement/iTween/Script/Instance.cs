using UnityEngine;
using System.Collections;

public class Instance : MonoBehaviour {

    public GameObject obj;
//    Vector3 vec = new Vector3(0, 0, 0);
	// Use this for initialization
	void Start () {
	
	}

    public float time = 3.0f;
    private float timeleft;
    GameObject obj1;
//    public float intarval;
    void Update()
    {
        //だいたい1秒ごとに処理を行う
        timeleft -= Time.deltaTime;
        if (timeleft <= 0.0)
        {
            timeleft = time;
            obj1 = (GameObject)Instantiate(obj, Vector3.zero, obj.transform.rotation);
            Destroy(obj1, 5f);
            //ここに処理
        }
    }
}
