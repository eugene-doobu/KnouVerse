﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public static string TAG_PLAYER = "Player";

    public static int LAYER_NPC = LayerMask.NameToLayer("NPC");
    public static int LAYER_GROUND = LayerMask.NameToLayer("GROUND");

    public static int HASH_NPC_ANIMATION = Animator.StringToHash("Animation"); 
    
    public static readonly string PROP_JSON_NAME = "PropTransform";
    
    public enum Scene
    {
        Unknown,
        LoginScene,
        WorldScene,
    }

    public enum Sound
    {
        Bgm,
        Effect,
        MaxCount,
    }

    public enum UIEvent
    {
        Click,
        Drag,
    }
}
