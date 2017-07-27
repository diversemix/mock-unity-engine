using System;

namespace UnityEngine
{
    namespace UI {}

    public class KeyCode
    {
        public static int Space = 1;
        public static int L  = 1;
        public static int E  = 1;
        public static int A  = 1;
        public static int D  = 1;
        public static int W  = 1;
        public static int S  = 1;
    }
    public class Input
    {
        public static bool GetKey(int k) { return true; }
    }
    public class Position
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
    }
    public class Vector3 : Position
    {
        public Vector3(float x, float y, float z)
        {

        }
    }
    public class Transform
    {
        public void Translate(float x, float y, float z) { }
        public void Rotate(float x) {  }
        public void Rotate(float x, float y, float z) { }
        public Position position { get; set; }
        public Position rotation { get; set; }
    }

    public class ThingWithTransform
    {
        public Transform transform { get; set; }
    }

    public class GameObject : ThingWithTransform
    {
        public String tag { get; }
        public void SetActive(bool x)
        {
        }
    }

    public class ThingWithGameObject : ThingWithTransform
    {
        public GameObject gameObject { get; }
    }

    // public class Collider : Mock< IPeter<Collider> > {}
    public class Random
    {
        public static float Range(float x, float y) { return 1.0f; }
        public static int Range(int x, int y) { return 1; }
    }

    public class Time
    {
        public static int fixedDeltaTime { get; set; }
    }

    public class Collider : ThingWithGameObject {}
    public class MonoBehaviour : ThingWithGameObject {}
    public class Collision : ThingWithGameObject {}
    public class Text : ThingWithGameObject
    {
        public String text { get; set; }
    }
    public class SerializeField  {}
    public class SerializeFieldAttribute:Attribute {}
    public class Button : ThingWithGameObject {}
}
