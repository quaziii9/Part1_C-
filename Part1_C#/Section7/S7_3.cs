namespace S7
{
    internal class S7_3
    {
        // 객체지향 -> 은닉성 
        class Knight
        {
            //protected int hp;
            //public int Hp
            //{
            //    get { return hp; }
            //    set { hp = value; }
            //    //  private set { hp = value; } // private나 protected는 외부에서는 사용 불가능
            //}

            //// Getter Get함수
            //public int GetHp () { return hp; }
            //// Setter Set함수
            //public void SetHp(int hp) { this.hp = hp; }

            public int Hp
            { get; set; }
            // 위에 한줄을 만들면 위에 세줄이 만들어짐
            private int _hp;
            public int GetHp() { return _hp; }
            public void SetHp(int value) { _hp = value; }

            // public int Hp { get; set; } = 100;
        }

        //
        static void Main(string[] args)
        {
            // 프로퍼티 
            Knight knight = new Knight();
            // knight.SetHp(100);
            knight.Hp = 100; // 사용 set

            int hp = knight.Hp; // 가져오기 get
        }
    }
}
