﻿using UnityEditor;
using UnityEngine;
using UnityEngine.Internal;

namespace bTools.TransformComponent
{
    [InitializeOnLoad, ExcludeFromDocs]
    public static partial class ClipboardData
    {
        public static Vector3 clipboardPosition;
        public static Vector3 clipboardRotation;
        public static Vector3 clipboardScale;
        public static GameObject clipboardGameObject;
        public static string clipboardLightmap;

        static ClipboardData()
        {
        }
    }
}
