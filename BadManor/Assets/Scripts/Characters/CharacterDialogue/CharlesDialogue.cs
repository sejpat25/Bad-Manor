﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;

public class CharlesDialogue : CharacterDialogue
{

    private string characterName = "Charles";
    private Dictionary<GameManager.GameState, string[]> storyLines;
    private List<string> randomLines = new List<string>();

    private static CharlesDialogue inst;

    public static CharlesDialogue getInstance()
    {
        if (inst == null)
            inst = new CharlesDialogue();

        return inst;
    }

    private CharlesDialogue()
    {
        storyLines[GameManager.GameState.TUTORIAL_1] = new string[] { "DIALOGUE LINE 1", "CHARACTER WHO SAYS DIALOGUE LINE 1", "DIALOGUE LINE 2", "CHARACTER WHO SAYS DIALOGUE LINE 2" };

        randomLines.Add("I NEED DIALOGUE");
    }

    public string[] getStoryLines(GameManager.GameState state)
    {
        string[] value = null;
        if (storyLines.TryGetValue(state, out value))
        {
            return value;
        }
        return null;
    }

    public string getRandomLine()
    {
        int index = (int)Random.Range(0f, randomLines.Count - 1);
        return randomLines[index];
    }

}
