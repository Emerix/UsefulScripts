using UnityEngine;
using System.Collections;

public class RandomTargetPicker : MonoBehaviour {
    [Range(1, 200)]
    [SerializeField]
    float timeToChangeTarget = 1;
    [SerializeField]
    Transform[] targets;
    [SerializeField]
    bool randomTime = true;
    [SerializeField]
    UsingTarget usingTarget;

    int currentTarget;
    bool needchange = true;
    // Use this for initialization
    void Start () {
	    if(usingTarget == null)
        {
            usingTarget = GetComponent<UsingTarget>();
        }
	}
	
	// Update is called once per frame
	void Update () {
	    if(needchange)
        {
            usingTarget.Target = targets[Random.Range(0, targets.Length)];
            needchange = false;
            StartCoroutine("ChangeTarget", randomTime? Random.Range(1.0f,timeToChangeTarget) : timeToChangeTarget);
        }
	}
    IEnumerator ChangeTarget(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        needchange = true;
    }
}
