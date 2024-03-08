using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace S7
{
    internal class S7_7
    {

        class TestException : Exception { }

        static void TestFunc()
        {
            throw new TestException();
        }

        static void Main(string[] args)
        {
           
            try
            {
                // 1. 0으로 나눌 때
                // 2. 잘못된 메모리를  참조 (null)
                // 3. 오버플로우 
                //int a = 10;
                //int b = 0;
                //int result = a / b;

                //int c = 0;

                TestFunc();
            }
            catch(DivideByZeroException)
            {

            }

            catch (Exception e) 
            {
                
            }
            finally
            {
                // DB, 파일 정리
            }
        }
    }


}
