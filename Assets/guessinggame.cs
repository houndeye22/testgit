using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guessinggame : MonoBehaviour
{

    public int guessingValue;
    public int guessingStreak;
    public int guessingHighscore;

    // Use this for initialization
    void Start()
    {
        guessingValue += 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            print("You guess: Higher");
            guessingValue = Random.Range(0, 101);
            if (guessingValue >= 50)
            {
                print("Correct");
                guessingStreak += 1;
            }
            else
            {
                print("Nah that just aint right chief");
                guessingStreak = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            print("You guess: Lower");
            guessingValue = Random.Range(0, 101);
            if (guessingValue <= 50)
            {
                print("Correct");
                guessingStreak += 1;
            }
            else
            {
                print("Nah that just aint right chief");
                guessingStreak = 0;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print(string.Format("Streak: {0}", guessingStreak));
        }
        if(guessingHighscore <= guessingStreak)
        {
            guessingHighscore = guessingStreak;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            print(string.Format("Highscore: {0}", guessingHighscore));
        }
    }
}