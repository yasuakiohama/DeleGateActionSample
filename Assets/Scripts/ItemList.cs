using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemList : MonoBehaviour
{
    public class ItemData{
        public int id;
        public int price;
        public string name;

        public ItemData(int id, int price, string name)
        {
            this.id = id;
            this.price = price;
            this.name = name;
        }
    }

    public static Dictionary<int, ItemData> Data = new Dictionary<int, ItemData> () {
        { 100001, new ItemData (100001, 0, "スマイル") },
        { 100002, new ItemData (100001, 100, "ポーション") },
        { 100003, new ItemData (100001, 5000, "エリクサー") },
        { 400001, new ItemData (100001, 9999, "世界平和") },
    };
}
