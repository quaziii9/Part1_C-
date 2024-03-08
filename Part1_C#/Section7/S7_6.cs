using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S7
{
    enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        Uncommon,
        Rare,
    }

    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }

    internal class S7_6
    {
        static List<Item> _items = new List<Item>();

        //delegate bool ItemSelector(Item item);  // delegate 함수가 아니라 인자로 넘겨줄수 있는 델리게이트 타입
        delegate Return MyFunc<T, Return>(T item);

        //static bool IsWeapon(Item item)
        //{
        //    return item.ItemType == ItemType.Weapon;
        //}

        static Item FindItem(MyFunc<Item,bool> selector)
        //static Item FindItem(ItemSelector selector)
        {
            foreach(Item item in _items)
            {
                if (selector(item))
                    return item;
            }

            return null;
        }

        //static Item FindRareItem()
        //{
        //    foreach (Item item in _items)
        //    {
        //        if (item.Rarity == Rarity.Rare)
        //            return item;
        //    }

        //    return null;
        //}

        static void Main(string[] args)
        {
            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

            // delegate를 직접 선언하지 않아도, 이미 만들어진 애들이 존재
            // -> 반환 타입이 있을 경우 Func
            // -> 반환 타입이 없는 경우 Action
            // Action<>
            // Func<>

            // MyFunc -> Func
            MyFunc<Item, bool> Selector = (Item item) => { return item.ItemType == ItemType.Weapon; };
            // ItemSelector Selctor = new ItemSelector((Item item) => { return item.ItemType == ItemType.Weapon; });
            // Lambda : 일회용 함수를 만드는데 사용하는 문법
            // Anonymous Function : 무명 함수 / 익명 함수
            // Item item = FindItem(delegate (Item item) { return item.ItemType == ItemType.Weapon; });
            // Item item2 = FindItem((Item item) => { return item.ItemType == ItemType.Weapon;  });

        }
    }
}

