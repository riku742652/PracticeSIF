using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TouchChecker : MonoBehaviour
{
    //デバッグ用
    public ScoreText test;

    public Notes notes;

    public GameObject test1;

    public ParticleSystem effect;

    public AudioSource se;

    // Use this for initialization
    void Start()
    {
        //        test = (ScoreText)GameObject.Find("Counter").GetComponent<Text>();
        //        test1.GetComponent<Text>();
        test1 = GameObject.Find("Counter");
        test = test1.GetComponent<ScoreText>();
        effect = GameObject.Find("TapEffect").GetComponent<ParticleSystem>();
        se = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckTouch();
        //        Debug.Log(GetComponent<Notes>().Good);
        //   test.GetComponent<ScoreText>().score++;


    }
    protected virtual void CheckTouch()
    {
        if (Input.touchCount <= 0)
        {
            return;
        }

        Touch touch = Input.GetTouch(0);
        if(touch.phase == TouchPhase.Began)
        {
            Vector2 point = touch.position;
            RaycastHit hit = new RaycastHit();
            Ray ray = Camera.main.ScreenPointToRay(point);

            if (Camera.main == null)
            {
                ray = Camera.current.ScreenPointToRay(point);
            }

            if (Physics.Raycast(ray, out hit))
            {


                //               if (hit.transform.position == notes.GetComponent<Notes>().obj.transform.position)
                if (hit.transform.gameObject.transform.position == notes.GetComponent<Notes>().obj.transform.position)

                    
                //                if(hit.transform.gameObject.tag == "Notes")
                {

                    effect.transform.position = notes.GetComponent<Notes>().obj.transform.position;
                    effect.Emit(1);
                    se.Play();


                    if (notes.GetComponent<Notes>().Good == true)
                    {
                        test.GetComponent<ScoreText>().score = 1;
                        //                        Destroy(notes.gameObject);
                        Destroy(this.gameObject, 0.5f);

                    }
                    if (notes.GetComponent<Notes>().Great == true)
                    {
                        test.GetComponent<ScoreText>().score = 2;
                        //                        Destroy(notes.gameObject);
                        Destroy(this.gameObject,0.5f);

                    }
                    if (notes.GetComponent<Notes>().Perfect == true)
                    {
                        test.GetComponent<ScoreText>().score = 3;
//                        Destroy(notes.gameObject);
                        Destroy(this.gameObject,0.5f);

                    }


                }

            }
        }
    }
}
