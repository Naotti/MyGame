using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Police : MonoBehaviour
{
    public GameObject target;
    private NavMeshAgent agent;
    public bool SearchFlag;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        SearchFlag = false;
    }

    void Update()
    {
        if (SearchFlag == true)
        {
            agent.destination = target.transform.position;

        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Cola Can")
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
