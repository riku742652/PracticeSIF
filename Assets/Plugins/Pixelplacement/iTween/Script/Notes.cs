using UnityEngine;
using System.Collections;

public class Notes : MonoBehaviour {

    //    public GameObject obj;
    public GameObject obj;
    public GameObject[] objlist;
    public float Speed = 0.01f;
    private float dis;
    public bool Good = false;
    public bool Great = false;
    public bool Perfect = false;

    Vector3 objA;
    Vector3 objB;


    // Use this for initialization
    void Start () {
        objlist = new GameObject[9];
        objlist[0] = GameObject.Find("Notes1");
        objlist[1] = GameObject.Find("Notes2");
        objlist[2] = GameObject.Find("Notes3");
        objlist[3] = GameObject.Find("Notes4");
        objlist[4] = GameObject.Find("Notes5");
        objlist[5] = GameObject.Find("Notes6");
        objlist[6] = GameObject.Find("Notes7");
        objlist[7] = GameObject.Find("Notes8");
        objlist[8] = GameObject.Find("Notes9");

        obj = objlist[Random.Range(0, 9)];


        //        obj = GameObject.Find("Notes");
        //        Vector3 pos = obj.transform.position;

    }

    // Update is called once per frame
    void Update ()
    {
        objA = transform.position;
        objB = obj.transform.position;
        dis = Vector3.Distance(objA, objB) + 1;

        transform.Translate(obj.transform.position * Speed, Space.World);
        //        Debug.Log(Good);
        Debug.Log(dis);
        if(dis <= 0.5 + 1)
        {
            Perfect = true;
        }else if(0.5 +1 < dis && dis <= 0.7 + 1){
            Great = true;
            Perfect = false;
            Good = false;
        }
        else if(0.7 + 1  < dis && dis <= 2 + 1)
        {
            Good = true;
            Perfect = false;
            Great = false;

        }else
        {
            Good = false;
            Great = false;
            Perfect = false;
        }
    }

    //いらないかも？
//    void OnTriggerEnter(Collider collision)
//    {
//        Debug.Log("Hit");
    //    if (dis*dis <= 1)
    //    {
    //        Debug.Log("OK");
    //    }
//    }
}
