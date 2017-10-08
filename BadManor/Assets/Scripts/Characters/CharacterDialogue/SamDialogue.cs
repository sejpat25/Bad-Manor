﻿using UnityEngine;
using System.Collections;
using Assets.Scripts;
using System.Collections.Generic;

public class SamDialogue : CharacterDialogue
{

    private string characterName = "Sam";
    private Dictionary<GameManager.GameState, string[]> storyLines;
    private List<string> randomLines = new List<string>();

    private static SamDialogue inst;

    public static SamDialogue getInstance()
    {
        if (inst == null)
            inst = new SamDialogue();

        return inst;
    }

    private SamDialogue()
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