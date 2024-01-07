using UnityEngine;

namespace Utils
{
    public static class Parent
    {
        public static void RemoveAllChildNodes(Transform transform)
        {
            int c = transform.childCount;
            for (int i = 0; i < c; i++)
            {
                GameObject.Destroy(transform.GetChild(0).gameObject);
            }
        }
    }
}