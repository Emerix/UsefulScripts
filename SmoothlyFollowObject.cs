using UnityEngine;
using System.Collections;

public class SmoothlyFollowObject : UsingTarget {

    [SerializeField]
    float speedPerSecond = 1.0f;
    [SerializeField]
    [Range(0,1)]
    float turn = 0.1f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(Target != null)
        {
            transform.position += Vector3.ClampMagnitude(transform.forward, speedPerSecond * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(Target.position - transform.position), turn * Time.deltaTime);
        }
    }
    void OnDrawGizmos()
    {
        if(Target != null)
        {
            Gizmos.color = Color.cyan;
            Gizmos.DrawWireSphere(Target.position, 0.4f);
        }
        Gizmos.color = Color.grey;
        Gizmos.DrawWireSphere(transform.position, 0.4f);
    }
}
