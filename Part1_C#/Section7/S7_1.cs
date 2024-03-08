namespace S7
{
    internal class Program
    {           
        class MyList<T>
        {
            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }
        }

        class MyList2<T, K> where T : struct
        {
            T[] arr = new T[10];

            public T GetItem(int i)
            {
                return arr[i];
            }
        }


        class Monster
        {

        }
        static void  Test<T>(T input)
        {

        }
        static void Main(string[] args)
        {

            // var : 명시적으로 때려맞추기, object : 얘는 타입자체가 object 타입
            // var obj3 = 3;
            // var obj4 = "hello world";

            //object obj = 3;             //  박싱
            //object obj2 = "hello world";

            //int number = 3;

            //int num = (int)obj;
            //string str = (string)obj2;  // 언박싱
            //// ojbect는 속도가 느림, 무조건 참조 타입


            //MyList <int> myIntList = new MyList<int>();
            //int item = myIntList.GetItem(0);
            //MyList <short> myShortList = new MyList<short>();
            //MyList<Monster> myMonsterList = new MyList<Monster>();


            Test<int>(3);
            Test<float>(3.0f);
        }
    }
}
