using System;
using System.Collections.Generic;
using System.Text;

namespace PokeGoldCalc
{
    class ItemCalc
    {
        private static Dictionary<int, string> _items = new Dictionary<int, string>{
         { 0x01, "Master Ball"},
         { 0x02, "Ultra Ball"},
         { 0x03, "Bright Powder"},
         { 0x04, "Great Ball"},
         { 0x05, "Poke Ball"},
         { 0x06, "Tera Suma"},
         { 0x07, "Bicycle"},
         { 0x08, "Moon Stone"}, 
         { 0x09, "Antidote"},
         { 0x0a, "Burn Heal"},
         { 0x0b, "Ice Heal"},
         { 0x0c, "Awakening"},
         { 0x0d, "Parlyz Heal"},
         { 0x0e, "Full Restore"},
         { 0x0f, "Max Potion"},
         { 0x10, "Hyper Potion"},
         { 0x11, "Super Potion"},
         { 0x12, "Potion"},
         { 0x13, "Escape Rope"},
         { 0x14, "Repel"},
         { 0x15, "Max Elixer"},
         { 0x16, "Fire Stone"},
         { 0x17, "Thunder Stone"},
         { 0x18, "Water Stone"},
         { 0x1a, "HP Up"},
         { 0x1b, "Protien"},
         { 0x1c, "Iron"},
         { 0x1d, "Carbos"},
         { 0x1e, "Lucky Punch"},
         { 0x1f, "Calcium"},
         { 0x20, "Rare Candy"}, 
         { 0x21, "X Accuracy"},
         { 0x22, "Leaf Stone"},
         { 0x23, "Metal Powder"},
         { 0x24, "Nugget"},
         { 0x25, "Poke Doll"},
         { 0x26, "Full Heal"},
         { 0x27, "Revive"},
         { 0x28, "Max Revive"}, 
         { 0x29, "Gaurd Spec"},
         { 0x2a, "Super Repel"},
         { 0x2b, "Max Repel"},
         { 0x2c, "Dire Hit"},
         { 0x2e, "Fresh Water"},
         { 0x2f, "Soda Pop"},
         { 0x30, "Lemonade"},
         { 0x31, "X Attack"},
         { 0x33, "X Defend"},
         { 0x34, "X Speed"},
         { 0x35, "X Special"},
         { 0x36, "Coin Case"},
         { 0x37, "Item Finder"},
         { 0x39, "Exp Share"},
         { 0x3a, "Old Rod"},
         { 0x3b, "Good Rod"},
         { 0x3c, "Silver Leaf"},
         { 0x3d, "Super Rod"},
         { 0x3e, "PP Up"},
         { 0x3f, "Ether"},
         { 0x40, "Max Ether"}, 
         { 0x41, "Elixer"},
         { 0x42, "Red Scale"},
         { 0x43, "Secret Potion"},
         { 0x44, "SS Ticket"},
         { 0x45, "Mystery Egg"},
         { 0x47, "Silver Wing"},
         { 0x48, "Moo Moo Milk"},
         { 0x49, "Quick Claw"},
         { 0x4a, "Psncureberry"},
         { 0x4b, "Gold Leaf"},
         { 0x4c, "Soft Sand"},
         { 0x4d, "Sharp Beak"},
         { 0x4e, "Przcureberry"},
         { 0x4f, "Burnt Berry"},
         { 0x50, "Ice Berry"},
         { 0x51, "Poison Barb"},
         { 0x52, "Kings Rock"},
         { 0x53, "Bitter Berry"},
         { 0x54, "Mint Berry"},
         { 0x55, "Red Apricorn"},
         { 0x56, "Tiny Mushroom"},
         { 0x57, "Big Mushroom"},
         { 0x58, "Silver Powder"},
         { 0x59, "Big Apricorn"},
         { 0x5b, "Amulet Coin"},
         { 0x5c, "Yellow Apricorn"}, 
         { 0x5d, "Green Apricorn"},
         { 0x5e, "Cleanse Tag"},
         { 0x5f, "Mystic Water"},
         { 0x60, "Twisted Spoon"},
         { 0x61, "White Apricorn"},
         { 0x62, "Black Belt"},
         { 0x63, "Black Apricorn"}, 
         { 0x65, "Pink Apricorn"},
         { 0x66, "Black Glasses"},
         { 0x67, "Slowpoketail"},
         { 0x68, "Pink Bow"},
         { 0x69, "Stick"},
         { 0x6a, "Smoke Ball"},
         { 0x6b, "Never Melt Ice"},
         { 0x6c, "Magnet"},
         { 0x6d, "Miracle Berry"},
         { 0x6e, "Pearl"},
         { 0x6f, "Big Pearl"},
         { 0x70, "Everstone"},
         { 0x71, "Spell Tag"},
         { 0x72, "Rage Candy Bar"},
         { 0x75, "Miracle Seed"},
         { 0x76, "Thick Club"},
         { 0x77, "Focus Band"},
         { 0x79, "Energy Power"},
         { 0x7a, "Energy Root"},
         { 0x7b, "Heal Powder"},
         { 0x7c, "Revival Herb"},
         { 0x7d, "Hardstone"},
         { 0x7e, "Lucky Egg"},
         { 0x7f, "Card Key"},
         { 0x80, "Machine Part"},
         { 0x82, "Lost Item"},
         { 0x83, "Stardust"},
         { 0x84, "Star Piece"},
         { 0x85, "Basement Key"},
         { 0x86, "Pass"},
         { 0x8a, "Charcoal"},
         { 0x8b, "Berry Juice"},
         { 0x8c, "Scope Lens"},
         { 0x8f, "Metal Coat"},
         { 0x90, "Dragon Fang"},
         { 0x96, "Mystery Berry"},
         { 0x97, "Dragon Scale"},
         { 0x98, "Berserk Gene"},
         { 0x9c, "Sacred Ash"},
         { 0x9d, "Heavy Ball"},
         { 0x9e, "Flower Mail"},
         { 0x9f, "Leve Ball"},
         { 0xa0, "Cure Ball"},
         { 0xa1, "Fast Ball"},
         { 0xa3, "Light Ball"},
         { 0xa4, "Friend Ball"},
         { 0xa5, "Moon Ball"},
         { 0xa6, "Love Ball"},
         { 0xa7, "Normal Box"},
         { 0xa8, "Gorgeous Box"},
         { 0xaa, "Poladotbox"},
         { 0xac, "Up-Grade"},
         { 0xad, "Berry"},
         { 0xae, "Gold Berry"},
         { 0xaf, "Squirt Bottle"},
         { 0xb1, "Park Ball"},
         { 0xb2, "Rainbow Wing"},
         { 0xb4, "Brick Peice"},
         { 0xb5, "Surf Mail"},
         { 0xb6, "Lite Blue Mail"},
         { 0xb7, "Portrait Mail"},
         { 0xb8, "Lovely Mail"},
         { 0xb9, "Eon Mail"},
         { 0xba, "Morph Mail"},
         { 0xbb, "Bluesky Mail"},
         { 0xbc, "Music Mail"},
         { 0xbd, "Mirage Mail"}
        };
        public static Dictionary<int, string> Items
        {
            get { return _items; }
        }

        public static string CountItem(int id, int slot, int qty)
        {
            int item = 0x010000d5 + (id << 16) + ((0xb6 + 2*slot) << 8);
            int count =  0x010000d5 + (qty << 16) + ((0xb7 + 2*slot) << 8);
            return String.Format("{0:x8}{2}{1:x8}", item, count, Environment.NewLine);
        }
    }

    struct Item
    {
        private int _id;
        public int Id
        {
            get { return _id; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
        }

        public Item(int id, string name)
        {
            _id = id;
            _name = name;
        }

        override public string ToString()
        {
            return _name;
        }
    }
}
