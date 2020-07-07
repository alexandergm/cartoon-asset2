using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicController : MonoBehaviour
{
    [SerializeField] private Animator _cursor; 
    private StarsController _starsController;
    private bool _isStartCinematic = false;

    private void Start()
    {
        _starsController = GetComponent<StarsController>();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void StartLevel()
    {
        _starsController.StartLevel();
        _cursor.SetTrigger("Start");
        _isStartCinematic = true;
    }
}
