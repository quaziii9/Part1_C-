namespace S6
{
    internal class S6_5
    {
        class Monster
        {
            public int id;
            public Monster(int id) { this.id = id; }
            
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            // ID식별자
            // 103 ID 몬스터

            // Hashtable
            // 메모리를 내주고 ,성능을 취한다
            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();
            for(int i =0; i < 10000; i++)
            {
                dic.Add(i, new Monster(i));
            }

            Monster mon;
            // bool found = dic.TryGetValue(20000, out mon);
            bool found = dic.TryGetValue(7777, out mon);

            dic.Remove(7777);
            dic.Clear();

            // Monster mon = dic[5000];

            //Monster mon = dic[20000]; // 크래쉬

            // dic[5] = new Monster(5);
        }
    }
}
