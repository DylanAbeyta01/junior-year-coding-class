using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    static GameManager instance;

    public static GameManager Instance
    { get {return instance ?? ((instance = new GameManager())); } }

    public character MyCharacter
    {
        get; set;
    }

    // Use this for initialization
    private GameManager()
    {
    Object.DontDestroyOnLoad(new GameObject("Updater", typeof(Updater)));
	}
	
	// Update is called once per frame
	private void Update ()
    {
		
	}
    class Updater : MonoBehaviour
    {
        private void Update()
        {
            instance.Update();
        }
    }   
}
