namespace Part1_C_.Section4
{
    // OOP(은닉성)

    // 자동차
    // 핸들 폐달  차문
    // 전기장치 엔진 기름 <-> 외부 노출

    class Knight
    {
        // 접근 한정자 
        // public protected private 
        // private 나만 사용 (상속도 불가능)
        // protected : 상속받으면 사용 가능
        // 접근 한정자를 입력하지 않으면 기본적으로 private 
        private int hp;

        public void SetHp(int hp)
        { this.hp = hp; }

    }

    class S4_7
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            // knight.hp = 1;
        }
    }
}
