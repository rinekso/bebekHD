using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckShooter : MonoBehaviour
{
    public GameObject Duck;
    public int intervalDuck;
    public int currentLevel=0;
    public int[] levelTarget;
    public Transform[] positions;

    // Start is called before the first frame update
    void Start()
    {
        GenerateDuck();
    }
    void GenerateDuck(){
        StartCoroutine(Generate());
    }
    IEnumerator Generate(){
        for (int i = 0; i < levelTarget[currentLevel]; i++)
        {
            int id = Mathf.FloorToInt(Random.Range(0,positions.Length));
            Instantiate(Duck,positions[i].position, new Quaternion()).GetComponent<DuckScript>().jump = true;
            yield return new WaitForSeconds(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
