namespace LevelTest3_Problem07
{/// <summary>
/// 정수 배열 array가 매개변수로 주어질 때, 
/// 가장 큰 수와 그 수의 인덱스를 담은 배열을 return 하도록 solution 함수를 완성해보세요.
/// 
/// ### 입출력 예
/// |     array      |   result  |
/// |      ---       |    ---    |
/// | [1, 8, 3]      |   [8, 1]  |
/// | [9, 10, 11, 8] |  [11, 2]  |
/// 
/// 입출력 예 #1
///             1, 8, 3 중 가장 큰 수는 8이고 인덱스 1에 있습니다.
/// 입출력 예 #2
///             9, 10, 11, 8 중 가장 큰 수는 11이고 인덱스 2에 있습니다.
/// 
/// 
/// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 8, 3 };
            int number = array[0];
            int index = 0;
            for (int i = 0; i < array.Length ; i++)
            {
                if (number < array[i])
                {
                    number = array[i];
                    index = i;
                }
                else
                {
                    number = number;
                    index = index;
                }
            }
            Console.WriteLine($"{number}, {index}");
        }
    }

    public class Solution
    {
        public int[] solution(int[] array)
        {
            // 배열을 입력했을 때, 가장 큰 수와 그 수의 인덱스 출력하기
            int number = 0;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (number < array[i])
                {
                    number = array[i];
                    index = i;
                }
                else
                {
                    number = number;
                    index = index;
                }
            }

            int[] answer = new int[] { number, index };
            return answer;
        }
    }
}
